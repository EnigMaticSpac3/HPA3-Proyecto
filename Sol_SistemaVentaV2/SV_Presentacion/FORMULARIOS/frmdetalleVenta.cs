using SV_Repositorio.Entidades;

namespace SV_Presentacion.FORMULARIOS
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta(DetalleVenta[] detallesVenta)
        {
            InitializeComponent();

            lblCliente.Text += detallesVenta.First().RefVenta.NombreCliente;
            lblTotal.Text += detallesVenta.Sum(d => d.PrecioTotal).ToString("C");
            lblFecha.Text += detallesVenta.First().RefVenta.FechaRegistro.ToString();

            dgvDetalle.DataSource = detallesVenta.Select(d => new
            {
                d.RefProducto.Descripcion,
                d.RefProducto.Codigo,
                d.PrecioVenta,
                d.Cantidad
            }).ToList();
        }
    }

}
