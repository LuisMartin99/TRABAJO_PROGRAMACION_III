namespace AplicacionMDI
{
  partial class frmListadoVentas
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnListar = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.dgvListado = new System.Windows.Forms.DataGridView();
      this.cdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
      this.SuspendLayout();
      // 
      // btnListar
      // 
      this.btnListar.Location = new System.Drawing.Point(31, 22);
      this.btnListar.Name = "btnListar";
      this.btnListar.Size = new System.Drawing.Size(75, 23);
      this.btnListar.TabIndex = 0;
      this.btnListar.Text = "Listar";
      this.btnListar.UseVisualStyleBackColor = true;
      this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.Location = new System.Drawing.Point(592, 415);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(75, 23);
      this.btnCerrar.TabIndex = 2;
      this.btnCerrar.Text = "Cerrar";
      this.btnCerrar.UseVisualStyleBackColor = true;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // dgvListado
      // 
      this.dgvListado.AllowUserToAddRows = false;
      this.dgvListado.AllowUserToDeleteRows = false;
      this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdDocumento,
            this.cdFecha,
            this.cdTotal});
      this.dgvListado.Location = new System.Drawing.Point(31, 54);
      this.dgvListado.Name = "dgvListado";
      this.dgvListado.ReadOnly = true;
      this.dgvListado.Size = new System.Drawing.Size(636, 351);
      this.dgvListado.TabIndex = 1;
      // 
      // cdDocumento
      // 
      this.cdDocumento.DataPropertyName = "Documento";
      this.cdDocumento.HeaderText = "Documento";
      this.cdDocumento.Name = "cdDocumento";
      this.cdDocumento.ReadOnly = true;
      this.cdDocumento.Width = 200;
      // 
      // cdFecha
      // 
      this.cdFecha.DataPropertyName = "Fecha";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle1.Format = "G";
      dataGridViewCellStyle1.NullValue = null;
      this.cdFecha.DefaultCellStyle = dataGridViewCellStyle1;
      this.cdFecha.HeaderText = "Fecha";
      this.cdFecha.Name = "cdFecha";
      this.cdFecha.ReadOnly = true;
      this.cdFecha.Width = 150;
      // 
      // cdTotal
      // 
      this.cdTotal.DataPropertyName = "Total";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "N2";
      this.cdTotal.DefaultCellStyle = dataGridViewCellStyle2;
      this.cdTotal.HeaderText = "Total";
      this.cdTotal.Name = "cdTotal";
      this.cdTotal.ReadOnly = true;
      this.cdTotal.Width = 150;
      // 
      // frmListadoVentas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(689, 450);
      this.Controls.Add(this.dgvListado);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.btnListar);
      this.Name = "frmListadoVentas";
      this.Text = "Listado de ventas";
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnListar;
    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.DataGridView dgvListado;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdDocumento;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdFecha;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdTotal;
  }
}