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
    public partial class FrmMobiliario : Form
    {
        public FrmMobiliario()
        {
            InitializeComponent();
        }

        private void FrmMobiliario_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmFormMobiliario formMobiliario = new FrmFormMobiliario();
            formMobiliario.ShowDialog();
        }
    }
}
