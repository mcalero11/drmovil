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
            var salesMockList = new SaleMock().GetList();
            StoreList = new ObservableCollection<string>(storeMockList.Select(x => x.Name).ToList());
            ItemSelected = storeMockList.FirstOrDefault().Name;

            SalesList = new ObservableCollection<Sale>(salesMockList);

            RefreshCommand = new Command(async () => await RefreshList());
            ItemSelectedCommand = new Command<object>(GoTo);
        }

        private void GoTo(object obj)
        {
            
        }

        private async Task RefreshList()
        {
            await Task.Delay(200);
            IsBusy = false;
        }
    }
}
