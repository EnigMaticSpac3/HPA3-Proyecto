using Microsoft.Extensions.DependencyInjection;

namespace SV_Presentacion.FORMULARIOS
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public frmMenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            var frmCategoria = _serviceProvider.GetRequiredService<frmCategoria>();
            frmCategoria.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            var frmProducto = _serviceProvider.GetRequiredService<frmProducto>();
            frmProducto.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var frmVenta = _serviceProvider.GetRequiredService<frmVenta>();
            frmVenta.ShowDialog();
        }
    }
}
