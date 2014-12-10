using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DefaultApp.Coverters
{
    class UnitConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string val = (string)value;

            string returnValue = string.Empty;
            switch(val)
            {
                case "Weight":
                    returnValue = "80 Kg";
                    break;
                case "Blood Pressure":
                    returnValue = "120/80mmHg";
                    break;
                case "Blood Glucose":
                    returnValue = "11.1 mmol/L";
                    break;
                case "Height":
                    returnValue = "6.6 ft";
                    break;
                case "Cholesterol":
                    returnValue = "240 mg/dL";
                    break;
                default:
                    break;

            }

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
