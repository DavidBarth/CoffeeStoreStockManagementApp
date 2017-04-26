using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Mocks;

namespace Tests
{
    [TestClass]
    public class CoffeeDataServiceTest
    {
        /// <summary>
        /// Tests Service/CoffeeDataService 
        /// </summary>
        private ICoffeeRepository repository;

        [TestInitialize]
        public void Init()
        {
            repository = new MockRepository();
        }

        [TestMethod]
        public void GetCoffeeDetailTest()
        {
            //Arrange
            var service = new CoffeeDataService(repository);

            //Act
            var coffee = service.GetCoffeeDetail(1);

            //Assert
            Assert.IsNotNull(coffee);
        }
    }
}
