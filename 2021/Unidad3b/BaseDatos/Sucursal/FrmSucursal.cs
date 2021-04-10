using BaseDatos.Bodega;
using BaseDatos.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDatos.Sucursal
{
    public partial class FrmSucursal : Form
    {
        private Int64 _id = -1;
        private AdminBD _adminBD = null;

        public FrmSucursal(Int64 id = -1)
        {
            InitializeComponent();

            _id = id;
            _adminBD = new AdminBD();

            if (_id == -1)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            if (_id != -1)
            {
                string comandoSQL = $"SELECT * FROM Sucursal WHERE ID={_id}";

                _adminBD.AbrirConexion();

                SqlDataReader lector = (SqlDataReader)_adminBD.EjecutarComando(comandoSQL);

                if (lector != null)
                {
                    lector.Read();

                    IDataRecord registro = (IDataRecord)lector;

                    TxtNombre.Text = registro[1].ToString();
                    TxtDireccion.Text = registro[2].ToString();
                    TxtCiudad.Text = registro[3].ToString();
                    TxtMunicipio.Text = registro[4].ToString();
                    TxtTelefono.Text = registro[5].ToString();

                    lector.Close();
                }

                _adminBD.CerrarConexion();

                ObtenerBodega();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (_id == -1 && !String.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                _adminBD.AbrirConexion();

                string comandoSQL = $"INSERT INTO Sucursal (Nombre, Direccion, Ciudad, Municipo, Telefono) " +
                        $"VALUES ('{TxtNombre.Text}','{TxtDireccion.Text}','{TxtCiudad.Text}'," +
                        $"'{TxtMunicipio.Text}','{TxtTelefono.Text}')";

                int resultado = (int)_adminBD.EjecutarComando(comandoSQL);

                comandoSQL = $"SELECT IDENT_CURRENT('Sucursal') AS NuevoId";

                SqlDataReader lector = (SqlDataReader)_adminBD.EjecutarComando(comandoSQL);

                if (lector != null)
                {
                    lector.Read();

                    var nuevoId = lector[0];

                    _id = Convert.ToInt64(nuevoId);

                    lector.Close();
                }

                _adminBD.CerrarConexion();
            }

            AdminFormulario.MostrarFormulario(new FrmBodega(_id, true));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(GrdLista.CurrentRow.Cells["Id"].Value);

            AdminFormulario.MostrarFormulario(new FrmBodega(id));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
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

                    ObtenerBodega();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                _adminBD.AbrirConexion();

                string comandoSQL = "";

                if (_id == -1)
                {
                    comandoSQL = $"INSERT INTO Sucursal (Nombre, Direccion, Ciudad, Municipo, Telefono) " +
                        $"VALUES ('{TxtNombre.Text}','{TxtDireccion.Text}','{TxtCiudad.Text}'," +
                        $"'{TxtMunicipio.Text}','{TxtTelefono.Text}')";

                    int resultado = (int)_adminBD.EjecutarComando(comandoSQL);
                }
                else
                {
                    comandoSQL = $"UPDATE Sucursal " +
                        $"SET Nombre='{TxtNombre.Text}', Direccion='{TxtDireccion.Text}', " +
                        $"Ciudad='{TxtCiudad.Text}', Municipo='{TxtMunicipio.Text}', " +
                        $"Telefono='{TxtTelefono.Text}' " +
                        $"WHERE Id={_id}";

                    int resultado = (int)_adminBD.EjecutarComando(comandoSQL);
                }

                _adminBD.CerrarConexion();

                this.Close();
            }
            else
            {
                MessageBox.Show("Campo Nombre es mandatorio.");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerBodega()
        {
            string comandoSQL = "SELECT B.ID, S.Nombre AS Sucursal, BT.Nombre AS Tipo, B.Nombre " +
                "FROM Bodega B " +
                "INNER JOIN Sucursal S ON B.Sucursal = S.ID " +
                "INNER JOIN BodegaTipo BT ON B.Tipo = BT.ID " +
                $"WHERE B.Sucursal = {_id}";

            _adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)_adminBD.EjecutarComando(comandoSQL);

            if (lector != null)
            {
                if (lector.HasRows)
                {
                    DataTable tabla = new DataTable();

                    tabla.Load(lector);

                    GrdLista.DataSource = tabla;

                    BtnEditar.Enabled = true;
                    BtnEliminar.Enabled = true;

                    lector.Close();
                }
            }

            _adminBD.CerrarConexion();
        }

        private void FrmSucursal_Activated(object sender, EventArgs e)
        {
            ObtenerBodega();
        }
    }
}
