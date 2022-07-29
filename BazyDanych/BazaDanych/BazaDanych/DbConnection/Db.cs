using BazaDanych.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace BazaDanych.DbConnection
{
    internal class Db
    {
        private readonly string _connectionString;

        public Db(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int AddAuthor(Author author)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "[uspAddAuthor]";
            var values = new { Name = author.Name, Surname = author.Surname };
            var result = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
            return result;
        }

        public int AddBook(Book book)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "[uspAddBook]";
            var values = new { Name = book.Name, DepartmentId = book.DepartmentId };
            var result = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
            return result;
        }

        public int AddBookAuthor(BookAuthor bookAuthor)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "[uspAddBookAuthor]";
            var values = new { BookId = bookAuthor.BookId, AuthorId = bookAuthor.AuhtorId };
            var result = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
            return result;
        }

        public int AddDepartment(Department department)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "uspAddDepartment";
            var values = new { Name = department.Name };
            var result = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
            return result;
        }

        public int AddWage(Wage wage)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "uspAddWage";
            var values = new { Amount = wage.Amount, WorkerId = wage.WorkerId };
            var result = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
            return result;
        }

        public int AddWorker(Worker worker)
        {
            using var connection = Connect();
            connection.Open();
            var procedure = "uspAddWorker";
            var values = new { Name = worker.Name, Surname = worker.Surname };
            var result = connection.Execute(procedure, values, commandType: CommandType.StoredProcedure);
            connection.Close();
            return result;
        }

        public IEnumerable<Woman> FindWomen()
        {
            using var connection = Connect();
            connection.Open();
            var women = connection.Query<Woman>("SELECT * FROM [dbo].[ufnFindWoman] ()");
            connection.Close();
            return women;
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