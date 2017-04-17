using System;
using System.ComponentModel;

namespace JoeCoffeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeId;
        private string coffeeName;
        private int price;

        public int CoffeeId
        {
            get { return coffeeId; }

            //when CoffeeId is changed RaisepropertyChanged method is called with prop. name passed in
            set { coffeeId = value; RaisePropertyChanged("CoffeeId"); }
        }

        public string CoffeeName
        {
            get { return coffeeName; }
            set { coffeeName = value; RaisePropertyChanged("CoffeeName"); }
        }

        public int Price
        {
            get { return price; }
            set { price = value; RaisePropertyChanged("Price"); }
        }

        public string Description
        {
            get;
            set;
        }

        public Country OriginCountry
        {
            get;
            set;
        }

        public bool InStock
        {
            get;
            set;
        }

        public int AmountInStock 
        { 
            get; 
            set; 
        }

        public DateTime FirstAddedToStockDate
        {
            get;
            set;
        }

        public int ImageId
        {
            get;
            set;
        }

        //event must be raised when a value of a property is changed
        public event PropertyChangedEventHandler PropertyChanged;

        //call method 
        public void RaisePropertyChanged (string propertyThatChanged)
        {
            //checking if event is not null than raise event and pass
            //in propperty name that has changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyThatChanged));

            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyThatChanged))
            //}
        }
    }
}
