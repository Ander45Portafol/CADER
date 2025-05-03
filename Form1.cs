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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FrmInicio frm= new FrmInicio();
            CargarFormularioEnPanel(frm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BtnInicio.BackColor = Color.FromArgb(63,63,63);
            BtnInicio.ForeColor = Color.FromArgb(217,217,217);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            BtnInicio.BackColor = Color.FromArgb(217, 217, 217);
            BtnInicio.ForeColor = Color.FromArgb(63, 63, 63);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            CargarFormularioEnPanel(frmInicio);
        }
        // Método para cargar un formulario en el panel
        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            PanelContenido.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            PanelContenido.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }

        private void BtnMobiliario_Click(object sender, EventArgs e)
        {
            FrmMobiliario frM = new FrmMobiliario();
            CargarFormularioEnPanel(frM);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
