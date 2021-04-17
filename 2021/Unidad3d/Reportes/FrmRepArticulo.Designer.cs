
namespace Reportes
{
    partial class FrmRepArticulo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UMA2021DataSet = new Reportes.UMA2021DataSet();
            this.ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArticuloTableAdapter = new Reportes.UMA2021DataSetTableAdapters.ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UMA2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ArticuloDS";
            reportDataSource1.Value = this.ArticuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.RepArticulo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // UMA2021DataSet
            // 
            this.UMA2021DataSet.DataSetName = "UMA2021DataSet";
            this.UMA2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArticuloBindingSource
            // 
            this.ArticuloBindingSource.DataMember = "Articulo";
            this.ArticuloBindingSource.DataSource = this.UMA2021DataSet;
            // 
            // ArticuloTableAdapter
            // 
            this.ArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa";
            this.Load += new System.EventHandler(this.FrmRepArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UMA2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArticuloBindingSource;
        private UMA2021DataSet UMA2021DataSet;
        private UMA2021DataSetTableAdapters.ArticuloTableAdapter ArticuloTableAdapter;
    }
}