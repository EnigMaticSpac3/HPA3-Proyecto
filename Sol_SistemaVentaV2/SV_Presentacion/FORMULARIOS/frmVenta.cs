using SV_Presentacion.Utilidades;
using SV_Presentacion.Utilidades.Objetos;
using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Servicios.INTERFACES;

namespace SV_Presentacion.FORMULARIOS
{
    public partial class frmVenta : Form
    {
        private readonly IProductoServicios _productoServicios;
        private readonly IVentaServicios _ventaServicios;

        private List<DetalleVenta> _detalleVentas = new();

        public frmVenta(IProductoServicios productoServicios, IVentaServicios ventaServicios)
        {
            InitializeComponent();
            _productoServicios = productoServicios;
            _ventaServicios = ventaServicios;
        }

        private async void frmVenta_Load(object sender, EventArgs e)
        {
            dgvDetalleVenta.ImplementarConfiguracion();

            var productos = await _productoServicios.listaProducto();
            var items = productos.Select(p => new OpcionCombo
            {
                Texto = p.Descripcion,
                Valor = p.IdProducto
            }).ToArray();

            cboProductos.InsertarItems(items);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productoSeleccionado = (OpcionCombo)cboProductos.SelectedItem!;
            var idProducto = productoSeleccionado.Valor;

            if (_detalleVentas.Any(d => d.RefProducto.IdProducto == idProducto))
            {
                MessageBox.Show("El producto ya está en el detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var detalle = new DetalleVenta
            {
                RefProducto = new Producto { IdProducto = idProducto, Descripcion = productoSeleccionado.Texto },
                Cantidad = 1, // Valor predeterminado
                PrecioVenta = 100, // Valor predeterminado
                PrecioTotal = 100 // Calcular cantidad * precio
            };

            _detalleVentas.Add(detalle);
            ActualizarDetalleVenta();
        }

        private void ActualizarDetalleVenta()
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = _detalleVentas;

            txtTotal.Text = _detalleVentas.Sum(d => d.PrecioTotal).ToString("0.00");
        }

        private async void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (_detalleVentas.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var venta = new Venta
            {
                NumeroVenta = "001-000001", // Generar dinámicamente
                NombreCliente = txtCliente.Text.Trim(),
                PrecioTotal = _detalleVentas.Sum(d => d.PrecioTotal),
                RefUsuarioRegistro = new Usuario { IdUsuario = 1 }, // Usuario predeterminado
                PagoCon = 0, // Actualizar con pago real
                Cambio = 0, // Actualizar con cambio real
            };

            var respuesta = await _ventaServicios.CrearVenta(venta, _detalleVentas);

            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtCliente.Clear();
            _detalleVentas.Clear();
            ActualizarDetalleVenta();
        }
    }
}
