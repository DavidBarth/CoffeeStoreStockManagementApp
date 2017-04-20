using JoeCoffeeStore.StockManagement.App.Extensions;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Coffee> coffees;

        private CoffeeDataService coffeeDataService;

        private Coffee selectedCoffee;

        public Coffee SelectedCoffee
        {
            get { return selectedCoffee; }

            set
            {
                selectedCoffee = value;
                RaisePropertyChanged("SelectedCoffee");
            }
        }

        //method will call PropertyChanged event if someone is listening
        public void RaisePropertyChanged(string propertyThatChanged)
        {
            //checking if event is not null than raise event and pass
            //in propperty name that has changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyThatChanged));
        }

        public ObservableCollection<Coffee> Coffees
        {
            get { return coffees; }

            set
            {
                coffees = value;
                RaisePropertyChanged("Coffees");
            }
        }


        public CoffeeOverviewViewModel()
        {
            //create data service to pull in the list of coffees
            coffeeDataService = new CoffeeDataService();
            LoadData();
        }

        private void LoadData()
        {
            Coffees = coffeeDataService.GetAllCoffees().ToObservableCollection();
        }
    }
}
