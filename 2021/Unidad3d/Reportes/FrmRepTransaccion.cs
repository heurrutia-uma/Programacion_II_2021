using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class FrmRepTransaccion : Form
    {
        private Int64 _id;

        public FrmRepTransaccion(Int64 id = -1)
        {
            InitializeComponent();

            _id = id;
        }

        private void FrmRepTransaccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UMA2021DataSet.Transaccion' table. You can move, or remove it, as needed.
            this.TransaccionTableAdapter.Fill(this.UMA2021DataSet.Transaccion, _id);

            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            this.reportViewer1.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("TransaccionDetalleDS", (object)this.TransaccionDetalleTableAdapter.GetData(_id));

            e.DataSources.Add(reportDataSource);
        }
    }
}
