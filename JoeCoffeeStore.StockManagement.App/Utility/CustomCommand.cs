﻿using System;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.Utility
{
    class CustomCommand : ICommand
    {
        //to store an action
        private Action<object> execute;
        
        //
        private Predicate<object> canExecute;

        //the action that is passed in here is the code/method I want to execute
        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute; 
        }

        //will be called to invoke something on view model
        public void Execute(object parameter)
        {
            execute(parameter);
        }

        //method checks canExecute which is null then it's true otherwise call
        //canExecute with a parameter that will be a Predicate passed in
        //and return result of that
        public bool CanExecute(object parameter)
        {
            bool b = canExecute == null ? true : canExecute(parameter);
            return b; 
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
