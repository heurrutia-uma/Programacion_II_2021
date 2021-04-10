using System;
using System.Data;
using System.Data.SqlClient;

namespace BaseDatos.Clases
{
    public class UMABD
    {
        private static DataTable ObtenerDataTable(string _comandoSQL)
        {
            DataTable tabla = null;

            AdminBD adminBD = new AdminBD();
            adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)adminBD.EjecutarComando(_comandoSQL);

            if (lector != null)
            {
                tabla = new DataTable();

                tabla.Load(lector);

                lector.Close();
            }

            adminBD.CerrarConexion();

            return tabla;
        }

        public static DataTable ObtenerSucursal(Int64 _id = -1)
        {
            string comandoSql = "SELECT Id, Nombre FROM Sucursal";

            if (_id != -1)
                comandoSql += $" WHERE Id={_id}";

            return UMABD.ObtenerDataTable(comandoSql);
        }

        public static DataTable ObtenerBodegaTipo(Int64 _id = -1)
        {
            string comandoSql = "SELECT Id, Nombre FROM BodegaTipo";

            if (_id != -1)
                comandoSql += $" WHERE Id={_id}";

            return UMABD.ObtenerDataTable(comandoSql);
        }

        public static DataTable ObtenerBodega(Int64 _id = -1, Int64 _sucursalId = -1)
        {
            string comandoSql = "SELECT Id, Nombre FROM Bodega";

            if (_id != -1)
                comandoSql += $" WHERE Id={_id}";

            if (_sucursalId != -1)
            {
                if (comandoSql.Contains("WHERE"))
                    comandoSql += $" AND Sucursal={_sucursalId}";
                else
                    comandoSql += $" WHERE Sucursal={_sucursalId}";
            }

            return UMABD.ObtenerDataTable(comandoSql);
        }
    }
}
