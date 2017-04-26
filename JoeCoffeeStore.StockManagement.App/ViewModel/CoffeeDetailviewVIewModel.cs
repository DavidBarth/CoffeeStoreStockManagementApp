using JoeCoffeeStore.StockManagement.App.Messages;
using JoeCoffeeStore.StockManagement.App.Services;
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

        
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private Coffee selectedCoffee;
        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogService;

        public Coffee SelectedCoffee
        {
            get { return selectedCoffee; }

            set
            {
                selectedCoffee = value;
                RaisePropertyChanged("SelectedCoffee");
            }
        }

        
        public CoffeeDetailviewViewModel(ICoffeeDataService coffeeDataService, IDialogService dialogService)
        {
            this.coffeeDataService = coffeeDataService;
            this.dialogService = dialogService;
            Messenger.Default.Register<Coffee>(this, OnCoffeeReceived);
            SaveCommand = new CustomCommand(SaveCoffee, CanSaveCoffee);
            DeleteCommand = new CustomCommand(DeleteCoffee, CanDeleteCoffee);
        }

        public void OnCoffeeReceived(Coffee coffee)
        {
            SelectedCoffee = coffee;   
        }

        //command
        private void SaveCoffee(object coffee)
        {
            coffeeDataService.UpdateCoffee(SelectedCoffee);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanSaveCoffee(object obj)
        {
            return true;
        }

        //command
        private void DeleteCoffee(object coffee)
        {
            coffeeDataService.DeleteCoffee(SelectedCoffee);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanDeleteCoffee(object coffee)
        {
            return true;
        }
    }
}
