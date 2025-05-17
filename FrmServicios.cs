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
    public partial class FrmServicios : Form
    {
        public FrmServicios()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                DataTable datos = ServiciosController.CargarServicios();
                DgvServicios.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvServicios.Columns["id_servicio"].HeaderText = "ID";
                DgvServicios.Columns["id_grupo"].HeaderText = "Grupo";
                DgvServicios.Columns["nombre_encargado"].HeaderText = "Nombre Encargado";
                DgvServicios.Columns["horario"].HeaderText = "Horario";
                DgvServicios.Columns["tipo_servicio"].HeaderText = "Tipo de Servicio";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormServicios formServicios = new FrmFormServicios();
            formServicios.DatoAgregado += FormAgregar_DatoAgregado;
            formServicios.ShowDialog();
        }
        private void FormAgregar_DatoAgregado(object sender, EventArgs e)
        {
            // Aquí es donde actualizas tu FormPrincipal
            CargarDatos(); // Vuelve a cargar los datos en tu DataGridView o ListBox
        }
        private void DgvServicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvServicios.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato = Int32.Parse(filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormServicios formServicios = new FrmFormServicios(dato);
                formServicios.DatoAgregado += FormAgregar_DatoAgregado;
                formServicios.Show();
            }
        }
    }
}
