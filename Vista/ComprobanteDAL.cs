using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    internal class ComprobanteDAL
    {
        public static int AgregarComprobante(Comprobante comprobante)
        {
            int retorna = 0;

            using (Conexion_db conexion_db = new Conexion_db())
            {
                using (SqlConnection conexion = conexion_db.abrir())
                {
                    string query = "INSERT INTO HLR_tblComprobante (Comprobante_ID, comNumPedido, comNumPago, comCliente, comDNI, comPlatillo, comCantidad, comPUnitario, comTipoPago, comNumero, comTotal, comFecha, comTipo) VALUES ('"+comprobante.com_ID+"', '"+comprobante.coNum+"', '"+comprobante.coPago+"', '"+comprobante.coCliente+"', '"+comprobante.coDNI+"', '"+comprobante.coPlatillo+"', '"+comprobante.coCantidad+"', '"+comprobante.coUnitario+"', '"+comprobante.coTipo+"', '"+comprobante.coNumero+"', '"+comprobante.coMonto+"', '"+comprobante.coFecha+"', '"+comprobante.coComprobante+"')";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }
    }
}
