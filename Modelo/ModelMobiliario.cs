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
        public static bool InsertarMobiliario(int id_objeto, int id_grupo, string fecha_uso, string fecha_regreso, out string message)
        {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "INSERT INTO mobiliarios (id_objeto, id_grupo, fecha_uso, fecha_regreso) " +
                               "VALUES (@Objeto,@Grupo,@FechaUso, @FechaRegreso)";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Objeto", id_objeto);
                    cmd.Parameters.AddWithValue("@Grupo", id_grupo);
                    cmd.Parameters.AddWithValue("@FechaUso", fecha_uso);
                    cmd.Parameters.AddWithValue("@FechaRegreso", fecha_regreso);
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
        public static DataTable CargarMobiliario(int id_mobiliario, out string message) {
            Conexion dbConnection = new Conexion();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT b.nombre_objeto, c.nombre_grupo, a.fecha_uso, a.fecha_regreso FROM Mobiliarios a, Objetos b, Grupos c WHERE a.id_objeto=b.id_objeto AND a.id_grupo=c.id_grupo AND id_mobiliario=@Mobiliario";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                    {
                        cmdselect.Parameters.AddWithValue("@Mobiliario", id_mobiliario);
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
        public static bool ActualizarMobiliario(int id_mobiliario,int id_objeto, int id_grupo, string fecha_uso, string fecha_regreso, out string message) {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "UPDATE mobiliarios SET id_objeto=@Objeto,id_grupo=@Grupo,fecha_uso=@FechaUso,fecha_regreso=@FechaRegreso WHERE id_mobiliario=@Mobiliario";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Mobiliario", id_mobiliario);
                    cmd.Parameters.AddWithValue("@Objeto", id_objeto);
                    cmd.Parameters.AddWithValue("@Grupo", id_grupo);
                    cmd.Parameters.AddWithValue("@FechaUso", fecha_uso);
                    cmd.Parameters.AddWithValue("@FechaRegreso", fecha_regreso);
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
        public static bool EliminarMobiliario(int id_mobiliario, out string message) {
            Conexion dbConnection = new Conexion();

            try
            {
                string query = "DELETE FROM mobiliarios " +
                               "WHERE id_mobiliario=@ID";
                using (SqlConnection connection = dbConnection.DatabaseConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id_mobiliario);
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
    }
}
