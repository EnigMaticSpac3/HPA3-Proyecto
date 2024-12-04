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
            tabControlPrincipal = new TabControl();
            tabLista = new TabPage();
            tabNuevo = new TabPage();
            tabEditar = new TabPage();
            label1 = new Label();
            dgvCategorias = new DataGridView();
            btnNuevoLista = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            txtNombreNuevoCategoria = new TextBox();
            label_Nombre = new Label();
            label_Medida = new Label();
            cbbNuevoMedida = new ComboBox();
            btnVolverNuevo = new Button();
            btnNuevoGuardar = new Button();
            tabControlPrincipal.SuspendLayout();
            tabLista.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
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
            // tabEditar
            // 
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(725, 263);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
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
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(26, 56);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvCategorias.Size = new Size(674, 185);
            dgvCategorias.TabIndex = 1;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Location = new Point(26, 27);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(111, 23);
            btnNuevoLista.TabIndex = 2;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(589, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(334, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(249, 23);
            txtBuscar.TabIndex = 4;
            // 
            // txtNombreNuevoCategoria
            // 
            txtNombreNuevoCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtNombreNuevoCategoria.Location = new Point(28, 54);
            txtNombreNuevoCategoria.Name = "txtNombreNuevoCategoria";
            txtNombreNuevoCategoria.Size = new Size(376, 23);
            txtNombreNuevoCategoria.TabIndex = 0;
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
            // label_Medida
            // 
            label_Medida.AutoSize = true;
            label_Medida.Location = new Point(28, 132);
            label_Medida.Name = "label_Medida";
            label_Medida.Size = new Size(47, 15);
            label_Medida.TabIndex = 2;
            label_Medida.Text = "Medida";
            // 
            // cbbNuevoMedida
            // 
            cbbNuevoMedida.FormattingEnabled = true;
            cbbNuevoMedida.Location = new Point(28, 150);
            cbbNuevoMedida.Name = "cbbNuevoMedida";
            cbbNuevoMedida.Size = new Size(376, 23);
            cbbNuevoMedida.TabIndex = 3;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Location = new Point(28, 225);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(111, 23);
            btnVolverNuevo.TabIndex = 4;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoGuardar
            // 
            btnNuevoGuardar.Location = new Point(559, 225);
            btnNuevoGuardar.Name = "btnNuevoGuardar";
            btnNuevoGuardar.Size = new Size(111, 23);
            btnNuevoGuardar.TabIndex = 5;
            btnNuevoGuardar.Text = "Guardar";
            btnNuevoGuardar.UseVisualStyleBackColor = true;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(label1);
            Controls.Add(tabControlPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            Text = "frmCategoria";
            tabControlPrincipal.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
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
    }
}