using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType dbType)
        {
            if (dbType == DatabaseType.Sql)
            {
                // TODO - Setup the SQL Connection.
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (dbType == DatabaseType.TextFile)
            {
                // TODO - Setup the Text Connection.
                TextConnector txt = new TextConnector();
                Connection = txt;
            }
        }

        /// <summary>
        /// Retrieves
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
