using drmovil.forms.Views.tab_ventas;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace drmovil.forms
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes
            Routing.RegisterRoute("sales/details", typeof(SaleDetailPage));
        }
    }
}
