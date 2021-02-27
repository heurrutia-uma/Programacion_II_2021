using System;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstViewDatos.Columns.Add("Nombre", 150);
            LstViewDatos.Columns.Add("Apellido", 150);
            LstViewDatos.Columns.Add("Email", 300);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using(FrmAgregar frmAgregar = new FrmAgregar())
            {
                frmAgregar.ShowDialog();

                if (frmAgregar.datos != null)
                    LstViewDatos.Items.Add(new ListViewItem(frmAgregar.datos));

                frmAgregar.Dispose();
            }
        }

        private void BtnSeleccion_Click(object sender, EventArgs e)
        {
            var seleccion = LstViewDatos.SelectedItems;
            if (seleccion.Count > 0)
            {
                string nombre = seleccion[0].SubItems[0].Text;
                string apellido = seleccion[0].SubItems[1].Text;
                string email = seleccion[0].SubItems[2].Text;

                MessageBox.Show(email);
            }
        }
    }
}
