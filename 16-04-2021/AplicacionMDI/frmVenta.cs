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
      frmBuscarCliente frm = new frmBuscarCliente();

      this.Cliente = frm.Buscar();
      if( this.Cliente != null)
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
      frmDetalleVenta frm = new frmDetalleVenta();
      DetalleVenta det;

      det = frm.Agregar();
      if ( det != null)
      {
        this.Detalles.Add(det);
        this.dgvDetalles.DataSource = null;
        this.dgvDetalles.AutoGenerateColumns = false;
        this.dgvDetalles.DataSource = this.Detalles;
      }

    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      Venta venta;

      if( this.ValidateChildren () == true)
      {
        venta = this.CrearEntidad();

        Program.Ventas.Add(venta);
        this.Close();
      }

    }

    private Venta CrearEntidad()
    {
      return new Venta()
      {
        Cliente = this.Cliente,
        TipoDocumento = this.cboDocumento.Text.Substring(0, 1),
        Serie = this.txtSerie.Text ,
        Numero = Int32.Parse( this.txtNumero.Text ),
        Fecha = this.dtpFecha.Value,
        Vigente = true ,
        Detalles = this.Detalles
      };
    }
  }
}
