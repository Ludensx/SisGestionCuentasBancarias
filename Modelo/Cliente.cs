using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        public Cliente() { }

        public int agregarCliente(string [] prms) {
            return 1;
        }
        public DataSet consultarDiezClientesMasAntiguos()
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "SELECT * FROM CLIENTE ORDER BY CLIENTE_FECHANACIMIENTO FETCH FIRST 10 ROWS ONLY";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }

    }
}
