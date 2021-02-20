using System;
using System.IO;
using System.Windows.Forms;

namespace Unidad2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            var rutaArchivo = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Archivo CSV (*.csv)|*.csv|Archivo de Excel (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    rutaArchivo = openFileDialog.FileName;

                    using (StreamReader reader = new StreamReader(rutaArchivo))
                    {
                        while (!reader.EndOfStream)
                        {
                            LstClientes.Items.Add(reader.ReadLine());   
                        }
                    }
                }
            }
        }
    }
}
