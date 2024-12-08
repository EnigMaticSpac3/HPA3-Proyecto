using SV_Presentacion.Utilidades;
using SV_Presentacion.Utilidades.Objetos;
using SV_Presentacion.VistaModelo;
using SV_Repositorio.ENTIDADES;
using SV_Servicios.INTERFACES;

namespace SV_Presentacion.FORMULARIOS
{
    public partial class frmCategoria : Form
    {
        private readonly IMedidaServicios _medidaServicios;
        private readonly ICategoriaServicios _categoriaServicios;
        private Categoria _categoriaseleccionada;

        public frmCategoria(IMedidaServicios medidaServicios, ICategoriaServicios categoriaServicios)
        {
            InitializeComponent();
            _medidaServicios = medidaServicios;
            _categoriaServicios = categoriaServicios;
        }
        private void btnVolverMenu_Click(object sender, EventArgs e)
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

        private async Task MostrarCategoria(string buscar = "")
        {
            // cuando se carga el formulario se crea una variable y se utiliza esa variable para cargar los datos en el datagridview
            var listaCategoria = await _categoriaServicios.listaCategoria(buscar);

            var listaVM = listaCategoria.Select(item => new VistaCategoria
            {
                IdCategoria = item.IdCategoria,
                NombreCategoria = item.NombreCategoria,
                Activo = item.Activo,
                IdMedida = item.RefMedida.IdMedida,
                NombreMedida = item.RefMedida.NomMedida,
                Habilitado = item.Activo == 1 ? "SI" : "NO"
            }).ToList();

            dgvCategorias.DataSource = listaVM;

            // se ocultan las columnas que no se quieren mostrar
            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
            dgvCategorias.Columns["IdMedida"].Visible = false;
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            // solo mostrar el tab de lista
            MostrarTab(tabLista.Name);

            // si no se pone text no se muestra el boton
            dgvCategorias.ImplementarConfiguracion("Editar");
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarCategoria();

            OpcionCombo[] itemsHabilitado = new OpcionCombo[]
            {
                new OpcionCombo{Texto = "SI", Valor = 1},
                new OpcionCombo{Texto = "NO", Valor = 0}
            };

            var listaMedida = await _medidaServicios.listaMedida();
            var items = listaMedida.Select(item => new OpcionCombo
            {
                Texto = item.NomMedida,
                Valor = item.IdMedida
            }).ToArray();

            cbbNuevoMedida.InsertarItems(items);
            cbbMedidaEditar.InsertarItems(items);
            cbbHabilitado.InsertarItems(itemsHabilitado);

            // Suscribir el evento en el constructor o en el evento Load del formulario.
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick!;



        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarCategoria(txtBuscar.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            txtNombreNuevoCategoria.Text = ""; //limpia el campo
            cbbNuevoMedida.SelectedIndex = 0; // selecciona el primer item
            txtNombreEditar.Select(); // selecciona el campo

            tabLista.Parent = null; // oculta el tab
            tabEditar.Parent = null; // oculta el tab

            MostrarTab(tabNuevo.Name);

        }

        // Este es el evento que captura cuando se hace clic en una celda del DataGridView.
        private async void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna del botón "Editar" (columna con el nombre "ColumnaAccion").
            if (e.ColumnIndex == dgvCategorias.Columns["ColumnaAccion"].Index)
            {
                // Limpiar los campos de la pestaña de edición
                txtNombreEditar.Text = ""; // Limpiar campo nombre
                cbbMedidaEditar.SelectedIndex = 0; // Seleccionar el primer item
                cbbHabilitado.SelectedIndex = 0; // Seleccionar el primer item

                // Seleccionar el campo de texto para facilitar la edición
                txtNombreEditar.Select();

                // Ocultar la pestaña de lista y nueva
                tabLista.Parent = null;
                tabNuevo.Parent = null;

                // Obtener el IdCategoria de la fila seleccionada
                int idCategoria = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells["IdCategoria"].Value);

                // Usar el IdCategoria para cargar los detalles de la categoría a editar
                var categoria = await _categoriaServicios.ObtenerCategoriaPorId(idCategoria);

                _categoriaseleccionada = categoria;

                // Si la categoría se encuentra, asignar los valores a los controles de la interfaz
                if (categoria != null)
                {
                    txtNombreEditar.Text = categoria.NombreCategoria;
                    // Aquí asignamos la medida de la categoría. Suponemos que la propiedad RefMedida es de tipo Medida.
                    var medidaSeleccionada = cbbMedidaEditar.Items
                        .Cast<OpcionCombo>()
                        .FirstOrDefault(m => m.Valor == categoria.RefMedida.IdMedida);
                    if (medidaSeleccionada != null)
                    {
                        cbbMedidaEditar.SelectedItem = medidaSeleccionada;
                    }
                    // Asignar el estado de habilitación
                    var habilitado = categoria.Activo == 1 ? "SI" : "NO";
                    cbbHabilitado.SelectedItem = cbbHabilitado.Items
                        .Cast<OpcionCombo>()
                        .FirstOrDefault(item => item.Texto == habilitado);
                }

                // Cambiar a la pestaña de edición
                MostrarTab(tabEditar.Name);
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

        private async void btnNuevoGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreNuevoCategoria.Text.Trim() == "")
            {
                MessageBox.Show("El campo nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (OpcionCombo)cbbNuevoMedida.SelectedItem!;

            var objeto = new Categoria
            {
                NombreCategoria = txtNombreNuevoCategoria.Text.Trim(),
                RefMedida = new Medida { IdMedida = item.Valor }
            };

            var respuesta = await _categoriaServicios.CrearCategoria(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                await MostrarCategoria();
                MostrarTab(tabLista.Name);
            }
        }

        private async void btnEditarGuardar_Click(object sender, EventArgs e)
        {
            // Validación de datos
            if (txtNombreEditar.Text.Trim() == "")
            {
                MessageBox.Show("El campo nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbbMedidaEditar.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (OpcionCombo)cbbMedidaEditar.SelectedItem!;

            var objeto = new Categoria
            {
                IdCategoria = _categoriaseleccionada.IdCategoria, // Usamos el Id de la categoría seleccionada
                NombreCategoria = txtNombreEditar.Text.Trim(),
                RefMedida = new Medida { IdMedida = item.Valor },
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor == 1 ? 0:1 // Obtener valor de Habilitado
            };

            var respuesta = await _categoriaServicios.EditarCategoria(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recargar la lista de categorías y volver a la lista
            await MostrarCategoria();
            MostrarTab(tabLista.Name);
        }



    }
}
