using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class RolRepositorio : IRolRepositorio
    {
        private readonly Conexion _conexion;

        public RolRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Rol>> ListarRoles(string buscar = "")
        {
            List<Rol> listaRoles = new List<Rol>();

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listarRol", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        listaRoles.Add(new Rol
                        {
                            IdRol = Convert.ToInt32(dr["IdRol"]),
                            NombreRol = dr["NombreRol"].ToString()!
                        });
                    }
                }
            }

            return listaRoles;
        }

        public async Task<string> CrearRol(Rol objeto)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();

                    using (var cmd = new SqlCommand("sp_crearRol", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreRol", objeto.NombreRol);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "Rol creado exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al crear el rol: {ex.Message}";
            }
        }

        public async Task<string> EditarRol(Rol objeto)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();

                    using (var cmd = new SqlCommand("sp_editarRol", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdRol", objeto.IdRol);
                        cmd.Parameters.AddWithValue("@NombreRol", objeto.NombreRol);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "Rol actualizado exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al editar el rol: {ex.Message}";
            }
        }
    }
}

