﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace XOutput.UI.Converters
{
    /// <summary>
    /// Converts a boolean value to brush.
    /// Cannot be used backwards.
    /// </summary>
    public class EnumerableNotEmptyToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts a list to a bool value, based on if it has any elements.
        /// </summary>
        /// <param name="value">List to check</param>
        /// <param name="targetType">Ignored</param>
        /// <param name="parameter">Ignored</param>
        /// <param name="culture">Ignored</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as IEnumerable).Cast<object>().Any() ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Intentionally not implemented.
        /// </summary>
        /// <param name="value">Ignored</param>
        /// <param name="targetType">Ignored</param>
        /// <param name="parameter">Ignored</param>
        /// <param name="culture">Ignored</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
