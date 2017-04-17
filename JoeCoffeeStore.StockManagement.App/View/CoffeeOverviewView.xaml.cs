﻿using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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

        private List<Coffee> coffeesList;

        public CoffeeOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            CoffeeDataService coffeeDataService = new CoffeeDataService();

            //calling on dataservice to get all coffees
            coffeesList = coffeeDataService.GetAllCoffees();
            //setting list's itemsource
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

        }
    }
}