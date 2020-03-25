using drmovil.forms.Data.MockService;
using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Work = drmovil.forms.Data.Models.Task;
using Task = System.Threading.Tasks.Task;
using Xamarin.Essentials;
using System.Threading.Tasks;
using drmovil.forms.Data.Repository;
using drmovil.forms.Helpers;

namespace drmovil.forms.ViewModels.tab_servicios
{
    public class ServicesViewModel : BaseViewModel
    {
		private ObservableCollection<Work> _taskList;

		public ObservableCollection<Work> TaskList
		{
			get { return _taskList; }
			set { SetProperty(ref _taskList, value); }
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
		public Command SelectedStoreChangedCommand { get; set; }

		public ServicesViewModel()
		{
			StoreSelectedName = Settings.StoreSeleted.Name;

			SelectedStoreChangedCommand = new Command<object>(async (obj) => await SelectedStoreChanged(obj));
			RefreshCommand = new Command(async () => await RefreshList());
			ItemSelectedCommand = new Command<object>(async (obj) => await GoTo(obj));

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
			var current = Connectivity.NetworkAccess;

			if (current == NetworkAccess.Internet)
			{
				// Connection to internet is available
				TaskList = new ObservableCollection<Work>(await getFromServer(StoreSelected));
			}
			else
			{
				TaskList = new ObservableCollection<Work>(getFromLocal(StoreSelected));
			}

			IsEmpty = TaskList?.Count == 0;
			IsBusy = false;
		}
		private List<Work> getFromLocal(Store store)
		{
			ServiceRepository<Work> serviceRepository = new ServiceRepository<Work>();

			return serviceRepository.GetTasksByStore(store).ToList();

		}
		private async Task<List<Work>> getFromServer(Store store)
		{
			await Task.Delay(1000);

			ServiceRepository<Work> serviceRepository = new ServiceRepository<Work>();

			return serviceRepository.GetTasksByStore(store).ToList();


		}

		private async Task GoTo(object obj)
		{
			//await Shell.Current.GoToAsync("sales/details");
		}
	}
}
