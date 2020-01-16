using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Repositories
{
    public class DatabaseRepository : BaseRepository
    {
        public List<string> GetFirstDatabaseList()
        {
            using(var connection = GetFirstConnection())
            {
                return connection.Query<string>("SELECT name FROM sys.databases WHERE owner_sid <> 0x01", commandType: System.Data.CommandType.Text).ToList();
            }
        }

        public List<string> GetSecondDatabaseList()
        {
            using (var connection = GetSecondConnection())
            {
                return connection.Query<string>("SELECT name FROM sys.databases WHERE owner_sid <> 0x01", commandType: System.Data.CommandType.Text).ToList();
            }
        }

        public List<string> GetTableName(bool isSecond  = false)
        {
            using (var connection = isSecond ? GetSecondConnection(true) : GetFirstConnection(true) )
            {
                return connection.Query<string>("SELECT name FROM sys.tables", commandType: System.Data.CommandType.Text).ToList();
            }
        }

        public List<TableCollumn> GetCollumns(string tableName, bool isSecond = false)
        {
            using(var connection = isSecond ? GetSecondConnection(true) : GetFirstConnection(true))
            {
                return connection.Query<TableCollumn>("SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName+"' ORDER BY ORDINAL_POSITION", commandType: System.Data.CommandType.Text).ToList();
            }
        }
    }
}
