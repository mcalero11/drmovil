using drmovil.forms.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace drmovil.forms.ViewModels.tab_tiendas
{
    public class StoresViewModel : BaseViewModel
    {
        private string _label;

        public string Label
        {
            get { return _label ; }
            set { SetProperty(ref _label, value); }
        }

        public Command CreateCommand => new Command(CrearEjemplo);

        private async void CrearEjemplo()
        {

        }
    }
}
