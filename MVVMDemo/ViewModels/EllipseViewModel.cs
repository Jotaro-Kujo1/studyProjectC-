using System.ComponentModel;
using System.Windows.Media;
using MVVM;
using MVVMDemo.Models;
using Prism.Commands;
using System.Windows.Input;

namespace MVVMDemo.ViewModels
{
    public class EllipseViewModel : BindableBase
    {
        private readonly EllipseModel _ell = new EllipseModel();


        public EllipseViewModel()
        {
            _ell.PropertyChanged += (s, e) =>
            {
                RaisePropertyChanged(e.PropertyName);
            };
            AddCommand = new DelegateCommand<string>(ival => {
                byte tmp;
                if (byte.TryParse(ival, out tmp)) _ell.AddValue(tmp);
            });
            
        }

        public ICommand AddCommand { get; }
        public Color Color => _ell.color;
    }
}