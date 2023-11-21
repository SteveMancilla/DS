using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    internal class PedidoDAL
    {
        public static int AgregarPedido(Pedido pedido)
        {
            int retorna = 0;

            using (Conexion_db conexion_db = new Conexion_db())
            {
                using (SqlConnection conexion = conexion_db.abrir())
                {
                    string query = "INSERT INTO HLR_tblPedido (Pedido_ID, pedNomCliente, pedCliDNI, pedFecha, pedPlatillo, pedCantidad, pedMonto) VALUES ('"+pedido.pedID+"', '"+pedido.pedNombre+ "', '"+pedido.pedDNI+"', '" + pedido.pedFecha+"', '"+pedido.pedPlatillo+ "', "+pedido.pedCantidad+ ", "+pedido.pedMonto+")";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    retorna = comando.ExecuteNonQuery();
                }
            }

            return retorna;
        }
    }
}
