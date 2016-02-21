using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace Popsql.Dapper
{
	public static partial class DbConnectionExtensions
	{
		/// <summary>
		/// Executes the specified <see cref="SqlInsert"/> statement and returns the number of affected rows.
		/// </summary>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the statement.
		/// </param>
		/// <param name="sql">
		/// The <see cref="SqlInsert"/> statement to execute.
		/// </param>
		/// <param name="transaction">
		/// The <see cref="IDbTransaction"/> within which the statement executes.
		/// </param>
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// The number of affected rows.
		/// </returns>
		public static Task<int> ExecuteAsync(this IDbConnection connection, SqlInsert sql, IDbTransaction transaction = null, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, p) => connection.ExecuteAsync(s, p, transaction, commandTimeout, CommandType.Text));
		}

		/// <summary>
		/// Executes the specified <see cref="SqlUpdate"/> statement and returns the number of affected rows.
		/// </summary>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the statement.
		/// </param>
		/// <param name="sql">
		/// The <see cref="SqlUpdate"/> statement to execute.
		/// </param>
		/// <param name="transaction">
		/// The <see cref="IDbTransaction"/> within which the statement executes.
		/// </param>
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// The number of affected rows.
		/// </returns>
		public static Task<int> ExecuteAsync(this IDbConnection connection, SqlUpdate sql, IDbTransaction transaction = null, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, p) => connection.ExecuteAsync(s, p, transaction, commandTimeout, CommandType.Text));
		}

		/// <summary>
		/// Executes the specified <see cref="SqlDelete"/> statement and returns the number of affected rows.
		/// </summary>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the statement.
		/// </param>
		/// <param name="sql">
		/// The <see cref="SqlDelete"/> statement to execute.
		/// </param>
		/// <param name="transaction">
		/// The <see cref="IDbTransaction"/> within which the statement executes.
		/// </param>
		/// <param name="commandTimeout">
		/// The wait time (in seconds) before terminating the attempt to execute the statement and generating an error.
		/// </param>
		/// <returns>
		/// The number of affected rows.
		/// </returns>
		public static Task<int> ExecuteAsync(this IDbConnection connection, SqlDelete sql, IDbTransaction transaction = null, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, p) => connection.ExecuteAsync(s, p, transaction, commandTimeout, CommandType.Text));
		}

		/// <summary>
		/// Executes the specified <see cref="SqlSelect"/> query and returns the first column of the first row from the
		/// returned resultset. Extra columns or rows are ignored.
		/// </summary>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the statement.
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
		/// The first column of the first row in the resultset.
		/// </returns>
		public static Task<object> ExecuteScalarAsync(this IDbConnection connection, SqlSelect sql, IDbTransaction transaction = null, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, o) => connection.ExecuteScalarAsync(s, o, transaction, commandTimeout, CommandType.Text));
		}

		/// <summary>
		/// Executes the specified <see cref="SqlSelect"/> query and returns the first column of the first row from the
		/// returned resultset. Extra columns or rows are ignored.
		/// </summary>
		/// <typeparam name="T">
		/// The type returned by the query.
		/// </typeparam>
		/// <param name="connection">
		/// The <see cref="IDbConnection"/> used when executing the statement.
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
		/// The first column of the first row in the resultset.
		/// </returns>
		public static Task<T> ExecuteScalarAsync<T>(this IDbConnection connection, SqlSelect sql, IDbTransaction transaction = null, int? commandTimeout = null)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (sql == null) throw new ArgumentNullException(nameof(sql));

			return Invoke(sql, (s, o) => connection.ExecuteScalarAsync<T>(s, o, transaction, commandTimeout, CommandType.Text));
		}
	}
}