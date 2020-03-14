using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezdy.Utils
{
    public class Config
    {   
        public string FinalURL(string table)
        {
            string url = Properties.Settings.Default.URL;
            string key = Properties.Settings.Default.Key;
            string filter = "?apiKey=";
            string formatType = "&format=";

            return string.Format("{0}{1}{2}{3}{4}{5}", url, table, filter, key, formatType,"json");         
        }

        public SqlConnection ConnectionDB()
        {
            SqlConnection cnn;
            string connectionString = ConfigurationManager.ConnectionStrings["RezdyDB"].ConnectionString;
            cnn = new SqlConnection(connectionString);
            return cnn;
        }
    }
}
