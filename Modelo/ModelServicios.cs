using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelServicios
    {
        public static DataTable CargarServicios(out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "Select* from Servicios";
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
        public static DataTable cargarGrupos(out string message)
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
        public static bool InsertarServicios(double id_grupo, string nombre_encargado, string horario,string tipo_servicio, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "INSERT INTO Servicios (id_grupo,nombre_encargado, horario,tipo_servicio) " +
                               "VALUES (@Grupo,@NombreEncargado, @Horario, @TipoServicio)";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Grupo", id_grupo);
                    cmd.Parameters.AddWithValue("@NombreEncargado", nombre_encargado);
                    cmd.Parameters.AddWithValue("@Horario", horario);
                    cmd.Parameters.AddWithValue("@TipoServicio", tipo_servicio);
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
        public static DataTable CargarServicio(int id_servicio, out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT b.nombre_grupo,a.nombre_encargado,a.horario, a.tipo_servicio FROM Servicios a, Grupos b WHERE a.id_grupo=b.id_grupo AND id_servicio=@Servicio";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                    {
                        cmdselect.Parameters.AddWithValue("@Servicio", id_servicio);
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
        public static bool ActualizarCuota(int id_servicio,int id_grupo, string nombre_encargado, string horario, string tipo_servicio, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "UPDATE servicios SET id_grupo=@Grupo,nombre_encargado=@NombreEncargado, horario=@Horario, tipo_servicio=@TipoServicio WHERE id_servicio=@Servicio";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Servicio", id_servicio);
                    cmd.Parameters.AddWithValue("@Grupo", id_grupo);
                    cmd.Parameters.AddWithValue("@NombreEncargado", nombre_encargado);
                    cmd.Parameters.AddWithValue("@Horario", horario);
                    cmd.Parameters.AddWithValue("@TipoServicio", tipo_servicio);

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
        public static bool EliminarServicio(int id_Servicio, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "DELETE FROM Servicios " +
                               "WHERE id_servicio=@ID";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id_Servicio);
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
