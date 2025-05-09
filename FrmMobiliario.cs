using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CADER.Personalizados;

namespace CADER
{
    public partial class FrmMobiliario : Form
    {
        public FrmMobiliario()
        {
            InitializeComponent();
            RoundedButton btn = new RoundedButton();
            btn.Text = "Botón Redondeado";
            btn.Size = new Size(150, 50);
            btn.Location = new Point(979, 15);
            btn.BorderRadius = 20;
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Black;
            this.Controls.Add(btn);
        }

        private void FrmMobiliario_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
