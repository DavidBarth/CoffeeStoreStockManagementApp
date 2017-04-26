using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.ViewModel;
using JoeCoffeeStore.StockManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using Tests.Mocks;

namespace Tests
{
    [TestClass]
    public class CoffeeOverviewViewModelTests
    {

        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogService;

        [TestInitialize]
        public void Init()
        {
            coffeeDataService = new MockCoffeeDataService(new MockRepository());
            dialogService = new MockDialogService();
        }


        [TestMethod]
        public void OverviewViewModel_LoadAllCoffees()
        {
            //Arrange
            ObservableCollection<Coffee> coffees = null;
            var expectedCoffees = coffeeDataService.GetAllCoffees();

            //Act
            var viewModel = new CoffeeOverviewViewModel(this.coffeeDataService,dialogService);
            coffees = viewModel.Coffees;

            //Assert
            CollectionAssert.AreEqual(expectedCoffees, coffees);
        }
    }
}
