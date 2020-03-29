using drmovil.forms.Data.MockService;
using drmovil.forms.Data.Models;
using Work = drmovil.forms.Data.Models.Task;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Xamarin.Forms;
using Task = System.Threading.Tasks.Task;
using Xamarin.Essentials;
using drmovil.forms.Data.Repository;
using drmovil.forms.Helpers;

namespace drmovil.forms.ViewModels.tab_ventas
{
    public class SalesViewModel : BaseViewModel
    {
        private ObservableCollection<Sale> _salesList;

        public ObservableCollection<Sale> SalesList
        {
            get { return _salesList; }
            set { SetProperty(ref _salesList, value); }
        }

        public ObservableCollection<string> StoreList => new ObservableCollection<string>(Settings.Stores.Select(x => x.Name).ToList());
        

        private string _storeSelectedName;

        public string StoreSelectedName
        {
            get { return _storeSelectedName; }
            set { SetProperty(ref _storeSelectedName, value); }
        }

        private Store StoreSelected = null;
        public Command ItemSelectedCommand { get; set; }
        public Command NewSaleCommand { get; set; }
        public Command SelectedStoreChangedCommand { get; set; }
        public SalesViewModel()
        {
            StoreSelectedName = Settings.StoreSeleted.Name;

            SelectedStoreChangedCommand = new Command<object>(async (obj) => await SelectedStoreChanged(obj));
            RefreshCommand = new Command(async () => await RefreshList());
            ItemSelectedCommand = new Command<object>(async (obj) => await GoTo(obj));
            NewSaleCommand = new Command(async () => await NewSale());

        }

        private async Task GoTo(object sale)
        {
            await Shell.Current.GoToAsync($"///sales/details?sale={sale}");
        }

        private async Task NewSale()
        {
            await Shell.Current.GoToAsync("sales/details");
        }
        public async Task SelectedStoreChanged(object store)
        {
            if (store is Store)
            {
                StoreSelected = (Store)store;
            }
            IsBusy = true;
            await RefreshList();
        }
        private async Task RefreshList()
        {
            if (StoreSelected is null)
            {
                IsBusy = false;
                return;
            }
            
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                // Connection to internet is available
                SalesList = new ObservableCollection<Sale>(await getFromServer(StoreSelected));
            }
            else
            {
                SalesList = new ObservableCollection<Sale>(getFromLocal(StoreSelected));
            }

            IsEmpty = SalesList?.Count == 0;

            IsBusy = false;
        }

        private List<Sale> getFromLocal(Store store)
        {
            SaleRepository<Sale> saleRepository = new SaleRepository<Sale>();

            return saleRepository.GetSalesByStore(store).ToList();

        }
        private async Task<List<Sale>> getFromServer(Store store)
        {
            await Task.Delay(500);
            SaleRepository<Sale> saleRepository = new SaleRepository<Sale>();
            // se evaluará si la petición es exitosa, de ser el caso
            // en la bd local se eliminará los datos para esa store
            // y se volverá a llenar con estos nuevos datos

            if (true)
            {

            }

            

            return saleRepository.GetSalesByStore(store).ToList();


        }

    }
}
