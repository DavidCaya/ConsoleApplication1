using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1.Library
{
	public static class StringUtils
	{
		public static bool Validate(this string nameToValidate)
		{
			return Regex.IsMatch(nameToValidate, @"^\D+$");
		}
	}
}
