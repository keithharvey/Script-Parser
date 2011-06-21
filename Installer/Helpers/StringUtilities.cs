using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Installer.Helpers
{
	public static class StringUtilities
	{
		public static string Join<T>(string delimiter,
			IEnumerable<T> collection, Func<T, string> convert)
		{
			return string.Join(delimiter,
				collection.Select(convert).ToArray());
		}
		/// <summary>
		/// used to check alias prefixes
		/// </summary>
		/// <param name="line">line to check</param>
		/// <param name="comparison">comparison line or prefix</param>
		/// <returns>True if matched.</returns>
		public static bool BeginsWithAndIsnt(this string line, string comparison)
		{
			return (line.StartsWith(comparison, StringComparison.CurrentCultureIgnoreCase) && !line.Equals(comparison));
		}
		/// <summary>
		/// used to check alias prefixes
		/// </summary>
		/// <param name="line">line to check</param>
		/// <param name="comparison">comparison line or prefix</param>
		/// <returns>True if matched.</returns>
		public static bool BeginsWith(this string line, string comparison)
		{
			return (line.StartsWith(comparison, StringComparison.CurrentCultureIgnoreCase));
		}
	}
}
