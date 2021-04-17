
namespace Reportes
{
    partial class FrmRepTransaccion
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
            this.TransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransaccionTableAdapter = new Reportes.UMA2021DataSetTableAdapters.TransaccionTableAdapter();
            this.TransaccionDetalleTableAdapter = new Reportes.UMA2021DataSetTableAdapters.TransaccionDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UMA2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransaccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TransaccionDS";
            reportDataSource1.Value = this.TransaccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.RepTransaccion.rdlc";
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
            // TransaccionBindingSource
            // 
            this.TransaccionBindingSource.DataMember = "Transaccion";
            this.TransaccionBindingSource.DataSource = this.UMA2021DataSet;
            // 
            // TransaccionTableAdapter
            // 
            this.TransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // TransaccionDetalleTableAdapter
            // 
            this.TransaccionDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa";
            this.Load += new System.EventHandler(this.FrmRepTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UMA2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransaccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransaccionBindingSource;
        private UMA2021DataSet UMA2021DataSet;
        private UMA2021DataSetTableAdapters.TransaccionTableAdapter TransaccionTableAdapter;
        private UMA2021DataSetTableAdapters.TransaccionDetalleTableAdapter TransaccionDetalleTableAdapter;
    }
}