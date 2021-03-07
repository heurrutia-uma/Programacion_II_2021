using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        const int TAMANIO_INICIAL = 8;
        const int TAMANIO_FINAL = 72;

        public Form1()
        {
            InitializeComponent();
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.ResetText();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirDialogo = new OpenFileDialog();
            abrirDialogo.Filter = "Archivo RTF (*.rtf)|*.rtf";

            if (abrirDialogo.ShowDialog() == DialogResult.OK)
            {
                RichTxtBox.LoadFile(abrirDialogo.FileName);
            }

            RichTxtBox_SelectionChanged(sender, e);
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarDialogo = new SaveFileDialog();
            guardarDialogo.Filter = "Archivo RTF (*.rtf)|*.rtf";

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                RichTxtBox.SaveFile(guardarDialogo.FileName);
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripNuevo_Click(object sender, EventArgs e)
        {
            NuevoToolStripMenuItem_Click(sender, e);
        }

        private void ToolStripAbrir_Click(object sender, EventArgs e)
        {
            AbrirToolStripMenuItem_Click(sender, e);
        }

        private void ToolStripGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarComoToolStripMenuItem_Click(sender, e);
        }

        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            SalirToolStripMenuItem_Click(sender, e);
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por:\nAlumnos de la Universidad Modular Abierta\nSanta Ana", "Editor de Texto");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] familias = FontFamily.Families;

            for (int i = 0; i < familias.Length; i++)
            {
                if (familias[i].IsStyleAvailable(FontStyle.Regular))
                {
                    ToolStripCmbFuente.Items.Add(familias[i].Name);
                }
            }

            int j = TAMANIO_INICIAL;
            while (j <= TAMANIO_FINAL)
            {
                ToolStripCmbTamanio.Items.Add(j.ToString());

                if (j < 12)
                    j++;
                else if (j >= 12 && j < 48)
                    j = j + 2;
                else if (j >= 48)
                    j = j + 24;
            }

            Font fuenteRichTextBox = RichTxtBox.Font;
            ToolStripCmbFuente.SelectedItem = fuenteRichTextBox.Name;
            ToolStripCmbTamanio.SelectedItem = Math.Truncate(fuenteRichTextBox.Size).ToString();
        }

        private void ToolStripCmbFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle estilo = RichTxtBox.SelectionFont == null ? FontStyle.Regular : RichTxtBox.SelectionFont.Style;
            AplicarEstilo(estilo);
        }

        private void ToolStripCmbTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle estilo = RichTxtBox.SelectionFont == null ? FontStyle.Regular : RichTxtBox.SelectionFont.Style;
            AplicarEstilo(estilo);
        }

        private void ToolStripBtnNegrita_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Bold;

            if (RichTxtBox.SelectionFont != null)
            {
                if (RichTxtBox.SelectionFont.Bold)
                    estilo = estilo & ~FontStyle.Bold;
                else
                    estilo = estilo | FontStyle.Bold;
            }

            AplicarEstilo(estilo);
        }

        private void ToolStripBtnItalica_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Italic;

            if (RichTxtBox.SelectionFont != null)
            {
                if (RichTxtBox.SelectionFont.Italic)
                    estilo = estilo & ~FontStyle.Italic;
                else
                    estilo = estilo | FontStyle.Italic;
            }

            AplicarEstilo(estilo);
        }

        private void ToolStripBtnSubrayado_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Underline;

            if (RichTxtBox.SelectionFont != null)
            {
                if (RichTxtBox.SelectionFont.Underline)
                    estilo = estilo & ~FontStyle.Underline;
                else
                    estilo = estilo | FontStyle.Underline;
            }

            AplicarEstilo(estilo);
        }

        private void AplicarEstilo(FontStyle estilo)
        {
            string fuenteCombo = ToolStripCmbFuente.SelectedItem.ToString();
            float tamnioCombo = ToolStripCmbTamanio.SelectedItem == null ? (float)Convert.ToDecimal(TAMANIO_INICIAL) : (float)Convert.ToDecimal(ToolStripCmbTamanio.SelectedItem);

            string nombreFuente;
            float tamanio;

            if (RichTxtBox.SelectionFont != null)
            {
                string fuenteSeleccion = RichTxtBox.SelectionFont.Name;
                float tamanioSeleccion = RichTxtBox.SelectionFont.Size;

                if (fuenteCombo != fuenteSeleccion)
                    nombreFuente = fuenteCombo;
                else
                    nombreFuente = fuenteSeleccion;

                if (tamnioCombo != tamanioSeleccion)
                    tamanio = tamnioCombo;
                else
                    tamanio = tamanioSeleccion;
            }
            else
            {
                nombreFuente = fuenteCombo;
                tamanio = tamnioCombo;
            }

            Font fuente = new Font(nombreFuente, tamanio, estilo);

            if (fuente != null)
                RichTxtBox.SelectionFont = fuente;
        }

        private void ToolStripBtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorFuente = new ColorDialog();

            if (colorFuente.ShowDialog() == DialogResult.OK)
            {
                RichTxtBox.SelectionColor = colorFuente.Color;
            }
        }

        private void ToolStripBntIzquierda_Click(object sender, EventArgs e)
        {
            RichTxtBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ToolStripBtnCentro_Click(object sender, EventArgs e)
        {
            RichTxtBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ToolStripBtnDerecha_Click(object sender, EventArgs e)
        {
            RichTxtBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Copy();
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Cut();
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Paste();
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Undo();
        }

        private void RehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTxtBox.Redo();
        }

        private void RichTxtBox_SelectionChanged(object sender, EventArgs e)
        {
            Font fuente = RichTxtBox.SelectionFont;
            if (fuente != null)
            {
                ToolStripCmbFuente.SelectedItem = fuente.Name;
                ToolStripCmbTamanio.SelectedItem = Math.Truncate(fuente.Size).ToString();
            }
        }
    }
}
