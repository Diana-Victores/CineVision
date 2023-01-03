using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaVistaReporteria
{
    class Conexion
    {
        public  static MySqlConnection conexion()
        {
            string servidor = "127.0.01";
            string bd = "cinevision";
            string usuario = "root";
            string password = "";

            string cadenaConexion = "Database=" + bd + ";Data Source=" + servidor + "; User Id="
                + usuario + "; Password=" + password+"";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
