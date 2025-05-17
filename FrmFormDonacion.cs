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
    public partial class FrmFormDonacion : Form
    {
        public bool state_window = false;
        private int id_donacion = 0;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos

        // 2. Declarar el evento usando el delegado.
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmFormDonacion()
        {
            InitializeComponent();
            state_window = false;
            BtnEliminar.Visible = false;
            Cargar_Datos();
            label5.Text = "INGRESAR";
        }
        public FrmFormDonacion(int id)
        {
            InitializeComponent();
            state_window = true;
            id_donacion = id;
            BtnEliminar.Visible = true;
            label5.Text = "MODIFICAR";
            CargarDonacion();
            Cargar_Datos();
        }
        private void CargarDonacion()
        {
            try
            {
                DonacionesController donacion = new DonacionesController();
                donacion.Id_Donacion = id_donacion;
                DataTable dt = donacion.CargarDonacion();
                cmbUsuario.Text = dt.Rows[0]["nombre_usuario"].ToString();
                txtCantidad.Text = dt.Rows[0]["cantidad_donacion"].ToString();
                //cmbGrupo.ValueMember = "id_grupo";
                //MessageBox.Show(dt.Rows[0]["nombre_grupo"].ToString());
                dtFechDonacion.Text = dt.Rows[0]["fecha_donacion"].ToString();
                txtDescripcion.Text = dt.Rows[0]["descripcion_donacion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Cargar_Datos()
        {
            try
            {
                DataTable usuarios = DonacionesController.CargarUsuarios();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = usuarios.NewRow();
                newRow["id_usuario"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["nombre_usuario"] = "Seleccione una opción";
                usuarios.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                cmbUsuario.DataSource = usuarios;
                cmbUsuario.DisplayMember = "nombre_usuario";
                cmbUsuario.ValueMember = "id_usuario";
                cmbUsuario.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                DonacionesController DC = new DonacionesController();
                // Asignar propiedades una por una
                DC.Id_Usuario = Convert.ToInt32(cmbUsuario.SelectedValue);
                DC.Cantidad_Donacion = Convert.ToDouble(txtCantidad.Text);
                DC.Fecha_Donacion = dtFechDonacion.Value.ToString("yyyy-MM-dd");
                DC.Descripcion_Donacion = txtDescripcion.Text;
                string message;
                bool isSuccess = DC.RegistrarDonacion(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Donacion registrado exitosamente.");
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
        private void actualizarDatos()
        {
            try
            {
                DonacionesController DC = new DonacionesController();
                // Asignar propiedades una por una
                DC.Id_Donacion = id_donacion;
                // Asignar propiedades una por una
                DC.Id_Usuario = Convert.ToInt32(cmbUsuario.SelectedValue);
                DC.Cantidad_Donacion = Convert.ToDouble(txtCantidad.Text);
                DC.Fecha_Donacion = dtFechDonacion.Value.ToString("yyyy-MM-dd");
                DC.Descripcion_Donacion = txtDescripcion.Text;
                string message;
                bool isSuccess = DC.ActualizarDonacion(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Donacion actualizado exitosamente.");
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
                DonacionesController DC = new DonacionesController();
                // Asignar propiedades una por una
                DC.Id_Donacion = id_donacion;
                string message;
                bool isSuccess = DC.EliminarDonacion(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Donacion Eliminado exitosamente.");
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
        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EliminarDatos(id_donacion);
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }
    }
}
