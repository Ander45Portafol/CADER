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
    public partial class FrmFormCuotas : Form
    {
        public bool state_window = false;
        private int id_cuota = 0;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmFormCuotas()
        {
            InitializeComponent();
            state_window = false;
            BtnEliminar.Visible = false;
            label5.Text = "INGRESAR";
            Cargar_Datos();
        }
        public FrmFormCuotas(int id)
        {
            InitializeComponent();
            state_window = true;
            id_cuota = id;
            BtnEliminar.Visible = true;
            label5.Text = "MODIFICAR";
            Cargar_Datos();
            CargarCuota();
        }
        private void CargarCuota()
        {
            try
            {
                CuotaController cuota = new CuotaController();
                cuota.Id_Cuota = id_cuota;
                DataTable dt = cuota.CargarCuota();
                CmbUsuario.Text = dt.Rows[0]["nombre_usuario"].ToString();
                TxtCantidad.Text = dt.Rows[0]["cantidad_cuota"].ToString();
                dtFechaCuota.Text = dt.Rows[0]["fecha_cuota"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Cargar_Datos()
        {
            try
            {
                DataTable usuarios = CuotaController.CargarUsuarios();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = usuarios.NewRow();
                newRow["id_usuario"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["nombre_usuario"] = "Escoja una opción";
                usuarios.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                CmbUsuario.DataSource = usuarios;
                CmbUsuario.DisplayMember = "nombre_usuario";
                CmbUsuario.ValueMember = "id_usuario";
                CmbUsuario.SelectedIndex = 0;
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
                CuotaController cc = new CuotaController();
                // Asignar propiedades una por una
                cc.Cantidad_Cuota = Convert.ToDouble(TxtCantidad.Text);

                cc.Id_Usuario = Convert.ToInt32(CmbUsuario.SelectedValue);
                cc.Fecha_Cuota = dtFechaCuota.Value.ToString("yyyy-MM-dd");
                string message;
                bool isSuccess = cc.RegistrarCuota(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Cuota registrado exitosamente.");
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
                // Crear una instancia usando el constructor vacío
                CuotaController cc = new CuotaController();
                // Asignar propiedades una por una
                cc.Id_Cuota = id_cuota;
                cc.Cantidad_Cuota = Convert.ToDouble(TxtCantidad.Text);

                cc.Id_Usuario = Convert.ToInt32(CmbUsuario.SelectedValue);
                cc.Fecha_Cuota = dtFechaCuota.Value.ToString("yyyy-MM-dd");
                string message;
                bool isSuccess = cc.ActualzarCuota(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Cuota actualizado exitosamente.");
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
                CuotaController cc = new CuotaController();
                cc.Id_Cuota = id;
                string message;
                bool isSuccess = cc.EliminarCuota(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Cuota Eliminado exitosamente.");
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
        protected virtual void OnDatoAgregado(EventArgs e)
        {
            DatoAgregado?.Invoke(this, e);
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EliminarDatos(id_cuota);
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }
    }
}
