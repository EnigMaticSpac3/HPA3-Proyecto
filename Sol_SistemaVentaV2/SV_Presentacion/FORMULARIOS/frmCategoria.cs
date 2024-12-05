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

        public frmCategoria(IMedidaServicios medidaServicios, ICategoriaServicios categoriaServicios)
        {
            InitializeComponent();
            _medidaServicios = medidaServicios;
            _categoriaServicios = categoriaServicios;
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
            if(txtNombreNuevoCategoria.Text.Trim() == "")
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
    }
}
