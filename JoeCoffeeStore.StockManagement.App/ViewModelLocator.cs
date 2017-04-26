using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.ViewModel;
using JoeCoffeeStore.StockManagement.DAL;

namespace JoeCoffeeStore.StockManagement.App
{
    //knows about all the VMs in the application
    //returns the needed VM that the View asks for

    /// <summary>
    /// ViewModels are not creating concrete implementation of
    /// the independencies anymore, instead the dependencies are plugged in 
    /// via this class
    /// </summary>
    public class ViewModelLocator
    {
        private static IDialogService dialogService = new DialogService();
        private static ICoffeeDataService coffeeDataService = new CoffeeDataService(new CoffeeRepository());

        private static CoffeeOverviewViewModel coffeeOverviewViewModel = new CoffeeOverviewViewModel(coffeeDataService,dialogService);

        private static CoffeeDetailviewViewModel coffeeDetailviewViewModel = new CoffeeDetailviewViewModel(coffeeDataService, dialogService);
         
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
 