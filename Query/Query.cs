using Npgsql;
using Dapper;

namespace Instalments;

public class Query
{
    private const string ConnectionString = "Host=localhost;Port=5432;Database=northwind;Username=postgres;Password=007012002";

    public IEnumerable<T> Get<T>(string query)
    {
        var connection = new NpgsqlConnection(ConnectionString);
        connection.Open();
            
        return connection.Query<T>(query);
    }
    
    public T GetById<T>(int id, string tableName)
    {
        var connection = new NpgsqlConnection(ConnectionString);
        connection.Open();

        var sql = $"SELECT * FROM {tableName} WHERE id = @Id";
        var parameters = new { Id = id };

        return connection.QuerySingleOrDefault<T>(sql, parameters);
    }
}