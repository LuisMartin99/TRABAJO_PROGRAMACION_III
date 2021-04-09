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
    public partial class frmLocales : Form
    {
        private Local Actual;
        public frmLocales()
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
            this.gbLocal.Enabled = estado;
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
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.chkVigente.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Local Loc;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    Loc = new Local();
                    Program.Locales.Add(Loc);
                }
                else
                {
                    Loc = this.Actual;
                }
                this.GuardarDatos(Loc);
                this.ListarLocales();
                this.ActivarControles(false);
            }
        }
        private void ListarLocales()
        {
            this.dgvListado.DataSource = null;
            if (Program.Locales.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Locales;
            }
        }
        private void GuardarDatos(Local wLocal)
        {
            wLocal.Nombre = this.txtNombre.Text;
            wLocal.Direccion= this.txtDireccion.Text;
            wLocal.Telefono = this.txtTelefono.Text;
            wLocal.Vigente = this.chkVigente.Checked;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Local)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un local", this.Text);
                this.dgvListado.Focus();
            }
        }
        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtDireccion.Text = this.Actual.Direccion;
            this.txtTelefono.Text = this.Actual.Telefono;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }
        private void frmLocales_Load(object sender, EventArgs e)
        {
            this.ListarLocales();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Local)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría", this.Text);
                this.dgvListado.Focus();
            }
        }
    }
}
