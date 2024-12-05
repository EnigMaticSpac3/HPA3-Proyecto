namespace SV_Presentacion.FORMULARIOS
{
    partial class frmProducto
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
            btnVolver = new Button();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecioCompra = new Label();
            txtPrecioCompra = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioVenta = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            dgvProductos = new DataGridView();
            btnAgregarProducto = new Button();
            btnBuscarProducto = new Button();
            tabControlPrincipal = new TabControl();
            tabLista = new TabPage();
            txtBuscar = new TextBox();
            tabNuevo = new TabPage();
            btnNuevoGuardar = new Button();
            btnVolverNuevo = new Button();
            lblCategoriaNuevo = new Label();
            cboCategoriaNuevo = new ComboBox();
            lblCodigoNuevo = new Label();
            txtCodigoNuevo = new TextBox();
            lblDescripcionNuevo = new Label();
            txtDescripcionNuevo = new TextBox();
            lblPrecioCompraNuevo = new Label();
            txtPrecioCompraNuevo = new TextBox();
            lblPrecioVentaNuevo = new Label();
            txtPrecioVentaNuevo = new TextBox();
            lblCantidadNuevo = new Label();
            txtCantidadNuevo = new TextBox();
            tabEditar = new TabPage();
            btnGuardarEditar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabControlPrincipal.SuspendLayout();
            tabLista.SuspendLayout();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(325, 388);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(76, 6);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(200, 23);
            cboCategoria.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 42);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(76, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(76, 72);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(12, 108);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(89, 15);
            lblPrecioCompra.TabIndex = 6;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(104, 105);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 7;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(12, 141);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(75, 15);
            lblPrecioVenta.TabIndex = 8;
            lblPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(104, 138);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 174);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(76, 171);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 11;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(27, 59);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(663, 181);
            dgvProductos.TabIndex = 12;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(27, 30);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 13;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(615, 30);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(75, 23);
            btnBuscarProducto.TabIndex = 14;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabLista);
            tabControlPrincipal.Controls.Add(tabNuevo);
            tabControlPrincipal.Controls.Add(tabEditar);
            tabControlPrincipal.ItemSize = new Size(80, 20);
            tabControlPrincipal.Location = new Point(24, 70);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(733, 291);
            tabControlPrincipal.TabIndex = 15;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(txtBuscar);
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(btnBuscarProducto);
            tabLista.Controls.Add(btnAgregarProducto);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(725, 263);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(449, 30);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(160, 23);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextAlign = HorizontalAlignment.Right;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnNuevoGuardar);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(lblCategoriaNuevo);
            tabNuevo.Controls.Add(cboCategoriaNuevo);
            tabNuevo.Controls.Add(lblCodigoNuevo);
            tabNuevo.Controls.Add(txtCodigoNuevo);
            tabNuevo.Controls.Add(lblDescripcionNuevo);
            tabNuevo.Controls.Add(txtDescripcionNuevo);
            tabNuevo.Controls.Add(lblPrecioCompraNuevo);
            tabNuevo.Controls.Add(txtPrecioCompraNuevo);
            tabNuevo.Controls.Add(lblPrecioVentaNuevo);
            tabNuevo.Controls.Add(txtPrecioVentaNuevo);
            tabNuevo.Controls.Add(lblCantidadNuevo);
            tabNuevo.Controls.Add(txtCantidadNuevo);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Size = new Size(725, 263);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            // 
            // btnNuevoGuardar
            // 
            btnNuevoGuardar.Location = new Point(558, 215);
            btnNuevoGuardar.Name = "btnNuevoGuardar";
            btnNuevoGuardar.Size = new Size(111, 23);
            btnNuevoGuardar.TabIndex = 5;
            btnNuevoGuardar.Text = "Guardar";
            btnNuevoGuardar.UseVisualStyleBackColor = true;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Location = new Point(28, 215);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(111, 23);
            btnVolverNuevo.TabIndex = 4;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            // 
            // lblCategoriaNuevo
            // 
            lblCategoriaNuevo.AutoSize = true;
            lblCategoriaNuevo.Location = new Point(12, 9);
            lblCategoriaNuevo.Name = "lblCategoriaNuevo";
            lblCategoriaNuevo.Size = new Size(61, 15);
            lblCategoriaNuevo.TabIndex = 0;
            lblCategoriaNuevo.Text = "Categoría:";
            // 
            // cboCategoriaNuevo
            // 
            cboCategoriaNuevo.FormattingEnabled = true;
            cboCategoriaNuevo.Location = new Point(76, 6);
            cboCategoriaNuevo.Name = "cboCategoriaNuevo";
            cboCategoriaNuevo.Size = new Size(200, 23);
            cboCategoriaNuevo.TabIndex = 1;
            // 
            // lblCodigoNuevo
            // 
            lblCodigoNuevo.AutoSize = true;
            lblCodigoNuevo.Location = new Point(12, 42);
            lblCodigoNuevo.Name = "lblCodigoNuevo";
            lblCodigoNuevo.Size = new Size(49, 15);
            lblCodigoNuevo.TabIndex = 2;
            lblCodigoNuevo.Text = "Código:";
            // 
            // txtCodigoNuevo
            // 
            txtCodigoNuevo.Location = new Point(76, 39);
            txtCodigoNuevo.Name = "txtCodigoNuevo";
            txtCodigoNuevo.Size = new Size(200, 23);
            txtCodigoNuevo.TabIndex = 3;
            // 
            // lblDescripcionNuevo
            // 
            lblDescripcionNuevo.AutoSize = true;
            lblDescripcionNuevo.Location = new Point(12, 75);
            lblDescripcionNuevo.Name = "lblDescripcionNuevo";
            lblDescripcionNuevo.Size = new Size(72, 15);
            lblDescripcionNuevo.TabIndex = 4;
            lblDescripcionNuevo.Text = "Descripción:";
            // 
            // txtDescripcionNuevo
            // 
            txtDescripcionNuevo.Location = new Point(76, 72);
            txtDescripcionNuevo.Name = "txtDescripcionNuevo";
            txtDescripcionNuevo.Size = new Size(200, 23);
            txtDescripcionNuevo.TabIndex = 5;
            // 
            // lblPrecioCompraNuevo
            // 
            lblPrecioCompraNuevo.AutoSize = true;
            lblPrecioCompraNuevo.Location = new Point(12, 108);
            lblPrecioCompraNuevo.Name = "lblPrecioCompraNuevo";
            lblPrecioCompraNuevo.Size = new Size(89, 15);
            lblPrecioCompraNuevo.TabIndex = 6;
            lblPrecioCompraNuevo.Text = "Precio Compra:";
            // 
            // txtPrecioCompraNuevo
            // 
            txtPrecioCompraNuevo.Location = new Point(104, 105);
            txtPrecioCompraNuevo.Name = "txtPrecioCompraNuevo";
            txtPrecioCompraNuevo.Size = new Size(100, 23);
            txtPrecioCompraNuevo.TabIndex = 7;
            // 
            // lblPrecioVentaNuevo
            // 
            lblPrecioVentaNuevo.AutoSize = true;
            lblPrecioVentaNuevo.Location = new Point(12, 141);
            lblPrecioVentaNuevo.Name = "lblPrecioVentaNuevo";
            lblPrecioVentaNuevo.Size = new Size(75, 15);
            lblPrecioVentaNuevo.TabIndex = 8;
            lblPrecioVentaNuevo.Text = "Precio Venta:";
            // 
            // txtPrecioVentaNuevo
            // 
            txtPrecioVentaNuevo.Location = new Point(104, 138);
            txtPrecioVentaNuevo.Name = "txtPrecioVentaNuevo";
            txtPrecioVentaNuevo.Size = new Size(100, 23);
            txtPrecioVentaNuevo.TabIndex = 9;
            // 
            // lblCantidadNuevo
            // 
            lblCantidadNuevo.AutoSize = true;
            lblCantidadNuevo.Location = new Point(12, 174);
            lblCantidadNuevo.Name = "lblCantidadNuevo";
            lblCantidadNuevo.Size = new Size(58, 15);
            lblCantidadNuevo.TabIndex = 10;
            lblCantidadNuevo.Text = "Cantidad:";
            // 
            // txtCantidadNuevo
            // 
            txtCantidadNuevo.Location = new Point(76, 171);
            txtCantidadNuevo.Name = "txtCantidadNuevo";
            txtCantidadNuevo.Size = new Size(100, 23);
            txtCantidadNuevo.TabIndex = 11;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(button2);
            tabEditar.Controls.Add(txtCodigo);
            tabEditar.Controls.Add(txtDescripcion);
            tabEditar.Controls.Add(txtPrecioCompra);
            tabEditar.Controls.Add(txtPrecioVenta);
            tabEditar.Controls.Add(txtCantidad);
            tabEditar.Controls.Add(cboCategoria);
            tabEditar.Controls.Add(lblCategoria);
            tabEditar.Controls.Add(lblCodigo);
            tabEditar.Controls.Add(lblDescripcion);
            tabEditar.Controls.Add(lblPrecioCompra);
            tabEditar.Controls.Add(lblPrecioVenta);
            tabEditar.Controls.Add(lblCantidad);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Size = new Size(725, 263);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(558, 215);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(111, 23);
            btnGuardarEditar.TabIndex = 5;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(28, 215);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 4;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            ClientSize = new Size(784, 441);
            Controls.Add(tabControlPrincipal);
            Controls.Add(btnVolver);
            Name = "frmProducto";
            Text = "Gestionar Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabControlPrincipal.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
        }

        #region Componentes
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecioCompra;
        private TextBox txtPrecioCompra;
        private Label lblPrecioVenta;
        private TextBox txtPrecioVenta;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private DataGridView dgvProductos;
        private Button btnAgregarProducto;
        private Button btnBuscarProducto;
        private TabControl tabControlPrincipal;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private TabPage tabEditar;
        private Button btnNuevoGuardar;
        private Button btnVolverNuevo;
        private Button btnGuardarEditar;
        private Button button2;
        #endregion

        private TextBox txtBuscar;
        private System.Windows.Forms.Button btnVolver;
        private Label lblCategoriaNuevo;
        private ComboBox cboCategoriaNuevo;
        private Label lblCodigoNuevo;
        private TextBox txtCodigoNuevo;
        private Label lblDescripcionNuevo;
        private TextBox txtDescripcionNuevo;
        private Label lblPrecioCompraNuevo;
        private TextBox txtPrecioCompraNuevo;
        private Label lblPrecioVentaNuevo;
        private TextBox txtPrecioVentaNuevo;
        private Label lblCantidadNuevo;
        private TextBox txtCantidadNuevo;
    }
}
