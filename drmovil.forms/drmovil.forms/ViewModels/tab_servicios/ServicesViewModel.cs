using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace drmovil.forms.ViewModels.tab_servicios
{
    public class ServicesViewModel : BaseViewModel
    {
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

		public ServicesViewModel()
		{
			StoreList = new ObservableCollection<string>(new List<string>
			{
				"drmovil SM",
				"drmovil Chinameca",
				"algún otro",
			});
			ItemSelected = "algún otro";
		}

	}
}
