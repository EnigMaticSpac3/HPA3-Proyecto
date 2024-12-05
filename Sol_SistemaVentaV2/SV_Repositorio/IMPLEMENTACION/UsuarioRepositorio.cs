using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Conexion _conexion;

        public UsuarioRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Usuario>> ListarUsuarios(string buscar = "")
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listarUsuario", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        listaUsuarios.Add(new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            NombreUsuario = dr["NombreUsuario"].ToString()!,
                            Correo = dr["Correo"].ToString()!,
                            Contraseña = dr["Contraseña"].ToString()!,
                            IdRol = Convert.ToInt32(dr["IdRol"]),
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                    }
                }
            }

            return listaUsuarios;
        }

        public async Task<string> CrearUsuario(Usuario objeto)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();

                    using (var cmd = new SqlCommand("sp_crearUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreUsuario", objeto.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", objeto.Contraseña);
                        cmd.Parameters.AddWithValue("@IdRol", objeto.IdRol);
                        cmd.Parameters.AddWithValue("@Activo", objeto.Activo);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "Usuario creado exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al crear el usuario: {ex.Message}";
            }
        }

        public async Task<string> EditarUsuario(Usuario objeto)
        {
            try
            {
                using (var cn = _conexion.ObtenerSql())
                {
                    await cn.OpenAsync();

                    using (var cmd = new SqlCommand("sp_editarUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdUsuario", objeto.IdUsuario);
                        cmd.Parameters.AddWithValue("@NombreUsuario", objeto.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", objeto.Contraseña);
                        cmd.Parameters.AddWithValue("@IdRol", objeto.IdRol);
                        cmd.Parameters.AddWithValue("@Activo", objeto.Activo);

                        var msjErrorParam = new SqlParameter("@MsjError", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msjErrorParam);

                        await cmd.ExecuteNonQueryAsync();

                        return msjErrorParam.Value?.ToString() ?? "Usuario actualizado exitosamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al editar el usuario: {ex.Message}";
            }
        }
    }
}
