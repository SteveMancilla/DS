using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    internal class Comprobante
    {
        public string com_ID { get; set; }

        public string coNum { get; set; }

        public string coPago { get; set; }

        public string coCliente { get; set; }

        public string coDNI { get; set; }

        public string coPlatillo { get; set; }

        public string coCantidad { get; set; }

        public string coUnitario { get; set; }

        public string coTipo { get; set; }

        public string coNumero { get; set; }

        public string coMonto { get; set; }

        public string coFecha { get; set; }

        public string coComprobante { get; set; }

        public Comprobante() { }

        public Comprobante(string com_ID, string coNum, string coPago, string coCliente, string coDNI, string coPlatillo, string coCantidad, string coUnitario, string coTipo, string coNumero, string coMonto, string coFecha, string coComprobante)
        {
            this.com_ID = com_ID;
            this.coNum = coNum;
            this.coPago = coPago;
            this.coCliente = coCliente;
            this.coDNI = coDNI;
            this.coPlatillo = coPlatillo;
            this.coCantidad = coCantidad;
            this.coUnitario = coUnitario;
            this.coTipo = coTipo;
            this.coNumero = coNumero;
            this.coMonto = coMonto;
            this.coFecha = coFecha;
            this.coComprobante = coComprobante;
        }
    }
}
