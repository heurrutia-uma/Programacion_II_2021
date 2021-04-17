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
    public partial class FrmRepArticulo : Form
    {
        public FrmRepArticulo()
        {
            InitializeComponent();
        }

        private void FrmRepArticulo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UMA2021DataSet.Articulo' table. You can move, or remove it, as needed.
            this.ArticuloTableAdapter.Fill(this.UMA2021DataSet.Articulo);

            this.reportViewer1.RefreshReport();
        }
    }
}
