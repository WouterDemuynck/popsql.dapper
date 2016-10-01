using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
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
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> whose elements are the results of the query.
		/// </returns>
		public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection connection, SqlSelect sql, IDbTransaction transaction, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, o) => connection.QueryAsync<T>(s, o, transaction, commandTimeout));
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
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> whose elements are the results of the query.
		/// </returns>
		public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection connection, SqlUnion sql, IDbTransaction transaction, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, o) => connection.QueryAsync<T>(s, o, transaction, commandTimeout));
		}
	}
}