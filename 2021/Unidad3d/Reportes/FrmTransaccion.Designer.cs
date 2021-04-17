
namespace Reportes
{
    partial class FrmTransaccion
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
            this.GrdLista = new System.Windows.Forms.DataGridView();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.SplitBtnImprimir = new System.Windows.Forms.ToolStripSplitButton();
            this.ImprimirCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirOrdenVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ImprimirListaPrecios = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLista)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdLista
            // 
            this.GrdLista.AllowUserToAddRows = false;
            this.GrdLista.AllowUserToDeleteRows = false;
            this.GrdLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdLista.Location = new System.Drawing.Point(12, 28);
            this.GrdLista.MultiSelect = false;
            this.GrdLista.Name = "GrdLista";
            this.GrdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdLista.Size = new System.Drawing.Size(860, 392);
            this.GrdLista.TabIndex = 33;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SplitBtnImprimir,
            this.ToolStripSeparator1,
            this.LblBuscar,
            this.TxtBuscar});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(884, 25);
            this.ToolStrip.TabIndex = 34;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // SplitBtnImprimir
            // 
            this.SplitBtnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SplitBtnImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImprimirCliente,
            this.ImprimirOrdenVenta,
            this.ImprimirListaPrecios});
            this.SplitBtnImprimir.Image = global::Reportes.Properties.Resources.Print_16x;
            this.SplitBtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SplitBtnImprimir.Name = "SplitBtnImprimir";
            this.SplitBtnImprimir.Size = new System.Drawing.Size(32, 22);
            this.SplitBtnImprimir.Text = "Imprimir";
            this.SplitBtnImprimir.ButtonClick += new System.EventHandler(this.SplitBtnImprimir_ButtonClick);
            // 
            // ImprimirCliente
            // 
            this.ImprimirCliente.Name = "ImprimirCliente";
            this.ImprimirCliente.Size = new System.Drawing.Size(180, 22);
            this.ImprimirCliente.Text = "Cliente";
            this.ImprimirCliente.Click += new System.EventHandler(this.ImprimirCliente_Click);
            // 
            // ImprimirOrdenVenta
            // 
            this.ImprimirOrdenVenta.Name = "ImprimirOrdenVenta";
            this.ImprimirOrdenVenta.Size = new System.Drawing.Size(180, 22);
            this.ImprimirOrdenVenta.Text = "Orden de Venta";
            this.ImprimirOrdenVenta.Click += new System.EventHandler(this.ImprimirOrdenVenta_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(44, 22);
            this.LblBuscar.Text = "Burcar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(200, 25);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Image = global::Reportes.Properties.Resources.Close_red_16x;
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(807, 426);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(65, 23);
            this.BtnCerrar.TabIndex = 32;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ImprimirListaPrecios
            // 
            this.ImprimirListaPrecios.Name = "ImprimirListaPrecios";
            this.ImprimirListaPrecios.Size = new System.Drawing.Size(180, 22);
            this.ImprimirListaPrecios.Text = "Lista de Precios";
            this.ImprimirListaPrecios.Click += new System.EventHandler(this.ImprimirListaPrecios_Click);
            // 
            // FrmTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.GrdLista);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FrmTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Transacciones";
            this.Activated += new System.EventHandler(this.FrmTransaccion_Activated);
            this.Load += new System.EventHandler(this.FrmTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdLista)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdLista;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripLabel LblBuscar;
        private System.Windows.Forms.ToolStripTextBox TxtBuscar;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton SplitBtnImprimir;
        private System.Windows.Forms.ToolStripMenuItem ImprimirCliente;
        private System.Windows.Forms.ToolStripMenuItem ImprimirOrdenVenta;
        private System.Windows.Forms.ToolStripMenuItem ImprimirListaPrecios;
    }
}

