using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;
using MVVM;

namespace MVVMDemo.Models
{
    public class EllipseModel : BindableBase
    {
        private List<byte> myList;
        public Color color;

        public EllipseModel()
        {
            myList = new List<byte>();
            color = new Color();
        }

        public void AddValue(byte value)
        {
            myList.Add(value);
            if (myList.Count == 4) ToColor();
        }

        public void ToColor()
        {
            color.A = myList[0];
            color.R = myList[1];
            color.G = myList[2];
            color.B = myList[3];
        }
    }
}