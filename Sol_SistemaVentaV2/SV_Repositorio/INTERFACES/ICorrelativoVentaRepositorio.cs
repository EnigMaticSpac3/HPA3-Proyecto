using SV_Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_Repositorio.INTERFACES
{
    public interface ICorrelativoVentaRepositorio
    {
        Task<CorrelativoVenta> ObtenerCorrelativoVenta();
        Task<string> ActualizarCorrelativo(CorrelativoVenta correlativoVenta);
    }
}
