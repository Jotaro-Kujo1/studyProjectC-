using System;
using System.Drawing;
using System.Globalization;
using MVVM;

namespace MVVMDemo.Convertors
{
    public class ValueToColor : ConvertorBase<ValueToColor>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is byte)
            {
                byte res = (byte) value;
                return res; 
            }
            else
            {
                return value;
            }
            
        }
    }
}