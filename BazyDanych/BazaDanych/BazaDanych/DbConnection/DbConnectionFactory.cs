using BazaDanych.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace BazaDanych.DbConnection
{
    internal class DbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Connect()
        {
            return new SqlConnection(_connectionString);
        }

        public IEnumerable<Author> GetAuthors()
        {
            using var connection = Connect();
            connection.Open();
            return connection.Query<Author>("select * from Authors");
        }

        public IEnumerable<BookProperties> GetBookProperties()
        {
            using var connection = Connect();
            connection.Open();
            return connection.Query<BookProperties>("select * from BookProperties");
        }
    }
}