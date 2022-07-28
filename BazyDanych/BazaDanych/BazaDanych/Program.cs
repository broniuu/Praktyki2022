using BazaDanych.DbConnection;

var connectionString = @"Server=(localdb)\LibraryDatabase;Database=LibraryDatabase;Trusted_Connection=True;";
var dbConnectionFactory = new DbConnectionFactory(connectionString);
var bookProperties = dbConnectionFactory.GetBookProperties();
;