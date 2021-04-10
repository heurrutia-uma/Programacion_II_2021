using BaseDatos.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDatos.Bodega
{
    public partial class FrmBodega_Lista : Form
    {
        private AdminBD _adminBD = null;

        public FrmBodega_Lista()
        {
            InitializeComponent();

            _adminBD = new AdminBD();
        }

        private void FrmBodega_Lista_Load(object sender, EventArgs e)
        {
            string comandoSQL = "SELECT B.ID, S.Nombre AS Sucursal, BT.Nombre AS Tipo, B.Nombre " +
                "FROM Bodega B " +
                "INNER JOIN Sucursal S ON B.Sucursal = S.ID " +
                "INNER JOIN BodegaTipo BT ON B.Tipo = BT.ID";

            if (!String.IsNullOrEmpty(TxtFiltro.Text))
            {
                comandoSQL += $" WHERE B.Nombre Like '{TxtFiltro.Text.Trim()}%'";
            }

            _adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)_adminBD.EjecutarComando(comandoSQL);

            if (lector != null)
            {
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                GrdLista.DataSource = tabla;

                lector.Close();
            }

            _adminBD.CerrarConexion();
        }

        private void FrmBodega_Lista_Activated(object sender, EventArgs e)
        {
            FrmBodega_Lista_Load(sender, e);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AdminFormulario.MostrarFormulario(new FrmBodega());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdLista.CurrentRow.Cells["Id"].Value);

            AdminFormulario.MostrarFormulario(new FrmBodega(id, false));
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdLista.CurrentRow.Cells["Id"].Value);

            if (id > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string comandoSql = $"DELETE FROM Bodega WHERE Id={id}";

                    _adminBD.AbrirConexion();

                    int resultado = (int)_adminBD.EjecutarComando(comandoSql);

                    _adminBD.CerrarConexion();

                    FrmBodega_Lista_Load(sender, e);
                }
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            FrmBodega_Lista_Load(sender, e);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
