using System;
using System.Globalization;
using MVVM;

namespace MVVMDemo.Convertors
{
    public class StringToInt : ConvertorBase<StringToInt>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = (string) value;
            return str.Length.ToString();
        }
    }
}