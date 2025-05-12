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
    public partial class FrmFormMobiliario : Form
    {
        public FrmFormMobiliario()
        {
            InitializeComponent();
            Cargar_Datos();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Cargar_Datos() {
            try
            {
                DataTable objetos = MobiliarioController.CargarObjetos();
                DataTable grupos = MobiliarioController.CargarGrupos();

                // Crea una nueva fila para "Escoja una opción"
                DataRow newRow = objetos.NewRow();
                newRow["id_objeto"] = DBNull.Value; // Valor nulo para el IdAgencia
                newRow["nombre_objeto"] = "Escoja una opción";
                objetos.Rows.InsertAt(newRow, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                cmbObjeto.DataSource = objetos;
                cmbObjeto.DisplayMember = "nombre_objeto";
                cmbObjeto.ValueMember = "id_objeto";
                cmbObjeto.SelectedIndex = 0;

                //Codigo para cargar la data en el control
                DataRow row = grupos.NewRow();
                row["id_grupo"] = DBNull.Value; // Valor nulo para el IdAgencia
                row["nombre_grupo"] = "Escoja una opción";
                grupos.Rows.InsertAt(row, 0); // 
                // Asigna el DataTable al ComboBox de la libreria
                cmbGrupo.DataSource = grupos;
                cmbGrupo.DisplayMember = "nombre_grupo";
                cmbGrupo.ValueMember = "id_grupo";
                cmbGrupo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las agencias, verifique su conexión a internet o que el cable de red está conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
