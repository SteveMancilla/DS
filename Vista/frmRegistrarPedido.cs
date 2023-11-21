using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class frmRegistrarPedido : Form
    {

        public frmRegistrarPedido()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ProcesarPago_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProcesarPago frmProcesarPago = new FrmProcesarPago();

            frmProcesarPago.Show(); 
        }

        private void RegistrarPedido_Click(object sender, EventArgs e)
        {

        }

        private void EmitirComprobante_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmEmitirComprobante frmEmitirComprobante = new FrmEmitirComprobante();

            frmEmitirComprobante.Show();
        }

        private void frmRegistrarPedido_Load(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.abrir();
            pedMonto.Enabled = false;
            pedID.Enabled = false;

            string connectionString = "Data Source=.;Initial Catalog=dbRestauranteTalita;User ID=sa;Password=continental";
            string query = "SELECT TOP 1 Pedido_ID FROM HLR_tblPedido ORDER BY Pedido_ID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string ultimoID = result.ToString();
                    string numeroStr = ultimoID.Substring(2);
                    int numero = int.Parse(numeroStr);
                    numero++;

                    string nuevoID = "PE" + numero.ToString("D3");

                    pedID.Text = nuevoID;
                }
                else
                {
                    pedID.Text = "PE001";
                }
            }
        }

        private bool seHizoClickEnActualizarPedido = false;

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pedID.Text) ||
                string.IsNullOrEmpty(pedCliente.Text) ||
                string.IsNullOrEmpty(pedDNI.Text) ||
                string.IsNullOrEmpty(pedPlatillo.Text) ||
                string.IsNullOrEmpty(pedCantidad.Text) ||
                string.IsNullOrEmpty(pedMonto.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Pedido pedido = new Pedido();
            pedido.pedID = pedID.Text;
            pedido.pedNombre = pedCliente.Text;
            pedido.pedDNI = pedDNI.Text;
            pedido.pedPlatillo = pedPlatillo.Text;
            pedido.pedCantidad = Convert.ToInt32(pedCantidad.Text);
            pedido.pedMonto = Convert.ToInt32(pedMonto.Text);
            DateTime FechaSeleccionada = monthCalendar1.SelectionRange.Start;
            pedido.pedFecha = FechaSeleccionada.ToString("yyyy-MM-dd");

            int result = PedidoDAL.AgregarPedido(pedido);

            seHizoClickEnActualizarPedido = true;


            int platCantidad = Convert.ToInt32(pedCantidad.Text);
            int monTotal = Convert.ToInt32(pedMonto.Text);
            int calcular = platCantidad * monTotal;

            this.Hide();
            FrmProcesarPago FPP = new FrmProcesarPago();
            FPP.PreTotal.Text = calcular.ToString();
            FPP.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pedID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pedCliente.Text = string.Empty;
            pedDNI.Text = string.Empty;
            pedPlatillo.Text = string.Empty;
            pedCantidad.Text = string.Empty;
            pedMonto.Text = string.Empty;
            monthCalendar1.SelectionRange = new SelectionRange();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (seHizoClickEnActualizarPedido)
            {
                this.Hide();

                FrmProcesarPago frmProcesarPago = new FrmProcesarPago();

                frmProcesarPago.Show();
                seHizoClickEnActualizarPedido = false;
            }
            else
            {
                MessageBox.Show("Debe guardar el pedido antes de pasar a pagar", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pedPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pedPlatillo.SelectedItem.ToString() == "Ají de Gallina")
            {
                pedMonto.Text = "12";
                pedMonto.Enabled = false;
            }
            else if (pedPlatillo.SelectedItem.ToString() == "Ceviche")
            {
                pedMonto.Text = "18";
                pedMonto.Enabled = false;
            }
            else if (pedPlatillo.SelectedItem.ToString() == "Chicharron")
            {
                pedMonto.Text = "15";
                pedMonto.Enabled = false;
            }
            else if (pedPlatillo.SelectedItem.ToString() == "Lomo Saltado")
            {
                pedMonto.Text = "15";
                pedMonto.Enabled = false;
            }
            else if (pedPlatillo.SelectedItem.ToString() == "Pollo al Horno")
            {
                pedMonto.Text= "12";
                pedMonto.Enabled = false;
            }
            else if (pedPlatillo.SelectedItem.ToString() == "Pachamanca")
            {
                pedMonto.Text = "20";
                pedMonto.Enabled = false;
            }
            else if (pedPlatillo.SelectedItem.ToString() == "Pollo a la Brasa")
            {
                pedMonto.Text = "15";
                pedMonto.Enabled = false;
            }

        }

        private void pedCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
