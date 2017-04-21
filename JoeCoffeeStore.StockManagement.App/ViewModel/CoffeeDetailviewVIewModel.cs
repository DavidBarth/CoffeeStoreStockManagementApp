using JoeCoffeeStore.StockManagement.Model;
using System.ComponentModel;
using System;
using JoeCoffeeStore.StockManagement.App.Services;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeDetailviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Coffee selectedCoffee;

        private CoffeeDataService coffeeDataService;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public Coffee SelectedCoffee
        {
            get { return selectedCoffee; }

            set
            {
                selectedCoffee = value;
                RaisePropertyChanged("SelectedCoffee");
            }
        }

       
    }
}
