using drmovil.forms.ViewModels.tab_ventas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace drmovil.forms.Views.tab_ventas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SalesPage : ContentPage
    {
        private readonly SalesViewModel _salesViewModel;
        public SalesPage()
        {
            InitializeComponent();
            _salesViewModel = new SalesViewModel();
            this.BindingContext = _salesViewModel;
        }

        
    }
}