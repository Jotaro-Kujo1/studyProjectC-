﻿using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace MVVMDemo
{
    public partial class SimpleConvertor : UserControl
    {
        public SimpleConvertor()
        {
            InitializeComponent();
        }
    }

    public class YesNoToBooleanConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
            {
                switch (value.ToString().ToLower())
                {
                    case "yes":
                        return true;
                    case "no":
                        return false;
                }

                return false;
            }

            public object ConvertBack(object value, Type targetType, object parameter,
                System.Globalization.CultureInfo culture)
            {
                if (value is bool)
                {
                    if ((bool) value == true)
                    {
                        return "yes";
                    }
                    else
                    {
                        return "no";
                    }
                }

                return "no";
            }
        }
    }