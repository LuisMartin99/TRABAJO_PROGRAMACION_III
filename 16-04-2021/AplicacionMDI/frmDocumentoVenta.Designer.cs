
namespace AplicacionMDI
{
    partial class frmDocumentoVenta
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDocumentoVenta = new System.Windows.Forms.GroupBox();
            this.chkInterno = new System.Windows.Forms.CheckBox();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbDocumentoVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(1003, 414);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "C&ERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Location = new System.Drawing.Point(607, 47);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4);
            this.gbListado.Size = new System.Drawing.Size(496, 341);
            this.gbListado.TabIndex = 7;
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
            this.Nombre,
            this.Interno,
            this.Vigente});
            this.dgvListado.Location = new System.Drawing.Point(21, 34);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(461, 249);
            this.dgvListado.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Documento Venta";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Interno
            // 
            this.Interno.DataPropertyName = "Interno";
            this.Interno.HeaderText = "Interno";
            this.Interno.MinimumWidth = 6;
            this.Interno.Name = "Interno";
            this.Interno.ReadOnly = true;
            this.Interno.Width = 125;
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
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(127, 299);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(19, 299);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbDocumentoVenta
            // 
            this.gbDocumentoVenta.Controls.Add(this.chkInterno);
            this.gbDocumentoVenta.Controls.Add(this.chkVigente);
            this.gbDocumentoVenta.Controls.Add(this.btnCancelar);
            this.gbDocumentoVenta.Controls.Add(this.btnAceptar);
            this.gbDocumentoVenta.Controls.Add(this.txtDescripcion);
            this.gbDocumentoVenta.Controls.Add(this.lblDescripcion);
            this.gbDocumentoVenta.Controls.Add(this.txtNombre);
            this.gbDocumentoVenta.Controls.Add(this.lblNombre);
            this.gbDocumentoVenta.Enabled = false;
            this.gbDocumentoVenta.Location = new System.Drawing.Point(24, 47);
            this.gbDocumentoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gbDocumentoVenta.Name = "gbDocumentoVenta";
            this.gbDocumentoVenta.Padding = new System.Windows.Forms.Padding(4);
            this.gbDocumentoVenta.Size = new System.Drawing.Size(523, 327);
            this.gbDocumentoVenta.TabIndex = 6;
            this.gbDocumentoVenta.TabStop = false;
            this.gbDocumentoVenta.Text = "Documento Venta";
            // 
            // chkInterno
            // 
            this.chkInterno.AutoSize = true;
            this.chkInterno.Location = new System.Drawing.Point(128, 204);
            this.chkInterno.Margin = new System.Windows.Forms.Padding(4);
            this.chkInterno.Name = "chkInterno";
            this.chkInterno.Size = new System.Drawing.Size(74, 21);
            this.chkInterno.TabIndex = 7;
            this.chkInterno.Text = "Interno";
            this.chkInterno.UseVisualStyleBackColor = true;
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(283, 204);
            this.chkVigente.Margin = new System.Windows.Forms.Padding(4);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(78, 21);
            this.chkVigente.TabIndex = 4;
            this.chkVigente.Text = "Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(415, 285);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(283, 285);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(128, 80);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(387, 82);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 89);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 57);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // frmDocumentoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 489);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbDocumentoVenta);
            this.Name = "frmDocumentoVenta";
            this.Text = "frmDocumentoVenta";
            this.Load += new System.EventHandler(this.frmDocumentoVenta_Load);
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbDocumentoVenta.ResumeLayout(false);
            this.gbDocumentoVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Interno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vigente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbDocumentoVenta;
        private System.Windows.Forms.CheckBox chkInterno;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}