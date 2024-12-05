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
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(0, 300);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 100);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            


            lblCliente = new Label();
            txtCliente = new TextBox();
            lblProducto = new Label();
            cboProductos = new ComboBox();
            dgvDetalleVenta = new DataGridView();
            btnAgregarProducto = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnRegistrarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(63, 6);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(12, 42);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(71, 39);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(192, 23);
            cboProductos.TabIndex = 3;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(25, 68);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(663, 150);
            dgvDetalleVenta.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(269, 37);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(15, 245);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(63, 242);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(184, 240);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(75, 23);
            btnRegistrarVenta.TabIndex = 8;
            btnRegistrarVenta.Text = "Registrar";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            ClientSize = new Size(727, 281);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(cboProductos);
            Controls.Add(lblProducto);
            Controls.Add(txtCliente);
            this.Controls.Add(this.btnVolver);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Controls.Add(lblCliente);
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
            
        }

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnVolver;
    }
}
