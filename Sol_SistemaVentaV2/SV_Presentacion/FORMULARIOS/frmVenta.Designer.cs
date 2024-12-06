namespace SV_Presentacion.FORMULARIOS
{
    partial class frmVenta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlVentas = new System.Windows.Forms.TabControl();
            this.tabRealizarVenta = new System.Windows.Forms.TabPage();
            this.tabVerVentas = new System.Windows.Forms.TabPage();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.tabControlVentas.SuspendLayout();
            this.tabRealizarVenta.SuspendLayout();
            this.tabVerVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlVentas
            // 
            this.tabControlVentas.Controls.Add(this.tabRealizarVenta);
            this.tabControlVentas.Controls.Add(this.tabVerVentas);
            this.tabControlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVentas.Location = new System.Drawing.Point(0, 0);
            this.tabControlVentas.Name = "tabControlVentas";
            this.tabControlVentas.SelectedIndex = 0;
            this.tabControlVentas.Size = new System.Drawing.Size(800, 450);
            this.tabControlVentas.TabIndex = 0;
            // 
            // tabRealizarVenta
            // 
            this.tabRealizarVenta.Controls.Add(this.lblCliente);
            this.tabRealizarVenta.Controls.Add(this.txtCliente);
            this.tabRealizarVenta.Controls.Add(this.lblProducto);
            this.tabRealizarVenta.Controls.Add(this.cboProductos);
            this.tabRealizarVenta.Controls.Add(this.dgvDetalleVenta);
            this.tabRealizarVenta.Controls.Add(this.btnAgregarProducto);
            this.tabRealizarVenta.Controls.Add(this.lblTotal);
            this.tabRealizarVenta.Controls.Add(this.txtTotal);
            this.tabRealizarVenta.Controls.Add(this.btnRegistrarVenta);
            this.tabRealizarVenta.Location = new System.Drawing.Point(4, 24);
            this.tabRealizarVenta.Name = "tabRealizarVenta";
            this.tabRealizarVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabRealizarVenta.Size = new System.Drawing.Size(792, 422);
            this.tabRealizarVenta.TabIndex = 0;
            this.tabRealizarVenta.Text = "Realizar Venta";
            this.tabRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // tabVerVentas
            // 
            this.tabVerVentas.Controls.Add(this.dgvVentas);
            this.tabVerVentas.Location = new System.Drawing.Point(4, 24);
            this.tabVerVentas.Name = "tabVerVentas";
            this.tabVerVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerVentas.Size = new System.Drawing.Size(792, 422);
            this.tabVerVentas.TabIndex = 1;
            this.tabVerVentas.Text = "Ver Ventas";
            this.tabVerVentas.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(73, 17);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(200, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(20, 60);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(59, 15);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(85, 57);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(188, 23);
            this.cboProductos.TabIndex = 3;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(20, 100);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(750, 200);
            this.dgvDetalleVenta.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(285, 57);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(73, 317);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.ReadOnly = true;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(200, 315);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrarVenta.TabIndex = 8;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(20, 20);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(750, 380);
            this.dgvVentas.TabIndex = 0;
            // 
            // frmVenta
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlVentas);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Ventas";
            this.tabControlVentas.ResumeLayout(false);
            this.tabRealizarVenta.ResumeLayout(false);
            this.tabRealizarVenta.PerformLayout();
            this.tabVerVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlVentas;
        private System.Windows.Forms.TabPage tabRealizarVenta;
        private System.Windows.Forms.TabPage tabVerVentas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}
