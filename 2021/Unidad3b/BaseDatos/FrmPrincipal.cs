using BaseDatos.Bodega;
using BaseDatos.Clases;
using BaseDatos.Sucursal;
using System;
using System.Windows.Forms;

namespace BaseDatos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void TipoDeBodegasMenuItem_Click(object sender, EventArgs e)
        {
            AdminFormulario.MostrarFormulario(new FrmBodegaTipo());
        }

        private void BodegasMenuItem_Click(object sender, EventArgs e)
        {
            AdminFormulario.MostrarFormulario(new FrmBodega_Lista());
        }

        private void SucursalMenuItem_Click(object sender, EventArgs e)
        {
            AdminFormulario.MostrarFormulario(new FrmSucursal_Lista());
        }
    }
}
