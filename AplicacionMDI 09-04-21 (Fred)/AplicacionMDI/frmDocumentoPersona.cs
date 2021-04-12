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
    public partial class frmDocumentoPersona : Form
    {
        private DocumentoPersona Actual;

        public frmDocumentoPersona()
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
            this.gbEntidad.Enabled = estado;
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
            this.txtSiglas.Text = "";
            this.txtValores.Text = "";
            this.chkVigente.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DocumentoPersona docP;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    docP = new DocumentoPersona();
                    Program.DocumentoPersonas.Add(docP);
                }
                else
                {
                    docP = this.Actual;
                }

                this.GuardarDatos(docP);
                this.ListarDocumentoPersona();
                this.ActivarControles(false);
            }
        }

        private void ListarDocumentoPersona()
        {
            this.dgvListado.DataSource = null;
            if (Program.DocumentoPersonas.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.DocumentoPersonas;
            }
        }

        private void GuardarDatos(DocumentoPersona wDocPersona)
        {
            wDocPersona.Nombre = this.txtNombre.Text;
            wDocPersona.Siglas = this.txtSiglas.Text;
            wDocPersona.Valores = Int32.Parse(this.txtValores.Text);
            wDocPersona.Vigente = this.chkVigente.Checked;
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtSiglas.Text = this.Actual.Siglas;
            this.txtValores.Text = this.Actual.Valores.ToString();
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        private void frmDocumentoPersona_Load(object sender, EventArgs e)
        {
            this.ListarDocumentoPersona();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (DocumentoPersona)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN DOCUMENTO", this.Text);
                this.dgvListado.Focus();
            }
        }

        private void dgvListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (DocumentoPersona)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un documento", this.Text);
                this.dgvListado.Focus();
            }
        }
    }
}
