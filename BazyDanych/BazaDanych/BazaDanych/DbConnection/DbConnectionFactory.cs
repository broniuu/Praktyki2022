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

        public void AddAuthor(Author author)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "[uspAddAuthor]";
            var values = new { Name = author.Name, Surname = author.Surname };
            var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
        }

        public void AddBook(Book book)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "[uspAddBook]";
            var values = new { Name = book.Name, DepartmentId = book.DepartmentId };
            var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
        }

        public void AddBookAuthor(BookAuthor bookAuthor)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "[uspAddBookAuthor]";
            var values = new { BookId = bookAuthor.BookId, AuthorId = bookAuthor.AuhtorId };
            var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
        }

        public void AddWorker(Worker worker)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "uspAddWorker";
            var values = new { Name = worker.Name, Surname = worker.Surname };
            var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
        }
        public void AddDepartment(Department department)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "uspAddDepartment";
            var values = new { Name = department.Name };
            var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
        }
        public void AddWage(Wage wage)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "uspAddWage";
            var values = new { Amount = wage.Amount, WorkerId = wage.WorkerId};
            var results = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
        }

        public IEnumerable<Author> GetAuthors()
        {
            using var connection = Connect();
            connection.Open();
            var authors = connection.Query<Author>("select * from Authors");
            connection.Close();
            return authors;
        }

        public IEnumerable<BookProperties> GetBookProperties()
        {
            using var connection = Connect();
            connection.Open();
            var bookProperties = connection.Query<BookProperties>("select * from BookProperties");
            connection.Close();
            return bookProperties;
        }

        public IEnumerable<WorkerProperties> GetWorkerProperties()
        {
            using var connection = Connect();
            connection.Open();
            var workerProperties = connection.Query<WorkerProperties>("select * from WorkerProperties");
            connection.Close();
            return workerProperties;
        }

        private IDbConnection Connect()
        {
            return new SqlConnection(_connectionString);
        }
    }
}