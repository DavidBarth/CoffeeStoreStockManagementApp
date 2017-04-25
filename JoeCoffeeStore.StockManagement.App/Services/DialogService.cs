using JoeCoffeeStore.StockManagement.App.View;
using System.Windows;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    /// <summary>
    /// Service class to open and close detail view
    /// </summary>
    public class DialogService
    {
        Window coffeeDetailView = null;

        public void ShowDialog()
        {
            coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.ShowDialog();
        }

        public void CloseDialog()
        {
            if (coffeeDetailView != null)
                coffeeDetailView.Close();
        }
    }
}
