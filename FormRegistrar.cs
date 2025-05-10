using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADER
{
    public partial class FormRegistrar: Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtClave.Text = "";
            txtclave2.Text = "";
            txtDui.Text = "";
            txtTelefono.Text = "";
            txtServicio.Text = "";
        }
        private void GuardarDatos()
        {
            // Cadena de conexión a la base de datos con autenticación de Windows
            string connectionString = "Data Source=.;Initial Catalog=CADER;Integrated Security=True";

            // Consulta SQL para insertar los datos
            string query = "INSERT INTO Usuarios (id_iglesia, nombre_usuario, clave_usuario, telefono_usuario, dui_usuario, tipo_usuario) " +
                           "VALUES (@Iglesia, @Nombre, @Clave, @Telefono, @Dui, @Tipo)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar valores a los parámetros
                        command.Parameters.AddWithValue("@Iglesia", ObtenerIdIglesia()); // Método para obtener el valor de id_iglesia
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@Clave", txtClave.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@Dui", txtDui.Text);
                        command.Parameters.AddWithValue("@Tipo", txtServicio.Text);

                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar el comando
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar si se insertaron los datos
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdIglesia()
        {
            // Aquí puedes obtener el valor de id_iglesia desde un control como un ComboBox o asignar un valor fijo
            // Por ejemplo, si tienes un ComboBox llamado cmbIglesia:
            // return Convert.ToInt32(cmbIglesia.SelectedValue);

            // Si es un valor fijo, puedes devolverlo directamente:
            return 1; // Cambia este valor según sea necesario
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == txtclave2.Text)
            {
                GuardarDatos();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
