using System;
using System.Globalization;
using System.Windows.Data;

namespace JoeCoffeeStore.StockManagement.App.Converter
{
    class PiecesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int amount = (int)value;
            if (amount > 1)
                return value + " pcs";
            return value + " pc";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
