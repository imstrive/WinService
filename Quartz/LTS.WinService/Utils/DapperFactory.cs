using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LTS.WinService.Utils
{
    /// <summary>
    /// Dapper 连接帮助类
    /// </summary>
    public class DapperFactory
    {
        public static readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();// ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static OracleConnection CrateOracleConnection()
        {
            var connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static SqlConnection CrateMsSqlConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
