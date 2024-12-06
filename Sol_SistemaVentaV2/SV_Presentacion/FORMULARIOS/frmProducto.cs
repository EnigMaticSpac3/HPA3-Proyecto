using SV_Presentacion.Utilidades;
using SV_Presentacion.Utilidades.Objetos;
using SV_Presentacion.VistaModelo;
using SV_Repositorio.ENTIDADES;
using SV_Servicios.INTERFACES;

namespace SV_Presentacion.FORMULARIOS
{
    public partial class frmProducto : Form
    {
        private readonly ICategoriaServicios _categoriaServicios;
        private readonly IProductoServicios _productoServicios;

        public frmProducto(ICategoriaServicios categoriaServicios, IProductoServicios productoServicios)
        {
            InitializeComponent();
            _categoriaServicios = categoriaServicios;
            _productoServicios = productoServicios;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarTab(string tabName)
        {
            var TabsMenus = new TabPage[] { tabLista, tabNuevo, tabEditar };

            foreach (var tab in TabsMenus)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlPrincipal;
                }
            }
        }

        private async Task MostrarProducto(string buscar = "")
        {
            var listaProducto = await _productoServicios.listaProducto(buscar);

            var listaVM = listaProducto.Select(item => new VistaProducto
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Descripcion = item.Descripcion,
                NombreCategoria = item.RefCategoria.NombreCategoria,
                PrecioCompra = item.PrecioCompra,
                PrecioVenta = item.PrecioVenta,
                Cantidad = item.Cantidad,
                Activo = item.Activo,
                Habilitado = item.Activo == true ? "SI" : "NO"
            }).ToList();

            dgvProductos.DataSource = listaVM;

            // Ocultar columnas no deseadas
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            // Solo mostrar el tab de lista
            MostrarTab(tabLista.Name);
            await MostrarProducto(txtBuscar.Text);

            dgvProductos.ImplementarConfiguracion("Editar");
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cargar categorías en el ComboBox
            var listaCategorias = await _categoriaServicios.listaCategoria();
            if (listaCategorias.Count > 0)
            {
                var items = listaCategorias.Select(item => new OpcionCombo
                {
                    Texto = item.NombreCategoria,
                    Valor = item.IdCategoria
                }).ToArray();

                cboCategoria.InsertarItems(items);
            }
            else
            {
                MessageBox.Show("No hay categorías disponibles. Agregue al menos una categoría.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            await MostrarProducto(txtBuscar.Text);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cboCategoria.Items.Count == 0)
            {
                MessageBox.Show("Debe haber al menos una categoría para agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar los campos del formulario
            LimpiarCamposNuevo();

            // Mostrar la pestaña para agregar
            tabLista.Parent = null;
            tabEditar.Parent = null;
            MostrarTab(tabNuevo.Name);
        }


        private void LimpiarCamposNuevo()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";

            if (cboCategoria.Items.Count > 0)
            {
                cboCategoria.SelectedIndex = 0;
            }
        }


        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }
        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los datos del producto editado
            var categoriaSeleccionada = (OpcionCombo)cboCategoria.SelectedItem!;
            
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvProductos.SelectedRows[0].Cells["IdProducto"].Value is not int idProducto)
            {
                MessageBox.Show("No se pudo obtener el ID del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var productoEditado = new Producto
            {
                IdProducto = idProducto, // Asignar el IdProducto de la fila seleccionada
                Codigo = txtCodigo.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                RefCategoria = new Categoria { IdCategoria = categoriaSeleccionada.Valor },
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                Cantidad = int.Parse(txtCantidad.Text)
            };

            // Llamada al servicio para editar el producto
            var respuesta = await _productoServicios.EditarProducto(productoEditado);

            if (!string.IsNullOrEmpty(respuesta))
            {
                // Si hay algún error, lo mostramos
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si la actualización fue exitosa
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver a cargar la lista de productos
                await MostrarProducto();

                // Volver a la pestaña de lista
                MostrarTab(tabLista.Name);
            }
        }

        private async void btnNuevoGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var categoriaSeleccionada = (OpcionCombo)cboCategoria.SelectedItem!;

            var objeto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                RefCategoria = new Categoria { IdCategoria = categoriaSeleccionada.Valor },
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                Cantidad = int.Parse(txtCantidad.Text)
            };

            var respuesta = await _productoServicios.CrearProducto(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                await MostrarProducto();
                MostrarTab(tabLista.Name);
            }
        }
    }
}