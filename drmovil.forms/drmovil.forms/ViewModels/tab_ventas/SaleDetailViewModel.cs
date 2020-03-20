using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace drmovil.forms.ViewModels.tab_ventas
{
    public class SaleDetailViewModel : BaseViewModel
    {
		private Sale _sale;

		public Sale Sale
		{
			get { return _sale; }
			set { SetProperty(ref _sale, value); }
		}

		public SaleDetailViewModel()
		{

		}

	}
}
