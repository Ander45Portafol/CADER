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

        }
    }
}
