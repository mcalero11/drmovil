using drmovil.forms.ViewModels.tab_servicios;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace drmovil.forms.Views.tab_servicios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicesPage : ContentPage
    {
        private readonly ServicesViewModel _servicesViewModel;
        public ServicesPage()
        {
            InitializeComponent();
            _servicesViewModel = new ServicesViewModel();
            this.BindingContext = _servicesViewModel;
        }
    }
}