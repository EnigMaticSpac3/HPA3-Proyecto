using SV_Repositorio.ENTIDADES;

namespace SV_Repositorio.INTERFACES
{
    public interface IMedidaRepositorio
    {
        //objeto de tipo lista
        Task <List<Medida>> listaMedida();//Nombre del objeto
    }
}
