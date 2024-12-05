namespace SV_Repositorio.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string NumeroVenta { get; set; }
        public Usuario RefUsuarioRegistro { get; set; } // Relación con Usuario
        public string NombreCliente { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal PagoCon { get; set; }
        public decimal Cambio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
