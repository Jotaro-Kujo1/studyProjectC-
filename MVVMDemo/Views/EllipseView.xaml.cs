using System.Windows.Controls;
using MVVMDemo.ViewModels;

namespace MVVMDemo.Views
{
    public partial class EllipseView : UserControl
    {
        public EllipseView()
        {
            InitializeComponent();
            DataContext = new EllipseViewModel();
        }
    }
}