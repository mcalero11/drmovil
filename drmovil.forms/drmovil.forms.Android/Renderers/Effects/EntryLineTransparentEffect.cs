using Android.Widget;
using drmovil.forms.Droid.Renderers.Effects;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("EntryEffect")]
[assembly: ExportEffect(typeof(EntryLineTransparentEffect), nameof(EntryLineTransparentEffect))]

namespace drmovil.forms.Droid.Renderers.Effects
{
    public class EntryLineTransparentEffect : PlatformEffect
    {
        EditText control;
        protected override void OnAttached()
        {

            if (Control != null && Control is EditText)
            {
                control = (EditText)Control;
                control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                control.SetPadding(1, 1, 1, 1);
            }

        }

        protected override void OnDetached()
        {
            control = null;
        }
    }
}