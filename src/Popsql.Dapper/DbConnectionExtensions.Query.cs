using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using Dapper;

namespace Popsql.Dapper
{
	public static partial class DbConnectionExtensions
	{
		/// <summary>
		/// Executes a <see cref="SqlSelect"/> query and returns the results as the specified data type.
		/// </summary>
		/// <typeparam name="T">
		/// The type returned by the query.
		/// </typeparam>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the query.
		/// </param>
		/// <param name="sql">
		/// The <see cref="SqlSelect"/> statement to execute.
		/// </param>
		/// <param name="transaction">
		/// The <see cref="IDbTransaction"/> within which the statement executes.
		/// </param>
		/// <param name="buffered">
		/// <see langword="true"/> to read all results immediately, or <see langword="false"/> to defer execution until the
		/// result is enumerated.
		/// </param>
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> whose elements are the results of the query.
		/// </returns>
		public static IEnumerable<T> Query<T>(this IDbConnection connection, SqlSelect sql, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));
			
			return Invoke(sql, (s, o) => connection.Query<T>(s, o, transaction, buffered, commandTimeout, CommandType.Text));
		}

		/// <summary>
		/// Executes a <see cref="SqlUnion"/> query and returns the results as the specified data type.
		/// </summary>
		/// <typeparam name="T">
		/// The type returned by the query.
		/// </typeparam>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the query.
		/// </param>
		/// <param name="sql">
		/// The <see cref="SqlUnion"/> statement to execute.
		/// </param>
		/// <param name="transaction">
		/// The <see cref="IDbTransaction"/> within which the statement executes.
		/// </param>
		/// <param name="buffered">
		/// <see langword="true"/> to read all results immediately, or <see langword="false"/> to defer execution until the
		/// result is enumerated.
		/// </param>
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> whose elements are the results of the query.
		/// </returns>
		public static IEnumerable<T> Query<T>(this IDbConnection connection, SqlUnion sql, IDbTransaction transaction = null,
			bool buffered = true, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, o) => connection.Query<T>(s, o, transaction, buffered, commandTimeout, CommandType.Text));
		}
	}
}