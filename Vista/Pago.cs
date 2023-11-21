using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    internal class Pago
    {
        public string pagID { get; set; }

        public string pagDetalleMoneda { get; set; }

        public string pagNumeroCuenta { get; set; }

        public int pagMonto { get; set; }


        public Pago() { }

        public Pago(string pagID, string pagDetalleMoneda, string pagNumeroCuenta, int pagMonto)
        {
            this.pagID = pagID;
            this.pagDetalleMoneda = pagDetalleMoneda;
            this.pagNumeroCuenta = pagNumeroCuenta;
            this.pagMonto = pagMonto;
        }
    }
}
