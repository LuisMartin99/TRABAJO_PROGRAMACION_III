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
    public partial class frmDocumentoVenta : Form
    {
        private DocumentoVenta Actual;

        public frmDocumentoVenta()
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
            this.gbDocumentoVenta.Enabled = estado;
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
            this.chkInterno.Checked = true;
            this.chkVigente.Checked = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DocumentoVenta docVent;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    docVent = new DocumentoVenta();
                    Program.DocumentoVentas.Add(docVent);
                }
                else
                {
                    docVent = this.Actual;
                }

                this.GuardarDatos(docVent);
                this.LisarDacumentoVenta();
                this.ActivarControles(false);
            }
                        
        }

        private void GuardarDatos(DocumentoVenta wDocVenta)
        {
            wDocVenta.Nombre = this.txtNombre.Text;
            wDocVenta.Descripcion = this.txtDescripcion.Text;
            wDocVenta.Interno = this.chkInterno.Checked;
            wDocVenta.Vigente = this.chkVigente.Checked;
        }

        private void LisarDacumentoVenta()
        {
            this.dgvListado.DataSource = null;

            if (Program.DocumentoVentas.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.DocumentoVentas;
            }
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtDescripcion.Text = this.Actual.Descripcion;
            this.chkInterno.Checked = this.Actual.Interno;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        private void frmDocumentoVenta_Load(object sender, EventArgs e)
        {
            this.LisarDacumentoVenta();
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
                MessageBox.Show("DEBE SELECCIONAR UN DOCUMENTO", this.Text);
                this.dgvListado.Focus();
            }

        }
    }
}
