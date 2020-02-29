using drmovil.forms.Controls;
using drmovil.forms.Helpers;
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

        private void ComboBoxControl_SelectedIndexChanged(object sender, Helpers.SelectedIndexChangedEventArgs e)
        {
            var cmb = (ComboBoxControl)sender;


            var obj = Settings.Stores[cmb.SelectedIndex];

            if (obj.Name == cmb.SelectedItem.ToString())
            {
                _servicesViewModel.SelectedStoreChangedCommand.Execute(obj);
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "No Store Selected", "Ok");
            }
        }
    }
}