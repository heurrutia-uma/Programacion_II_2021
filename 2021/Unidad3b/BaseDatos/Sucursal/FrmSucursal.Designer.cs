
namespace BaseDatos.Sucursal
{
    partial class FrmSucursal
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.LblMunicipio = new System.Windows.Forms.Label();
            this.TxtMunicipio = new System.Windows.Forms.TextBox();
            this.GrpSublista = new System.Windows.Forms.GroupBox();
            this.GrdLista = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GrpSublista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLista)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(12, 9);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(62, 6);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(12, 44);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 2;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(62, 41);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(150, 20);
            this.TxtTelefono.TabIndex = 3;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(257, 9);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 4;
            this.LblDireccion.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(315, 6);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(403, 20);
            this.TxtDireccion.TabIndex = 5;
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Location = new System.Drawing.Point(257, 44);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(40, 13);
            this.LblCiudad.TabIndex = 6;
            this.LblCiudad.Text = "Ciudad";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(315, 41);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(150, 20);
            this.TxtCiudad.TabIndex = 7;
            // 
            // LblMunicipio
            // 
            this.LblMunicipio.AutoSize = true;
            this.LblMunicipio.Location = new System.Drawing.Point(510, 44);
            this.LblMunicipio.Name = "LblMunicipio";
            this.LblMunicipio.Size = new System.Drawing.Size(52, 13);
            this.LblMunicipio.TabIndex = 8;
            this.LblMunicipio.Text = "Municipio";
            // 
            // TxtMunicipio
            // 
            this.TxtMunicipio.Location = new System.Drawing.Point(568, 41);
            this.TxtMunicipio.Name = "TxtMunicipio";
            this.TxtMunicipio.Size = new System.Drawing.Size(150, 20);
            this.TxtMunicipio.TabIndex = 9;
            // 
            // GrpSublista
            // 
            this.GrpSublista.Controls.Add(this.GrdLista);
            this.GrpSublista.Controls.Add(this.BtnEliminar);
            this.GrpSublista.Controls.Add(this.BtnEditar);
            this.GrpSublista.Controls.Add(this.BtnAgregar);
            this.GrpSublista.Location = new System.Drawing.Point(12, 81);
            this.GrpSublista.Name = "GrpSublista";
            this.GrpSublista.Size = new System.Drawing.Size(706, 328);
            this.GrpSublista.TabIndex = 10;
            this.GrpSublista.TabStop = false;
            this.GrpSublista.Text = "Bodegas";
            // 
            // GrdLista
            // 
            this.GrdLista.AllowUserToAddRows = false;
            this.GrdLista.AllowUserToDeleteRows = false;
            this.GrdLista.AllowUserToResizeRows = false;
            this.GrdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdLista.Location = new System.Drawing.Point(6, 48);
            this.GrdLista.MultiSelect = false;
            this.GrdLista.Name = "GrdLista";
            this.GrdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdLista.Size = new System.Drawing.Size(694, 274);
            this.GrdLista.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(168, 19);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(87, 19);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(6, 19);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(643, 415);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(562, 415);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GrpSublista);
            this.Controls.Add(this.TxtMunicipio);
            this.Controls.Add(this.LblMunicipio);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSucursal";
            this.Text = "Sucursal";
            this.Activated += new System.EventHandler(this.FrmSucursal_Activated);
            this.Load += new System.EventHandler(this.FrmSucursal_Load);
            this.GrpSublista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.Label LblMunicipio;
        private System.Windows.Forms.TextBox TxtMunicipio;
        private System.Windows.Forms.GroupBox GrpSublista;
        private System.Windows.Forms.DataGridView GrdLista;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}