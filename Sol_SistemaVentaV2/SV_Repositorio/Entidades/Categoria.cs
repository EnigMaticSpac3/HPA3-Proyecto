namespace SV_Repositorio.ENTIDADES
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public Medida RefMedida { get; set; }
        public int Activo { get; set; }

    }
}
