using System;
using System.Globalization;
using System.Windows;
using MVVM;

namespace MVVM
{
    /// <summary>
    /// Extentions
    /// </summary>
    public static class Extentions
    {   
        /// <summary>
        /// Visibility inversion
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Visibility Invert(this Visibility s) =>  s == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
    }

    /// <summary>
    /// Boolean to Visibility converter
    /// </summary>
    public class VisibilityConverter : ConvertorBase<VisibilityConverter>
    {
        /// <summary>
        /// Direct
        /// </summary>
        /// <param name="value"><see cref="bool"/></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (parameter != null && Equals(parameter, "Reverse"))
                {
                    if (value == null) return Visibility.Collapsed;
                    return (bool)value ? Visibility.Collapsed : Visibility.Visible;
                }

                if (value == null) return Visibility.Visible;
                return (bool)value ? Visibility.Visible : Visibility.Collapsed;
            }
            catch
            {
                return Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Back
        /// </summary>
        /// <param name="value"><see cref="bool"/></param>  
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => DependencyProperty.UnsetValue;
    }

}


