using BazaDanych.DbConnection;
using BazaDanych.Mapper;
using BazaDanych.Model;
using Dapper;
using System.ComponentModel.DataAnnotations.Schema;

MapSetter.SetDapperMapper();

var connectionString = @"Server=(localdb)\LibraryDatabase;Database=LibraryDatabase;Trusted_Connection=True;";
var dbConnectionFactory = new DbConnectionFactory(connectionString);
var worker = new Worker("Józef", "Motyka");
dbConnectionFactory.AddWorker(worker);
var author = new Author("Natalia", "Kowalczyk");
dbConnectionFactory.AddAuthor(author);
var bookProperties = dbConnectionFactory.GetBookProperties();
var workerProperties = dbConnectionFactory.GetWorkerProperties();
;