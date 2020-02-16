using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace drmovil.forms.Controls
{
    public class CustomListView : ListView
    {
        public CustomListView()
        {
            this.ItemTapped += this.OnItemTapped;
            this.HasUnevenRows = true;
        }

        public static BindableProperty ItemClickCommandProperty =
            BindableProperty.Create("ItemClickCommand", typeof(ICommand), typeof(CustomListView),null);

        public ICommand ItemClickCommand
        {
            get { return (ICommand)this.GetValue(ItemClickCommandProperty); }
            set { this.SetValue(ItemClickCommandProperty, value); }
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null && this.ItemClickCommand != null && this.ItemClickCommand.CanExecute(e))
            {
                this.ItemClickCommand.Execute(e.Item);
                this.SelectedItem = null;
            }
        }
    }
}
