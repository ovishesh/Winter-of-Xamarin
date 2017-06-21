using DroneLander.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using System.Collections.ObjectModel;

namespace DroneLander
{
    public class MainViewModel : Common.ObservableBase
    {
        public MainViewModel(MainPage activityPage)
        {
            this.ActivityPage = activityPage;
            this.ActiveLandingParameters = new LandingParameters();
            this.Altitude = this.ActiveLandingParameters.Altitude;
            this.Velocity = this.ActiveLandingParameters.Velocity;
            this.Fuel = this.ActiveLandingParameters.Fuel;
            this.Thrust = this.ActiveLandingParameters.Thrust;
            this.FuelRemaining = CoreConstants.StartingFuel;
            this.IsActive = false;
            this.CurrentActivity = new ObservableCollection<ActivityItem>();
            this.SignInLabel = "Sign In";
        }

        private MainPage _activityPage;
        public MainPage ActivityPage
        {
            get { return this._activityPage; }
            set { this.SetProperty(ref this._activityPage, value); }
        }

        public LandingParameters ActiveLandingParameters { get; set; }

        private double _altitude;
        public double Altitude
        {
            get { return this._altitude; }
            set { this.SetProperty(ref this._altitude, value); }
        }

        private double _descentRate;
        public double DescentRate
        {
            get { return this._descentRate; }
            set { this.SetProperty(ref this._descentRate, value); }
        }

        private double _velocity;
        public double Velocity
        {
            get { return this._velocity; }
            set { this.SetProperty(ref this._velocity, value); }
        }

        private double _fuel;
        public double Fuel
        {
            get { return this._fuel; }
            set { this.SetProperty(ref this._fuel, value); }
        }

        private double _fuelRemaining;
        public double FuelRemaining
        {
            get { return this._fuelRemaining; }
            set { this.SetProperty(ref this._fuelRemaining, value); }
        }

        private double _thrust;
        public double Thrust
        {
            get { return this._thrust; }
            set { this.SetProperty(ref this._thrust, value); }
        }

        private double _throttle;
        public double Throttle
        {
            get { return this._throttle; }
            set
            {
                this.SetProperty(ref this._throttle, value);
                if (this.IsActive && this.FuelRemaining > 0.0) Helpers.AudioHelper.AdjustVolume(value);
            }
        }

        private bool _isActionable() => true;
        private string _actionLabel;
        public string ActionLabel
        {
            get { return this._actionLabel; }
            set { this.SetProperty(ref this._actionLabel, value); }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return this._isActive; }
            set { this.SetProperty(ref this._isActive, value); this.ActionLabel = (this.IsActive) ? "Reset" : "Start"; }
        }

        public System.Windows.Input.ICommand SignInCommand
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    this.CurrentActivity.Clear();

                    //if (this.IsAuthenticated)
                    //{
                    //    this.IsAuthenticated = !(await App.Authenticator.SignOutAsync());
                    //}
                    //else
                    //{
                        this.IsAuthenticated = await App.Authenticator.SignInAsync();
                        if (this.IsAuthenticated) this.UserId = TelemetryManager.DefaultManager.CurrentClient.CurrentUser.UserId.Split(':').LastOrDefault();
                   // }

                    this.SignInLabel = (this.IsAuthenticated) ? "Sign Out" : "Sign In";
                    var activityToolbarItem = this.ActivityPage.ToolbarItems.Where(w => w.AutomationId.Equals("ActivityLabel")).FirstOrDefault();

