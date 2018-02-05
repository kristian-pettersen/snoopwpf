// Author: Kristian Pettersen
// Copyright 2018 Kristian Pettersen

using System;
using System.Globalization;
using System.Windows.Data;

namespace Snoop.Converters
{
	public class BooleanToObjectConverter : IValueConverter
	{
		public object TrueValue { get; set; }
		public object FalseValue { get; set; }

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool)
			{
				if ((bool) value)
				{
					return TrueValue;
				}

				return FalseValue;
			}

			return Binding.DoNothing;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
