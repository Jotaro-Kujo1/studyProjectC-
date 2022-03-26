using System.Collections.ObjectModel;
using System.Linq;
using MVVM;

namespace MVVMDemo.Models
{
    public class MathModel : BindableBase
    {
        private readonly ObservableCollection<int> _myValues = new ObservableCollection<int>();
        public readonly ReadOnlyObservableCollection<int> MyPublicValues;

        public MathModel()
        {
            MyPublicValues = new ReadOnlyObservableCollection<int>(_myValues);
        }

        public void AddValue(int value)
        {
            _myValues.Add(value);
            RaisePropertyChanged("Sum");
        }

        public void RemoveValue(int index)
        {
            if (index >= 0 && index < _myValues.Count) _myValues.RemoveAt(index);
            RaisePropertyChanged("Sum");
        }

        public int Sum => MyPublicValues.Sum();
    }
}