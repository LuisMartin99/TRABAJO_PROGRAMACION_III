namespace AplicacionMDI
{
  partial class frmDetalleVenta
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
      this.lblProducto = new System.Windows.Forms.Label();
      this.cboProducto = new System.Windows.Forms.ComboBox();
      this.lblPrecio = new System.Windows.Forms.Label();
      this.txtPrecio = new System.Windows.Forms.TextBox();
      this.lblCantidad = new System.Windows.Forms.Label();
      this.nudCantidad = new System.Windows.Forms.NumericUpDown();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
      this.SuspendLayout();
      // 
      // lblProducto
      // 
      this.lblProducto.AutoSize = true;
      this.lblProducto.Location = new System.Drawing.Point(26, 35);
      this.lblProducto.Name = "lblProducto";
      this.lblProducto.Size = new System.Drawing.Size(50, 13);
      this.lblProducto.TabIndex = 0;
      this.lblProducto.Text = "Producto";
      // 
      // cboProducto
      // 
      this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboProducto.FormattingEnabled = true;
      this.cboProducto.Location = new System.Drawing.Point(119, 27);
      this.cboProducto.Name = "cboProducto";
      this.cboProducto.Size = new System.Drawing.Size(271, 21);
      this.cboProducto.TabIndex = 1;
      // 
      // lblPrecio
      // 
      this.lblPrecio.AutoSize = true;
      this.lblPrecio.Location = new System.Drawing.Point(26, 94);
      this.lblPrecio.Name = "lblPrecio";
      this.lblPrecio.Size = new System.Drawing.Size(37, 13);
      this.lblPrecio.TabIndex = 2;
      this.lblPrecio.Text = "Precio";
      // 
      // txtPrecio
      // 
      this.txtPrecio.Location = new System.Drawing.Point(119, 87);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.ReadOnly = true;
      this.txtPrecio.Size = new System.Drawing.Size(100, 20);
      this.txtPrecio.TabIndex = 3;
      this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblCantidad
      // 
      this.lblCantidad.AutoSize = true;
      this.lblCantidad.Location = new System.Drawing.Point(26, 139);
      this.lblCantidad.Name = "lblCantidad";
      this.lblCantidad.Size = new System.Drawing.Size(49, 13);
      this.lblCantidad.TabIndex = 4;
      this.lblCantidad.Text = "Cantidad";
      // 
      // nudCantidad
      // 
      this.nudCantidad.Location = new System.Drawing.Point(119, 132);
      this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudCantidad.Name = "nudCantidad";
      this.nudCantidad.Size = new System.Drawing.Size(59, 20);
      this.nudCantidad.TabIndex = 5;
      this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(207, 209);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 6;
      this.btnAceptar.Text = "Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(315, 209);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 7;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // frmDetalleVenta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(406, 269);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.Controls.Add(this.nudCantidad);
      this.Controls.Add(this.txtPrecio);
      this.Controls.Add(this.lblCantidad);
      this.Controls.Add(this.lblPrecio);
      this.Controls.Add(this.cboProducto);
      this.Controls.Add(this.lblProducto);
      this.Name = "frmDetalleVenta";
      this.Text = "frmDetalleVenta";
      this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblProducto;
    private System.Windows.Forms.ComboBox cboProducto;
    private System.Windows.Forms.Label lblPrecio;
    private System.Windows.Forms.TextBox txtPrecio;
    private System.Windows.Forms.Label lblCantidad;
    private System.Windows.Forms.NumericUpDown nudCantidad;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
  }
}