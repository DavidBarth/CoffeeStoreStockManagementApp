﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace JoeCoffeeStore.StockManagement.App.Converter
{
    public class ImageConverter : IValueConverter
    {
        //based on the value which is the image id the converter returns a bitmap image
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            if (targetType != typeof(ImageSource))
                throw new InvalidOperationException("Target type must be System.Windows.Media.ImageSource.");


            try
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("/JoeCoffeeStore.StockManagement.App;component/Images/coffee" + value  + ".jpg", UriKind.Relative);
                img.EndInit();
                return img;
            }
            catch (Exception ex)
            {
                return DependencyProperty.UnsetValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
