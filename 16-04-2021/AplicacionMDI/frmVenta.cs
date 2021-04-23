using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMDI
{
    public partial class frmVenta : Form
    {

        private Cliente Cliente;
        private List<DetalleVenta> Detalles = new List<DetalleVenta>();

        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            frmBuscarCliente frm = new frmBuscarCliente();

            this.Cliente = frm.Buscar();
            if (this.Cliente != null)
            {
                this.txtCliente.Text = this.Cliente.NombreCompleto;
            }
            else
            {
                this.txtCliente.Text = "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();

        }

        private void Agregar()
        {
            frmDetalleVenta frm = new frmDetalleVenta();
            DetalleVenta det;

            det = frm.Agregar();
            if (det != null)
            {
                this.Detalles.Add(det);
                this.dgvDetalles.DataSource = null;
                this.dgvDetalles.AutoGenerateColumns = false;
                this.dgvDetalles.DataSource = this.Detalles;
                this.ActualizarTotal(this.Detalles);
            }
        }

        private void ActualizarTotal(List<DetalleVenta> detalles)
        {
            double total = 0;
            foreach (var det in detalles)
            {
                total = total + (det.PrecioUnitario * det.Cantidad);
            }

            this.txtTotal.Text = total + "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();

        }

        private void Aceptar()
        {

            Venta venta;

            if (this.ValidateChildren() == true)
            {
                BorrarMensajeError();

                if (this.Detalles.Count > 0)
                {
                    if (ValidarCampos())
                    {
                        venta = this.CrearEntidad();

                        Program.Ventas.Add(venta);
                        MessageBox.Show("Venta Registrada con Exito.", this.Text, MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Agregar Productos", ".:ALERTA:.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private Venta CrearEntidad()
        {
            return new Venta()
            {
                Cliente = this.Cliente,
                TipoDocumentoVenta = (DocumentoVenta)this.cboDocumento.SelectedItem,
                Serie = this.txtSerie.Text,
                Numero = Int32.Parse(this.txtNumero.Text),
                Fecha = this.dtpFecha.Value,
                Vigente = true,
                Detalles = this.Detalles
            };
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtCliente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCliente, "Ingrese nombre");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtCliente, "");
        }

        private void frmVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BuscarCliente();
            }

            if (e.KeyCode == Keys.F3)
            {
                Agregar();
            }
            if (e.KeyCode == Keys.F4)
            {
                Eliminar();
            }

            if (e.KeyCode == Keys.F5)
            {
                Aceptar();
            }

            if (e.KeyCode == Keys.F6)
            {
                Close();
            }

        }


        private void Eliminar()
        {
            DetalleVenta Actual;
            if (this.dgvDetalles.CurrentRow != null)
            {
                Actual = (DetalleVenta)this.dgvDetalles.CurrentRow.DataBoundItem;
                this.Detalles.Remove(Actual);
                this.dgvDetalles.DataSource = null;
                this.dgvDetalles.DataSource = this.Detalles;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un detalle para eliminar", this.Text);
                this.dgvDetalles.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            CargarDocumentoVenta();
            //CargarInicial();
        }
        private void CargarDocumentoVenta()
        {
            if (Program.DocumentoVentas.Count > 0)
            {
                this.cboDocumento.DisplayMember = "Nombre";
                this.cboDocumento.DataSource = Program.DocumentoVentas;
            }
        }
        //private void CargarInicial()
        //{
        //    int ultimoNumero = 0;
        //    if (Program.Ventas.Count != 0)
        //    {
        //        cboDocumento.SelectedItem = "Boleta";
        //        ultimoNumero = Program.Ventas.Where(v => v.NombreDocumentoVenta  == "Boleta").Last().Numero;
        //        txtNumero.Text = Convert.ToString(ultimoNumero + 1);
        //    }
        //}

        private void cboDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombredocumento;
            string serie;
            int correlativo;
            if (Program.Ventas.Count != 0)
            {
                nombredocumento = cboDocumento.Text ;
                var listaventa = Program.Ventas.Where(v => v.NombreDocumentoVenta == nombredocumento).ToList();
                if (listaventa .Count > 0) 
                { 
                    correlativo  = listaventa.Last ().Numero;
                    serie  = listaventa.Last().Serie;
                    txtSerie.Text = serie; 
                    txtNumero.Text = (correlativo + 1).ToString();
                }
            }

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingresar Numeros", "ERROR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
