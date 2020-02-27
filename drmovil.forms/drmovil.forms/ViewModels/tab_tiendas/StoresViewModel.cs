using drmovil.forms.Data.MockService;
using drmovil.forms.Data.Models;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Work = drmovil.forms.Data.Models.Task;
using Task = System.Threading.Tasks.Task;
using drmovil.forms.Data.Repository;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using drmovil.forms.Helpers;

namespace drmovil.forms.ViewModels.tab_tiendas
{
    public class StoresViewModel : BaseViewModel
    {
		
		private ObservableCollection<Store> _storeList;

		public ObservableCollection<Store> StoreList
		{
			get { return _storeList; }
			set { SetProperty(ref _storeList, value); }
		}

		public Command ItemSelectedCommand { get; set; }
		public StoresViewModel()
        {
            Title = "Mis tiendas";

            RefreshCommand = new Command(async () => await RefreshList());
            ItemSelectedCommand = new Command<object>(async (obj) => await GoTo(obj));

			StoreList = new ObservableCollection<Store>( Settings.Stores );

		}
		private async Task RefreshList()
		{
			var current = Connectivity.NetworkAccess;

			if (current == NetworkAccess.Internet)
			{
				// Connection to internet is available
				StoreList = new ObservableCollection<Store>(await getFromServer());
			}
			else
			{
				StoreList = new ObservableCollection<Store>(getFromLocal());
			}
			IsBusy = false;
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
		private async Task GoTo(object obj)
		{
			await Shell.Current.GoToAsync("sales/details");
		}

		public Command ButtonCommand => new Command(show);

		private void show()
		{
			App.Current.MainPage.DisplayAlert("ok","ok","ok");
		}
	}
}
