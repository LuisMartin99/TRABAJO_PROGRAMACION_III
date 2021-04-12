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
    public partial class frmUsuarios : Form
    {
        private Usuario Actual;

        public frmUsuarios()
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
            this.gbUsuario.Enabled = estado;
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
            this.txtPassword.Text = "";
            this.txtTipo.Text = "";
            this.chkVigente.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario us;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    us = new Usuario();
                    Program.Usuarios.Add(us);
                }
                else
                {
                    us = this.Actual;
                }
                this.GuardarDatos(us);
                this.ListarUsuarios();
                this.ActivarControles(false);
            }
        }
        private void ListarUsuarios()
        {
            this.dgvListado.DataSource = null;
            if (Program.Usuarios.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Usuarios;
            }
        }

        private void GuardarDatos(Usuario wUsuarios)
        {
            wUsuarios.Nombre = this.txtNombre.Text;
            wUsuarios.Clave = this.txtNombre.Text;
            wUsuarios.Tipo = this.txtNombre.Text;
            wUsuarios.Vigente = this.chkVigente.Checked;
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtPassword.Text = this.Actual.Clave;
            this.txtTipo.Text = this.Actual.Tipo;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.ListarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Usuario)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario", this.Text);
                this.dgvListado.Focus();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
