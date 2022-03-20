using System;
using System.Windows;
using System.Windows.Controls;

namespace MVVMDemo
{
    public partial class AdditionOfNumbers : UserControl
    {
        public AdditionOfNumbers()
        {
            InitializeComponent();
        }

        public void sum_Click(object sender, RoutedEventArgs e)
        {
            MainVM vm = new MainVM();
            vm.Number1 = Convert.ToInt32(txtBoxNumA.Text);
            vm.Number2 = Convert.ToInt32(txtBoxNumB.Text);
            txtBoxRes.AppendText(Convert.ToString(vm.Number3));
        }
    }
}