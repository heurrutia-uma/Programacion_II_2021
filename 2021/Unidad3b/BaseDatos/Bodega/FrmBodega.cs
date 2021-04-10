using BaseDatos.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDatos.Bodega
{
    public partial class FrmBodega : Form
    {
        private Int64 _id = -1;
        private AdminBD _adminBD = null;
        private Boolean _sublista = false;

        public FrmBodega(Int64 id = -1, Boolean sublista = false)
        {
            InitializeComponent();

            _id = id;
            _adminBD = new AdminBD();
            _sublista = sublista;

            ObtenerSucursal();
            ObtenerBodegaTipo();

            if (_id != -1 && _sublista == true)
            {
                CmbSucursal.Enabled = false;
                CmbSucursal.SelectedValue = _id;
            }
            else if (_id != -1 && _sublista == false)
            {
                CmbSucursal.Enabled = false;
                CmbSucursal.SelectedValue = _id;
            }
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            if (_id != -1 && _sublista == false)
            {
                string comandoSQL = $"SELECT * FROM Bodega WHERE Id={_id}";

                _adminBD.AbrirConexion();

                SqlDataReader lector = (SqlDataReader)_adminBD.EjecutarComando(comandoSQL);

                if (lector != null)
                {
                    lector.Read();
                    IDataRecord registro = (IDataRecord)lector;

                    CmbSucursal.SelectedValue = registro[1];
                    CmbTipo.SelectedValue = registro[2];
                    TxtNombre.Text = registro[3].ToString();

                    lector.Close();
                }

                _adminBD.CerrarConexion();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Int64 sucursalId = -1;
            Int64 tipoId = -1;
            string nombre = TxtNombre.Text.Trim();

            var controlSucursal = CmbSucursal.SelectedValue;
            var controlTipo = CmbTipo.SelectedValue;

            if (controlSucursal != null)
            {
                if (controlSucursal.GetType().Equals(typeof(long)))
                    sucursalId = Convert.ToInt64(controlSucursal);
            }

            if (controlTipo != null)
            {
                if (controlTipo.GetType().Equals(typeof(long)))
                    tipoId = Convert.ToInt64(controlTipo);
            }

            if (sucursalId > -1 && tipoId > -1 && !String.IsNullOrEmpty(nombre))
            {
                _adminBD.AbrirConexion();

                if (_id == -1 && _sublista == false)
                {
                    string comandoSQL = $"INSERT INTO Bodega (Sucursal, Tipo, Nombre) " +
                        $"VALUES({sucursalId}, {tipoId}, '{nombre}')";

                    int resultado = (int)_adminBD.EjecutarComando(comandoSQL);
                }
                else if(_id != -1 && _sublista == true)
                {
                    string comandoSQL = $"INSERT INTO Bodega (Sucursal, Tipo, Nombre) " +
                        $"VALUES({_id}, {tipoId}, '{nombre}')";

                    int resultado = (int)_adminBD.EjecutarComando(comandoSQL);
                }
                else
                {
                    string comandoSQL = $"UPDATE Bodega " +
                        $"SET Sucursal={sucursalId}, Tipo={tipoId}, Nombre='{nombre}' " +
                        $"WHERE ID={_id}";

                    int resultado = (int)_adminBD.EjecutarComando(comandoSQL);
                }

                _adminBD.CerrarConexion();
            }

            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObtenerSucursal()
        { 
            DataTable tabla = UMABD.ObtenerSucursal();

            if (tabla != null)
            {
                CmbSucursal.DataSource = tabla;
                CmbSucursal.ValueMember = "Id";
                CmbSucursal.DisplayMember = "Nombre";
                CmbSucursal.SelectedIndex = -1;
            }
        }

        private void ObtenerBodegaTipo()
        {
            DataTable tabla = UMABD.ObtenerBodegaTipo();

            if (tabla != null)
            {
                CmbTipo.DataSource = tabla;
                CmbTipo.ValueMember = "Id";
                CmbTipo.DisplayMember = "Nombre";
                CmbTipo.SelectedIndex = -1;
            }
        }
    }
}
