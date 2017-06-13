using DroneLander.UWP.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(FuelControlRenderer))]
namespace DroneLander.UWP.Renderers
{
    public class FuelControlRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Height = 16;
                Control.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 217, 0, 0));
            }
        }
    }
}