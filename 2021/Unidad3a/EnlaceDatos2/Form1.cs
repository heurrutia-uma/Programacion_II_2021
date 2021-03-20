using EnlaceDatos2.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnlaceDatos2
{
    public partial class Form1 : Form
    {
        private InfoContacto infoContacto = new InfoContacto();

        public Form1()
        {
            InitializeComponent();

            infoContacto.PropertyChanged += InfoContacto_PropertyChanged;
            infoContacto.Nombre = "Hector Urrutia";
            infoContacto.Email = "hector.urrutia@uma.edu.sv";
            infoContacto.Telefono = "4444 5555";
        }

        private void InfoContacto_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Nombre":
                    TxtNombre.Text = infoContacto.Nombre;
                    break;
                case "Email":
                    TxtEmail.Text = infoContacto.Email;
                    break;
                case "Telefono":
                    TxtTelefono.Text = infoContacto.Telefono;
                    break;
            }
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
        }
    }
}
