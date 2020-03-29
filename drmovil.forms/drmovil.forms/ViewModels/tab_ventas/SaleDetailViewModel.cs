using drmovil.forms.Data.Models;
using drmovil.forms.Templates.Popups;
using drmovil.forms.Validations;
using drmovil.forms.Validations.Rules;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
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
		public List<SaleDetail> DetailsMock => new Data.MockService.SaleDetailMock().GetList();
		#region Bindable for validations

		private ValidatableObject<string> _customer;

		public ValidatableObject<string> Customer
		{
			get { return _customer; }
			set { SetProperty(ref _customer, value); }
		}

		public ICommand ValidateCustomerCommand => new Command(() => validateCustomer());
		#endregion
		#region Rules for validations
		private void addValidations()
		{
			_customer.Validations.Add(new IsNotNullOrEmptyRule<string>() { ValidationMessage = "The Customer is required" });
		}
		
		private bool validateCustomer()
		{
			return _customer.Validate();
		}

		#endregion


		private bool validate()
		{
			bool isValidCustomer = validateCustomer();

			return  isValidCustomer;

		}

		public Command NewItemCommand => new Command(newItem);
		private async void newItem()
		{
			await PopupNavigation.Instance.PushAsync(new NewSalesItem());
		}

		public SaleDetailViewModel()
		{
			Customer = new ValidatableObject<string>();
			addValidations();
		}

		private void saveData()
		{
			if (!validate()) return;
			// do stuff
		}

	}
}
