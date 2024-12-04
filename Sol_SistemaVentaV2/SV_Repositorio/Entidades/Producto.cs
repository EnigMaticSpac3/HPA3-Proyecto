using SV_Repositorio.ENTIDADES;

namespace SVRepositorio.ENTIDADES
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public Categoria RefCategoria { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public bool Activo { get; set; }
    }
}