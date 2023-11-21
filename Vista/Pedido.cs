using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    internal class Pedido
    {
        public string pedID { get; set; }

        public string pedNombre { get; set; }

        public string pedDNI { get; set; }

        public string pedFecha { get; set; }

        public string pedPlatillo { get; set; }

        public int pedCantidad { get; set; }

        public int pedMonto { get; set; }

        public Pedido() { }

        public Pedido(string pedID, string pedNombre, string pedDNI, string pedFecha, string pedPlatillo, int pedCantidad, int pedMonto)
        {
            this.pedID = pedID;
            this.pedNombre = pedNombre;
            this.pedDNI = pedDNI; 
            this.pedFecha = pedFecha;
            this.pedPlatillo = pedPlatillo;
            this.pedCantidad = pedCantidad;
            this.pedMonto = pedMonto;
        }
    }
}
