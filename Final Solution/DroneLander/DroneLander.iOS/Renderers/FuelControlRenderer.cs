using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

using DroneLander.iOS.Renderers;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(FuelControlRenderer))]
namespace DroneLander.iOS.Renderers
{
    public class FuelControlRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TintColor = UIColor.FromRGB(217, 0, 0);
            }
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            var X = 1.0f;
            var Y = 4.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(X, Y);
            Control.Transform = transform;
        }
    }
}