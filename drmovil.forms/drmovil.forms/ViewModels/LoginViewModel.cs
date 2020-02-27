using drmovil.forms.Data.Models;
using drmovil.forms.Data.Repository;
using drmovil.forms.Data.SqliteService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Work = drmovil.forms.Data.Models.Task;
using Task = System.Threading.Tasks.Task;
using System.Collections.ObjectModel;
using drmovil.forms.Helpers;

namespace drmovil.forms.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand => new Command(async()=> await Login());

        public async Task Login()
        {
            // enviar datos y comprobar que se tenga sesión iniciada
            IsBusy = true;
            // una vez validado el token se inicializa el ambiente local
            var sqlite = new SqliteService();
            await sqlite.CreateTablesAsync();

            // definimos la lista de tiendas y cuál será la preseleccionada

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                // Connection to internet is available
                Settings.Stores = await getFromServer();
            }
            else
            {
                Settings.Stores = getFromLocal();
            }

            if (Settings.Stores?.Count > 0)
            {
                Settings.StoreSeleted = Settings.Stores.FirstOrDefault();
            }

            IsBusy = false;

            Application.Current.MainPage = new AppShell();
        }

        private List<Store> getFromLocal()
        {
            StoreRepository<Store> storeRepository = new StoreRepository<Store>();

            return storeRepository.GetMyStores().ToList();

        }
        private async Task<List<Store>> getFromServer()
        {
            await Task.Delay(5000);

            StoreRepository<Store> storeRepository = new StoreRepository<Store>();

            return storeRepository.GetMyStores().ToList();


        }
    }
}
