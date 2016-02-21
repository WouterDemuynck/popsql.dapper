using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Popsql.Dapper
{
	/// <summary>
	/// Provides methods to simplify working with dynamically created <see cref="ExpandoObject"/> objects.
	/// </summary>
	internal static class ExpandoObjectExtensions
	{
		/// <summary>
		/// Adds the specified property with the specified value to the <see cref="ExpandoObject"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="ExpandoObject"/> to extend.
		/// </param>
		/// <param name="name">
		/// The name of the property to add.
		/// </param>
		/// <param name="value">
		/// The value of the property to add.
		/// </param>
		public static void AddProperty(this ExpandoObject obj, string name, object value)
		{
			if (obj == null) throw new ArgumentNullException(nameof(obj));
			((IDictionary<string, object>)obj).Add(name, value);
		}
	}
}