using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class MenuRolRepositorio : IMenuRolRepositorio
    {
        private readonly Conexion _conexion;

        public MenuRolRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<MenuRol>> ListarMenuRoles(string buscar = "")
        {
            List<MenuRol> listaMenuRol = new List<MenuRol>();

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listarMenuRol", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        listaMenuRol.Add(new MenuRol
                        {
                            IdMenuRol = Convert.ToInt32(dr["IdMenuRol"]),
                            IdMenu = Convert.ToInt32(dr["IdMenu"]),
                            IdRol = Convert.ToInt32(dr["IdRol"]),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                    }
                }
            }

            return listaMenuRol;
        }

        public async Task<string> CrearMenuRol(MenuRol objeto)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();

                    using (var cmd = new SqlCommand("sp_crearMenuRol", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdMenu", objeto.IdMenu);
                        cmd.Parameters.AddWithValue("@IdRol", objeto.IdRol);
                        cmd.Parameters.AddWithValue("@Activo", objeto.Activo);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "MenuRol creado exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al crear el MenuRol: {ex.Message}";
            }
        }

        public async Task<string> EditarMenuRol(MenuRol objeto)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();

                    using (var cmd = new SqlCommand("sp_editarMenuRol", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdMenuRol", objeto.IdMenuRol);
                        cmd.Parameters.AddWithValue("@IdMenu", objeto.IdMenu);
                        cmd.Parameters.AddWithValue("@IdRol", objeto.IdRol);
                        cmd.Parameters.AddWithValue("@Activo", objeto.Activo);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "MenuRol actualizado exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al editar el MenuRol: {ex.Message}";
            }
        }
    }
}

