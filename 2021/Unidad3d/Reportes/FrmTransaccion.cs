using Reportes.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Reportes
{
    public partial class FrmTransaccion : Form
    {
        private AdminBD _adminBD = null;

        public FrmTransaccion()
        {
            InitializeComponent();

            _adminBD = new AdminBD();
        }

        private void FrmTransaccion_Load(object sender, EventArgs e)
        {
            string comandoSql = "SELECT Transaccion.Id, Cliente.Id AS ClienteId, Transaccion.Tipo, Transaccion.Transaccion AS Documento, " +
                "Transaccion.Fecha, Cliente.Nombre AS Cliente, Cliente.Tipo AS TipoCliente, Transaccion.Estado, Sucursal.Nombre AS Sucursal " +
                "FROM Cliente " +
                "INNER JOIN Transaccion ON Cliente.Id = Transaccion.Cliente " +
                "INNER JOIN Sucursal ON Transaccion.Sucursal = Sucursal.ID";

            string buscar = TxtBuscar.Text.Trim();

            if (!String.IsNullOrEmpty(buscar))
                comandoSql += $" WHERE Transaccion.Transaccion Like '{buscar}%' " +
                    $"OR Cliente.Nombre Like '{buscar}%' " +
                    $"OR Transaccion.Estado Like '{buscar}%' " +
                    $"OR Sucursal.Nombre Like '{buscar}%'";

            _adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)_adminBD.EjecutarComando(comandoSql);

            if (lector != null)
            {
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                GrdLista.DataSource = tabla;

                GrdLista.Columns[0].Visible = false;
                GrdLista.Columns[1].Visible = false;

                lector.Close();
            }

            _adminBD.CerrarConexion();
        }

        private void FrmTransaccion_Activated(object sender, EventArgs e)
        {
            FrmTransaccion_Load(sender, e);
        }

        private void SplitBtnImprimir_ButtonClick(object sender, EventArgs e)
        {

        }

        private void ImprimirCliente_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdLista.CurrentRow.Cells["ClienteId"].Value);

            AdminFormulario.MostrarFormulario(new FrmRepCliente(id));
        }

        private void ImprimirOrdenVenta_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdLista.CurrentRow.Cells["Id"].Value);

            AdminFormulario.MostrarFormulario(new FrmRepTransaccion(id));
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // if (TxtBuscar.Text.Trim().Length > 3)
                FrmTransaccion_Load(sender, e);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImprimirListaPrecios_Click(object sender, EventArgs e)
        {
            AdminFormulario.MostrarFormulario(new FrmRepArticulo());
        }
    }
}
