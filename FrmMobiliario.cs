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

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ControllerConexion.ConexionVerificar())
            {
                MessageBox.Show("Si existe conexion");
            }
            else {
                MessageBox.Show("No existe conexion");
            }
            FrmFormMobiliario formMobiliario = new FrmFormMobiliario();
            formMobiliario.ShowDialog();
        }
    }
}
