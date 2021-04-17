using Microsoft.Reporting.WinForms;
using Reportes.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Reportes
{
    public partial class FrmRepCliente : Form
    {
        private Int64 _id = -1;

        public FrmRepCliente(Int64 id = -1)
        {
            InitializeComponent();

            _id = id;
        }

        private void FrmRepCliente_Load(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("ClienteDS", ObtenerCliente());

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private List<Cliente> ObtenerCliente()
        {
            List<Cliente> cliente = new List<Cliente>();

            string comandoSql = $"Select * FROM Cliente WHERE Id={_id}";

            AdminBD adminBD = new AdminBD();

            adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)adminBD.EjecutarComando(comandoSql);

            if (lector != null)
            {
                while (lector.Read())
                { 
                    IDataReader registro = (IDataReader)lector;

                    cliente.Add(new Cliente
                    {
                        Id = Convert.ToInt64(registro[0]),
                        Nombre = registro[1].ToString(),
                        Tipo = registro[2].ToString(),
                        Email = registro[3].ToString(),
                        Telefono = registro[4].ToString(),
                        Direccion = registro[5].ToString(),
                        Ciudad = registro[6].ToString(),
                        Municipio = registro[7].ToString()
                    });
                }

                lector.Close();
            }

            adminBD.CerrarConexion();

            return cliente;
        }
    }
}
