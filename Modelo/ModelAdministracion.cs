using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelAdministracion
    {
        public static DataTable CargarUsuarios(out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT id_usuario,CONCAT(nombre_usuario,' ',Apellido_usuario) AS nombre_completo,correo_usuario,telefono_usuario,tipo_usuario FROM usuarios";
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
        public static bool InsertarUsuario(string nombre_usuario, string apellido_usuario,string correo_usuario,string clave_usuario,string telefono_usuario, string dui_usuario, string tipo_usuario, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "INSERT INTO Usuarios (id_iglesia,nombre_usuario,apellido_usuario,correo_usuario,clave_usuario,telefono_usuario,dui_usuario,tipo_usuario ) " +
                               "VALUES (@1,@Nombre,@Apellido,@Correo,@Clave,@Telefono,@DUI,@Tipo)";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre_usuario);
                    cmd.Parameters.AddWithValue("@Apellido", apellido_usuario);
                    cmd.Parameters.AddWithValue("@Correo", correo_usuario);
                    cmd.Parameters.AddWithValue("@Clave", clave_usuario);
                    cmd.Parameters.AddWithValue("@Telefono", telefono_usuario);
                    cmd.Parameters.AddWithValue("@DUI", dui_usuario);
                    cmd.Parameters.AddWithValue("@Tipo", tipo_usuario);

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
        public static DataTable CargarUsuario(int usuario, out string message)
        {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT * FROM Usuarios WHERE id_usuario=@Usuario";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                    {
                        cmdselect.Parameters.AddWithValue("@Usuario", usuario);
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
        public static bool ActualizarUsuario(int id_usuario, string nombre_usuario, string apellido_usuario, string correo_usuario, string clave_usuario, string telefono_usuario,string dui_usuario, string tipo_usuario, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "UPDATE Usuarios SET id_iglesia=1,nombre_usuario=@Usuario,apellido_usuario=@Apellido,correo_usuario=@Correo,clave_usuario=@Clave,telefono_usuario=@Telefono,dui_usuario=@DUI,tipo_usuario=@Tipo WHERE id_usuario=@ID";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id_usuario);
                    cmd.Parameters.AddWithValue("@Usuario", nombre_usuario);
                    cmd.Parameters.AddWithValue("@Apellido", apellido_usuario);
                    cmd.Parameters.AddWithValue("@Correo", correo_usuario);
                    cmd.Parameters.AddWithValue("@Clave", clave_usuario);
                    cmd.Parameters.AddWithValue("@Telefono", telefono_usuario);
                    cmd.Parameters.AddWithValue("@DUI", dui_usuario);
                    cmd.Parameters.AddWithValue("@Tipo", tipo_usuario);
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
        public static bool EliminarUsuario(int usuario, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "DELETE FROM Usuarios " +
                               "WHERE id_usuario=@ID";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", usuario);
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
