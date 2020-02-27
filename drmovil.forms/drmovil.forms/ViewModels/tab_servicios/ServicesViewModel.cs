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

		public ServicesViewModel()
		{
			StoreList = new ObservableCollection<string>(Settings.Stores.Select(x => x.Name).ToList());
			ItemSelected = Settings.Stores.FirstOrDefault().Name;


			RefreshCommand = new Command(async () => await RefreshList());
			ItemSelectedCommand = new Command<object>(async (obj) => await GoTo(obj));

			IsBusy = true;
			RefreshCommand.Execute(null);
		}

		private async Task RefreshList()
		{
			var current = Connectivity.NetworkAccess;

			if (current == NetworkAccess.Internet)
			{
				// Connection to internet is available
				TaskList = new ObservableCollection<Work>(await getFromServer());
			}
			else
			{
				TaskList = new ObservableCollection<Work>(getFromLocal());
			}
			IsBusy = false;
		}
		private List<Work> getFromLocal()
		{
			Repository<Work> taskRepository = new Repository<Work>();

			return taskRepository.GetFirst(0).ToList();

		}
		private async Task<List<Work>> getFromServer()
		{
			await Task.Delay(5000);

			Repository<Work> taskRepository = new Repository<Work>();

			return taskRepository.GetFirst(0).ToList();


		}

		private async Task GoTo(object obj)
		{
			//await Shell.Current.GoToAsync("sales/details");
		}
	}
}
