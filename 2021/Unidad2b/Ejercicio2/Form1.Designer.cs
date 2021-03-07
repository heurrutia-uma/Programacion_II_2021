
namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichTxtBox = new System.Windows.Forms.RichTextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolStripArchivo = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEdicion = new System.Windows.Forms.ToolStrip();
            this.ToolStripCmbFuente = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripCmbTamanio = new System.Windows.Forms.ToolStripComboBox();
            this.ContextMenuEdicion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripBtnNegrita = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnItalica = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnSubrayado = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnColor = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBntIzquierda = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnCentro = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnDerecha = new System.Windows.Forms.ToolStripButton();
            this.toolStripNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripGuardarComo = new System.Windows.Forms.ToolStripButton();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.ToolStripArchivo.SuspendLayout();
            this.toolStripEdicion.SuspendLayout();
            this.ContextMenuEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(681, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // RichTxtBox
            // 
            this.RichTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTxtBox.ContextMenuStrip = this.ContextMenuEdicion;
            this.RichTxtBox.Location = new System.Drawing.Point(0, 52);
            this.RichTxtBox.Name = "RichTxtBox";
            this.RichTxtBox.Size = new System.Drawing.Size(681, 501);
            this.RichTxtBox.TabIndex = 1;
            this.RichTxtBox.Text = "";
            this.RichTxtBox.SelectionChanged += new System.EventHandler(this.RichTxtBox_SelectionChanged);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ToolStripArchivo
            // 
            this.ToolStripArchivo.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNuevo,
            this.toolStripAbrir,
            this.toolStripGuardarComo,
            this.toolStripSeparator1,
            this.toolStripSalir,
            this.toolStripSeparator2});
            this.ToolStripArchivo.Location = new System.Drawing.Point(0, 24);
            this.ToolStripArchivo.Name = "ToolStripArchivo";
            this.ToolStripArchivo.Size = new System.Drawing.Size(122, 25);
            this.ToolStripArchivo.TabIndex = 2;
            this.ToolStripArchivo.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(29, 22);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.ToolStripSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripEdicion
            // 
            this.toolStripEdicion.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEdicion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCmbFuente,
            this.ToolStripCmbTamanio,
            this.ToolStripBtnNegrita,
            this.ToolStripBtnItalica,
            this.ToolStripBtnSubrayado,
            this.ToolStripBtnColor,
            this.ToolStripBntIzquierda,
            this.ToolStripBtnCentro,
            this.ToolStripBtnDerecha});
            this.toolStripEdicion.Location = new System.Drawing.Point(122, 24);
            this.toolStripEdicion.Name = "toolStripEdicion";
            this.toolStripEdicion.Size = new System.Drawing.Size(409, 27);
            this.toolStripEdicion.TabIndex = 3;
            this.toolStripEdicion.Text = "toolStrip1";
            // 
            // ToolStripCmbFuente
            // 
            this.ToolStripCmbFuente.Name = "ToolStripCmbFuente";
            this.ToolStripCmbFuente.Size = new System.Drawing.Size(150, 27);
            this.ToolStripCmbFuente.Text = "Fuente";
            this.ToolStripCmbFuente.ToolTipText = "Fuente";
            this.ToolStripCmbFuente.SelectedIndexChanged += new System.EventHandler(this.ToolStripCmbFuente_SelectedIndexChanged);
            // 
            // ToolStripCmbTamanio
            // 
            this.ToolStripCmbTamanio.Name = "ToolStripCmbTamanio";
            this.ToolStripCmbTamanio.Size = new System.Drawing.Size(75, 27);
            this.ToolStripCmbTamanio.Text = "Tamaño";
            this.ToolStripCmbTamanio.ToolTipText = "Tamaño";
            this.ToolStripCmbTamanio.SelectedIndexChanged += new System.EventHandler(this.ToolStripCmbTamanio_SelectedIndexChanged);
            // 
            // ContextMenuEdicion
            // 
            this.ContextMenuEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopiarToolStripMenuItem,
            this.CortarToolStripMenuItem,
            this.PegarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.DeshacerToolStripMenuItem,
            this.RehacerToolStripMenuItem});
            this.ContextMenuEdicion.Name = "ContextMenuEdicion";
            this.ContextMenuEdicion.Size = new System.Drawing.Size(123, 120);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // ToolStripBtnNegrita
            // 
            this.ToolStripBtnNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnNegrita.Image = global::Ejercicio2.Properties.Resources.Bold_16x;
            this.ToolStripBtnNegrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnNegrita.Name = "ToolStripBtnNegrita";
            this.ToolStripBtnNegrita.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnNegrita.Text = "Negrita";
            this.ToolStripBtnNegrita.Click += new System.EventHandler(this.ToolStripBtnNegrita_Click);
            // 
            // ToolStripBtnItalica
            // 
            this.ToolStripBtnItalica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnItalica.Image = global::Ejercicio2.Properties.Resources.Italic_16x;
            this.ToolStripBtnItalica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnItalica.Name = "ToolStripBtnItalica";
            this.ToolStripBtnItalica.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnItalica.Text = "Italica";
            this.ToolStripBtnItalica.Click += new System.EventHandler(this.ToolStripBtnItalica_Click);
            // 
            // ToolStripBtnSubrayado
            // 
            this.ToolStripBtnSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnSubrayado.Image = global::Ejercicio2.Properties.Resources.Underline_16x;
            this.ToolStripBtnSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnSubrayado.Name = "ToolStripBtnSubrayado";
            this.ToolStripBtnSubrayado.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnSubrayado.Text = "Subrayado";
            this.ToolStripBtnSubrayado.Click += new System.EventHandler(this.ToolStripBtnSubrayado_Click);
            // 
            // ToolStripBtnColor
            // 
            this.ToolStripBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnColor.Image = global::Ejercicio2.Properties.Resources.FontColor_16x;
            this.ToolStripBtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnColor.Name = "ToolStripBtnColor";
            this.ToolStripBtnColor.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnColor.Text = "Color";
            this.ToolStripBtnColor.Click += new System.EventHandler(this.ToolStripBtnColor_Click);
            // 
            // ToolStripBntIzquierda
            // 
            this.ToolStripBntIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBntIzquierda.Image = global::Ejercicio2.Properties.Resources.TextLeftJustify_16x;
            this.ToolStripBntIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBntIzquierda.Name = "ToolStripBntIzquierda";
            this.ToolStripBntIzquierda.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBntIzquierda.Text = "Justificado Izquierda";
            this.ToolStripBntIzquierda.Click += new System.EventHandler(this.ToolStripBntIzquierda_Click);
            // 
            // ToolStripBtnCentro
            // 
            this.ToolStripBtnCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnCentro.Image = global::Ejercicio2.Properties.Resources.TextCenter_16x;
            this.ToolStripBtnCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnCentro.Name = "ToolStripBtnCentro";
            this.ToolStripBtnCentro.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnCentro.Text = "Justificación Centro";
            this.ToolStripBtnCentro.Click += new System.EventHandler(this.ToolStripBtnCentro_Click);
            // 
            // ToolStripBtnDerecha
            // 
            this.ToolStripBtnDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnDerecha.Image = global::Ejercicio2.Properties.Resources.TextRightJustify_16x;
            this.ToolStripBtnDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnDerecha.Name = "ToolStripBtnDerecha";
            this.ToolStripBtnDerecha.Size = new System.Drawing.Size(24, 24);
            this.ToolStripBtnDerecha.Text = "Justificado Derecha";
            this.ToolStripBtnDerecha.Click += new System.EventHandler(this.ToolStripBtnDerecha_Click);
            // 
            // toolStripNuevo
            // 
            this.toolStripNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNuevo.Image = global::Ejercicio2.Properties.Resources.NewFile_16x;
            this.toolStripNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNuevo.Name = "toolStripNuevo";
            this.toolStripNuevo.Size = new System.Drawing.Size(23, 22);
            this.toolStripNuevo.Text = "toolStripButton1";
            this.toolStripNuevo.ToolTipText = "Nuevo";
            this.toolStripNuevo.Click += new System.EventHandler(this.ToolStripNuevo_Click);
            // 
            // toolStripAbrir
            // 
            this.toolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbrir.Image = global::Ejercicio2.Properties.Resources.OpenFile_16x;
            this.toolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbrir.Name = "toolStripAbrir";
            this.toolStripAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolStripAbrir.Text = "toolStripButton2";
            this.toolStripAbrir.ToolTipText = "Abrir";
            this.toolStripAbrir.Click += new System.EventHandler(this.ToolStripAbrir_Click);
            // 
            // toolStripGuardarComo
            // 
            this.toolStripGuardarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGuardarComo.Image = global::Ejercicio2.Properties.Resources.SaveAs_16x;
            this.toolStripGuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardarComo.Name = "toolStripGuardarComo";
            this.toolStripGuardarComo.Size = new System.Drawing.Size(23, 22);
            this.toolStripGuardarComo.Text = "toolStripButton3";
            this.toolStripGuardarComo.ToolTipText = "Guardar Como...";
            this.toolStripGuardarComo.Click += new System.EventHandler(this.ToolStripGuardarComo_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.NewFile_16x;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.OpenFile_16x;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.abrirToolStripMenuItem.Text = "A&brir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.SaveAs_16x;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.guardarComoToolStripMenuItem.Text = "&Guardar Como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.Close_8x_16x;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // CopiarToolStripMenuItem
            // 
            this.CopiarToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.Copy_16x;
            this.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem";
            this.CopiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopiarToolStripMenuItem.Text = "Copiar";
            this.CopiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItem_Click);
            // 
            // CortarToolStripMenuItem
            // 
            this.CortarToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.Cut_16x;
            this.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem";
            this.CortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CortarToolStripMenuItem.Text = "Cortar";
            this.CortarToolStripMenuItem.Click += new System.EventHandler(this.CortarToolStripMenuItem_Click);
            // 
            // PegarToolStripMenuItem
            // 
            this.PegarToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.Paste_16x;
            this.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem";
            this.PegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PegarToolStripMenuItem.Text = "Pegar";
            this.PegarToolStripMenuItem.Click += new System.EventHandler(this.PegarToolStripMenuItem_Click);
            // 
            // DeshacerToolStripMenuItem
            // 
            this.DeshacerToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.Undo_grey_16x;
            this.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem";
            this.DeshacerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeshacerToolStripMenuItem.Text = "Deshacer";
            this.DeshacerToolStripMenuItem.Click += new System.EventHandler(this.DeshacerToolStripMenuItem_Click);
            // 
            // RehacerToolStripMenuItem
            // 
            this.RehacerToolStripMenuItem.Image = global::Ejercicio2.Properties.Resources.Redo_grey_16x;
            this.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem";
            this.RehacerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RehacerToolStripMenuItem.Text = "Rehacer";
            this.RehacerToolStripMenuItem.Click += new System.EventHandler(this.RehacerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 553);
            this.Controls.Add(this.toolStripEdicion);
            this.Controls.Add(this.ToolStripArchivo);
            this.Controls.Add(this.RichTxtBox);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ToolStripArchivo.ResumeLayout(false);
            this.ToolStripArchivo.PerformLayout();
            this.toolStripEdicion.ResumeLayout(false);
            this.toolStripEdicion.PerformLayout();
            this.ContextMenuEdicion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.RichTextBox RichTxtBox;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStrip ToolStripArchivo;
        private System.Windows.Forms.ToolStripButton toolStripNuevo;
        private System.Windows.Forms.ToolStripButton toolStripAbrir;
        private System.Windows.Forms.ToolStripButton toolStripGuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripSalir;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStripEdicion;
        private System.Windows.Forms.ToolStripComboBox ToolStripCmbFuente;
        private System.Windows.Forms.ToolStripComboBox ToolStripCmbTamanio;
        private System.Windows.Forms.ToolStripButton ToolStripBtnNegrita;
        private System.Windows.Forms.ToolStripButton ToolStripBtnItalica;
        private System.Windows.Forms.ToolStripButton ToolStripBtnSubrayado;
        private System.Windows.Forms.ToolStripButton ToolStripBtnColor;
        private System.Windows.Forms.ToolStripButton ToolStripBntIzquierda;
        private System.Windows.Forms.ToolStripButton ToolStripBtnCentro;
        private System.Windows.Forms.ToolStripButton ToolStripBtnDerecha;
        private System.Windows.Forms.ContextMenuStrip ContextMenuEdicion;
        private System.Windows.Forms.ToolStripMenuItem CopiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DeshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RehacerToolStripMenuItem;
    }
}

