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
            formMobiliario.ShowDialog();
        }
        void CargarDatos() {
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
    }
}
