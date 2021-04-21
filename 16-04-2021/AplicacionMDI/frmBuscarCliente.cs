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
  public partial class frmBuscarCliente : Form
  {

    public  Cliente Cliente;

    public frmBuscarCliente()
    {
      InitializeComponent();
    }

    public  Cliente Buscar()
    {
      this.ShowDialog();

      return this.Cliente;
    }

    private void btnlistar_Click(object sender, EventArgs e)
    {
      this.dgvClientes.DataSource = null;
      if( Program.Clientes != null)
      {
        this.dgvClientes.AutoGenerateColumns = false;
        this.dgvClientes.DataSource = Program.Clientes;
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Cliente = null;
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
      if( this.dgvClientes.CurrentRow != null)
      {
        this.Cliente = (Cliente )this.dgvClientes.CurrentRow.DataBoundItem;
        this.Close();
      }
      else
      {
        MessageBox.Show("Debe seleccionar un cliente");
        this.dgvClientes.Focus();
      }
    }

  }
}
