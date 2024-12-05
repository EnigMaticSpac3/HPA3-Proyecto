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

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            // cuando se carga el formulario se crea una variable y se utiliza esa variable para cargar los datos en el datagridview
            var listaCategoria = await _categoriaServicios.listaCategoria();
            dgvCategorias.DataSource = listaCategoria;
        }
    }
}
