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
using System.IO;
using System.Text.RegularExpressions;


namespace Vista
{
    public partial class FrmEmitirComprobante : Form
    {
        private Conexion_db conexion;

        public FrmEmitirComprobante()
        {
            InitializeComponent();
            conexion = new Conexion_db();
            coNum.TextChanged += coNum_TextChanged;
        }

        private void LimpiarTextBoxes()
        {
            coCliente.Text = string.Empty;
            coDNI.Text = string.Empty;
            coFecha.Text = string.Empty;
            coPlatillo.Text = string.Empty;
            coCantidad.Text = string.Empty;
            coMonto.Text = string.Empty;
        }

        private void RegistrarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegistrarPedido frmRegistrarPedido = new frmRegistrarPedido();

            frmRegistrarPedido.Show();
        }

        private void ProcesarPago_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProcesarPago frmProcesarPago = new FrmProcesarPago();

            frmProcesarPago.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmEmitirComprobante_Load(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.abrir();
            coComprobante.SelectedItem = "Boleta";

            coNum.Enabled = false;
            coPago.Enabled = false;
            com_ID.Enabled = false;
            coCliente.Enabled = false;
            coDNI.Enabled = false;
            coPlatillo.Enabled = false;
            coCantidad.Enabled = false;
            coUnitario.Enabled = false;
            coTipo.Enabled = false;
            coNumero.Enabled = false;
            coMonto.Enabled = false;
            coFecha.Enabled = false;

            string connectionString = "Data Source=.;Initial Catalog=dbRestauranteTalita;User ID=sa;Password=continental";
            string query = "SELECT TOP 1 Comprobante_ID FROM HLR_tblComprobante ORDER BY Comprobante_ID DESC";
            string queryPedido = "SELECT TOP 1 Pedido_ID FROM HLR_tblPedido ORDER BY Pedido_ID DESC";
            string queryPago = "SELECT TOP 1 Pago_ID FROM HLR_tblPago ORDER BY Pago_ID DESC";

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

                    string nuevoID = "CO" + numero.ToString("D3");

                    com_ID.Text = nuevoID;
                }
                else
                {
                    com_ID.Text = "CO001";
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPedido, connection);
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string ultimoNumPedido = result.ToString();
                    coNum.Text = ultimoNumPedido;
                }
                else
                {
                    coNum.Text = "Sin registros";
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPago, connection);
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string ultimoNumPedido = result.ToString();
                    coPago.Text = ultimoNumPedido;
                }
                else
                {
                    coPago.Text = "Sin registros";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProcesarPago frmProcesarPago = new FrmProcesarPago();

            frmProcesarPago.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (seHizoClickEnActualizarPedido)
            {
                this.Hide();

                frmRegistrarPedido frmRegistrarPedido = new frmRegistrarPedido();

                frmRegistrarPedido.Show();
            }
            else
            {
                MessageBox.Show("Debe emitir el comprobante antes registrar otro pedido", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            coNum.Text = string.Empty;
            coCliente.Text = string.Empty;
            coDNI.Text = string.Empty;
            coPlatillo.Text = string.Empty;
            coCantidad.Text = string.Empty;
            coPago.Text = string.Empty;
            coMonto.Text = string.Empty;
            coTipo.Text = string.Empty;
            coComprobante.Text = string.Empty;
            coFecha.Text = string.Empty;
            coNumero.Text = string.Empty;
            coUnitario.Text = string.Empty;
        }

        private void coNum_TextChanged(object sender, EventArgs e)
        {

        }

        private bool seHizoClickEnActualizarPedido = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(com_ID.Text) ||
                string.IsNullOrEmpty(coNum.Text) ||
                string.IsNullOrEmpty(coPago.Text) ||
                string.IsNullOrEmpty(coCliente.Text) ||
                string.IsNullOrEmpty(coDNI.Text) ||
                string.IsNullOrEmpty(coPlatillo.Text) ||
                string.IsNullOrEmpty(coCantidad.Text) ||
                string.IsNullOrEmpty(coUnitario.Text) ||
                string.IsNullOrEmpty(coTipo.Text) ||
                string.IsNullOrEmpty(coNumero.Text) ||
                string.IsNullOrEmpty(coMonto.Text) ||
                string.IsNullOrEmpty(coMonto.Text) ||
                string.IsNullOrEmpty(coFecha.Text) ||
                string.IsNullOrEmpty(coComprobante.Text)
               )
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Comprobante comprobante = new Comprobante();
            comprobante.com_ID = com_ID.Text;
            comprobante.coNum = coNum.Text;
            comprobante.coPago = coPago.Text;
            comprobante.coCliente = coCliente.Text;
            comprobante.coDNI = coDNI.Text;
            comprobante.coPlatillo = coPlatillo.Text;
            comprobante.coCantidad = coCantidad.Text;
            comprobante.coUnitario = coUnitario.Text;
            comprobante.coTipo = coTipo.Text;
            comprobante.coNumero = coNumero.Text;
            comprobante.coMonto = coMonto.Text;
            comprobante.coFecha = coFecha.Text;
            comprobante.coComprobante = coComprobante.Text;

            int result = ComprobanteDAL.AgregarComprobante(comprobante);

            seHizoClickEnActualizarPedido = true;

            MessageBox.Show("La venta se realizó con éxito", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string rutaPersonalizada = @"E:\Universidad Continental\Ciclo 06\Diseño de Software\Comprobantes";
            string fechaActual = DateTime.Now.ToString("yyyyMMddHHmmss");
            string nombreArchivoTexto = "Comprobante_" + fechaActual + ".txt";
            string rutaArchivo = Path.Combine(rutaPersonalizada, nombreArchivoTexto);
            List<(string, string)> datosAGuardar = new List<(string, string)>
            {
                ("Código de comprobante", ""),
                ("Código de Pedido", ""),
                ("Código de Pago", ""),
                ("Cliente", ""),
                ("DNI del Cliente", ""),
                ("Nombre del Platillo", ""),
                ("Cantidad de Platillos", ""),
                ("Precio por Platillo en Soles", ""),
                ("Tipo de Pago", ""),
                ("Número de Tarjeta", ""),
                ("Monto Total en Soles", ""),
                ("Fecha de Consumo", ""),
                ("Tipo de Comprobante", "Boleta"),
            };

            foreach (Control control in groupBox1.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    switch (textBox.Name)
                    {
                        case "com_ID":
                            datosAGuardar[0] = ("Código de comprobante", textBox.Text);
                            break;
                        case "coNum":
                            datosAGuardar[1] = ("Código de Pedido", textBox.Text);
                            break;
                        case "coCliente":
                            datosAGuardar[2] = ("Cliente", textBox.Text);
                            break;
                        case "coDNI":
                            datosAGuardar[3] = ("DNI del Cliente", textBox.Text);
                            break;
                        case "coPlatillo":
                            datosAGuardar[4] = ("Nombre del Platillo", textBox.Text);
                            break;
                        case "coCantidad":
                            datosAGuardar[5] = ("Cantidad de Platillos", textBox.Text);
                            break;
                        case "coUnitario":
                            datosAGuardar[6] = ("Precio por Platillo en Soles", textBox.Text);
                            break;
                        case "coPago":
                            datosAGuardar[7] = ("Código de Pago", textBox.Text);
                            break;
                        case "coTipo":
                            datosAGuardar[8] = ("Tipo de Pago", textBox.Text);
                            break;
                        case "coNumero":
                            datosAGuardar[9] = ("Número de Tarjeta", textBox.Text);
                            break;
                        case "coMonto":
                            datosAGuardar[10] = ("Monto Total en Soles", textBox.Text);
                            break;
                        case "coFecha":
                            datosAGuardar[11] = ("Fecha de Consumo", textBox.Text);
                            break;
                        default:
                            break;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine("---------------------------------------");
                writer.WriteLine("COMPROBANTE DE CONSUMO - ASN RESTAURANT");
                writer.WriteLine("---------------------------------------");
                writer.WriteLine("");

                foreach (var dato in datosAGuardar)
                {
                    writer.WriteLine(dato.Item1 + ": " + dato.Item2);
                }

                writer.WriteLine("");
                writer.WriteLine("------------------------------");
                writer.WriteLine("Muchas gracias, vuelva pronto.");
                writer.WriteLine("------------------------------");
            }
        }

        private void coCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string pedidoID = coNum.Text;
            string pagoID = coPago.Text;

            using (SqlConnection connection = conexion.abrir())
            {

                if (connection != null)
                {
                    string query = $"SELECT pedNomCliente, pedCliDNI, pedFecha, pedPlatillo, pedCantidad, pedMonto FROM HLR_tblPedido WHERE Pedido_ID = '{pedidoID}'";
                    string query02 = $"SELECT Pago_ID, pagTipo, pagNumero, pagMonto FROM HLR_tblPago WHERE Pago_ID = '{pagoID}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                coCliente.Text = reader["pedNomCliente"].ToString();
                                coDNI.Text = reader["pedCliDNI"].ToString();
                                coFecha.Text = reader["pedFecha"].ToString();
                                coPlatillo.Text = reader["pedPlatillo"].ToString();
                                coCantidad.Text = reader["pedCantidad"].ToString();
                                coUnitario.Text = reader["pedMonto"].ToString();
                            }
                            else
                            {
                                LimpiarTextBoxes();
                            }
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query02, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                coMonto.Text = reader["pagMonto"].ToString();
                                coTipo.Text = reader["pagTipo"].ToString();
                                coNumero.Text = reader["pagNumero"].ToString();
                            }
                            else
                            {
                                LimpiarTextBoxes();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El ID que ingresó no existe", "Servicio TI - ASN Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    FrmEmitirComprobante FrmEmitirComprobante = new FrmEmitirComprobante();

                    FrmEmitirComprobante.Show();
                }

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void coComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
