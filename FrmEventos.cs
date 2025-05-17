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
    public partial class FrmEventos : Form
    {
        public FrmEventos()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
            CargarDatos();
        }
        public void CargarDatos()
        {
            try
            {
                DataTable datos = EventoController.CargarEventos();
                DgvEventos.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvEventos.Columns["id_evento"].HeaderText = "ID";
                DgvEventos.Columns["id_iglesia"].HeaderText = "Iglesia";
                DgvEventos.Columns["lugar_evento"].HeaderText = "Lugar";
                DgvEventos.Columns["fecha_evento"].HeaderText = "Fecha de Evento";
                DgvEventos.Columns["tipo_evento"].HeaderText = "Tipo de Evento";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormEventos frmFormEventos = new FrmFormEventos();
            frmFormEventos.DatoAgregado += FormAgregar_DatoAgregado;
            frmFormEventos.ShowDialog();
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {

        }
        private void FormAgregar_DatoAgregado(object sender, EventArgs e)
        {
            // Aquí es donde actualizas tu FormPrincipal
            CargarDatos(); // Vuelve a cargar los datos en tu DataGridView o ListBox
        }
        private void DgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvEventos.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato = Int32.Parse(filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormEventos frmFormEventos = new FrmFormEventos(dato);
                frmFormEventos.DatoAgregado += FormAgregar_DatoAgregado;
                frmFormEventos.Show();
            }
        }
    }
}
