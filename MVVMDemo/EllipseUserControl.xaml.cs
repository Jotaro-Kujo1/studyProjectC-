using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MVVMDemo
{
    public partial class EllipseUserControl : UserControl
    {
        public EllipseUserControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Color color = GetColor(txtBox.Text);
            ellipse.Visibility = Visibility.Visible;
            ellipse.Fill = new SolidColorBrush(color);
        }

        private Color GetColor(string str)
        {
            string[] arr = str.Split(new string[] {","}, StringSplitOptions.None);
            Color res = new Color();
            res.A = byte.Parse(arr[0]);
            res.R = byte.Parse(arr[1]);
            res.G = byte.Parse(arr[2]);
            res.B = byte.Parse(arr[3]);
            return res;
            
        }
    }
}