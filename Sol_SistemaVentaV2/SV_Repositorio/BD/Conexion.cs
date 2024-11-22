using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SV_Repositorio.BD
{
    public class Conexion //public porque lo vamos a estar llamando desde los otros proyectos
    {
        //IConfiguration esta accediendo al entorno
        private readonly IConfiguration _configuracion; // viene de la clase de los componentes
        // IConfiguration crea una interfaz haciendo inyeccion de dependencias
        private readonly string _cadenaSql;
        

        public Conexion(IConfiguration configuracion)
        {//metodo constructor, 
            _configuracion = configuracion;//
            _cadenaSql = _configuracion.GetConnectionString("CadenaSql")!;// '!' = no recibe valores nulo
        }

        public SqlConnection ObtenerSql()
        {
            return new SqlConnection(_cadenaSql);
        }
    }
}
