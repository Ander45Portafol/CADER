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
    public partial class FrmFormUsuarios : Form
    {
        public bool state_window = false;
        private int id_usuario = 0;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos

        // 2. Declarar el evento usando el delegado.
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmFormUsuarios()
        {
            InitializeComponent();
            state_window = false;
            BtnEliminar.Visible = false;
            label5.Text = "INGRESAR";
        }
        public FrmFormUsuarios(int id)
        {
            InitializeComponent();
            state_window = true;
            id_usuario = id;
            BtnEliminar.Visible = true;
            label5.Text = "MODIFICAR";
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                AdministracionController ADMC = new AdministracionController();
                // Asignar propiedades una por una
                ADMC.Nombre_Usuario = TxtNombre.Text;
                ADMC.Apellido_Usuario= TxtApellido.Text;
                ADMC.Correo_Usuario=TxtCorreo.Text;
                ADMC.Clave_Usuario=TxtClave.Text;
                ADMC.Telefono_Usuario = MTxtTelefono.Text;
                ADMC.Dui_Usuario= MTxtDui.Text;
                ADMC.Tipo_Usuario = CmbTipoUsuario.SelectedItem.ToString();
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
        private void CargarUsuario()
        {
            try
            {
                AdministracionController usuario = new AdministracionController();
                usuario.Id_Usuario = id_usuario;
                DataTable dt = usuario.CargarUsuario();
                TxtNombre.Text = dt.Rows[0]["nombre_usuario"].ToString();
                TxtApellido.Text = dt.Rows[0]["apellido_usuario"].ToString();
                TxtCorreo.Text = dt.Rows[0]["correo_usuario"].ToString();
                TxtClave.Text = dt.Rows[0]["clave_usuario"].ToString();
                MTxtTelefono.Text = dt.Rows[0]["telefono_usuario"].ToString();
                MTxtDui.Text = dt.Rows[0]["dui_usuario"].ToString();
                CmbTipoUsuario.Text = dt.Rows[0]["tipo_usuario"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void actualizarDatos()
        {
            try
            {
                AdministracionController ADMC = new AdministracionController();
                // Asignar propiedades una por una
                ADMC.Id_Usuario = id_usuario;
                ADMC.Nombre_Usuario = TxtNombre.Text;
                ADMC.Apellido_Usuario = TxtApellido.Text;
                ADMC.Correo_Usuario = TxtCorreo.Text;
                ADMC.Clave_Usuario = TxtClave.Text;
                ADMC.Telefono_Usuario = MTxtTelefono.Text;
                ADMC.Dui_Usuario = MTxtDui.Text;
                ADMC.Tipo_Usuario = CmbTipoUsuario.SelectedItem.ToString();
                string message;
                bool isSuccess = ADMC.ActualizarUsuario(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario actualizado exitosamente.");
                }
                else
                {
                    MessageBox.Show(message, " Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones general
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarDatos(int id)
        {
            try
            {
                AdministracionController ADMC = new AdministracionController();
                // Asignar propiedades una por una
                ADMC.Id_Usuario = id_usuario;
                string message;
                bool isSuccess = ADMC.EliminarUsuario(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Usuario Eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show(message, " Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones general
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected virtual void OnDatoAgregado(EventArgs e)
        {
            DatoAgregado?.Invoke(this, e);
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (state_window)
            {
                actualizarDatos();
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
            else
            {
                guardarDatos();
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }

        private void FrmFormUsuarios_Load(object sender, EventArgs e)
        {
            if (state_window)
            {
                CargarUsuario();
            }
            else
            {

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EliminarDatos(id_usuario);
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }
    }
}
