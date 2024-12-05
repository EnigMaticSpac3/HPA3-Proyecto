using SV_Repositorio.ENTIDADES;

namespace SV_Presentacion.VistaModelo
{
    public class VistaProducto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string NombreCategoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public bool Activo { get; set; }
        public string Habilitado { get; set; }

    }
}