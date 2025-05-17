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
    public partial class FrmDonaciones : Form
    {
        public FrmDonaciones()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
            CargarDatos();
        }
        public void CargarDatos()
        {
            try
            {
                DataTable datos = DonacionesController.CargarDonaciones();
                DgvDonaciones.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvDonaciones.Columns["id_donaciones"].HeaderText = "ID";
                DgvDonaciones.Columns["id_usuario"].HeaderText = "Usuario";
                DgvDonaciones.Columns["cantidad_donacion"].HeaderText = "Cantidad Donación";
                DgvDonaciones.Columns["fecha_donacion"].HeaderText = "Fecha Donación";
                DgvDonaciones.Columns["descripcion_donacion"].HeaderText = "Descripción Donación";
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
        private void DgvDonaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvDonaciones.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato = Int32.Parse(filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormDonacion formDonacion = new FrmFormDonacion(dato);
                formDonacion.DatoAgregado += FormAgregar_DatoAgregado;
                formDonacion.ShowDialog();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormDonacion formDonacion = new FrmFormDonacion();
            formDonacion.DatoAgregado += FormAgregar_DatoAgregado;
            formDonacion.ShowDialog();
        }
    }
}
