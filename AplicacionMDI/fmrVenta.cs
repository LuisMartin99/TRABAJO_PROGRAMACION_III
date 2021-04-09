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
    public partial class fmrVenta : Form
    {
        private DocumentoVenta Actual;
        public fmrVenta()
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
            this.gbVenta.Enabled = estado;
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
            this.chkInterno.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DocumentoVenta ven;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    ven = new DocumentoVenta();
                    Program.Ventas.Add(ven);
                }
                else
                {
                    ven = this.Actual;
                }
                this.GuardarDatos(ven);
                this.ListarVentas();
                this.ActivarControles(false);
            }
        }

        private void ListarVentas()
        {
            this.dgvListado.DataSource = null;
            if (Program.Ventas.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Ventas;
            }
            foreach (DataGridViewRow Myrow in dgvListado.Rows)
            {           
                if ((bool)Myrow.Cells["Vigente"].Value == false )
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Salmon;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.White ;
                }
            }
        }

        private void GuardarDatos(DocumentoVenta wVenta)
        {
            wVenta.Nombre = this.txtNombre.Text;
            wVenta.Descripcion = this.txtDescripcion.Text;
            wVenta.Vigente = this.chkVigente.Checked;
            wVenta.Interno = this.chkInterno.Checked;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (DocumentoVenta)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Venta", this.Text);
                this.dgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtDescripcion.Text = this.Actual.Descripcion;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.chkInterno.Checked = this.Actual.Interno;
            this.ActivarControles(true);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.ListarVentas();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (DocumentoVenta)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Venta", this.Text);
                this.dgvListado.Focus();
            }
        }

        
    }
}
