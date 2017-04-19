using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace JoeCoffeeStore.StockManagement.App.Converter
{
    //instantiating Converter on application level in App.xaml
    class PriceConverter : IValueConverter
    {
        //the Convert(0 will be called automatically
        //when going from source to target, we return a pre-fixed value
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "$ " + value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
