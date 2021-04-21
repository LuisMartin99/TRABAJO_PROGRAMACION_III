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
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void mnuCategorias_Click(object sender, EventArgs e)
    {
      frmCategorias frm = new frmCategorias();

      frm.MdiParent = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
      //frm.ListarCategorias();
      // Singleton
    }

    private void mnuProductos_Click(object sender, EventArgs e)
    {
      frmProducto frm = new frmProducto();

      frm.MdiParent = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
    }

    private void mnuVenta_Click(object sender, EventArgs e)
    {
      frmVenta  frm = new frmVenta();

      frm.MdiParent = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
    }

    private void mnuListadoVentas_Click(object sender, EventArgs e)
    {
      frmListadoVentas frm = new frmListadoVentas();

      frm.MdiParent = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
    }
  }
}
