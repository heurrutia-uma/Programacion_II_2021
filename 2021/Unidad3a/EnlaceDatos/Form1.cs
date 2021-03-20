using EnlaceDatos.Clases;
using System;
using System.Windows.Forms;

namespace EnlaceDatos
{
    public partial class Form1 : Form
    {
        private InfoContacto infoContacto = new InfoContacto();

        public Form1()
        {
            InitializeComponent();

            infoContacto.Nombre = "Hector Urrutia";
            infoContacto.Email = "hector.urrutia@uma.edu.sv";
            infoContacto.Telefono = "5550 5555";

            TxtNombre.Text = infoContacto.Nombre;
            TxtEmail.Text = infoContacto.Email;
            TxtTelefono.Text = infoContacto.Telefono;
        }

        private void BtnMensaje_Click(object sender, EventArgs e)
        {
            string datos = infoContacto.Nombre + "\n" + infoContacto.Email + "\n" + infoContacto.Telefono;

            MessageBox.Show(datos);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            infoContacto.Nombre = "Luis Lopez";
            infoContacto.Email = "luis.lopez@uma.edu.sv";
            infoContacto.Telefono = "6666 5555";

            TxtNombre.Text = infoContacto.Nombre;
            TxtEmail.Text = infoContacto.Email;
            TxtTelefono.Text = infoContacto.Telefono;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            infoContacto.Nombre = TxtNombre.Text;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            infoContacto.Email = TxtEmail.Text;
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            infoContacto.Telefono = TxtTelefono.Text;
        }
    }
}
