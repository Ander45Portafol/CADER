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
    public partial class FrmFormEventos : Form
    {
        public bool state_window = false;
        private int id_Evento = 0;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmFormEventos()
        {
            InitializeComponent();
            state_window = false;
            BtnEliminar.Visible = false;
            label5.Text = "INGRESAR";
        }
        public FrmFormEventos(int id)
        {
            InitializeComponent();
            state_window = true;
            id_Evento = id;
            BtnEliminar.Visible = true;
            label5.Text = "MODIFICAR";
            CargarEvento();
        }
        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                EventoController EC = new EventoController();
                // Asignar propiedades una por una
                EC.Lugar_Evento = txtLugar.Text;
                EC.Tipo_Evento = cmbTipoEvento.SelectedItem.ToString();
                EC.Fecha_Evento = dtFechaEvento.Value.ToString("yyyy-MM-dd");
                string message;
                bool isSuccess = EC.RegistrarEento(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Evento registrado exitosamente.");
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
                EventoController EC = new EventoController();
                // Asignar propiedades una por una
                EC.Id_Evento = id_Evento;
                EC.Lugar_Evento = txtLugar.Text;
                EC.Tipo_Evento = cmbTipoEvento.SelectedItem.ToString();
                EC.Fecha_Evento = dtFechaEvento.Value.ToString("yyyy-MM-dd");
                string message;
                bool isSuccess = EC.ActualizarEvento(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Mobiliario actualizado exitosamente.");
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
                EventoController EC = new EventoController();
                // Asignar propiedades una por una
                EC.Id_Evento = id_Evento;
                string message;
                bool isSuccess = EC.EliminarEvento(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Evento Eliminado exitosamente.");
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
        private void CargarEvento()
        {
            try
            {
                EventoController evento = new EventoController();
                evento.Id_Evento = id_Evento;
                DataTable dt = evento.CargarEvento();
                cmbTipoEvento.Text = dt.Rows[0]["tipo_evento"].ToString();
                txtLugar.Text = dt.Rows[0]["lugar_evento"].ToString();
                dtFechaEvento.Text = dt.Rows[0]["fecha_evento"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                EliminarDatos(id_Evento);
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }
    }
}
