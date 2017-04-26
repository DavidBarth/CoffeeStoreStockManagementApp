using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.Generic;

namespace Tests.Mocks
{
    class MockCoffeeDataService : ICoffeeDataService
    {
        private MockRepository repository = new MockRepository();

        public void DeleteCoffee(Coffee coffee)
        {

        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            Coffee coffee = repository.GetCoffeeById(coffeeId);
            return coffee;
        }

        public void UpdateCoffee(Coffee coffee)
        {

        }
    }
}
