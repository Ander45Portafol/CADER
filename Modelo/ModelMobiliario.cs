using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelMobilirio
    {
        public static DataTable CargarMobiliarios(out string message) {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "Select* from Mobiliarios";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    connection.Open();
                    adp.Fill(data);
                }
            }
            catch (Exception ex)
            {
                message = $"Error al cargar datos: {ex.Message}";
                data = null;
            }
            message = null;
            return data;
        }
        public static DataTable CargarObjetos(out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_objeto,nombre_objeto FROM Objetos";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    connection.Open();
                    adp.Fill(data);
                }
            }
            catch (Exception ex)
            {
                message = $"Error al cargar datos: {ex.Message}";
                data = null;
            }
            message = null;
            return data;
        }
        public static DataTable CargarGrupos(out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_grupo,nombre_grupo FROM Grupos";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    connection.Open();
                    adp.Fill(data);
                }
            }
            catch (Exception ex)
            {
                message = $"Error al cargar datos: {ex.Message}";
                data = null;
            }
            message = null;
            return data;
        }
    }
}
