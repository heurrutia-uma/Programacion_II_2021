using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.ResetText();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirDialogo = new OpenFileDialog();
            abrirDialogo.Filter = "Archivo UMA (*.uma)|*.uma";

            if (abrirDialogo.ShowDialog() == DialogResult.OK)
            {
                RichTxtBox.Text = File.ReadAllText(abrirDialogo.FileName);
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarDialogo = new SaveFileDialog();
            guardarDialogo.Filter = "Archivo UMA (*.uma)|*.uma";

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(guardarDialogo.FileName, RichTxtBox.Text);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            nuevoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem_Click(sender, e);
        }

        private void toolStripGuardarComo_Click(object sender, EventArgs e)
        {
            guardarComoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por:\nAlumnos de la Universidad Modular Abierta\nSanta Ana", "Editor de Texto");
        }
    }
}
