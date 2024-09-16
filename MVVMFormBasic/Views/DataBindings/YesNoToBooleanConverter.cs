using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;

namespace MVVMFormBasic.Views.DataBindings
{
    public class YesNoToBooleanConverter : IValueConverter


        /* it just implements the two required methods, called Convert() and ConvertBack().
         * The Convert() methods assumes that it receives a string as the input (the value parameter)
         * and then converts it to a Boolean true or false value, with a fallback value of false. 
         * For fun, I added the possibility to do this conversion from French words as well.
    The ConvertBack() method obviously does the opposite: It assumes an input value with a Boolean
        type and then returns the English word "yes" or "no" in return, with a fallback value of "no".
*/    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        switch (value.ToString().ToLower())
        {
            case "yes":
            case "oui":
                return true;
            case "no":
            case "non":
                return false;
        }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value == true)
                    return "yes";
                else
                    return "no";
            }
            return "no";
        }
    }
}
