namespace AplicacionMDI
{
  partial class frmCategorias
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
      this.gbCategoria = new System.Windows.Forms.GroupBox();
      this.chkVigente = new System.Windows.Forms.CheckBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.txtDescripcion = new System.Windows.Forms.TextBox();
      this.lblDescripcion = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblNombre = new System.Windows.Forms.Label();
      this.gbListado = new System.Windows.Forms.GroupBox();
      this.dgvListado = new System.Windows.Forms.DataGridView();
      this.btnModificar = new System.Windows.Forms.Button();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.gbCategoria.SuspendLayout();
      this.gbListado.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
      this.SuspendLayout();
      // 
      // gbCategoria
      // 
      this.gbCategoria.Controls.Add(this.chkVigente);
      this.gbCategoria.Controls.Add(this.btnCancelar);
      this.gbCategoria.Controls.Add(this.btnAceptar);
      this.gbCategoria.Controls.Add(this.txtDescripcion);
      this.gbCategoria.Controls.Add(this.lblDescripcion);
      this.gbCategoria.Controls.Add(this.txtNombre);
      this.gbCategoria.Controls.Add(this.lblNombre);
      this.gbCategoria.Enabled = false;
      this.gbCategoria.Location = new System.Drawing.Point(24, 29);
      this.gbCategoria.Name = "gbCategoria";
      this.gbCategoria.Size = new System.Drawing.Size(392, 234);
      this.gbCategoria.TabIndex = 0;
      this.gbCategoria.TabStop = false;
      this.gbCategoria.Text = "Categoría";
      // 
      // chkVigente
      // 
      this.chkVigente.AutoSize = true;
      this.chkVigente.Location = new System.Drawing.Point(96, 151);
      this.chkVigente.Name = "chkVigente";
      this.chkVigente.Size = new System.Drawing.Size(62, 17);
      this.chkVigente.TabIndex = 4;
      this.chkVigente.Text = "Vigente";
      this.chkVigente.UseVisualStyleBackColor = true;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(293, 190);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 6;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(212, 190);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 5;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // txtDescripcion
      // 
      this.txtDescripcion.Location = new System.Drawing.Point(96, 65);
      this.txtDescripcion.Multiline = true;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new System.Drawing.Size(272, 67);
      this.txtDescripcion.TabIndex = 3;
      // 
      // lblDescripcion
      // 
      this.lblDescripcion.AutoSize = true;
      this.lblDescripcion.Location = new System.Drawing.Point(26, 72);
      this.lblDescripcion.Name = "lblDescripcion";
      this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
      this.lblDescripcion.TabIndex = 2;
      this.lblDescripcion.Text = "Descripción";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(96, 39);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(176, 20);
      this.txtNombre.TabIndex = 1;
      // 
      // lblNombre
      // 
      this.lblNombre.AutoSize = true;
      this.lblNombre.Location = new System.Drawing.Point(26, 46);
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
      this.gbListado.Controls.Add(this.dgvListado);
      this.gbListado.Controls.Add(this.btnModificar);
      this.gbListado.Controls.Add(this.btnNuevo);
      this.gbListado.Location = new System.Drawing.Point(431, 29);
      this.gbListado.Name = "gbListado";
      this.gbListado.Size = new System.Drawing.Size(378, 277);
      this.gbListado.TabIndex = 1;
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
            this.cdNombre,
            this.cdVigente});
      this.dgvListado.Location = new System.Drawing.Point(16, 28);
      this.dgvListado.MultiSelect = false;
      this.dgvListado.Name = "dgvListado";
      this.dgvListado.ReadOnly = true;
      this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvListado.Size = new System.Drawing.Size(352, 202);
      this.dgvListado.TabIndex = 0;
      // 
      // btnModificar
      // 
      this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnModificar.Location = new System.Drawing.Point(95, 243);
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
      this.btnNuevo.Location = new System.Drawing.Point(14, 243);
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
      this.btnCerrar.Location = new System.Drawing.Point(734, 334);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(75, 23);
      this.btnCerrar.TabIndex = 2;
      this.btnCerrar.Text = "Cerrar";
      this.btnCerrar.UseVisualStyleBackColor = true;
      // 
      // cdNombre
      // 
      this.cdNombre.DataPropertyName = "Nombre";
      this.cdNombre.HeaderText = "Categoría";
      this.cdNombre.Name = "cdNombre";
      this.cdNombre.ReadOnly = true;
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
      // frmCategorias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(823, 369);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.gbListado);
      this.Controls.Add(this.gbCategoria);
      this.Name = "frmCategorias";
      this.Text = "Gestión de categorias";
      this.Load += new System.EventHandler(this.frmCategorias_Load);
      this.gbCategoria.ResumeLayout(false);
      this.gbCategoria.PerformLayout();
      this.gbListado.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbCategoria;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.TextBox txtDescripcion;
    private System.Windows.Forms.Label lblDescripcion;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.GroupBox gbListado;
    private System.Windows.Forms.DataGridView dgvListado;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.CheckBox chkVigente;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
    private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
  }
}