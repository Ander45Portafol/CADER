using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Modelo
{
    public class ModelOfrenda
    {
        public static DataTable CargarOfrendas(out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "Select* from Ofrendas";
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
        public static bool InsertarOfrenda(double cantidad_ofrenda, string fecha_ofrenda, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "INSERT INTO Ofrendas (cantidad_ofrenda,id_iglesia, fecha_ofrenda) " +
                               "VALUES (@cantidad_ofrenda,1, @fecha_ofrenda)";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad_ofrenda", cantidad_ofrenda);
                    cmd.Parameters.AddWithValue("@fecha_ofrenda", fecha_ofrenda);
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
        public static DataTable CargarOfrenda(int id_ofrenda, out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT * FROM ofrendas WHERE id_ofrenda=@Ofrenda";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                    {
                        cmdselect.Parameters.AddWithValue("@Ofrenda", id_ofrenda);
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
        public static bool ActualizarOfrenda(int id_ofrenda, double cantidad_ofrenda, string fecha_ofrenda, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "UPDATE ofrendas SET cantidad_ofrenda=@CantidadOfrenda,fecha_ofrenda=@FechaOfrenda WHERE id_ofrenda=@Ofrenda";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Ofrenda", id_ofrenda);
                    cmd.Parameters.AddWithValue("@CantidadOfrenda", cantidad_ofrenda);
                    cmd.Parameters.AddWithValue("@FechaOfrenda", fecha_ofrenda);

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
        public static bool EliminarOfrenda(int id_ofrenda, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "DELETE FROM Ofrendas " +
                               "WHERE id_ofrenda=@ID";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id_ofrenda);
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
