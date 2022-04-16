using System;
using System.Collections.ObjectModel;

namespace MVVMDemo.Services
{
    public interface ISaveLoadService
    {
        void Save(object obj, string path);
        
        ObservableCollection<int> Load(string path);
    }
}