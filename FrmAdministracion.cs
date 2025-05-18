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
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
            LblDay.Text = DateTime.Today.ToString("yyyy-MM-dd");
            CargarDatos();
        }
        public void CargarDatos()
        {
            try
            {
                DataTable datos = AdministracionController.CargarUsuarios();
                DgvUsuarios.DataSource = datos;
                // Renombrar las columnas en el DataGridView
                DgvUsuarios.Columns["id_usuario"].HeaderText = "ID";
                DgvUsuarios.Columns["nombre_completo"].HeaderText = "Nombre Usuario";
                DgvUsuarios.Columns["correo_usuario"].HeaderText = "Correo";
                DgvUsuarios.Columns["telefono_usuario"].HeaderText = "Telefono";
                DgvUsuarios.Columns["tipo_usuario"].HeaderText = "Tipo de Usuario";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvUsuarios.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                int dato = Int32.Parse(filaSeleccionada.Cells[0].Value?.ToString());
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmFormUsuarios frmFormUsuarios = new FrmFormUsuarios(dato);
                frmFormUsuarios.DatoAgregado += FormAgregar_DatoAgregado;
                frmFormUsuarios.ShowDialog();
            }
        }
        private void FormAgregar_DatoAgregado(object sender, EventArgs e)
        {
            // Aquí es donde actualizas tu FormPrincipal
            CargarDatos(); // Vuelve a cargar los datos en tu DataGridView o ListBox
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormUsuarios frmUsuario = new FrmFormUsuarios();
            frmUsuario.DatoAgregado += FormAgregar_DatoAgregado;
            frmUsuario.ShowDialog();
        }
    }
}
