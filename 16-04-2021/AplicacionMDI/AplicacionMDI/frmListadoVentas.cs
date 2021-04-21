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
  public partial class frmListadoVentas : Form
  {
    public frmListadoVentas()
    {
      InitializeComponent();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
      this.dgvListado.DataSource = null;
      if( Program.Ventas.Count > 0 )
      {
        this.dgvListado.AutoGenerateColumns = false;
        this.dgvListado.DataSource = Program.Ventas;
      }
    }

  }
}
