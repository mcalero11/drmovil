using drmovil.forms.ViewModels.tab_ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace drmovil.forms.Views.tab_ventas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaleDetailPage : ContentPage
    {
        private SaleDetailViewModel _saleDetailViewModel;
        public SaleDetailPage()
        {
            InitializeComponent();
            _saleDetailViewModel = new SaleDetailViewModel();
            BindingContext = _saleDetailViewModel;
        }
    }
}