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
    public partial class FrmMobiliario : Form
    {
        public FrmMobiliario()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
            CargarDatos();
        }

        private void FrmMobiliario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormMobiliario formMobiliario = new FrmFormMobiliario();
            formMobiliario.DatoAgregado += FormAgregar_DatoAgregado;
            formMobiliario.ShowDialog();
        }
        private void FormAgregar_DatoAgregado(object sender, EventArgs e)
        {
            // Aquí es donde actualizas tu FormPrincipal
            CargarDatos(); // Vuelve a cargar los datos en tu DataGridView o ListBox
        }
        public void CargarDatos() {
            try
            {
                DataTable datos = MobiliarioController.CargarMobiliarios();
                DgvMobiliario.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvMobiliario.Columns["id_mobiliario"].HeaderText = "ID";
                DgvMobiliario.Columns["id_objeto"].HeaderText = "Objeto";
                DgvMobiliario.Columns["id_grupo"].HeaderText = "Grupo";
                DgvMobiliario.Columns["fecha_uso"].HeaderText = "Fecha de Uso";
                DgvMobiliario.Columns["fecha_regreso"].HeaderText = "Fecha de Regreso";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMobiliario_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DgvMobiliario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvMobiliario.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato =Int32.Parse( filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormMobiliario formMobiliario = new FrmFormMobiliario(dato);
                formMobiliario.DatoAgregado += FormAgregar_DatoAgregado;
                formMobiliario.Show();
            }
        }
    }
}
