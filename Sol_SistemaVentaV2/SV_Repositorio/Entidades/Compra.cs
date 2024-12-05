using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_Repositorio.ENTIDADES
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Total { get; set; }
        public int IdUsuario { get; set; }
        public bool Activo { get; set; }

        // Referencia a la tabla Usuario
        public Usuario RefUsuario { get; set; }
    }
}

