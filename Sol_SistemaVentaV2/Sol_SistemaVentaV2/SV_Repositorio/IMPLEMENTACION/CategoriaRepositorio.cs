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
                var cmd = new SqlCommand("sp_listaCategoria", cn);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync()) {
                    while (await dr.ReadAsync()) {
                        listaCat.Add(new Categoria
                        {
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            NombreCategoria = (dr["NombreCategoria"]).ToString()!,
                            Activo = Convert.ToInt32(dr["Activo"]),
                            RefMedida = new Medida
                            {
                                IdMedida = Convert.ToInt32(dr["IdMedida"]),
                                NomMedida = (dr["NombreMedida"]).ToString()!
                            }
                        });
                    }
                    return listaCat;
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
                    cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    try // para encapsular una instruccion y si hay un errory evitar que la aplicacion se rompa
                    {
                        await cmd.ExecuteNonQueryAsync();
                        respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                    }
                    catch
                    {
                        respuesta = "Error(Crear Categoria), No se pudo insertar el registro";
                    }
                }
                return respuesta;
            }

        public Task<string> EditarCategoria(Categoria objeto)
        {
            throw new NotImplementedException();
        }

        
    }
}
