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
            tabControlVentas = new TabControl();
            tabRealizarVenta = new TabPage();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblProducto = new Label();
            cboProductos = new ComboBox();
            dgvDetalleVenta = new DataGridView();
            btnAgregarProducto = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnRegistrarVenta = new Button();
            tabVerVentas = new TabPage();
            dgvVentas = new DataGridView();
            label1 = new Label();
            cbUsuarios = new ComboBox();
            tabControlVentas.SuspendLayout();
            tabRealizarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            tabVerVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // tabControlVentas
            // 
            tabControlVentas.Controls.Add(tabRealizarVenta);
            tabControlVentas.Controls.Add(tabVerVentas);
            tabControlVentas.Dock = DockStyle.Fill;
            tabControlVentas.Location = new Point(0, 0);
            tabControlVentas.Name = "tabControlVentas";
            tabControlVentas.SelectedIndex = 0;
            tabControlVentas.Size = new Size(800, 450);
            tabControlVentas.TabIndex = 0;
            // 
            // tabRealizarVenta
            // 
            tabRealizarVenta.Controls.Add(cbUsuarios);
            tabRealizarVenta.Controls.Add(label1);
            tabRealizarVenta.Controls.Add(lblCliente);
            tabRealizarVenta.Controls.Add(txtCliente);
            tabRealizarVenta.Controls.Add(lblProducto);
            tabRealizarVenta.Controls.Add(cboProductos);
            tabRealizarVenta.Controls.Add(dgvDetalleVenta);
            tabRealizarVenta.Controls.Add(btnAgregarProducto);
            tabRealizarVenta.Controls.Add(lblTotal);
            tabRealizarVenta.Controls.Add(txtTotal);
            tabRealizarVenta.Controls.Add(btnRegistrarVenta);
            tabRealizarVenta.Location = new Point(4, 24);
            tabRealizarVenta.Name = "tabRealizarVenta";
            tabRealizarVenta.Padding = new Padding(3);
            tabRealizarVenta.Size = new Size(792, 422);
            tabRealizarVenta.TabIndex = 0;
            tabRealizarVenta.Text = "Realizar Venta";
            tabRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 20);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(73, 17);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 60);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(85, 57);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(188, 23);
            cboProductos.TabIndex = 3;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(20, 100);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(750, 200);
            dgvDetalleVenta.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(285, 57);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(20, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(73, 317);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(200, 315);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(100, 23);
            btnRegistrarVenta.TabIndex = 8;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // tabVerVentas
            // 
            tabVerVentas.Controls.Add(dgvVentas);
            tabVerVentas.Location = new Point(4, 24);
            tabVerVentas.Name = "tabVerVentas";
            tabVerVentas.Padding = new Padding(3);
            tabVerVentas.Size = new Size(792, 422);
            tabVerVentas.TabIndex = 1;
            tabVerVentas.Text = "Ver Ventas";
            tabVerVentas.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(20, 20);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(750, 380);
            dgvVentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 69);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 9;
            label1.Text = "Usuario:";
            // 
            // cbUsuarios
            // 
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(582, 66);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(188, 23);
            cbUsuarios.TabIndex = 10;
            // 
            // frmVenta
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlVentas);
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Ventas";
            tabControlVentas.ResumeLayout(false);
            tabRealizarVenta.ResumeLayout(false);
            tabRealizarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            tabVerVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
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
        private ComboBox cbUsuarios;
        private Label label1;
    }
}
