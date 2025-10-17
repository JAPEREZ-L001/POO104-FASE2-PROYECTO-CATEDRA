using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.Data.SqlClient;
=======

>>>>>>> 0e481ca94db18b3ec632948f4fe0df35379984ea
namespace PROYECTO_CATEDRAPOO104
{
    internal class ConexionBD
    {

        // Cadena de conexión a la base de datos
        //CADENA DE CONEXION JL
<<<<<<< HEAD
        private readonly string cadenaConexion = "Data Source=HP-PAVILION-JL\\SQLDEVELOPER;Initial Catalog=ProyectoDeCatedra_FaseI;Integrated Security=True;Trust Server Certificate=True";
        
        //CADENA DE CONEXION 
        //private readonly string cadenaConexion = "Rellena con tu Data Source";
=======
        //private readonly string cadenaConexion = "Data Source=HP-PAVILION-JL\\SQLDEVELOPER;Initial Catalog=ProyectoDeCatedra_FaseI;Integrated Security=True;Trust Server Certificate=True";
        
        //CADENA DE CONEXION 
        private readonly string cadenaConexion = "Rellena con tu Data Source";
>>>>>>> 0e481ca94db18b3ec632948f4fe0df35379984ea

        // Método para obtener una conexión abierta
        public SqlConnection ObtenerConexion()
        {
            var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        // Método para testear la conexión
        public bool ProbarConexion()
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    return conexion.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
