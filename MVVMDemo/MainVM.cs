using System;
using System.ComponentModel;


namespace MVVMDemo
{
    public class MainVM : INotifyPropertyChanged
    {
        //ViewModel
        private int _number1;

        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Number3");
            }
        }

        private int _number2;

        public int Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged("Number3");
            }
        }

        public int Number3 { get => MathSum. GetSum(Number1,Number2); }

    public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}