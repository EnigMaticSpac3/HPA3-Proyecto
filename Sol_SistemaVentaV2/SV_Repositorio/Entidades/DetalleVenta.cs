using SV_Repositorio.ENTIDADES;

namespace SV_Repositorio.Entidades
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Venta RefVenta { get; set; } // Relación con Venta
        public Producto RefProducto { get; set; } // Relación con Producto
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
