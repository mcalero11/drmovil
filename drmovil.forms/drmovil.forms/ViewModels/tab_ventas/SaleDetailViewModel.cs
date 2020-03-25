using drmovil.forms.Data.Models;
using drmovil.forms.Validations;
using drmovil.forms.Validations.Rules;
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

		private ValidatableObject<string> _comments;

		public ValidatableObject<string> Comments
		{
			get { return _comments; }
			set
			{
				SetProperty(ref _comments, value);
			}
		}

		public ICommand ValidateCommentsCommand => new Command(() => validateComments());

		private bool validateComments()
		{
			return _comments.Validate();
		}

		private void validate()
		{
			bool isValidComments = validateComments();
		}

		private void addValidations()
		{
			_comments.Validations.Add(new IsNotNullOrEmptyRule<string>() { ValidationMessage = "The Comment is required" });
		}
		public SaleDetailViewModel()
		{
			Comments = new ValidatableObject<string>();
			addValidations();
		}

	}
}
