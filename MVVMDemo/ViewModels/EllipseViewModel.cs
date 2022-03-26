using System.ComponentModel;
using System.Drawing;
using MVVM;

namespace MVVMDemo.ViewModels
{
    public class EllipseViewModel : BindableBase
    {
        private Color _color;
        

        public Color Color
        {
            get { return _color; }
            set => SetProperty(ref _color, value);
        }

        public event PropertyChangedEventHandler ProrertyChanged;
    }
}