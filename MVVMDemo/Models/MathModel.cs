using System.Collections.ObjectModel;
using System.Linq;
using MVVM;
using MVVMDemo.Services;

namespace MVVMDemo.Models
{
    public class MathModel : BindableBase
    {
        private readonly ObservableCollection<int> _myValues = new ObservableCollection<int>();
        public readonly ReadOnlyObservableCollection<int> MyPublicValues;
        private ISaveLoadService _saveLoadService = new SaveLoadService();

        public MathModel()
        {
            MyPublicValues = new ReadOnlyObservableCollection<int>(_myValues);
        }

        public void AddValue(int value)
        {
            _myValues.Add(value);
            RaisePropertyChanged(nameof(Sum));
        }

        public void RemoveValue(int index)
        {
            if (index >= 0 && index < _myValues.Count) _myValues.RemoveAt(index);
            RaisePropertyChanged(nameof(Sum));
        }

        public void Save()
        {
            _saveLoadService.Save(_myValues, "Data.json");
            RaisePropertyChanged(nameof(Sum));
        }

        public void Load()
        {
            foreach (var tmp in _saveLoadService.Load("Data.json"))
            {
                _myValues.Add(tmp);
            }
            RaisePropertyChanged(nameof(Sum));
        }
        
        public int Sum => MyPublicValues.Sum();
    }
}