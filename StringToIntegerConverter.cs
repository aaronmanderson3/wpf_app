using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1
{
	internal class IntegerToStringConverter : IValueConverter
	{

		#region Methods

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.ToString();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string input = value as string;

			int output;

			if (int.TryParse(input, out output))
				return output;
			else
				return DependencyProperty.UnsetValue;
		}

		#endregion Methods

	}
}