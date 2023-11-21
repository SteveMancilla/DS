using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class PagoDAL
    {
        public static int AgregarPago(Pago pago)
        {
            int retorna = 0;

            using (Conexion_db conexion_db = new Conexion_db())
            {
                using (SqlConnection conexion = conexion_db.abrir())
                {
                    string query = "INSERT INTO HLR_tblPago (Pago_ID, pagTipo, pagNumero, pagMonto) VALUES ('" + pago.pagID + "', '" + pago.pagDetalleMoneda + "', '" + pago.pagNumeroCuenta + "', " + pago.pagMonto + ")";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }
    }
}
