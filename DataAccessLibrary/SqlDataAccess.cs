using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    /// <summary>
    /// SQL Data Access using Dapper
    /// </summary>
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public string ConnectionStringName { get; set; } = "Default";
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString(ConnectionStringName);
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task<T> LoadDataSingleOrDefault<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var data = await connection.QuerySingleOrDefaultAsync<T>(sql, parameters);

                return data;
            }
        }

        public async Task<IEnumerable<T>> LoadDataUsingStoredProcedure<T, U>(string storedProcedure, U parameters)
        {
            // 'using' enables garbage collection/shutting down the sql connection
            using IDbConnection connection = CreateConnection();

            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = CreateConnection())
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task SaveDataUsingStoredProcedure<T>(string storedProcedure, T parameters)
        {
            using IDbConnection connection = CreateConnection();

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}