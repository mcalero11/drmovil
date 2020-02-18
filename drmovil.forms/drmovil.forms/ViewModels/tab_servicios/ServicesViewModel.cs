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
			var storeMockList = new StoreMock().GetList();
			var taskMockList = new TaskMock().GetList();
			StoreList = new ObservableCollection<string>(storeMockList.Select(x => x.Name).ToList());
			ItemSelected = storeMockList.FirstOrDefault().Name;

			TaskList = new ObservableCollection<Work>(taskMockList);

			RefreshCommand = new Command(async () => await RefreshList());
			ItemSelectedCommand = new Command<object>(async (obj) => await GoTo(obj));

		}

		private async Task RefreshList()
		{
			await Task.Delay(200);
			IsBusy = false;
		}

		private async Task GoTo(object obj)
		{
			//await Shell.Current.GoToAsync("sales/details");
		}
	}
}
