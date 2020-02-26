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

        private ObservableCollection<string> _storeList;

        public ObservableCollection<string> StoreList
        {
            get { return _storeList; }
            set { SetProperty(ref _storeList, value); }
        }

        private string _itemSelected;

        public string ItemSelected
        {
            get { return _itemSelected; }
            set { SetProperty(ref _itemSelected, value); }
        }

        public Command ItemSelectedCommand { get; set; }
        public SalesViewModel()
        {
            var storeMockList = new StoreMock().GetList();
            StoreList = new ObservableCollection<string>(storeMockList.Select(x => x.Name).ToList());
            ItemSelected = storeMockList.FirstOrDefault().Name;
            
            RefreshCommand = new Command(async () => await RefreshList());
            ItemSelectedCommand = new Command<object>(async (obj) => await GoTo(obj));

            IsBusy = true;
            RefreshCommand.Execute(null);
        }

        private async Task GoTo(object obj)
        {
            await Shell.Current.GoToAsync("sales/details");
        }

        private async Task RefreshList()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                // Connection to internet is available
                SalesList = new ObservableCollection<Sale>(await getFromServer());
            }
            else
            {
                SalesList = new ObservableCollection<Sale>(getFromLocal());
            }
            IsBusy = false;
        }

        private List<Sale> getFromLocal()
        {
            Repository<Sale> saleRepository = new Repository<Sale>();

            return saleRepository.GetFirst(0).ToList();

        }
        private async Task<List<Sale>> getFromServer()
        {
            await Task.Delay(5000);
            
            Repository<Sale> saleRepository = new Repository<Sale>();

            return saleRepository.GetFirst(0).ToList();


        }

    }
}
