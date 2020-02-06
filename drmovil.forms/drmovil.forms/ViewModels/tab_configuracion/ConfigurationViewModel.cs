using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace drmovil.forms.ViewModels.tab_configuracion
{
    public class ConfigurationViewModel : BaseViewModel
    {
        public ConfigurationViewModel()
        {
            RefreshCommand = new Command(async() => await RefreshSettings());
        }

        private async Task RefreshSettings()
        {
            IsBusy = false;
        }
    }
}
