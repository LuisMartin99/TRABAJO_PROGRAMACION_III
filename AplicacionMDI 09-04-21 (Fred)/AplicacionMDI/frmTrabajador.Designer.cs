
namespace AplicacionMDI
{
    partial class frmTrabajador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbTrabajador = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrodeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errNotificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTrabajador.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTrabajador
            // 
            this.gbTrabajador.Controls.Add(this.txtEmail);
            this.gbTrabajador.Controls.Add(this.lblEmail);
            this.gbTrabajador.Controls.Add(this.txtCelular);
            this.gbTrabajador.Controls.Add(this.label1);
            this.gbTrabajador.Controls.Add(this.dtpFecha);
            this.gbTrabajador.Controls.Add(this.txtNroDocumento);
            this.gbTrabajador.Controls.Add(this.lblNroDocumento);
            this.gbTrabajador.Controls.Add(this.cboDocumento);
            this.gbTrabajador.Controls.Add(this.txtApellido);
            this.gbTrabajador.Controls.Add(this.lblApellido);
            this.gbTrabajador.Controls.Add(this.chkVigente);
            this.gbTrabajador.Controls.Add(this.btnCancelar);
            this.gbTrabajador.Controls.Add(this.btnAceptar);
            this.gbTrabajador.Controls.Add(this.lblCelular);
            this.gbTrabajador.Controls.Add(this.txtNombre);
            this.gbTrabajador.Controls.Add(this.lblTipoDocumento);
            this.gbTrabajador.Controls.Add(this.lblNombre);
            this.gbTrabajador.Enabled = false;
            this.gbTrabajador.Location = new System.Drawing.Point(32, 30);
            this.gbTrabajador.Name = "gbTrabajador";
            this.gbTrabajador.Size = new System.Drawing.Size(392, 396);
            this.gbTrabajador.TabIndex = 0;
            this.gbTrabajador.TabStop = false;
            this.gbTrabajador.Text = "Trabajador";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(147, 237);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(129, 20);
            this.txtCelular.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha De Nacimiento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(147, 197);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(87, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(147, 155);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(129, 20);
            this.txtNroDocumento.TabIndex = 8;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(26, 162);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(97, 13);
            this.lblNroDocumento.TabIndex = 7;
            this.lblNroDocumento.Text = "Nro de Documento";
            // 
            // cboDocumento
            // 
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(147, 115);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(129, 21);
            this.cboDocumento.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(278, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(26, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellidos";
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(147, 328);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(62, 17);
            this.chkVigente.TabIndex = 15;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(299, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(205, 367);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(26, 244);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(26, 123);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDocumento.TabIndex = 5;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Location = new System.Drawing.Point(430, 44);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(472, 300);
            this.gbListado.TabIndex = 16;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellidos,
            this.Email,
            this.NrodeDocumento,
            this.cdVigente});
            this.dgvListado.Location = new System.Drawing.Point(16, 28);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(446, 225);
            this.dgvListado.TabIndex = 0;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NrodeDocumento
            // 
            this.NrodeDocumento.DataPropertyName = "Nro Documento";
            this.NrodeDocumento.HeaderText = "Nro de Documento";
            this.NrodeDocumento.Name = "NrodeDocumento";
            this.NrodeDocumento.ReadOnly = true;
            // 
            // cdVigente
            // 
            this.cdVigente.DataPropertyName = "Vigente";
            this.cdVigente.HeaderText = "Vigente";
            this.cdVigente.Name = "cdVigente";
            this.cdVigente.ReadOnly = true;
            this.cdVigente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdVigente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(95, 266);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(14, 266);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(827, 403);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errNotificacion
            // 
            this.errNotificacion.ContainerControl = this;
            // 
            // frmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbTrabajador);
            this.Name = "frmTrabajador";
            this.Text = "Gestion de trabajadores";
            this.Load += new System.EventHandler(this.frmDocumentoPersona_Load);
            this.gbTrabajador.ResumeLayout(false);
            this.gbTrabajador.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNotificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrabajador;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errNotificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrodeDocumento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
    }
}