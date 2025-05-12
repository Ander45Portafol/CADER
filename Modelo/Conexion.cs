using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Conexion
    {
        //Variable gobla que guarda el estado de la conexion

        //Metodo de tipo Bool para realizar la conexion a la DB y asi mismo devolver false o true si existe la conexion;
        public SqlConnection DatabaseConnection()
        {
            string DB = "CADER";
            string user = "sa";
            string password = "123";
            string connectionString = "Server=localhost;Database=" + DB+ ";User= "+user+";Password="+password+";";
            SqlConnection _connection = new SqlConnection(connectionString);      
            return _connection;
        }
    }
}
