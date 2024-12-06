using Microsoft.Data.SqlClient;
using SV_Repositorio.BD;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using System.Data;

namespace SV_Repositorio.IMPLEMENTACION
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly Conexion _conexion;

        public CategoriaRepositorio(Conexion conexion)//constructor (ctor)
        {
            _conexion = conexion;
        }

        public async Task<List<Categoria>> listaCategoria(string buscar = "")
        {
            List<Categoria> listaCat = new List<Categoria>();

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_listarCategoria", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        listaCat.Add(new Categoria
                        {
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            NombreCategoria = (dr["NombreCategoria"]).ToString()!,
                            Activo = Convert.ToInt32(dr["Activo"]),
                            RefMedida = new Medida
                            {
                                IdMedida = Convert.ToInt32(dr["IdMedida"]),
                                NomMedida = (dr["NomMedida"]).ToString()!
                            }
                        });
                    }
                    return listaCat;
                }
            }
        }


        public async Task<string> CrearCategoria(Categoria objeto)
        {
            String respuesta = "";

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_crearCategoria", cn);
                cmd.Parameters.AddWithValue("@NombreCat", objeto.NombreCategoria);
                cmd.Parameters.AddWithValue("@IdMedida", objeto.RefMedida.IdMedida);
                cmd.Parameters.Add("@MsError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try // para encapsular una instruccion y si hay un errory evitar que la aplicacion se rompa
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsError"].Value)!;
                }
                catch
                {
                    respuesta = "Error(Crear Categoria), No se pudo insertar el registro";
                }
            }
            return respuesta;
        }

        public async Task<string> EditarCategoria(Categoria objeto)
        {
            string respuesta = "";

            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_editarCategoria", cn);
                cmd.Parameters.AddWithValue("@IdCategoria", objeto.IdCategoria);
                cmd.Parameters.AddWithValue("@NombreCat", objeto.NombreCategoria);
                cmd.Parameters.AddWithValue("@IdMedida", objeto.RefMedida.IdMedida);
                cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    respuesta = "Error (Editar Categoría), No se pudo editar el registro.";
                }

            }
            return respuesta;
        }

        public async Task<Categoria> ObtenerCategoriaPorId(int idCategoria)
        {
            Categoria categoria = null!;
            using (var cn = _conexion.ObtenerSql())
            {
                cn.Open();
                var cmd = new SqlCommand("sp_obtenerCategoriaPorId", cn);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                cmd.CommandType = CommandType.StoredProcedure;

                var reader = await cmd.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        categoria = new Categoria
                        {
                            IdCategoria = reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                            NombreCategoria = reader.GetString(reader.GetOrdinal("NombreCategoria")),
                            Activo = reader.GetBoolean(reader.GetOrdinal("Activo")) ? 1 : 0,
                            RefMedida = new Medida
                            {
                                IdMedida = reader.GetInt32(reader.GetOrdinal("IdMedida"))
                            }
                        };
                    }
                }
            }
            return categoria;
        }

    }
}
