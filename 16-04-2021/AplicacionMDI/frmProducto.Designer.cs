namespace AplicacionMDI
{
  partial class frmProducto
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.gbProducto = new System.Windows.Forms.GroupBox();
      this.nudStock = new System.Windows.Forms.NumericUpDown();
      this.nudPrecio = new System.Windows.Forms.NumericUpDown();
      this.cboCategoria = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkVigente = new System.Windows.Forms.CheckBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lblNombre = new System.Windows.Forms.Label();
      this.gbListado = new System.Windows.Forms.GroupBox();
      this.dgvListado = new System.Windows.Forms.DataGridView();
      this.btnModificar = new System.Windows.Forms.Button();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.cdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.gbProducto.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
      this.gbListado.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
      this.SuspendLayout();
      // 
      // gbProducto
      // 
      this.gbProducto.Controls.Add(this.nudStock);
      this.gbProducto.Controls.Add(this.nudPrecio);
      this.gbProducto.Controls.Add(this.cboCategoria);
      this.gbProducto.Controls.Add(this.label1);
      this.gbProducto.Controls.Add(this.chkVigente);
      this.gbProducto.Controls.Add(this.btnCancelar);
      this.gbProducto.Controls.Add(this.btnAceptar);
      this.gbProducto.Controls.Add(this.label3);
      this.gbProducto.Controls.Add(this.txtNombre);
      this.gbProducto.Controls.Add(this.label2);
      this.gbProducto.Controls.Add(this.lblNombre);
      this.gbProducto.Enabled = false;
      this.gbProducto.Location = new System.Drawing.Point(24, 29);
      this.gbProducto.Name = "gbProducto";
      this.gbProducto.Size = new System.Drawing.Size(392, 266);
      this.gbProducto.TabIndex = 0;
      this.gbProducto.TabStop = false;
      this.gbProducto.Text = "Producto";
      // 
      // nudStock
      // 
      this.nudStock.Location = new System.Drawing.Point(96, 150);
      this.nudStock.Name = "nudStock";
      this.nudStock.Size = new System.Drawing.Size(76, 20);
      this.nudStock.TabIndex = 7;
      this.nudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // nudPrecio
      // 
      this.nudPrecio.DecimalPlaces = 2;
      this.nudPrecio.Location = new System.Drawing.Point(96, 113);
      this.nudPrecio.Name = "nudPrecio";
      this.nudPrecio.Size = new System.Drawing.Size(120, 20);
      this.nudPrecio.TabIndex = 5;
      this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // cboCategoria
      // 
      this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCategoria.FormattingEnabled = true;
      this.cboCategoria.Location = new System.Drawing.Point(96, 37);
      this.cboCategoria.Name = "cboCategoria";
      this.cboCategoria.Size = new System.Drawing.Size(278, 21);
      this.cboCategoria.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Categoría";
      // 
      // chkVigente
      // 
      this.chkVigente.AutoSize = true;
      this.chkVigente.Location = new System.Drawing.Point(96, 192);
      this.chkVigente.Name = "chkVigente";
      this.chkVigente.Size = new System.Drawing.Size(62, 17);
      this.chkVigente.TabIndex = 8;
      this.chkVigente.Text = "Vigente";
      this.chkVigente.UseVisualStyleBackColor = true;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(308, 230);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 10;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(227, 230);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 9;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 157);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Stock";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(96, 76);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(278, 20);
      this.txtNombre.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Precio";
      // 
      // lblNombre
      // 
      this.lblNombre.AutoSize = true;
      this.lblNombre.Location = new System.Drawing.Point(26, 83);
      this.lblNombre.Name = "lblNombre";
      this.lblNombre.Size = new System.Drawing.Size(44, 13);
      this.lblNombre.TabIndex = 2;
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
            this.cdCategoria,
            this.cdNombre,
            this.cdPrecio,
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
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // cdCategoria
      // 
      this.cdCategoria.DataPropertyName = "NombreCategoria";
      this.cdCategoria.HeaderText = "Categoría";
      this.cdCategoria.Name = "cdCategoria";
      this.cdCategoria.ReadOnly = true;
      // 
      // cdNombre
      // 
      this.cdNombre.DataPropertyName = "Nombre";
      this.cdNombre.HeaderText = "Producto";
      this.cdNombre.Name = "cdNombre";
      this.cdNombre.ReadOnly = true;
      // 
      // cdPrecio
      // 
      this.cdPrecio.DataPropertyName = "Precio";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "N2";
      dataGridViewCellStyle1.NullValue = null;
      this.cdPrecio.DefaultCellStyle = dataGridViewCellStyle1;
      this.cdPrecio.HeaderText = "Precio";
      this.cdPrecio.Name = "cdPrecio";
      this.cdPrecio.ReadOnly = true;
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
      // frmProducto
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(823, 369);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.gbListado);
      this.Controls.Add(this.gbProducto);
      this.Name = "frmProducto";
      this.Text = "Gestión de productos";
      this.Load += new System.EventHandler(this.frmCategorias_Load);
      this.gbProducto.ResumeLayout(false);
      this.gbProducto.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
      this.gbListado.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbProducto;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.GroupBox gbListado;
    private System.Windows.Forms.DataGridView dgvListado;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.CheckBox chkVigente;
    private System.Windows.Forms.NumericUpDown nudStock;
    private System.Windows.Forms.NumericUpDown nudPrecio;
    private System.Windows.Forms.ComboBox cboCategoria;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdCategoria;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdPrecio;
    private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
  }
}