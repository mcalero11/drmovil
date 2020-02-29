using drmovil.forms.Controls;
using drmovil.forms.Helpers;
using drmovil.forms.ViewModels.tab_ventas;
using System.Collections.Generic;
using System.Linq;
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

        private void ComboBoxControl_SelectedIndexChanged(object sender, Helpers.SelectedIndexChangedEventArgs e)
        {
            var cmb = (ComboBoxControl)sender;


            var obj = Settings.Stores[cmb.SelectedIndex];

            if (obj.Name == cmb.SelectedItem.ToString())
            {
                _salesViewModel.SelectedStoreChangedCommand.Execute(obj);
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error","No Store Selected","Ok");
            }
        }
    }
}