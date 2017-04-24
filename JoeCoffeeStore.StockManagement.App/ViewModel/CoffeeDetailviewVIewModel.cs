using JoeCoffeeStore.StockManagement.App.Utility;
using JoeCoffeeStore.StockManagement.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeDetailviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SaveCommand;
        public ICommand DeleteCommand;

        private Coffee selectedCoffee;

       
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

       public CoffeeDetailviewViewModel()
        {
            SaveCommand = new CustomCommand(SaveCoffee, CanSaveCoffee);
            DeleteCommand = new CustomCommand(DeleteCoffee, CanDeleteCoffee);
        }

        private void SaveCoffee(object coffee)
        {

        }

        private bool CanSaveCoffee(object coffee)
        {
            if (selectedCoffee != null)
                return true;
            return false;
        }

        private void DeleteCoffee(object coffee)
        {

        }

        private bool CanDeleteCoffee(object coffee)
        {
            if (selectedCoffee != null)
                return true;
            return false;
        }
    }
}
