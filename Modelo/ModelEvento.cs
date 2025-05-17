using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelEvento
    {
        public static DataTable CargarEvento(out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "Select* from Eventos";
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
        public static bool InsertarEvento(string lugar_evento, string fecha_evento, string tipo_evento, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "INSERT INTO Eventos (lugar_evento,id_iglesia,fecha_evento, tipo_evento) " +
                               "VALUES (@LugarEvento,1,@FechaEvento, @TipoEvento)";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@LugarEvento", lugar_evento);
                    cmd.Parameters.AddWithValue("@FechaEvento", fecha_evento);
                    cmd.Parameters.AddWithValue("@TipoEvento", tipo_evento);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Agregado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se insertó ningún registro.";
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                message = $"Error de SQL: {dbConnection.FormatSqlErrorMessage(ex)}";
                return false;
            }
            catch (Exception ex)
            {
                message = $"Error general al insertar el usuario: {ex.Message}";
                return false;
            }

        }
        public static DataTable CargarEvento(int id_evento, out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT * FROM Eventos WHERE id_evento=@Evento";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                    {
                        cmdselect.Parameters.AddWithValue("@Evento", id_evento);
                        connection.Open();
                        adp.Fill(data);
                    }
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
        public static bool ActualizarEvento(int id_evento,string lugar_evento, string fecha_evento, string tipo_evento, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "UPDATE Eventos SET lugar_Evento=@LugarEvento,fecha_evento=@FechaEvento, tipo_evento=@TipoEvento WHERE id_evento=@Evento";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Evento", id_evento);
                    cmd.Parameters.AddWithValue("@LugarEvento", lugar_evento);
                    cmd.Parameters.AddWithValue("@FechaEvento", fecha_evento);
                    cmd.Parameters.AddWithValue("@TipoEvento", tipo_evento);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Actualizado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se actualizó ningún registro.";
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                message = $"Error de SQL: {dbConnection.FormatSqlErrorMessage(ex)}";
                return false;
            }
            catch (Exception ex)
            {
                message = $"Error general al insertar el usuario: {ex.Message}";
                return false;
            }
        }
        public static bool EliminarEvento(int id_Evento, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "DELETE FROM Eventos " +
                               "WHERE id_evento=@ID";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id_Evento);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        message = "Eliminado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se eliminó ningún registro.";
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                message = $"Error de SQL: {dbConnection.FormatSqlErrorMessage(ex)}";
                return false;
            }
            catch (Exception ex)
            {
                message = $"Error general al eliminar la ofrenda: {ex.Message}";
                return false;
            }
        }
    }
}
