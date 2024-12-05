﻿using SV_Repositorio.ENTIDADES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Repositorio.INTERFACES
{
    public interface ICompraRepositorio
    {
        Task<List<Compra>> ListarCompras(string buscar = "");
        Task<string> CrearCompra(Compra compra);
        Task<string> EditarCompra(Compra compra);
    }
}