using System;
using System.Dynamic;

namespace Popsql.Dapper
{
	// Private helper methods to easily map to Dapper.
	public static partial class DbConnectionExtensions
	{
		private static TResult Invoke<TResult>(SqlSelect sql, Func<string, object, TResult> handler)
		{
			ExpandoObject parameters = new ExpandoObject();
			string query = sql.ToSql(p => parameters.AddProperty(p.ParameterName, p.Value));
			return handler(query, parameters);
		}

		private static TResult Invoke<TResult>(SqlUnion sql, Func<string, object, TResult> handler)
		{
			ExpandoObject parameters = new ExpandoObject();
			string query = sql.ToSql(p => parameters.AddProperty(p.ParameterName, p.Value));
			return handler(query, parameters);
		}

		private static TResult Invoke<TResult>(SqlInsert sql, Func<string, object, TResult> handler)
		{
			ExpandoObject parameters = new ExpandoObject();
			string query = sql.ToSql(p => parameters.AddProperty(p.ParameterName, p.Value));
			return handler(query, parameters);
		}

		private static TResult Invoke<TResult>(SqlUpdate sql, Func<string, object, TResult> handler)
		{
			ExpandoObject parameters = new ExpandoObject();
			string query = sql.ToSql(p => parameters.AddProperty(p.ParameterName, p.Value));
			return handler(query, parameters);
		}

		private static TResult Invoke<TResult>(SqlDelete sql, Func<string, object, TResult> handler)
		{
			ExpandoObject parameters = new ExpandoObject();
			string query = sql.ToSql(p => parameters.AddProperty(p.ParameterName, p.Value));
			return handler(query, parameters);
		}
	}
}