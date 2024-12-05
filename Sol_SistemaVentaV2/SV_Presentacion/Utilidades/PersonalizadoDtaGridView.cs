namespace SV_Presentacion.Utilidades
{
    public static class PersonalizadoDtaGridView
    {
        public static void ImplementarConfiguracion (this DataGridView datagrid, string textoEnBoton="")
        {
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToResizeColumns = false;
            datagrid.AllowUserToResizeRows = false;
            datagrid.AllowUserToOrderColumns = false;
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ReadOnly = true;
            datagrid.BackgroundColor = Color.White;

            datagrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.DarkBlue,
                SelectionBackColor = Color.Gray,
                ForeColor = Color.White,
            };

            datagrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.LightCyan,
                SelectionForeColor = Color.Black,
            };

            datagrid.ColumnHeadersHeight = 30;
            datagrid.EnableHeadersVisualStyles = false; // para que no se muestre el estilo por defecto

            // permitir cambiar el alto y ancho de las cabeceras
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            if (textoEnBoton != "")
            {
                //Boton datagridview para redirigir a la ventana de editar
                var btnEditarColumna = new DataGridViewButtonColumn();
                btnEditarColumna.Text = textoEnBoton;
                btnEditarColumna.Name = "ColumnaAccion";
                btnEditarColumna.HeaderText = "";
                btnEditarColumna.UseColumnTextForButtonValue = true; //mostrar el texto en el boton
                btnEditarColumna.Width = 50;
                btnEditarColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                datagrid.Columns.Add(btnEditarColumna);
            }

        }
    }
}
