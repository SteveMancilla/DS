using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelos
{
    public class Conexion_db : IDisposable
    {
        private string cadena = "Data Source=.;Initial Catalog=dbRestauranteTalita;User ID=sa;Password=continental";
        
        private SqlConnection conectardb = null;

        public Conexion_db()
        {
            conectardb = new SqlConnection(cadena);
        }

        public SqlConnection abrir()
        {
            try
            {
                conectardb.Open();
                Console.WriteLine("Conexion abierta");
                return conectardb;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos " + ex.Message);
                return null;
            }
        }

        public void cerrar()
        {
            if (conectardb != null)
            {
                conectardb.Close();
                Console.WriteLine("Conexion cerrada");
            }
        }

        public void Dispose()
        {
            cerrar(); // Cierra la conexión al liberar recursos
        }
    }
}
