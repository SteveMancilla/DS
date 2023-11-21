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
    public partial class FrmProcesarPago : Form
    {
        public FrmProcesarPago()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegistrarPedido frmRegistrarPedido = new frmRegistrarPedido();

            frmRegistrarPedido.Show();
        }

        private void EmitirComprobante_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmEmitirComprobante frmEmitirComprobante = new FrmEmitirComprobante();

            frmEmitirComprobante.Show();
        }

        private void FrmProcesarPago_Load(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.abrir();
            MonTipo.SelectedItem = "Efectivo";
            PreTotal.Enabled = false;
            Pago_ID.Enabled = false;

            string connectionString = "Data Source=.;Initial Catalog=dbRestauranteTalita;User ID=sa;Password=continental";
            string query = "SELECT TOP 1 Pago_ID FROM HLR_tblPago ORDER BY Pago_ID DESC";

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

                    string nuevoID = "PA" + numero.ToString("D3");

                    Pago_ID.Text = nuevoID;
                }
                else
                {
                    Pago_ID.Text = "PA001";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegistrarPedido frmRegistrarPedido = new frmRegistrarPedido();

            frmRegistrarPedido.Show();
            seHizoClickEnPagar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool seHizoClickEnPagar = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pago_ID.Text) ||
                string.IsNullOrEmpty(MonTipo.Text) ||
                string.IsNullOrEmpty(PreTotal.Text) ||
                string.IsNullOrEmpty(NumCuenta.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Pago pago = new Pago();
            pago.pagID = Pago_ID.Text;
            pago.pagDetalleMoneda = MonTipo.Text;
            pago.pagNumeroCuenta = NumCuenta.Text;
            pago.pagMonto = Convert.ToInt32(PreTotal.Text);

            int result = PagoDAL.AgregarPago(pago);

            seHizoClickEnPagar = true;

            this.Hide();
            FrmEmitirComprobante FPP = new FrmEmitirComprobante();
            FPP.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MonTipo.Text = string.Empty;
            NumCuenta.Text = string.Empty;
            PreTotal.Text = string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (seHizoClickEnPagar)
            {
                this.Hide();

                FrmEmitirComprobante FrmEmitirComprobante = new FrmEmitirComprobante();

                FrmEmitirComprobante.Show();
                seHizoClickEnPagar = false;
            }
            else
            {
                MessageBox.Show("Debe guardar el pago antes de emitir un comprobante", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MonTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonTipo.SelectedItem.ToString() == "Efectivo")
            {
                NumCuenta.Text = "Sin Número";
                NumCuenta.Enabled = false;
            }
            else
            {
                NumCuenta.Text = string.Empty;
                NumCuenta.Enabled = true;
            }
        }

        private void NumCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
