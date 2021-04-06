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
  public partial class frmCategorias : Form
  {

    private Categoria Actual;

    public frmCategorias()
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
      this.gbCategoria.Enabled = estado;
      this.gbListado.Enabled = !estado;
      if (estado == true)
      {
        this.txtNombre.Focus();
      }
      else
      {
        this.dgvListado.Focus();
      }
    }

    private void LimpiarControles()
    {
      this.txtNombre.Text = "";
      this.txtDescripcion.Text = "";
      this.chkVigente.Checked = true;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.ActivarControles(false);
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      Categoria cat;

      if (this.ValidateChildren() == true)
      {
        if( this.Actual  == null)
        {
          cat = new Categoria();
          Program.Categorias.Add(cat);
        }
        else
        {
          cat = this.Actual;
        }
        this.GuardarDatos(cat);
        this.ListarCategorias();
        this.ActivarControles(false);
      }
    }

    private void ListarCategorias()
    {
      this.dgvListado.DataSource = null;
      if (Program.Categorias.Count > 0)
      {
        this.dgvListado.AutoGenerateColumns = false;
        this.dgvListado.DataSource = Program.Categorias;
      }
    }

    private void GuardarDatos(Categoria wCategoria)
    {
      wCategoria.Nombre = this.txtNombre.Text;
      wCategoria.Descripcion = this.txtDescripcion.Text;
      wCategoria.Vigente = this.chkVigente.Checked;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {

      if( this.dgvListado.CurrentRow != null)
      {
        this.Actual =(Categoria) this.dgvListado.CurrentRow.DataBoundItem;
        this.PresentarDatos();
      }
      else
      {
        MessageBox.Show("Debe seleccionar una categoría", this.Text);
        this.dgvListado.Focus();
      }
    }

    private void PresentarDatos()
    {
      this.txtNombre.Text = this.Actual.Nombre;
      this.txtDescripcion.Text = this.Actual.Descripcion;
      this.chkVigente.Checked = this.Actual.Vigente;
      this.ActivarControles(true);
    }

    private void frmCategorias_Load(object sender, EventArgs e)
    {
      this.ListarCategorias();
    }

  }
}
