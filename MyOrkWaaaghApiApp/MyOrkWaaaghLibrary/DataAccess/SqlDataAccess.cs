using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace MyOrkWaaaghLibrary.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration configuration;

        public SqlDataAccess(IConfiguration config)
        {
            this.configuration = config;
        }

        public Task LoadData<T, U>(string storedProcedure, U parameters, string connectionString)
        {
            throw new NotImplementedException();
        }

        public async Task PutData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = configuration.GetConnectionString(connectionStringName);

            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(storedProcedure,
                                                parameters,
                                                commandType: CommandType.StoredProcedure);
            }
        }
    }
}
