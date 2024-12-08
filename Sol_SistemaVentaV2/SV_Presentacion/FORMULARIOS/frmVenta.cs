using SV_Presentacion.Utilidades;
using SV_Presentacion.Utilidades.Objetos;
using SV_Presentacion.VistaModelo;
using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Servicios.IMPLEMENTACION;
using SV_Servicios.INTERFACES;

namespace SV_Presentacion.FORMULARIOS
{
    public partial class frmVenta : Form
    {
        private readonly IProductoServicios _productoServicios;
        private readonly IVentaServicios _ventaServicios;
        private readonly IDetalleVentaServicios _detalleVentaServicios;
        private readonly ICategoriaServicios _categoriaServicios;
        //private List<Producto> _productosDisponibles = new();
        //private List<DetalleVenta> _detallesVenta = new();
        private decimal _totalVenta = 0;

        public frmVenta(IProductoServicios productoServicios, IVentaServicios ventaServicios, IDetalleVentaServicios detalleVentaServicios, ICategoriaServicios categoriaServicios)
        {
            InitializeComponent();
            _productoServicios = productoServicios;
            _ventaServicios = ventaServicios;
            _detalleVentaServicios = detalleVentaServicios;
            _categoriaServicios = categoriaServicios;
        }

        private async void frmVenta_Load(object sender, EventArgs e)
        {

            // Configurar DataGridView
            dgvDetalleVenta.ImplementarConfiguracion("Detalle");
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var listaMedida = await _productoServicios.listaProducto();
            var items = listaMedida.Select(item => new OpcionCombo
            {
                Texto = item.Descripcion,
                Valor = item.IdProducto
            }).ToArray();

            cboProductos.InsertarItems(items);

            // Mostrar ventas realizadas
            //await MostrarVentas();
        }

        //private void btnAgregarProducto_Click(object sender, EventArgs e)
        //{
        //    if (cboProductos.SelectedItem is OpcionCombo productoSeleccionado)
        //    {

                //if (producto != null)
                //{
                //    // Agregar producto al detalle de venta
                //    _detallesVenta.Add(new DetalleVenta
                //    {
                //        RefProducto = producto,
                //        PrecioVenta = producto.PrecioVenta,
                //        Cantidad = 1 // Por simplicidad, cantidad fija de 1
                //    });

                //    // Actualizar total
                //    _totalVenta += producto.PrecioVenta;
                //    txtTotal.Text = _totalVenta.ToString("C");

                //    // Refrescar DataGridView
                //    dgvDetalleVenta.DataSource = null;
                //    dgvDetalleVenta.DataSource = _detallesVenta.Select(d => new
                //    {
                //        d.RefProducto.Descripcion,
                //        d.RefProducto.Codigo,
                //        Categoria = d.RefProducto.RefCategoria.NombreCategoria,
                //        d.PrecioVenta
                //    }).ToList();
                //}
        //    }
        //}

        //private async void btnRegistrarVenta_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtCliente.Text))
        //    {
        //        MessageBox.Show("Debe ingresar el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (_detallesVenta.Count == 0)
        //    {
        //        MessageBox.Show("Debe agregar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    var confirmacion = MessageBox.Show(
        //        $"¿Confirma la venta por un total de {_totalVenta:C}?",
        //        "Confirmación",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question);

        //    if (confirmacion == DialogResult.Yes)
        //    {
        //        var venta = new Venta
        //        {
        //            NombreCliente = txtCliente.Text,
        //            PrecioTotal = _totalVenta,
        //            FechaRegistro = DateTime.Now,
        //        };

        //        var respuesta = await _ventaServicios.CrearVenta(venta);
        //        if (string.IsNullOrEmpty(respuesta))
        //        {
        //            MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Reiniciar estado
        //            _detallesVenta.Clear();
        //            _totalVenta = 0;
        //            txtTotal.Text = "";
        //            dgvDetalleVenta.DataSource = null;
        //            txtCliente.Text = "";

        //            // Refrescar lista de ventas
        //            await MostrarVentas();
        //        }
        //        else
        //        {
        //            MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private async Task MostrarVentas()
        //{
        //    var ventas = await _ventaServicios.listaVenta();
        //    dgvVentas.DataSource = ventas.Select(v => new
        //    {
        //        v.NumeroVenta,
        //        v.NombreCliente,
        //        v.PrecioTotal,
        //        v.FechaRegistro
        //    }).ToList();

        //    dgvVentas.Columns["NumeroVenta"].HeaderText = "N° Venta";
        //    dgvVentas.Columns["NombreCliente"].HeaderText = "Cliente";
        //    dgvVentas.Columns["PrecioTotal"].HeaderText = "Total";
        //    dgvVentas.Columns["FechaRegistro"].HeaderText = "Fecha";
        //}

        //private async void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvVentas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
        //    {
        //        var numeroVenta = dgvVentas.Rows[e.RowIndex].Cells["NumeroVenta"].Value.ToString();
        //        if (!string.IsNullOrEmpty(numeroVenta))
        //        {
        //            var detallesVenta = await _ventaServicios.ObtenerDetalleVenta(numeroVenta);
        //            var frmDetalles = new frmDetalleVenta(detallesVenta.ToArray());
        //            frmDetalles.ShowDialog();
        //        }
        //    }
        //}

    }
}
