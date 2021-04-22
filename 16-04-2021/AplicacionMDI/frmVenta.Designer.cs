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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(35, 47);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 17);
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
            this.cboDocumento.Location = new System.Drawing.Point(123, 37);
            this.cboDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(167, 24);
            this.cboDocumento.TabIndex = 1;
            this.cboDocumento.SelectedIndexChanged += new System.EventHandler(this.cboDocumento_SelectedIndexChanged);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(473, 47);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(41, 17);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(544, 37);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(73, 22);
            this.txtSerie.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(655, 37);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(143, 22);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 103);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(123, 95);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(167, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(35, 160);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(123, 151);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(495, 22);
            this.txtCliente.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(627, 148);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar (F2)";
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
            this.dgvDetalles.Location = new System.Drawing.Point(8, 23);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(601, 287);
            this.dgvDetalles.TabIndex = 0;
            // 
            // cdProducto
            // 
            this.cdProducto.DataPropertyName = "NombreProducto";
            this.cdProducto.HeaderText = "Producto";
            this.cdProducto.MinimumWidth = 6;
            this.cdProducto.Name = "cdProducto";
            this.cdProducto.ReadOnly = true;
            this.cdProducto.Width = 200;
            // 
            // cdCantidad
            // 
            this.cdCantidad.DataPropertyName = "Cantidad";
            this.cdCantidad.HeaderText = "Cantidad";
            this.cdCantidad.MinimumWidth = 6;
            this.cdCantidad.Name = "cdCantidad";
            this.cdCantidad.ReadOnly = true;
            this.cdCantidad.Width = 125;
            // 
            // cdPrecioUnitario
            // 
            this.cdPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.cdPrecioUnitario.HeaderText = "Precio Unitario";
            this.cdPrecioUnitario.MinimumWidth = 6;
            this.cdPrecioUnitario.Name = "cdPrecioUnitario";
            this.cdPrecioUnitario.ReadOnly = true;
            this.cdPrecioUnitario.Width = 125;
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.dgvDetalles);
            this.gbDetalles.Controls.Add(this.btnEliminar);
            this.gbDetalles.Controls.Add(this.btnAgregar);
            this.gbDetalles.Location = new System.Drawing.Point(39, 214);
            this.gbDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetalles.Size = new System.Drawing.Size(760, 336);
            this.gbDetalles.TabIndex = 10;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(633, 128);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar (F4)";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(633, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar (F3)";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(576, 582);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar (F5)";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(699, 582);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar (F6)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 625);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVenta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}