using BaseDatos.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDatos.Bodega
{
    public partial class FrmBodegaTipo : Form
    {
        public FrmBodegaTipo()
        {
            InitializeComponent();
        }

        private void FrmBodegaTipo_Load(object sender, EventArgs e)
        {
            AdminBD admBD = new AdminBD();

            string comandoSql = "SELECT * FROM BodegaTipo";

            admBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)admBD.EjecutarComando(comandoSql);

            if (lector != null)
            {
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                GrdListaBodega.DataSource = tabla;
            }

            admBD.CerrarConexion();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmBodegaTipo_Edicion frmEdicion = new FrmBodegaTipo_Edicion();
            frmEdicion.ShowDialog();

            FrmBodegaTipo_Load(sender, e);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdListaBodega.CurrentRow.Cells["Id"].Value);

            FrmBodegaTipo_Edicion frmEdicion = new FrmBodegaTipo_Edicion(id);
            frmEdicion.ShowDialog();

            FrmBodegaTipo_Load(sender, e);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdListaBodega.CurrentRow.Cells["Id"].Value);

            if (id > 0)
            {
                if (MessageBox.Show("¿Está seguro de qué eliminar el registro seleccionado?", "Tipo de Bodega", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AdminBD admBD = new AdminBD();
                    string comandoSql = $"DELETE FROM BodegaTipo WHERE Id={id}";

                    admBD.AbrirConexion();
                    int resultado = (int)admBD.EjecutarComando(comandoSql);
                    admBD.CerrarConexion();

                    FrmBodegaTipo_Load(sender, e);
                }
            }
        }
    }
}
