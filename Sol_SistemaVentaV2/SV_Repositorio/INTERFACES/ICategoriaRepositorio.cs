using SV_Repositorio.ENTIDADES;

namespace SV_Repositorio.INTERFACES
{
    public interface ICategoriaRepositorio
    {                                       
        Task<List<Categoria>> listaCategoria(string buscar ="");//Nombre del objeto
        Task<string> CrearCategoria(Categoria objeto);
        Task<string> EditarCategoria(Categoria objeto);
        Task<Categoria> ObtenerCategoriaPorId(int idCategoria);
        Task<List<Categoria>> ObtenerCategorias();
    }
}
