using BazaDanych.DbConnection;
using BazaDanych.Mapper;
using BazaDanych.Model;
using Dapper;
using System.ComponentModel.DataAnnotations.Schema;

MapSetter.SetDapperMapper();

var connectionString = @"Server=(localdb)\LibraryDatabase;Database=LibraryDatabase;Trusted_Connection=True;";
var dbConnectionFactory = new DbConnectionFactory(connectionString);
var bookProperties = dbConnectionFactory.GetBookProperties();
var workerProperties = dbConnectionFactory.GetWorkerProperties();
;