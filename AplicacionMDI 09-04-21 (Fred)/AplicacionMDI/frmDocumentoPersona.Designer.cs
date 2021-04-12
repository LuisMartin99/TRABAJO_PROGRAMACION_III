
namespace AplicacionMDI
{
    partial class frmDocumentoPersona
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
            this.gbEntidad = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.txtSiglas = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblValores = new System.Windows.Forms.Label();
            this.lblSiglas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siglas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbEntidad.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntidad
            // 
            this.gbEntidad.Controls.Add(this.btnCancelar);
            this.gbEntidad.Controls.Add(this.btnAceptar);
            this.gbEntidad.Controls.Add(this.txtValores);
            this.gbEntidad.Controls.Add(this.chkVigente);
            this.gbEntidad.Controls.Add(this.txtSiglas);
            this.gbEntidad.Controls.Add(this.txtNombre);
            this.gbEntidad.Controls.Add(this.lblValores);
            this.gbEntidad.Controls.Add(this.lblSiglas);
            this.gbEntidad.Controls.Add(this.lblNombre);
            this.gbEntidad.Enabled = false;
            this.gbEntidad.Location = new System.Drawing.Point(33, 36);
            this.gbEntidad.Margin = new System.Windows.Forms.Padding(2);
            this.gbEntidad.Name = "gbEntidad";
            this.gbEntidad.Padding = new System.Windows.Forms.Padding(2);
            this.gbEntidad.Size = new System.Drawing.Size(289, 229);
            this.gbEntidad.TabIndex = 4;
            this.gbEntidad.TabStop = false;
            this.gbEntidad.Text = "Persona";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 189);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 24);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(106, 189);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 24);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(62, 96);
            this.txtValores.Margin = new System.Windows.Forms.Padding(2);
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(206, 20);
            this.txtValores.TabIndex = 7;
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(62, 132);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(2);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(62, 17);
            this.chkVigente.TabIndex = 6;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // txtSiglas
            // 
            this.txtSiglas.Location = new System.Drawing.Point(62, 59);
            this.txtSiglas.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiglas.Name = "txtSiglas";
            this.txtSiglas.Size = new System.Drawing.Size(113, 20);
            this.txtSiglas.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(14, 96);
            this.lblValores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(42, 13);
            this.lblValores.TabIndex = 2;
            this.lblValores.Text = "Valores";
            // 
            // lblSiglas
            // 
            this.lblSiglas.AutoSize = true;
            this.lblSiglas.Location = new System.Drawing.Point(14, 59);
            this.lblSiglas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiglas.Name = "lblSiglas";
            this.lblSiglas.Size = new System.Drawing.Size(35, 13);
            this.lblSiglas.TabIndex = 1;
            this.lblSiglas.Text = "Siglas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 31);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Location = new System.Drawing.Point(341, 36);
            this.gbListado.Margin = new System.Windows.Forms.Padding(2);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(2);
            this.gbListado.Size = new System.Drawing.Size(448, 279);
            this.gbListado.TabIndex = 5;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Lista";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(82, 240);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 24);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(4, 240);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 24);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.Nombres,
            this.Siglas,
            this.Valores,
            this.Vigente});
            this.dgvListado.Location = new System.Drawing.Point(4, 17);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListado.Size = new System.Drawing.Size(440, 209);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_CellMouseDoubleClick);
            this.dgvListado.DoubleClick += new System.EventHandler(this.btnModificar_Click);
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombre";
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 125;
            // 
            // Siglas
            // 
            this.Siglas.DataPropertyName = "Siglas";
            this.Siglas.HeaderText = "Siglas";
            this.Siglas.MinimumWidth = 6;
            this.Siglas.Name = "Siglas";
            this.Siglas.ReadOnly = true;
            this.Siglas.Width = 125;
            // 
            // Valores
            // 
            this.Valores.DataPropertyName = "Valores";
            this.Valores.HeaderText = "Valores";
            this.Valores.MinimumWidth = 6;
            this.Valores.Name = "Valores";
            this.Valores.ReadOnly = true;
            this.Valores.Width = 125;
            // 
            // Vigente
            // 
            this.Vigente.DataPropertyName = "Vigente";
            this.Vigente.HeaderText = "Vigente";
            this.Vigente.MinimumWidth = 6;
            this.Vigente.Name = "Vigente";
            this.Vigente.ReadOnly = true;
            this.Vigente.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(717, 408);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(68, 22);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "C&ERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmDocumentoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEntidad);
            this.Name = "frmDocumentoPersona";
            this.Text = "frmDocumentoPersona";
            this.gbEntidad.ResumeLayout(false);
            this.gbEntidad.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.TextBox txtSiglas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblSiglas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siglas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vigente;
        private System.Windows.Forms.Button btnCerrar;
    }
}