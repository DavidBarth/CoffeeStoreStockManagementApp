using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.ViewModel;
using JoeCoffeeStore.StockManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Tests.Mocks;

namespace Tests
{
    [TestClass]
    public class DetailViewViewModelTests
    {
        //instances to store mock dependency
        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogService;

        [TestInitialize]
        public void Init()
        {
            coffeeDataService = new MockCoffeeDataService(new MockRepository());
            dialogService = new MockDialogService();
        }

        [TestMethod]
        public void DetalViewViewModel_SelectedCoffeeTest()
        {

            //Arrange
            Coffee theCoffee = null;
            var expectedCoffee = coffeeDataService.GetCoffeeDetail(1);
            int expectedCoffeeId = expectedCoffee.CoffeeId;


            //Act

            CoffeeOverviewViewModel overViewModel = new CoffeeOverviewViewModel(coffeeDataService, dialogService);
            var allCoffee = overViewModel.Coffees;
            theCoffee = allCoffee.First(a => a.CoffeeId == expectedCoffeeId);

            //Assert
            Assert.AreEqual(theCoffee, expectedCoffee);
        }
    }
}
