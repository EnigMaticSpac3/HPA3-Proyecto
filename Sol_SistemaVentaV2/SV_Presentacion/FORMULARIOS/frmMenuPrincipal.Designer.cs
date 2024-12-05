namespace SV_Presentacion.FORMULARIOS
{
    partial class frmMenuPrincipal
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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategoria.Location = new System.Drawing.Point(100, 50);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(200, 50);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "Gestión de Categorías";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProducto.Location = new System.Drawing.Point(100, 120);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(200, 50);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "Gestión de Productos";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenta.Location = new System.Drawing.Point(100, 190);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(200, 50);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Gestión de Ventas";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnCategoria);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnVenta;
    }
}
