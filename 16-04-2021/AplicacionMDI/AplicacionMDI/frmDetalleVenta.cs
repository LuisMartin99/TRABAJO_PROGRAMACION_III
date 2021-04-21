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
  public partial class frmDetalleVenta : Form
  {
    private DetalleVenta Detalle;

    public frmDetalleVenta()
    {
      InitializeComponent();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Detalle = null;
      this.Close();
    }

    internal DetalleVenta Agregar()
    {
      this.ShowDialog();

      return this.Detalle;
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if( this.cboProducto.SelectedIndex > -1)
      {
        this.Detalle = new DetalleVenta();

        this.Detalle.Producto = (Producto)this.cboProducto.SelectedItem;
        this.Detalle.PrecioUnitario = this.Detalle.Producto.Precio;
        this.Detalle.Cantidad = (int)this.nudCantidad.Value;

        this.Close();
      }
      else
      {
        MessageBox.Show("Debe seleccionar un producto");
      }
    }

    private void frmDetalleVenta_Load(object sender, EventArgs e)
    {
      this.CargarProductos();
    }

    private void CargarProductos()
    {
      this.cboProducto.DataSource = null;
      if( Program.Productos != null)
      {
        this.cboProducto.DisplayMember = "Nombre";
        this.cboProducto.DataSource = Program.Productos;
      }
    }
  }
}
