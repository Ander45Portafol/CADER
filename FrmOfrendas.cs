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
    public partial class FrmOfrendas : Form
    {
        public FrmOfrendas()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmOfrendas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

        }
        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            PanelOfrenda.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            PanelOfrenda.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }
        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            FrmFinanzas frmFinanzas = new FrmFinanzas();
            CargarFormularioEnPanel(frmFinanzas);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void CargarDatos()
        {
            try
            {
                DataTable datos = OfrendaController.CargarOfrendas();
                DgvOfrenda.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvOfrenda.Columns["id_ofrenda"].HeaderText = "ID";
                DgvOfrenda.Columns["id_iglesia"].HeaderText = "Iglesia";
                DgvOfrenda.Columns["cantidad_ofrenda"].HeaderText = "Cantidad Ofrenda";
                DgvOfrenda.Columns["fecha_ofrenda"].HeaderText = "Fecha de Ofrenda";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormAgregar_DatoAgregado(object sender, EventArgs e)
        {
            // Aquí es donde actualizas tu FormPrincipal
            CargarDatos(); // Vuelve a cargar los datos en tu DataGridView o ListBox
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormOfrenda frmFormOfrenda = new FrmFormOfrenda();
            frmFormOfrenda.DatoAgregado += FormAgregar_DatoAgregado;
            frmFormOfrenda.ShowDialog();
        }

        private void DgvOfrenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvOfrenda.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato = Int32.Parse(filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormOfrenda formOfrenda = new FrmFormOfrenda(dato);
                formOfrenda.DatoAgregado += FormAgregar_DatoAgregado;
                formOfrenda.Show();
            }
        }
    }
}
