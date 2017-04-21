using JoeCoffeeStore.StockManagement.App.ViewModel;

namespace JoeCoffeeStore.StockManagement.App
{
    //knows about all the VMs in the application
    //returns the needed VM that the View asks for
    public class ViewModelLocator
    {
        private static CoffeeOverviewViewModel coffeeOverviewViewModel = new CoffeeOverviewViewModel();

        private static CoffeeDetailviewViewModel coffeeDetailviewViewModel = new CoffeeDetailviewViewModel();
         
        public static CoffeeOverviewViewModel CoffeeOverviewViewModel
        {
            get { return coffeeOverviewViewModel; }
        }

        public static CoffeeDetailviewViewModel CoffeDetailviewViewModel
        {
            get { return coffeeDetailviewViewModel; }
        }
    }

    
}
 