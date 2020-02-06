using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using drmovil.forms.Controls;
using drmovil.forms.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomTableView), typeof(CustomTableViewRenderer))]
namespace drmovil.forms.Droid.Renderers
{
    public class CustomTableViewRenderer : TableViewRenderer
    {
        public CustomTableViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;

            var listView = Control as global::Android.Widget.ListView;
            listView.Divider = new ColorDrawable(Android.Graphics.Color.Transparent);
            listView.DividerHeight = 0;
        }
    }
}