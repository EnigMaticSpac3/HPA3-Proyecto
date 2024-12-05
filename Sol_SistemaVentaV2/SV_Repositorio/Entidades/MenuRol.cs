using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_Repositorio.Entidades
{
    public class MenuRol
    {
        public int IdMenuRol { get; set; }
        public int IdMenu { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }

        // Referencias a otras entidades
        public Menu RefMenu { get; set; }
        public Rol RefRol { get; set; }
    }
}
