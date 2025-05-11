using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Model
{
    public class Conexion
    {

        public static bool VerficiarConexion() {
            string DB = "CADER";
            string user = "sa";
            string password = "anderson123";
            string connectionString = "Server=localhost;Database=" + DB ;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
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
