using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public class SqlDataAccess1
    {
        //Connection
        public static string GetConnectionString(string connectionName = "DentalInqury")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        //Connection>Load
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection conn1 = new SqlConnection(GetConnectionString()))
            {
                return conn1.Query<T>(sql).ToList();
            }
        }

        //Connection>Save
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection conn1 = new SqlConnection(GetConnectionString()))
            {
                return conn1.Execute(sql, data);
            }   
        }        
    }
}

