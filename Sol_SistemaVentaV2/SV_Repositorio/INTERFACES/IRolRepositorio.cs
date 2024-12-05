﻿using SV_Repositorio.Entidades;

namespace SV_Repositorio.INTERFACES
{
    public interface IRolRepositorio
    {
        Task<List<Rol>> ListarRoles(string buscar = "");
        Task<string> CrearRol(Rol objeto);
        Task<string> EditarRol(Rol objeto);
    }
}
