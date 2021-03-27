using BaseDatos.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDatos.Bodega
{
    public partial class FrmBodegaTipo_Edicion : Form
    {
        private Int64 _id;
        private AdminBD _admBD = null;

        public FrmBodegaTipo_Edicion(Int64 id = -1)
        {
            InitializeComponent();

            _id = id;
            _admBD = new AdminBD(@"R90NKLWW\SQLEXPRESS", "UMA2021");
        }

        private void FrmBodegaTipo_Edicion_Load(object sender, EventArgs e)
        {
            if (_id != -1)
            {
                string comandoSql = $"SELECT Nombre FROM BodegaTipo WHERE Id={_id}";

                _admBD.AbrirConexion();

                SqlDataReader lector = (SqlDataReader)_admBD.EjecutarComando(comandoSql);

                if (lector != null)
                {
                    lector.Read();
                    TxtNombre.Text = lector[0].ToString();
                }

                _admBD.CerrarConexion();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtNombre.Text))
            {
                _admBD.AbrirConexion();
                if (_id == -1)
                {
                    // Insert
                    string comandoSql = $"INSERT INTO BodegaTipo (Nombre) VALUES ('{TxtNombre.Text}')";
                    int resultado = (int)_admBD.EjecutarComando(comandoSql);
                }
                else
                {
                    // Update
                    string comandoSql = $"UPDATE BodegaTipo SET Nombre='{TxtNombre.Text}' WHERE Id={_id}";
                    int resultado = (int)_admBD.EjecutarComando(comandoSql);
                }
                _admBD.CerrarConexion();
            }
            this.Close();
        }
    }
}
