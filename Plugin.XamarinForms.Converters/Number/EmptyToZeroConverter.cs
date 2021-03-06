﻿// EmptyToZeroConverter.cs
//
// Author: Saimel Saez <saimelsaez@gmail.com>
//
// 10/14/2019
//
// --------------------------------------------------

using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plugin.XamarinForms.Converters
{
    public class EmptyToZeroConverter : IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            if (value is double)
            {
                return (double)value == 0d ? string.Empty : value;
            }

            if (value is int)
            {
                return (int)value == 0d ? string.Empty : value;
            }

            if (value is long)
            {
                return (long)value == 0d ? string.Empty : value;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return 0;
            }

            return value;
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
