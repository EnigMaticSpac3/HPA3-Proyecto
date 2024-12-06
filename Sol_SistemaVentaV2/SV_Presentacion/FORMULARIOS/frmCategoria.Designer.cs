namespace SV_Presentacion.FORMULARIOS
{
    partial class frmCategoria
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
            btnVolverMenu = new Button();
            tabControlPrincipal = new TabControl();
            tabLista = new TabPage();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnNuevoLista = new Button();
            dgvCategorias = new DataGridView();
            tabNuevo = new TabPage();
            btnNuevoGuardar = new Button();
            btnVolverNuevo = new Button();
            cbbNuevoMedida = new ComboBox();
            label_Medida = new Label();
            label_Nombre = new Label();
            txtNombreNuevoCategoria = new TextBox();
            tabEditar = new TabPage();
            cbbHabilitado = new ComboBox();
            labelHabilitarEditar = new Label();
            btnEditarGuardar = new Button();
            button2 = new Button();
            cbbMedidaEditar = new ComboBox();
            label2 = new Label();
            labelEditarNombre = new Label();
            txtNombreEditar = new TextBox();
            label1 = new Label();
            tabControlPrincipal.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolverMenu.Location = new Point(340, 363);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(100, 30);
            btnVolverMenu.TabIndex = 0;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
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
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(txtBuscar);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Controls.Add(dgvCategorias);
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
            txtBuscar.Location = new Point(334, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(249, 23);
            txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(589, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Location = new Point(26, 27);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(111, 23);
            btnNuevoLista.TabIndex = 2;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(26, 56);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvCategorias.Size = new Size(674, 185);
            dgvCategorias.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnNuevoGuardar);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbNuevoMedida);
            tabNuevo.Controls.Add(label_Medida);
            tabNuevo.Controls.Add(label_Nombre);
            tabNuevo.Controls.Add(txtNombreNuevoCategoria);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(725, 263);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoGuardar
            // 
            btnNuevoGuardar.Location = new Point(558, 215);
            btnNuevoGuardar.Name = "btnNuevoGuardar";
            btnNuevoGuardar.Size = new Size(111, 23);
            btnNuevoGuardar.TabIndex = 5;
            btnNuevoGuardar.Text = "Guardar";
            btnNuevoGuardar.UseVisualStyleBackColor = true;
            btnNuevoGuardar.Click += btnNuevoGuardar_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Location = new Point(28, 215);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(111, 23);
            btnVolverNuevo.TabIndex = 4;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbNuevoMedida
            // 
            cbbNuevoMedida.FormattingEnabled = true;
            cbbNuevoMedida.Location = new Point(28, 150);
            cbbNuevoMedida.Name = "cbbNuevoMedida";
            cbbNuevoMedida.Size = new Size(376, 23);
            cbbNuevoMedida.TabIndex = 3;
            // 
            // label_Medida
            // 
            label_Medida.AutoSize = true;
            label_Medida.Location = new Point(28, 132);
            label_Medida.Name = "label_Medida";
            label_Medida.Size = new Size(47, 15);
            label_Medida.TabIndex = 2;
            label_Medida.Text = "Medida";
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Location = new Point(28, 36);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(51, 15);
            label_Nombre.TabIndex = 1;
            label_Nombre.Text = "Nombre";
            // 
            // txtNombreNuevoCategoria
            // 
            txtNombreNuevoCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtNombreNuevoCategoria.Location = new Point(28, 54);
            txtNombreNuevoCategoria.Name = "txtNombreNuevoCategoria";
            txtNombreNuevoCategoria.Size = new Size(376, 23);
            txtNombreNuevoCategoria.TabIndex = 0;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(labelHabilitarEditar);
            tabEditar.Controls.Add(btnEditarGuardar);
            tabEditar.Controls.Add(button2);
            tabEditar.Controls.Add(cbbMedidaEditar);
            tabEditar.Controls.Add(label2);
            tabEditar.Controls.Add(labelEditarNombre);
            tabEditar.Controls.Add(txtNombreEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(725, 263);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(42, 175);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(170, 23);
            cbbHabilitado.TabIndex = 13;
            // 
            // labelHabilitarEditar
            // 
            labelHabilitarEditar.AutoSize = true;
            labelHabilitarEditar.Location = new Point(42, 157);
            labelHabilitarEditar.Name = "labelHabilitarEditar";
            labelHabilitarEditar.Size = new Size(55, 15);
            labelHabilitarEditar.TabIndex = 12;
            labelHabilitarEditar.Text = "Habilitar:";
            // 
            // btnEditarGuardar
            // 
            btnEditarGuardar.Location = new Point(572, 223);
            btnEditarGuardar.Name = "btnEditarGuardar";
            btnEditarGuardar.Size = new Size(111, 23);
            btnEditarGuardar.TabIndex = 11;
            btnEditarGuardar.Text = "Guardar";
            btnEditarGuardar.UseVisualStyleBackColor = true;
            btnEditarGuardar.Click += btnEditarGuardar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 223);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 10;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbbMedidaEditar
            // 
            cbbMedidaEditar.FormattingEnabled = true;
            cbbMedidaEditar.Location = new Point(42, 111);
            cbbMedidaEditar.Name = "cbbMedidaEditar";
            cbbMedidaEditar.Size = new Size(376, 23);
            cbbMedidaEditar.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Medida:";
            // 
            // labelEditarNombre
            // 
            labelEditarNombre.AutoSize = true;
            labelEditarNombre.Location = new Point(42, 30);
            labelEditarNombre.Name = "labelEditarNombre";
            labelEditarNombre.Size = new Size(54, 15);
            labelEditarNombre.TabIndex = 7;
            labelEditarNombre.Text = "Nombre:";
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEditar.Location = new Point(42, 48);
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(376, 23);
            txtNombreEditar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO / CATEGORIAS";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(label1);
            Controls.Add(tabControlPrincipal);
            Controls.Add(btnVolverMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Categorías";
            Load += frmCategoria_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private Label label1;
        private TabPage tabEditar;
        private Button btnBuscar;
        private Button btnNuevoLista;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private ComboBox cbbNuevoMedida;
        private Label label_Medida;
        private Label label_Nombre;
        private TextBox txtNombreNuevoCategoria;
        private Button btnNuevoGuardar;
        private Button btnVolverNuevo;
        private Button btnEditarGuardar;
        private Button button2;
        private ComboBox cbbMedidaEditar;
        private Label label2;
        private Label labelEditarNombre;
        private TextBox txtNombreEditar;
        private ComboBox cbbHabilitado;
        private Label labelHabilitarEditar;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}