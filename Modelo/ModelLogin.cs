using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelLogin
    {
        public static bool Autenticar(string correo, string contraseña, out string message)
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection connection = conexion.DatabaseConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE correo_usuario=@Correo AND clave_usuario=@Contraseña";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        message = null;
                        return count == 1;
                    }
                }
            }
            catch (SqlException sqlex)
            {
                message = $"Error de SQL: {sqlex.Message}";
                //MessageBox.Show($"Error de SQL: {sqlEx.Message}\nNúmero: {sqlEx.Number}");
                return false;
            }
            catch (Exception ex)
            {
                message = $"Error  general: {ex.Message}";
                //essageBox.Show($"Error general: {ex.Message}");
                return false;
            }
        }
    }
}
