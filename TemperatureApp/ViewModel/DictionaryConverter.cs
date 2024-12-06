using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace TemperatureApp.ViewModel
{
    class DictionaryConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Dictionary<string, object> valuePairs = new Dictionary<string, object>();
            foreach (var item in values)
            {
                if (item is FrameworkElement element)
                {
                    valuePairs.Add(element.Name, element);
                }
            }
            return valuePairs;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
