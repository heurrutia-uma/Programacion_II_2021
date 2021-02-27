
namespace Ejercicio1
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
            this.LstViewDatos = new System.Windows.Forms.ListView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSeleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstViewDatos
            // 
            this.LstViewDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstViewDatos.FullRowSelect = true;
            this.LstViewDatos.HideSelection = false;
            this.LstViewDatos.Location = new System.Drawing.Point(12, 12);
            this.LstViewDatos.MultiSelect = false;
            this.LstViewDatos.Name = "LstViewDatos";
            this.LstViewDatos.Size = new System.Drawing.Size(723, 561);
            this.LstViewDatos.TabIndex = 0;
            this.LstViewDatos.UseCompatibleStateImageBehavior = false;
            this.LstViewDatos.View = System.Windows.Forms.View.Details;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(579, 579);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSeleccion
            // 
            this.BtnSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccion.Location = new System.Drawing.Point(660, 579);
            this.BtnSeleccion.Name = "BtnSeleccion";
            this.BtnSeleccion.Size = new System.Drawing.Size(75, 23);
            this.BtnSeleccion.TabIndex = 2;
            this.BtnSeleccion.Text = "Seleccion";
            this.BtnSeleccion.UseVisualStyleBackColor = true;
            this.BtnSeleccion.Click += new System.EventHandler(this.BtnSeleccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 614);
            this.Controls.Add(this.BtnSeleccion);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LstViewDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstViewDatos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSeleccion;
    }
}

