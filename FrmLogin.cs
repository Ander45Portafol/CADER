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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            string correo = TxtCorreo.Text.Trim();
            string contraseña = TxtClave.Text;
            AdministracionController login= new AdministracionController();
            login.Correo_Usuario = correo;
            login.Clave_Usuario = contraseña;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor ingrese sus credenciales");
                return;
            }

            if (login.Login())
            {

                MessageBox.Show("¡Acceso correcto!");

                Form1 fmrinicio = new Form1();
                fmrinicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
                TxtClave.Clear();
                TxtCorreo.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarUsuarios frmRegistrar = new FrmRegistrarUsuarios();
            frmRegistrar.Show();
            this.Hide();
        }
    }
}
