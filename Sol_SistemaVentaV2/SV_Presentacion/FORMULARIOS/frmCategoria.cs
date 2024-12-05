using SV_Presentacion.Utilidades;
using SV_Presentacion.VistaModelo;
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
            _medidaServicios    = medidaServicios;
            _categoriaServicios = categoriaServicios;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            dgvCategorias.ImplementarConfiguracion();
            await MostrarCategoria();

            
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}
