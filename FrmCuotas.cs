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
    public partial class FrmCuotas : Form
    {
        public FrmCuotas()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }
        public void CargarDatos()
        {
            try
            {
                DataTable datos = CuotaController.CargarCuotas();
                DgvCuota.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvCuota.Columns["id_cuota"].HeaderText = "ID";
                DgvCuota.Columns["id_usuario"].HeaderText = "Usuario";
                DgvCuota.Columns["cantidad_cuota"].HeaderText = "Cantidad Cuota";
                DgvCuota.Columns["fecha_cuota"].HeaderText = "Fecha de Cuota";

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
        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            PanelCuota.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            PanelCuota.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }
        private void FrmCuotas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            FrmFinanzas frmFinanzas = new FrmFinanzas();
            CargarFormularioEnPanel(frmFinanzas);
        }

        private void DgvCuota_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvCuota.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato = Int32.Parse(filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormCuotas formCuotas = new FrmFormCuotas(dato);
                formCuotas.DatoAgregado += FormAgregar_DatoAgregado;
                formCuotas.Show();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormCuotas frmFormCuotas = new FrmFormCuotas();
            frmFormCuotas.DatoAgregado += FormAgregar_DatoAgregado;
            frmFormCuotas.ShowDialog();
        }
    }
}
