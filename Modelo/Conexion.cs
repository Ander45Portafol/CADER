using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Conexion
    {
        public static bool VerficiarConexion()
        {
            string DB = "CADER";
            string user = "sa";
            string password = "123";
            string connectionString = "Server=localhost;Database=" + DB+ ";User= "+user+";Password="+password+";";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
