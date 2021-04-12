using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AplicacionMDI
{
    public partial class frmTrabajador : Form
    {
        private Trabajador Actual;

        public frmTrabajador()
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

            this.gbTrabajador.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.cboDocumento.Focus();
            }
            else
            {
                this.dgvListado.Focus();
            }
        }

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.cboDocumento.SelectedIndex = -1;
            this.txtNroDocumento.Text = "";
            //this.
            this.txtCelular.Text = "";
            this.txtEmail.Text = "";
            this.chkVigente.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Trabajador trab;
            
            if (this.ValidateChildren() == true)
            {
                BorrarMensajeError();
                if (ValidarCampos()) 
                { 
                    if (this.Actual == null)
                    {
                        trab = new Trabajador();
                        Program.Trabajadores.Add(trab);
                    }
                    else
                    {
                        trab = this.Actual;
                    }
                    this.GuardarDatos(trab);
                    this.ListarTrabajadores();
                    this.ActivarControles(false);
                    this.AutoValidate = AutoValidate.Disable;
                }
            }
        }

        private void ListarTrabajadores()
        {
            this.dgvListado.DataSource = null;
            if (Program.Trabajadores.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Trabajadores;
            }
        }

        private void GuardarDatos(Trabajador wTrabajador)
        {
            wTrabajador.Nombres = this.txtNombre.Text;
            wTrabajador.Apellidos = this.txtNombre.Text;
            wTrabajador.TipoDocumento = (DocumentoPersona)this.cboDocumento.SelectedItem;
            wTrabajador.NumeroDocumento = this.txtNroDocumento.Text;
            //wTrabajador.FechaNacimiento = 
            wTrabajador.Celular = this.txtCelular.Text;
            wTrabajador.Correo = this.txtEmail.Text;
            wTrabajador.Vigente = this.chkVigente.Checked;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Trabajador)this.dgvListado.CurrentRow.DataBoundItem;
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
            this.txtNombre.Text = this.Actual.Nombres;
            this.txtApellido.Text = this.Actual.Apellidos;
            this.cboDocumento.Text = this.Actual.TipoDocumento.Nombre;
            this.txtNroDocumento.Text = this.Actual.NumeroDocumento;

            this.txtCelular.Text = this.Actual.Celular;
            this.txtEmail.Text = this.Actual.Correo;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.ActivarControles(true);
        }

        private void frmDocumentoPersona_Load(object sender, EventArgs e)
        {

            this.CargarDocumentoPersona();
        }

        private void CargarDocumentoPersona()
        {
            if (Program.Categorias.Count > 0)
            {
                this.cboDocumento.DisplayMember = "Nombre";
                this.cboDocumento.DataSource = Program.DocumentoPersonas;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            Regex miRegex = new Regex(@"\S+@\S+\.\S+");
             var match = miRegex.Match(txtEmail.Text);
            if (!match.Success)
            {
                ok = false;
                errNotificacion.SetError(txtEmail, "Email Incorrecto");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errNotificacion.SetError(txtEmail, "");
        }


    }
}
