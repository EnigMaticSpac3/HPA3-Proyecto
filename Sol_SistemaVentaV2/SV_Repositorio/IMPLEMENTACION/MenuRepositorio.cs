using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class MenuRepositorio : IMenuRepositorio
    {
        private readonly Conexion _conexion;

        public MenuRepositorio(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<IEnumerable<Menu>> ObtenerTodosMenusAsync()
        {
            List<Menu> lista = new List<Menu>();
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("ListarMenus", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Buscar", string.Empty));

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Menu
                        {
                            IdMenu = Convert.ToInt32(dr["IdMenu"]),
                            NombreMenu = Convert.ToString(dr["NombreMenu"]),
                            IdMenuPadre = Convert.ToInt32(dr["IdMenuPadre"])
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<Menu> ObtenerMenuByIdAsync(int id)
        {
            Menu menu = null;
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("ObtenerMenuPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdMenu", id));

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        menu = new Menu
                        {
                            IdMenu = Convert.ToInt32(dr["IdMenu"]),
                            NombreMenu = Convert.ToString(dr["NombreMenu"]),
                            IdMenuPadre = Convert.ToInt32(dr["IdMenuPadre"])
                        };
                    }
                }
            }
            return menu;
        }

        public async Task AgregarMenuAsync(Menu menu)
        {
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("CrearMenu", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NombreMenu", menu.NombreMenu));
                cmd.Parameters.Add(new SqlParameter("@IdMenuPadre", menu.IdMenuPadre));

                await cmd.ExecuteScalarAsync();
            }
        }

        public async Task ActualizarMenuAsync(Menu menu)
        {
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("EditarMenu", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdMenu", menu.IdMenu));
                cmd.Parameters.Add(new SqlParameter("@NombreMenu", menu.NombreMenu));
                cmd.Parameters.Add(new SqlParameter("@IdMenuPadre", menu.IdMenuPadre));

                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
