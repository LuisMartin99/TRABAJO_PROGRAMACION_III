namespace AplicacionMDI
{
  partial class frmPrincipal
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrabajadores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocumentoPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocumentoVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimiento,
            this.operacionesToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategorias,
            this.mnuProductos,
            this.toolStripMenuItem1,
            this.mnuClientes,
            this.mnuTrabajadores,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.mnuLocal,
            this.mnuDocumentoPersonas,
            this.mnuDocumentoVentas,
            this.toolStripMenuItem3,
            this.mnuSalir});
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(124, 24);
            this.mnuMantenimiento.Text = "&Mantenimiento";
            // 
            // mnuCategorias
            // 
            this.mnuCategorias.Name = "mnuCategorias";
            this.mnuCategorias.Size = new System.Drawing.Size(254, 26);
            this.mnuCategorias.Text = "Categorías";
            this.mnuCategorias.Click += new System.EventHandler(this.mnuCategorias_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(254, 26);
            this.mnuProductos.Text = "Productos";
            this.mnuProductos.Click += new System.EventHandler(this.mnuProductos_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(254, 26);
            this.mnuClientes.Text = "Cliente";
            // 
            // mnuTrabajadores
            // 
            this.mnuTrabajadores.Name = "mnuTrabajadores";
            this.mnuTrabajadores.Size = new System.Drawing.Size(254, 26);
            this.mnuTrabajadores.Text = "Trabajador";
            this.mnuTrabajadores.Click += new System.EventHandler(this.mnuTrabajadores_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(254, 26);
            this.toolStripMenuItem4.Text = "Usuario";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuLocal
            // 
            this.mnuLocal.Name = "mnuLocal";
            this.mnuLocal.Size = new System.Drawing.Size(254, 26);
            this.mnuLocal.Text = "Local";
            // 
            // mnuDocumentoPersonas
            // 
            this.mnuDocumentoPersonas.Name = "mnuDocumentoPersonas";
            this.mnuDocumentoPersonas.Size = new System.Drawing.Size(254, 26);
            this.mnuDocumentoPersonas.Text = "Documento de personas";
            // 
            // mnuDocumentoVentas
            // 
            this.mnuDocumentoVentas.Name = "mnuDocumentoVentas";
            this.mnuDocumentoVentas.Size = new System.Drawing.Size(254, 26);
            this.mnuDocumentoVentas.Text = "Documento de ventas";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(254, 26);
            this.mnuSalir.Text = "Salir";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVenta});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // mnuVenta
            // 
            this.mnuVenta.Name = "mnuVenta";
            this.mnuVenta.Size = new System.Drawing.Size(129, 26);
            this.mnuVenta.Text = "Venta";
            this.mnuVenta.Click += new System.EventHandler(this.mnuVenta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Módulo de ventas";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuPrincipal;
    private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
    private System.Windows.Forms.ToolStripMenuItem mnuCategorias;
    private System.Windows.Forms.ToolStripMenuItem mnuProductos;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuClientes;
    private System.Windows.Forms.ToolStripMenuItem mnuTrabajadores;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem mnuDocumentoPersonas;
    private System.Windows.Forms.ToolStripMenuItem mnuDocumentoVentas;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    private System.Windows.Forms.ToolStripMenuItem mnuLocal;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuVenta;
  }
}

