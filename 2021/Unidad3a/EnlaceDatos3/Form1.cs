using EnlaceDatos3.Clases;
using System;
using System.Windows.Forms;

namespace EnlaceDatos3
{
    public partial class Form1 : Form
    {
        private InfoContacto infoContacto = new InfoContacto();

        private BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            //TxtNombre.DataBindings.Add(new Binding("Text", infoContacto, "Nombre"));
            //TxtEmail.DataBindings.Add(new Binding("Text", infoContacto, "Email"));
            //TxtTelefono.DataBindings.Add(new Binding("Text", infoContacto, "Telefono"));

            /*******************************/

            bs.DataSource = infoContacto;

            TxtNombre.DataBindings.Add("Text", bs, "Nombre");
            TxtEmail.DataBindings.Add("Text", bs, "Email");
            TxtTelefono.DataBindings.Add("Text", bs, "Telefono");

            infoContacto.Nombre = "Hector Urrutia";
            infoContacto.Email = "hector.urrutia@uma.edu.sv";
            infoContacto.Telefono = "4444 5555";
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            infoContacto.Nombre = "Luis Lopez";
            infoContacto.Email = "luis.lopez@uma.edu.sv";
            infoContacto.Telefono = "6666 5555";
        }

        private void BtnMensaje_Click(object sender, EventArgs e)
        {
            string datos = infoContacto.Nombre + "\n" + infoContacto.Email + "\n" + infoContacto.Telefono;

            MessageBox.Show(datos);
        }
    }
}
