using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DroneLander
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewActivityPage : ContentPage
    {
        public ViewActivityPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = App.ViewModel;
            App.ViewModel.LoadActivityAsync();
        }
    }
}