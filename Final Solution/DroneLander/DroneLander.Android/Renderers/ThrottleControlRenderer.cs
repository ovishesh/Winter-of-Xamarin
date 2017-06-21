using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;
using DroneLander.Droid.Renderers;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;

[assembly: ExportRenderer(typeof(Slider), typeof(ThrottleControlRenderer))]
namespace DroneLander.Droid.Renderers
{
    public class ThrottleControlRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.Rgb(217, 0, 0), PorterDuff.Mode.SrcIn);
                Drawable myThumb = ContextCompat.GetDrawable(Context, Resource.Drawable.throttle_thumb);
                Control.SetThumb(myThumb);
            }
        }
    }
}