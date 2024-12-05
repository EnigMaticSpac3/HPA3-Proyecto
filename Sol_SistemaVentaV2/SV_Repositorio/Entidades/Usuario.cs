using SV_Repositorio.Entidades;

namespace SV_Repositorio.ENTIDADES
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }

        // Referencia a la tabla Rol
        public Rol RefRol { get; set; }
    }
}
