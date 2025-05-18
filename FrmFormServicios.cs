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
    public partial class FrmFormServicios : Form
    {
        public bool state_window = false;
        private int id_servicio = 0;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos

        // 2. Declarar el evento usando el delegado.
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmFormServicios()
        {
            InitializeComponent();
            state_window = false;
            BtnEliminar.Visible = false;
            label5.Text = "INGRESAR";
            Cargar_Datos();
        }
        public FrmFormServicios(int id)
        {
            InitializeComponent();
            state_window = true;
            id_servicio = id;
            BtnEliminar.Visible = true;
            label5.Text = "MODIFICAR";
            CargarServicio();
            Cargar_Datos();
        }
        void Cargar_Datos()
        {
            try
            {
                DataTable grupos = ServiciosController.CargarGrupos();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = grupos.NewRow();
                newRow["id_grupo"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["nombre_grupo"] = "Seleccione una opción";
                grupos.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                cmbGrupo.DataSource = grupos;
                cmbGrupo.DisplayMember = "nombre_grupo";
                cmbGrupo.ValueMember = "id_grupo";
                cmbGrupo.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarServicio()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                ServiciosController SERVC = new ServiciosController();
                // Asignar propiedades una por una
                SERVC.Id_Servicio = id_servicio;
                DataTable dt = SERVC.CargarServicio();
                txtNombre.Text = dt.Rows[0]["nombre_encargado"].ToString();
                cmbGrupo.Text = dt.Rows[0]["nombre_grupo"].ToString();
                //MessageBox.Show(dt.Rows[0]["nombre_grupo"].ToString());
                cmbHorario.Text = dt.Rows[0]["horario"].ToString();
                cmbTipoServicio.Text = dt.Rows[0]["tipo_servicio"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                ServiciosController SERVC = new ServiciosController();
                // Asignar propiedades una por una
                SERVC.Id_Grupo = Convert.ToInt32(cmbGrupo.SelectedValue);
                SERVC.Tipo_Servicio = cmbTipoServicio.SelectedItem.ToString();
                SERVC.Nombre_Encargado = txtNombre.Text;
                SERVC.Horario = cmbHorario.SelectedItem.ToString();
                string message;
                bool isSuccess = SERVC.RegistrarServicios(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Servicio registrado exitosamente.");
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
                // Crear una instancia usando el constructor vacío
                ServiciosController SERVC = new ServiciosController();
                // Asignar propiedades una por una
                SERVC.Id_Servicio = id_servicio;
                SERVC.Id_Grupo = Convert.ToInt32(cmbGrupo.SelectedValue);
                SERVC.Tipo_Servicio = cmbTipoServicio.SelectedItem.ToString();
                SERVC.Nombre_Encargado = txtNombre.Text;
                SERVC.Horario = cmbHorario.SelectedItem.ToString();
                string message;
                bool isSuccess = SERVC.ActualizarServicios(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Servicio actualizado exitosamente.");
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
                // Crear una instancia usando el constructor vacío
                ServiciosController SERVC = new ServiciosController();
                // Asignar propiedades una por una
                SERVC.Id_Servicio = id_servicio;
                string message;
                bool isSuccess = SERVC.ELiminarServicios(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Servicios Eliminado exitosamente.");
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
        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            state_window = false;
            this.Close();
        }

        private void FrmFormServicios_Load(object sender, EventArgs e)
        {
            if (state_window)
            {
                CargarServicio();
            }
            else
            {

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EliminarDatos(id_servicio);
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }
    }
}
