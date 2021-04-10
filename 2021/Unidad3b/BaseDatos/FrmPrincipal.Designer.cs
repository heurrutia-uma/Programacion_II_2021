
namespace BaseDatos
{
    partial class FrmPrincipal
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ListasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticulosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaccionesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenDeVentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SucursalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoDeBodegasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BodegasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListasMenuItem,
            this.TransaccionesMenuItem,
            this.configuracionesToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "MenuPrincipal";
            // 
            // ListasMenuItem
            // 
            this.ListasMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticulosMenuItem,
            this.ClientesMenuItem});
            this.ListasMenuItem.Name = "ListasMenuItem";
            this.ListasMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ListasMenuItem.Text = "Listas";
            // 
            // ArticulosMenuItem
            // 
            this.ArticulosMenuItem.Name = "ArticulosMenuItem";
            this.ArticulosMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ArticulosMenuItem.Text = "Artículos";
            // 
            // ClientesMenuItem
            // 
            this.ClientesMenuItem.Name = "ClientesMenuItem";
            this.ClientesMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ClientesMenuItem.Text = "Clientes";
            // 
            // TransaccionesMenuItem
            // 
            this.TransaccionesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenDeVentasMenuItem});
            this.TransaccionesMenuItem.Name = "TransaccionesMenuItem";
            this.TransaccionesMenuItem.Size = new System.Drawing.Size(92, 20);
            this.TransaccionesMenuItem.Text = "Transacciones";
            // 
            // OrdenDeVentasMenuItem
            // 
            this.OrdenDeVentasMenuItem.Name = "OrdenDeVentasMenuItem";
            this.OrdenDeVentasMenuItem.Size = new System.Drawing.Size(160, 22);
            this.OrdenDeVentasMenuItem.Text = "Orden de Ventas";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SucursalMenuItem,
            this.bodegaToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // SucursalMenuItem
            // 
            this.SucursalMenuItem.Name = "SucursalMenuItem";
            this.SucursalMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SucursalMenuItem.Text = "Sucursal";
            this.SucursalMenuItem.Click += new System.EventHandler(this.SucursalMenuItem_Click);
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoDeBodegasMenuItem,
            this.BodegasMenuItem});
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            // 
            // TipoDeBodegasMenuItem
            // 
            this.TipoDeBodegasMenuItem.Name = "TipoDeBodegasMenuItem";
            this.TipoDeBodegasMenuItem.Size = new System.Drawing.Size(161, 22);
            this.TipoDeBodegasMenuItem.Text = "Tipo de Bodegas";
            this.TipoDeBodegasMenuItem.Click += new System.EventHandler(this.TipoDeBodegasMenuItem_Click);
            // 
            // BodegasMenuItem
            // 
            this.BodegasMenuItem.Name = "BodegasMenuItem";
            this.BodegasMenuItem.Size = new System.Drawing.Size(161, 22);
            this.BodegasMenuItem.Text = "Bodegas";
            this.BodegasMenuItem.Click += new System.EventHandler(this.BodegasMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Programación II - UMA 2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SucursalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipoDeBodegasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BodegasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArticulosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransaccionesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenDeVentasMenuItem;
    }
}

