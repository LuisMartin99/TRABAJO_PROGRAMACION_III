namespace AplicacionMDI
{
  partial class frmBuscarCliente
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
      this.lblCliente = new System.Windows.Forms.Label();
      this.txtCliente = new System.Windows.Forms.TextBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.dgvClientes = new System.Windows.Forms.DataGridView();
      this.btnSeleccionar = new System.Windows.Forms.Button();
      this.btnlistar = new System.Windows.Forms.Button();
      this.cdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
      this.SuspendLayout();
      // 
      // lblCliente
      // 
      this.lblCliente.AutoSize = true;
      this.lblCliente.Location = new System.Drawing.Point(30, 43);
      this.lblCliente.Name = "lblCliente";
      this.lblCliente.Size = new System.Drawing.Size(39, 13);
      this.lblCliente.TabIndex = 0;
      this.lblCliente.Text = "Cliente";
      // 
      // txtCliente
      // 
      this.txtCliente.Location = new System.Drawing.Point(93, 40);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new System.Drawing.Size(264, 20);
      this.txtCliente.TabIndex = 1;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(574, 387);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 2;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // dgvClientes
      // 
      this.dgvClientes.AllowUserToAddRows = false;
      this.dgvClientes.AllowUserToDeleteRows = false;
      this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdCliente,
            this.cdDocumento});
      this.dgvClientes.Location = new System.Drawing.Point(33, 84);
      this.dgvClientes.Name = "dgvClientes";
      this.dgvClientes.ReadOnly = true;
      this.dgvClientes.Size = new System.Drawing.Size(616, 265);
      this.dgvClientes.TabIndex = 3;
      // 
      // btnSeleccionar
      // 
      this.btnSeleccionar.Location = new System.Drawing.Point(478, 387);
      this.btnSeleccionar.Name = "btnSeleccionar";
      this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
      this.btnSeleccionar.TabIndex = 2;
      this.btnSeleccionar.Text = "Seleccionar";
      this.btnSeleccionar.UseVisualStyleBackColor = true;
      this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
      // 
      // btnlistar
      // 
      this.btnlistar.Location = new System.Drawing.Point(377, 40);
      this.btnlistar.Name = "btnlistar";
      this.btnlistar.Size = new System.Drawing.Size(75, 23);
      this.btnlistar.TabIndex = 2;
      this.btnlistar.Text = "Listar";
      this.btnlistar.UseVisualStyleBackColor = true;
      this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
      // 
      // cdCliente
      // 
      this.cdCliente.DataPropertyName = "NombreCompleto";
      this.cdCliente.HeaderText = "Cliente";
      this.cdCliente.Name = "cdCliente";
      this.cdCliente.ReadOnly = true;
      this.cdCliente.Width = 300;
      // 
      // cdDocumento
      // 
      this.cdDocumento.DataPropertyName = "Documento";
      this.cdDocumento.HeaderText = "Documento";
      this.cdDocumento.Name = "cdDocumento";
      this.cdDocumento.ReadOnly = true;
      this.cdDocumento.Width = 150;
      // 
      // frmBuscarCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(666, 427);
      this.Controls.Add(this.dgvClientes);
      this.Controls.Add(this.btnlistar);
      this.Controls.Add(this.btnSeleccionar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.txtCliente);
      this.Controls.Add(this.lblCliente);
      this.Name = "frmBuscarCliente";
      this.Text = "Buscar cliente";
      ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblCliente;
    private System.Windows.Forms.TextBox txtCliente;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.DataGridView dgvClientes;
    private System.Windows.Forms.Button btnSeleccionar;
    private System.Windows.Forms.Button btnlistar;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdDocumento;
  }
}