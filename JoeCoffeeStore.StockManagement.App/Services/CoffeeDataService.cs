using JoeCoffeeStore.StockManagement.DAL;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.Generic;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    //business layer of service layer towards CoffeeRepository class 
    public class CoffeeDataService: ICoffeeDataService
    {
        ICoffeeRepository repository;


        //parameter introduced to be able to plug in a mock repository
        public CoffeeDataService(ICoffeeRepository repository)
        {
            this.repository = repository;
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return repository.GetCoffeeById(coffeeId);
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            repository.UpdateCoffee(coffee);
        }

        public void DeleteCoffee(Coffee coffee)
        {
            repository.DeleteCoffee(coffee);
        }
    }
}
