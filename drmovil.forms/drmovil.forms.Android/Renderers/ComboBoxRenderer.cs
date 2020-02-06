using System.ComponentModel;
using Android.Content;
using Android.Widget;
using drmovil.forms.Controls;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using drmovil.forms.Droid.Renderers;
using Android.Support.V4.Graphics.Drawable;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(ComboBoxControl),typeof(ComboBoxRenderer))]
namespace drmovil.forms.Droid.Renderers
{
    public class ComboBoxRenderer : ViewRenderer<ComboBoxControl, FormsSpinner>
    {
        #region Fields
        private bool _isDisposed;
        #endregion

        public ComboBoxRenderer(Context context)
            : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ComboBoxControl> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    var spinner = CreateNativeControl();

                    spinner.ItemSelected += Spinner_ItemSelected;
                    var items = e.NewElement.ItemsSource;

                    if (items == null)
                    {
                        spinner.Adapter = null;
                    }
                    else
                    {
                        
                        spinner.Adapter = new ArrayAdapter(Context, global::Android.Resource.Layout.SimpleSpinnerDropDownItem, items);
                        //spinner.Adapter = new FormsSpinnerAdapter(Context, global::Android.Resource.Layout.SimpleSpinnerItem, items);
                    }
                    //spinner.SetPopupBackgroundDrawable(new ColorDrawable(Android.Graphics.Color.ParseColor("#00BCD4")));
                    SetNativeControl(spinner);
                    Element.SelectedIndexChanged += Element_SelectedIndexChanged;
                    UpdateSelectedIndex();
                }
            }
        }


        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Picker.SelectedIndexProperty.PropertyName)
            {
                UpdateSelectedIndex();
            }

            base.OnElementPropertyChanged(sender, e);
        }

        private void Element_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateSelectedIndex();
            
        }

        

        private void UpdateSelectedIndex()
        {
            if (Element is null)
            {
                return;
            }
            var index = Element.SelectedIndex;
            if (Control.SelectedItemPosition != index)
            {
                Control.SetSelection(index);

            }
        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            UpdateSelectedItem();
        }

        private void UpdateSelectedItem()
        {
            if (Element.SelectedIndex != Control.SelectedItemPosition)
            {
                Element.SelectedIndex = Control.SelectedItemPosition;
            }
        }

        

        protected override FormsSpinner CreateNativeControl()
        {
            // Base.Widget.AppCompat.Spinner.Underlined
            // , null, global::Android.Resource.Style.WidgetSpinnerDropDown
            var spinner = new FormsSpinner(Context)
            {
                Focusable = true,
                Clickable = true,
                Tag = this, 
                

            };
            
            return spinner;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && !_isDisposed)
            {
                _isDisposed = true;
            }

            base.Dispose(disposing);
        }

    }
}