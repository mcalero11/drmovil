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
        protected override void OnAttached()
        {

            if (Control != null && Control is EditText)
            {
                var edit = (EditText)Control;
                edit.SetBackgroundColor(Android.Graphics.Color.Transparent);
                edit.SetPadding(1, 1, 1, 1);
            }

        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}