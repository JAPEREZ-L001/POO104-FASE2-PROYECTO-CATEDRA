
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    class Conexion
    {
        public string servidor, db;
        public string cadena;
        public void conec()
        {
            servidor = "(localdb)\\MSSQLLocalDB";
            db = "GestionHoteles";
            cadena = "Server=" + servidor + ";database=" + db + ";Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        }


    }
}
