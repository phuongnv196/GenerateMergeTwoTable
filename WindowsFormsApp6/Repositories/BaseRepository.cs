using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Repositories
{
    public class BaseRepository
    {
        public static string FirstConnectString;
        public static string SecondConnectString;
        public static string FirstDatabaseName;
        public static string SecondDatabaseName;
        public SqlConnection GetFirstConnection(bool isFirtDataBase = false)
        {
            return new SqlConnection(FirstConnectString.Replace("master", isFirtDataBase ? FirstDatabaseName :"master"));
        }
        public SqlConnection GetSecondConnection(bool isSecondDataBase = false)
        {
            return new SqlConnection(SecondConnectString.Replace("master", isSecondDataBase ? SecondDatabaseName : "master"));
        }
    }
}
