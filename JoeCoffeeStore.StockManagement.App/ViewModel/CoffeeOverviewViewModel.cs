﻿using JoeCoffeeStore.StockManagement.App.Extensions;
using JoeCoffeeStore.StockManagement.App.Messages;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.App.Utility;
using JoeCoffeeStore.StockManagement.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Coffee> coffees;

        private ICoffeeDataService coffeeDataService;
        private IDialogService dialogueService;

        public ICommand EditCommand { get; set; }

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

        //using constructor injection 
        public CoffeeOverviewViewModel(ICoffeeDataService coffeeDataService, IDialogService dialogService)
        {
            //create data service to pull in the list of coffees
            this.coffeeDataService = coffeeDataService;
            this.dialogueService = dialogService;
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateListMessage>(this, OnUpDateListMessageReceived);
        }

        private void OnUpDateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            dialogueService.CloseDialog(); //here using the passed in instance to perfom work
        }

        private void LoadCommands()
        {
            EditCommand = new CustomCommand(EditCoffee, CanEditCoffee);
        }

        private void EditCoffee(object obj)
        {
            Messenger.Default.Send<Coffee>(selectedCoffee);
            dialogueService.ShowDialog();
        }

        
        //if coffee was selected the button becomes enabled
        //command can be executed
        private bool CanEditCoffee(object obj)
        {
            if (selectedCoffee != null)
                return true;
            return false;
        }

        private void LoadData()
        {
            Coffees = coffeeDataService.GetAllCoffees().ToObservableCollection();
        }
    }
}
