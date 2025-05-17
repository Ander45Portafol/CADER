using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADER
{
    public partial class FrmFinanzas : Form
    {
        public FrmFinanzas()
        {
            InitializeComponent();
        }
        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            PanelFinanzas.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            PanelFinanzas.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }
        private void BtnOfrendas_Click(object sender, EventArgs e)
        {

        }

        private void BtnOfrendas_Click_1(object sender, EventArgs e)
        {
            FrmOfrendas frmOfrendas = new FrmOfrendas();
            CargarFormularioEnPanel(frmOfrendas);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            FrmCuotas frm = new FrmCuotas();
            CargarFormularioEnPanel(frm);
        }
    }
}
