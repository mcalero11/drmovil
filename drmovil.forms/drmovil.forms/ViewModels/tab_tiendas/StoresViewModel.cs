using drmovil.forms.Data.MockService;
using drmovil.forms.Data.Models;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Work = drmovil.forms.Data.Models.Task;
using Task = System.Threading.Tasks.Task;

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
            var storeMockList = new StoreMock().GetList();
            StoreList = new ObservableCollection<Store>(storeMockList);


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
			await Shell.Current.GoToAsync("sales/details");
		}

		public Command ButtonCommand => new Command(show);

		private void show()
		{
			App.Current.MainPage.DisplayAlert("ok","ok","ok");
		}
	}
}
