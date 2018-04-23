using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace ComboBoxEdit_CreatingCheckedComboBox
{
    public class SelectedItemsConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value != null)
                return new List<object>((IEnumerable<object>)value);
            return null;
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            ObservableCollection<Customer> result = new ObservableCollection<Customer>();
            var enumerable = (List<object>)value;
            if (enumerable != null)
                foreach (object item in enumerable)
                    result.Add((Customer)item);
            return result;
        }
    }
}
