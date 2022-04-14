using System;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVM;
using MVVM.Command;
using MVVMDemo.Models;
using Prism.Commands;


namespace MVVMDemo.ViewModels
{
    public class MathViewModel : BindableBase
    {
        private readonly MathModel _model = new MathModel();

        public MathViewModel()
        {
            _model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            
            AddCommand = new DelegateCommand<string>(str => {
                int ival;
                if (int.TryParse(str, out ival)) _model.AddValue(ival);
            });
            RemoveCommand = new DelegateCommand<int?>(i => {
                if(i.HasValue) _model.RemoveValue(i.Value);
            });
        }


        //public ICommand AddCommand { get; }
        public DelegateCommand<string> AddCommand { get; }
        public DelegateCommand<int?> RemoveCommand { get; }
        public int Sum => _model.Sum;
        public ReadOnlyObservableCollection<int> MyValues => _model.MyPublicValues;
    }

    
}