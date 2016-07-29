using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace GODInventory.ViewModel.Commands
{

    public class StringToBoolConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameters, System.Globalization.CultureInfo culture)
        {
            String yes_or_no = (string)value;
            switch (yes_or_no)
            {
                case "yes":
                    return true;

                case "no":
                    return false;

                default:
                    return false;

            }
        }

        public object ConvertBack(object value, Type targetType, object parameters, System.Globalization.CultureInfo culture)
        {
            bool true_or_false = (bool)value;

            return true_or_false ? "yes" : "no";
             
        }
    }
}