using JoeCoffeeStore.StockManagement.App.Extensions;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using MahApps.Metro.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace JoeCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : MetroWindow
    {
        private Coffee selectedCoffee;

        //private List<Coffee> coffeesList;
        private ObservableCollection<Coffee> coffeesList;

        public CoffeeOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            CoffeeDataService coffeeDataService = new CoffeeDataService();

            //calling on dataservice to get all coffees
            //using the extension method in /Extensions that transforms the List into an ObservableCollection
            //thus change becomes visible in UI list
            coffeesList = coffeeDataService.GetAllCoffees().ToObservableCollection();

            //setting list's itemsource to coffeeList
            CoffeeListView.ItemsSource = coffeesList;
        }

        private void EditCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.SelectedCoffee = selectedCoffee;
            coffeeDetailView.ShowDialog();
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCoffee = e.AddedItems[0] as Coffee;

            if (e != null)
            {
                CoffeeIdLabel.Content = selectedCoffee.CoffeeId;
                CoffeeNameLabel.Content = selectedCoffee.CoffeeName;
                DescriptionLabel.Content = selectedCoffee.Description;
                PriceLabel.Content = selectedCoffee.Price;
                StockAmountLabel.Content = selectedCoffee.AmountInStock.ToString();
                FirstTimeAddedLabel.Content = selectedCoffee.FirstAddedToStockDate.ToShortDateString();

                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("/JoeCoffeeStore.StockManagement.App;component/Images/coffee" + selectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
                img.EndInit();
                CoffeeImage.Source = img;
            }
        }

        private void AddFakeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            Coffee fake = new Coffee()
            {
                CoffeeId = 123,
                CoffeeName = "Fake",
                Description = "Fake tasting fake coffee",
                ImageId = 1,
                AmountInStock = 1,
                InStock = true,
                FirstAddedToStockDate = new DateTime(2014, 1, 3),
                OriginCountry = Country.Ecuador,
                Price = 100000
            };

            coffeesList.Add(fake);
        }
    }
}
