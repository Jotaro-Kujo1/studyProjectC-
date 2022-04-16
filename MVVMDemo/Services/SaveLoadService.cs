using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace MVVMDemo.Services
{
    public class SaveLoadService : ISaveLoadService
    {
        public ObservableCollection<int> Load(string path)
        {
            try
            {
                return JsonSerializer.Deserialize<ObservableCollection<int>>(File.ReadAllText(path));
            }
            catch 
            {
                return new ObservableCollection<int>();
            }
        }

        public void Save(object obj, string path)
        {
            File.WriteAllText(path,JsonSerializer.Serialize(obj));
        }
    }
}