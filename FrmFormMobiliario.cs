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
    public partial class FrmFormMobiliario : Form
    {
        public bool state_window = false;
        private int id_mob=0;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos

        // 2. Declarar el evento usando el delegado.
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmFormMobiliario()
        {
            InitializeComponent();
            state_window = false;
            BtnEliminar.Visible = false;
            label5.Text = "INGRESAR";
            Cargar_Datos();
        }
        public FrmFormMobiliario(int id) {
            InitializeComponent();
            state_window = true;
            id_mob= id;
            BtnEliminar.Visible = true;
            label5.Text = "MODIFICAR";
            CargarMobiliario();
            Cargar_Datos();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            state_window= false;
            this.Close();
        }
        void Cargar_Datos() {
            try
            {
                DataTable objetos = MobiliarioController.CargarObjetos();
                DataTable grupos = MobiliarioController.CargarGrupos();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = objetos.NewRow();
                newRow["id_objeto"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["nombre_objeto"] = "Seleccione una opción";
                objetos.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                cmbObjeto.DataSource = objetos;
                cmbObjeto.DisplayMember = "nombre_objeto";
                cmbObjeto.ValueMember = "id_objeto";
                cmbObjeto.SelectedIndex = 0;

                //Codigo para cargar la data en el control
                DataRow row = grupos.NewRow();
                row["id_grupo"] = DBNull.Value; // Valor nulo para el IdAgencia
                row["nombre_grupo"] = "Seleccione una opción";
                grupos.Rows.InsertAt(row, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                cmbGrupo.DataSource = grupos;
                cmbGrupo.DisplayMember = "nombre_grupo";
                cmbGrupo.ValueMember = "id_grupo";
                cmbGrupo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarDatos()
        {
            try
            {
                // Crear una instancia usando el constructor vacío
                MobiliarioController MBC=new MobiliarioController();
                // Asignar propiedades una por una
                MBC.Id_Objeto = Convert.ToInt32(cmbObjeto.SelectedValue);
                MBC.Id_Grupo = Convert.ToInt32(cmbGrupo.SelectedValue);
                MBC.Fecha_Uso = dtFechaUso.Value.ToString("yyyy-MM-dd");
                MBC.Fecha_Regreso = dtFechaRegreso.Value.ToString("yyyy-MM-dd");
                string message;
                bool isSuccess = MBC.RegistrarMobiliario(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Mobiliario registrado exitosamente.");
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
        private void CargarMobiliario() {
            try
            {
                MobiliarioController mobiliario = new MobiliarioController();
                mobiliario.Id_Mobiliario = id_mob;
                DataTable dt = mobiliario.CargarMobiliario();
                cmbGrupo.Text = dt.Rows[0]["nombre_grupo"].ToString();
                cmbObjeto.Text = dt.Rows[0]["nombre_objeto"].ToString();
                //cmbGrupo.ValueMember = "id_grupo";
                //MessageBox.Show(dt.Rows[0]["nombre_grupo"].ToString());
                dtFechaUso.Text = dt.Rows[0]["fecha_uso"].ToString();
                dtFechaRegreso.Text = dt.Rows[0]["fecha_regreso"].ToString();
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
                // Crear una instancia usando el constructor vacío
                MobiliarioController MBC = new MobiliarioController();
                // Asignar propiedades una por una
                MBC.Id_Mobiliario = Convert.ToInt32(id_mob);
                MBC.Id_Objeto = Convert.ToInt32(cmbObjeto.SelectedValue);
                MBC.Id_Grupo = Convert.ToInt32(cmbGrupo.SelectedValue);
                MBC.Fecha_Uso = dtFechaUso.Value.ToString("yyyy-MM-dd");
                MBC.Fecha_Regreso = dtFechaRegreso.Value.ToString("yyyy-MM-dd");
                string message;
                bool isSuccess = MBC.ActualizarMobiliario(out message);

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
            try {
                MobiliarioController MBC = new MobiliarioController();
                MBC.Id_Mobiliario = id;
                string message;
                bool isSuccess = MBC.EliminarMobiliario(out message);

                if (isSuccess)
                {
                    MessageBox.Show("Mobiliario Eliminado exitosamente.");
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
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (state_window)
            {
                actualizarDatos();
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
            else {
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
            DialogResult result=MessageBox.Show("¿Esta seguro de eliminar el registro?","Eliminar registro",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                EliminarDatos(id_mob);
                OnDatoAgregado(EventArgs.Empty);
                this.Close();
            }
        }

        private void FrmFormMobiliario_Load(object sender, EventArgs e)
        {
            if (state_window) {
                CargarMobiliario();
            }
            else { 
                
            }
        }
    }
}
