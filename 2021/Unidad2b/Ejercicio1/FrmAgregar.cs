using System;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FrmAgregar : Form
    {

        public string[] datos;

        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtNombre.Text) && !String.IsNullOrEmpty(TxtApellido.Text) && !String.IsNullOrEmpty(TxtEmail.Text))
            {
                string[] info = { TxtNombre.Text, TxtApellido.Text, TxtEmail.Text };
                datos = info;
                this.Close();
            }
            else
            { 
                MessageBox.Show("Nombre, Apellido y Email son mandatorios.", "Agregar Registro");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
