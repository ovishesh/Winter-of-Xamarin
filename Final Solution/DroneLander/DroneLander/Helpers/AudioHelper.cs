using DroneLander.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Helpers
{
    public static class AudioHelper
    {
        public static IAudioService AudioPlayer;
        public static void ToggleEngine()
        {
            AudioPlayer = Xamarin.Forms.DependencyService.Get<IAudioService>();
            AudioPlayer.ToggleEngine();
        }

        public static void AdjustVolume(double volume)
        {
            AudioPlayer = Xamarin.Forms.DependencyService.Get<IAudioService>();
            AudioPlayer.AdjustVolume(volume);
        }

        public static void KillEngine()
        {
            AudioPlayer = Xamarin.Forms.DependencyService.Get<IAudioService>();
            AudioPlayer.KillEngine();
        }
    }
}