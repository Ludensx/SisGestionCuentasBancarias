using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Controlador
{
    public class Datos
    {
        string cadenaConexion = "Data Source=localhost/orcl;User ID=BD2;Password=12345";
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            miConexion.Open();
            filasAfectadas = comando.ExecuteNonQuery();
            miConexion.Close();
            return filasAfectadas;
        }

        public DataSet ejecutarSELECT(string consulta)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}