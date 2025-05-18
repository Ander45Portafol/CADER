using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace CADER
{
    public partial class FrmRegistrarUsuarios : Form
    {
        public FrmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                AdministracionController ADMC = new AdministracionController();
                // Asignar propiedades una por una
                ADMC.Nombre_Usuario = TxtNombre.Text;
                ADMC.Apellido_Usuario = TxtApellido.Text;
                ADMC.Correo_Usuario = TxtCorreo.Text;
                ADMC.Clave_Usuario = TxtClave.Text;
                ADMC.Telefono_Usuario = MTextTelefono.Text;
                ADMC.Dui_Usuario = MTextDUI.Text;
                ADMC.Tipo_Usuario = cmbCargo.SelectedItem.ToString();
                string message;
                bool isSuccess = ADMC.RegistrarUsuario(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                }
                else
                {
                    MessageBox.Show(message, " Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones general
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text.Trim() == TxtClave2.Text.Trim())
            {
                guardarDatos();
            }
            else {

                MessageBox.Show("Error, contraseñas no coinciden","Error contraseñas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
