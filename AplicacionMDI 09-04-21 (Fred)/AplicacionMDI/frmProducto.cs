using System;
using System.Windows.Forms;

namespace AplicacionMDI
{
  public partial class frmProducto : Form
  {

    //Programadores:
    //    Codificadores
    //    Analistas

    //Desarrollo basado en modelos
    //    Extincion programadores Codificadores

    private Producto Actual;

    public frmProducto()
    {
      InitializeComponent();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      this.LimpiarControles();
      this.ActivarControles(true);
      this.Actual = null;
    }

    private void ActivarControles(bool estado)
    {
      this.gbProducto.Enabled = estado;
      this.gbListado.Enabled = !estado;
      if (estado == true)
      {
        this.cboCategoria.Focus();
      }
      else
      {
        this.dgvListado.Focus();
      }
    }

    private void LimpiarControles()
    {
      this.cboCategoria.SelectedIndex = -1;
      this.txtNombre.Text = "";
      this.nudPrecio.Value = 1;
      this.nudStock.Value = 0;
      this.chkVigente.Checked = true;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.ActivarControles(false);
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      Producto prod;

      if (this.ValidateChildren() == true)
      {
                BorrarMensajeError();
                if (ValidarCampos())
                {
                    if (this.Actual == null)
                    {
                        prod = new Producto();
                        Program.Productos.Add(prod);
                    }
                    else
                    {
                        prod = this.Actual;
                    }
                    this.GuardarDatos(prod);
                    this.ListarProductos();
                    this.ActivarControles(false);
                }
      }
        else
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

       }

    private void ListarProductos()
    {
      this.dgvListado.DataSource = null;
      if (Program.Productos.Count > 0)
      {
        this.dgvListado.AutoGenerateColumns = false;
        this.dgvListado.DataSource = Program.Productos;
      }
    }

    private void GuardarDatos(Producto wProducto)
    {
      wProducto.Categoria = (Categoria)this.cboCategoria.SelectedItem;
      wProducto.Nombre = this.txtNombre.Text;
      wProducto.Precio = (double)this.nudPrecio.Value;
      wProducto.Stock = (int)this.nudStock.Value;
      wProducto.Vigente = this.chkVigente.Checked;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {

      if (this.dgvListado.CurrentRow != null)
      {
        this.Actual = (Producto)this.dgvListado.CurrentRow.DataBoundItem;
        this.PresentarDatos();
      }
      else
      {
        MessageBox.Show("Debe seleccionar un producto", this.Text);
        this.dgvListado.Focus();
      }
    }

    private void PresentarDatos()
    {
      this.cboCategoria.Text = this.Actual.Categoria.Nombre;
      this.txtNombre.Text = this.Actual.Nombre;
      this.nudPrecio.Value = (decimal)this.Actual.Precio;
      this.nudStock.Value = this.Actual.Stock;
      this.chkVigente.Checked = this.Actual.Vigente;
      this.ActivarControles(true);
    }

    private void frmCategorias_Load(object sender, EventArgs e)
    {
      this.CargarCategorias();
      //this.ListarProductos();
    }

    private void CargarCategorias()
    {
      if (Program.Categorias.Count > 0)
      {
        this.cboCategoria.DisplayMember = "Nombre";
        this.cboCategoria.DataSource = Program.Categorias;
      }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

        //private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(this.txtNombre.Text) == true)
        //    {

        //        this.errNotificacion.SetError(this.txtNombre,
        //                 "Debe ingresar nombre");
        //        e.Cancel = true; // Informo que no cumple validación
        //    }
        //    else
        //    {
        //        this.errNotificacion.SetError(this.txtNombre, "");
        //    }
        //}

        //private void cboCategoria_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (this.cboCategoria.SelectedItem == null)
        //    {
        //        this.errNotificacion.SetError(this.cboCategoria,
        //                 "Debe seleccionar categoria");
        //        e.Cancel = true; // Informo que no cumple validación
        //    }
        //    else
        //    {
        //        this.errNotificacion.SetError(this.cboCategoria, "");
        //    }
        //}
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtNombre.Text=="")
            {
                ok = false;
                errNotificacion.SetError(txtNombre, "Ingrese nombre");
            }
            if (cboCategoria.SelectedItem == null)
            {
                ok = false;
                errNotificacion.SetError(cboCategoria, "Seleccione categoria");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errNotificacion.SetError(txtNombre, "");
            errNotificacion.SetError(cboCategoria, "");
        }
    }
}
