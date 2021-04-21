namespace AplicacionMDI
{
  partial class frmVenta
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
      this.lblDocumento = new System.Windows.Forms.Label();
      this.cboDocumento = new System.Windows.Forms.ComboBox();
      this.lblSerie = new System.Windows.Forms.Label();
      this.txtSerie = new System.Windows.Forms.TextBox();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.lblFecha = new System.Windows.Forms.Label();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.lblCliente = new System.Windows.Forms.Label();
      this.txtCliente = new System.Windows.Forms.TextBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.dgvDetalles = new System.Windows.Forms.DataGridView();
      this.cdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gbDetalles = new System.Windows.Forms.GroupBox();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
      this.gbDetalles.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblDocumento
      // 
      this.lblDocumento.AutoSize = true;
      this.lblDocumento.Location = new System.Drawing.Point(26, 38);
      this.lblDocumento.Name = "lblDocumento";
      this.lblDocumento.Size = new System.Drawing.Size(62, 13);
      this.lblDocumento.TabIndex = 0;
      this.lblDocumento.Text = "Documento";
      // 
      // cboDocumento
      // 
      this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboDocumento.FormattingEnabled = true;
      this.cboDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
      this.cboDocumento.Location = new System.Drawing.Point(92, 30);
      this.cboDocumento.Name = "cboDocumento";
      this.cboDocumento.Size = new System.Drawing.Size(126, 21);
      this.cboDocumento.TabIndex = 1;
      // 
      // lblSerie
      // 
      this.lblSerie.AutoSize = true;
      this.lblSerie.Location = new System.Drawing.Point(355, 38);
      this.lblSerie.Name = "lblSerie";
      this.lblSerie.Size = new System.Drawing.Size(31, 13);
      this.lblSerie.TabIndex = 2;
      this.lblSerie.Text = "Serie";
      // 
      // txtSerie
      // 
      this.txtSerie.Location = new System.Drawing.Point(408, 30);
      this.txtSerie.Name = "txtSerie";
      this.txtSerie.Size = new System.Drawing.Size(56, 20);
      this.txtSerie.TabIndex = 3;
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(491, 30);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(108, 20);
      this.txtNumero.TabIndex = 4;
      // 
      // lblFecha
      // 
      this.lblFecha.AutoSize = true;
      this.lblFecha.Location = new System.Drawing.Point(26, 84);
      this.lblFecha.Name = "lblFecha";
      this.lblFecha.Size = new System.Drawing.Size(37, 13);
      this.lblFecha.TabIndex = 5;
      this.lblFecha.Text = "Fecha";
      // 
      // dtpFecha
      // 
      this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpFecha.Location = new System.Drawing.Point(92, 77);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(126, 20);
      this.dtpFecha.TabIndex = 6;
      // 
      // lblCliente
      // 
      this.lblCliente.AutoSize = true;
      this.lblCliente.Location = new System.Drawing.Point(26, 130);
      this.lblCliente.Name = "lblCliente";
      this.lblCliente.Size = new System.Drawing.Size(39, 13);
      this.lblCliente.TabIndex = 7;
      this.lblCliente.Text = "Cliente";
      // 
      // txtCliente
      // 
      this.txtCliente.Location = new System.Drawing.Point(92, 123);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.ReadOnly = true;
      this.txtCliente.Size = new System.Drawing.Size(372, 20);
      this.txtCliente.TabIndex = 8;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(470, 120);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 23);
      this.btnBuscar.TabIndex = 9;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // dgvDetalles
      // 
      this.dgvDetalles.AllowUserToAddRows = false;
      this.dgvDetalles.AllowUserToDeleteRows = false;
      this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdProducto,
            this.cdCantidad,
            this.cdPrecioUnitario});
      this.dgvDetalles.Location = new System.Drawing.Point(6, 19);
      this.dgvDetalles.Name = "dgvDetalles";
      this.dgvDetalles.ReadOnly = true;
      this.dgvDetalles.Size = new System.Drawing.Size(451, 233);
      this.dgvDetalles.TabIndex = 0;
      // 
      // cdProducto
      // 
      this.cdProducto.DataPropertyName = "NombreProducto";
      this.cdProducto.HeaderText = "Producto";
      this.cdProducto.Name = "cdProducto";
      this.cdProducto.ReadOnly = true;
      this.cdProducto.Width = 200;
      // 
      // cdCantidad
      // 
      this.cdCantidad.DataPropertyName = "Cantidad";
      this.cdCantidad.HeaderText = "Cantidad";
      this.cdCantidad.Name = "cdCantidad";
      this.cdCantidad.ReadOnly = true;
      // 
      // cdPrecioUnitario
      // 
      this.cdPrecioUnitario.DataPropertyName = "PrecioUnitario";
      this.cdPrecioUnitario.HeaderText = "Precio Unitario";
      this.cdPrecioUnitario.Name = "cdPrecioUnitario";
      this.cdPrecioUnitario.ReadOnly = true;
      // 
      // gbDetalles
      // 
      this.gbDetalles.Controls.Add(this.dgvDetalles);
      this.gbDetalles.Controls.Add(this.btnEliminar);
      this.gbDetalles.Controls.Add(this.btnAgregar);
      this.gbDetalles.Location = new System.Drawing.Point(29, 174);
      this.gbDetalles.Name = "gbDetalles";
      this.gbDetalles.Size = new System.Drawing.Size(570, 273);
      this.gbDetalles.TabIndex = 10;
      this.gbDetalles.TabStop = false;
      this.gbDetalles.Text = "Detalles";
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(475, 104);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 2;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(475, 19);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(75, 23);
      this.btnAgregar.TabIndex = 1;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(432, 473);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 11;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(524, 473);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 12;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // frmVenta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(623, 508);
      this.Controls.Add(this.gbDetalles);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtCliente);
      this.Controls.Add(this.lblCliente);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.txtNumero);
      this.Controls.Add(this.txtSerie);
      this.Controls.Add(this.cboDocumento);
      this.Controls.Add(this.lblFecha);
      this.Controls.Add(this.lblSerie);
      this.Controls.Add(this.lblDocumento);
      this.Name = "frmVenta";
      this.Text = "Venta";
      ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
      this.gbDetalles.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.ComboBox cboDocumento;
    private System.Windows.Forms.Label lblSerie;
    private System.Windows.Forms.TextBox txtSerie;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.Label lblFecha;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Label lblCliente;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.DataGridView dgvDetalles;
    private System.Windows.Forms.GroupBox gbDetalles;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdProducto;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdCantidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdPrecioUnitario;
  }
}