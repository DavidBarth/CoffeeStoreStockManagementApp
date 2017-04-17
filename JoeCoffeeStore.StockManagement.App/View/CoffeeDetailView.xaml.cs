using JoeCoffeeStore.StockManagement.Model;
using MahApps.Metro.Controls;
using System.Windows;

namespace JoeCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : MetroWindow
    {
        public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();

            this.Loaded += CoffeeDetailView_Loaded;
        }

        void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {

            //the source for databinding 
            //in the xaml all controlls will look for a non-null datacontext -> XAML tree walking
            //binding SelectedCoffee as the datacontext to the entire window 
            this.DataContext = SelectedCoffee;
            
            //LoadData();
        }

        //private void LoadData()
        //{
        //    CoffeeNameLabel.Content = SelectedCoffee.CoffeeName;
        //    CoffeeIdTextBox.Text = SelectedCoffee.CoffeeId.ToString();
        //    CoffeeDescriptionTextBox.Text = SelectedCoffee.Description;
        //    CoffeePriceTextBox.Text = SelectedCoffee.Price.ToString();
        //    StockAmountTextBox.Text = SelectedCoffee.AmountInStock.ToString();
        //    FirstTimeAddedTextBox.Text = SelectedCoffee.FirstAddedToStockDate.ToShortDateString();
        //    if (SelectedCoffee is SuperiorCoffee)
        //        ExtraDescriptionTextBox.Text = (SelectedCoffee as SuperiorCoffee).ExtraDescription;
        //    else
        //        ExtraDescriptionTextBox.Text = "NA";

        //    BitmapImage img = new BitmapImage();
        //    img.BeginInit();
        //    img.UriSource = new Uri("/JoeCoffeeStore.StockManagement.App;component/Images/coffee" + SelectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
        //    img.EndInit();
        //    CoffeeImage.Source = img;
        //}

        private void DeleteCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedCoffee.CoffeeName = "New coffee name";
            SelectedCoffee.Price = 1000;
        }
    }
}
