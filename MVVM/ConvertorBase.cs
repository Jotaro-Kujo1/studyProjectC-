using System.Globalization;

namespace MVVM
{
    public abstract class ConvertorBase<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => new NotImplementedException();

        #region MarkupExtension members

        public override object ProvideValue(IServiceProvider serviceProvider) => _converter ?? (_converter = new T());

        private static T _converter;

        #endregion
    }
}

