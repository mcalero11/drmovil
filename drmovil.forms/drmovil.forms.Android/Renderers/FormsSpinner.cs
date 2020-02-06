using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V7.Widget;
using drmovil.forms.Controls;
using drmovil.forms.Droid.Renderers;
using Xamarin.Forms;
using AColor = Android.Graphics.Color;
using BuildVersionCodes = Android.OS.BuildVersionCodes;

[assembly: ExportRenderer(typeof(ComboBoxControl), typeof(ComboBoxRenderer))]
namespace drmovil.forms.Droid.Renderers
{
    public class FormsSpinner : AppCompatSpinner
    {
        public FormsSpinner(Context context) : base(context)
        {
            ChangeArrowColor();

        }

        void ChangeArrowColor()
        {
            this.Background.SetColorFilter(AColor.White, PorterDuff.Mode.SrcAtop);
            Drawable spinnerDrawable = Background.GetConstantState().NewDrawable();

            spinnerDrawable.SetColorFilter(AColor.White, PorterDuff.Mode.SrcAtop);

            
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean)
            {
                Background = spinnerDrawable;
            }
            else
            {
                // ignore deprecate
                SetBackgroundDrawable(spinnerDrawable);
                
            }
        }

        

    }
}