                    if (this.IsAuthenticated)
                    {
                        if (activityToolbarItem == null)
                        {
                            activityToolbarItem = new ToolbarItem()
                            {
                                Text = "Activity",
                                AutomationId = "ActivityLabel",
                            };

                            activityToolbarItem.Clicked += (s, e) =>
                            {
                                this.ActivityPage.Navigation.PushModalAsync(new ViewActivityPage(), true);
                            };

                            this.ActivityPage.ToolbarItems.Insert(0, activityToolbarItem);
                        }
                    }
                    else
                    {
                        if (activityToolbarItem != null) this.ActivityPage.ToolbarItems.Remove(activityToolbarItem);
                    }
                });
            }
        }
        public ICommand AttemptLandingCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    this.IsActive = !this.IsActive;

                    if (this.IsActive)
                    {
                        StartLanding();
                    }
                    else
                    {
                        ResetLanding();
                    }

                }, _isActionable);
            }
        }

        public void StartLanding()
        {
            Helpers.AudioHelper.ToggleEngine();

            Device.StartTimer(TimeSpan.FromMilliseconds(Common.CoreConstants.PollingIncrement), () =>
            {
                UpdateFlightParameters();

                if (this.ActiveLandingParameters.Altitude > 0.0)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        this.Altitude = this.ActiveLandingParameters.Altitude;
                        this.DescentRate = this.ActiveLandingParameters.Velocity;
                        this.FuelRemaining = this.ActiveLandingParameters.Fuel / 1000;
                        this.Thrust = this.ActiveLandingParameters.Thrust;
                    });

                    if (this.FuelRemaining == 0.0) Helpers.AudioHelper.KillEngine();

                    return this.IsActive;
                }
                else
                {
                    this.ActiveLandingParameters.Altitude = 0.0;
                    this.IsActive = false;

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        this.Altitude = this.ActiveLandingParameters.Altitude;
                        this.DescentRate = this.ActiveLandingParameters.Velocity;
                        this.FuelRemaining = this.ActiveLandingParameters.Fuel / 1000;
                        this.Thrust = this.ActiveLandingParameters.Thrust;
                    });

                    LandingResultType landingResult = (this.ActiveLandingParameters.Velocity > -5.0) ? LandingResultType.Landed : LandingResultType.Kaboom;

                    if (this.IsAuthenticated)
                    {
                        Helpers.ActivityHelper.AddActivityAsync(landingResult);
                    }

                    MessagingCenter.Send(this.ActivityPage, "ActivityUpdate", landingResult);
                    return false;
                }
            });
        }

        private void UpdateFlightParameters()
        {
            double seconds = Common.CoreConstants.PollingIncrement / 1000.0;

            // Compute thrust and remaining fuel
            //thrust = throttle * 1200.0;
            var used = (this.Throttle * seconds) / 10.0;
            used = Math.Min(used, this.ActiveLandingParameters.Fuel); // Can't burn more fuel than you have
            this.ActiveLandingParameters.Thrust = used * 25000.0;
            this.ActiveLandingParameters.Fuel -= used;

            // Compute new flight parameters
            double avgmass = Common.CoreConstants.LanderMass + (used / 2.0);
            double force = this.ActiveLandingParameters.Thrust - (avgmass * Common.CoreConstants.Gravity);
            double acc = force / avgmass;

            double vel2 = this.ActiveLandingParameters.Velocity + (acc * seconds);
            double avgvel = (this.ActiveLandingParameters.Velocity + vel2) / 2.0;
            this.ActiveLandingParameters.Altitude += (avgvel * seconds);
            this.ActiveLandingParameters.Velocity = vel2;
        }

        public async void ShakeLandscapeAsync(ContentPage page)
        {
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    await Task.WhenAll(
                            page.ScaleTo(1.1, 20, Easing.Linear),
                            page.TranslateTo(-30, 0, 20, Easing.Linear)
                        );

                    await Task.WhenAll(
                            page.TranslateTo(0, 0, 20, Easing.Linear)
                       );

                    await Task.WhenAll(
                            page.TranslateTo(0, -30, 20, Easing.Linear)
                       );

                    await Task.WhenAll(
                             page.ScaleTo(1.0, 20, Easing.Linear),
                             page.TranslateTo(0, 0, 20, Easing.Linear)
                         );
                }
            }
            catch { }
        }

        public async void ResetLanding()
        {
            Helpers.AudioHelper.ToggleEngine();

            await Task.Delay(500);

            this.ActiveLandingParameters = new LandingParameters();

            this.Altitude = 5000.0;
            this.Velocity = 0.0;
            this.Fuel = 1000.0;
            this.FuelRemaining = 1000.0;
            this.Thrust = 0.0;
            this.DescentRate = 0.0;
            this.Throttle = 0.0;
        }

        private bool _isAuthenticated;
        public bool IsAuthenticated
        {
            get { return this._isAuthenticated; }
            set { this.SetProperty(ref this._isAuthenticated, value); }
        }

        private string _userId;
        public string UserId
        {
            get { return this._userId; }
            set { this.SetProperty(ref this._userId, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return this._isBusy; }
            set { this.SetProperty(ref this._isBusy, value); }
        }

        private string _signInLabel;
        public string SignInLabel
        {
            get { return this._signInLabel; }
            set { this.SetProperty(ref this._signInLabel, value); }
        }

        private ObservableCollection<ActivityItem> _currentActivity;
        public ObservableCollection<ActivityItem> CurrentActivity
        {
            get { return this._currentActivity; }
            set { this.SetProperty(ref this._currentActivity, value); }
        }

        public async void LoadActivityAsync()
        {
            this.IsBusy = true;
            this.CurrentActivity.Clear();

            var activities = await TelemetryManager.DefaultManager.GetAllActivityAync();

            foreach (var activity in activities)
            {
                this.CurrentActivity.Add(activity);
            }

            this.IsBusy = false;
        }
    }
}