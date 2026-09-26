using Book.model;
using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace DataAccessLayer
{
    public class DapperRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        private readonly string _connectionString;
        private readonly string _tableName;
        private readonly PropertyInfo[] _columnsWithoutId;

        public DapperRepository(string connectionString, string? tableName = null)
        {
            _connectionString = connectionString;
            _tableName = tableName ?? typeof(T).Name + "s"; // Book -> Books

            _columnsWithoutId = typeof(T)
                .GetProperties()
                .Where(p => p.Name != nameof(IDomainObject.Id))
                .ToArray();

            EnsureTableExists();
        }

        private IDbConnection CreateConnection() => new SqliteConnection(_connectionString);

        private void EnsureTableExists()
        {
            var columnsSql = string.Join(",\n    ",
                _columnsWithoutId.Select(p => $"{p.Name} {MapSqlType(p.PropertyType)}"));

            using var db = CreateConnection();
            db.Execute($@"
        CREATE TABLE IF NOT EXISTS {_tableName} (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            {columnsSql}
        );");
        }

        private static string MapSqlType(Type t) => t == typeof(int) ? "INTEGER" : "TEXT";

        public void Add(T item)
        {
            var columns = string.Join(", ", _columnsWithoutId.Select(p => p.Name));
            var parameters = string.Join(", ", _columnsWithoutId.Select(p => "@" + p.Name));

            using var db = CreateConnection();
            db.Execute($"INSERT INTO {_tableName} ({columns}) VALUES ({parameters})", item);
        }

        public void Delete(int id)
        {
            using var db = CreateConnection();
            db.Execute($"DELETE FROM {_tableName} WHERE Id = @Id", new { Id = id });
        }

        public List<T> GetAll()
        {
            using var db = CreateConnection();
            return db.Query<T>($"SELECT * FROM {_tableName}").ToList();
        }

        public T? GetById(int id)
        {
            using var db = CreateConnection();
            return db.QueryFirstOrDefault<T>(
                $"SELECT * FROM {_tableName} WHERE Id = @Id", new { Id = id });
        }

        public void Update(T item)
        {
            var setClause = string.Join(", ", _columnsWithoutId.Select(p => $"{p.Name} = @{p.Name}"));

            using var db = CreateConnection();
            db.Execute($"UPDATE {_tableName} SET {setClause} WHERE Id = @Id", item);
        }
    }
}
