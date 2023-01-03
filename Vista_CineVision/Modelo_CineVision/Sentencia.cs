using Controlador_CineVision;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Modelo_CineVision
{
   public class Sentencia
    {
        Controlador_CineVision.Conexion  Con = new Controlador_CineVision.Conexion();

        

        public string buscarid(string tabla, string tipo)
        {
            string dato = " ";
            try
            {

                string sql = "select " + tipo + " from " + tabla + " Order by " + tipo + " Desc Limit 1";
                OdbcCommand cmd = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato = lr.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }

        public OdbcDataAdapter filtro(string tabla, string tipodato, string dato)
        {


            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, Con.conexion());



            return datatable;
        }

        public int estadotabla(string tabla)
        {
            int dato = 0;
            string sql = "select count(*) as total from " + tabla;
            OdbcCommand cmd = new OdbcCommand(sql, Con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, Con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


        }

        public string[] llenarhorario(string idpelicula)
        {

            string[] datos = new string[2];
            string sql = "select fkSala, fechaHorario from horariocine where fkPelicula = '" + idpelicula + "';";
            OdbcCommand cmd = new OdbcCommand(sql, Con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);

            }

            return datos;
        }
        public string llenartotalsala(string idsala)
        {

            string datos = "";
            string sql = "select precioSala from salas where idSalas = '" + idsala + "';";
            OdbcCommand cmd = new OdbcCommand(sql, Con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {
                datos = lr.GetString(0);


            }

            return datos;
        }

        public OdbcDataAdapter llenartablapcombof(string tabla, string sala)
        {


            string sql = "select Fila from " + tabla + " where fkSala = '" + sala + "' ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, Con.conexion());



            return datatable;
        }
        public OdbcDataAdapter llenartablapcomboc(string tabla, string sala)
        {


            string sql = "select Columna from " + tabla + " where fkSala = '" + sala + "' ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, Con.conexion());



            return datatable;
        }

        public string buscarasiento(string sala, string fila, string columna)
        {
            string dato = "";
            string sql = "select idAsientos from asientos where  fkSala = '" + sala + "' and Fila = '" + fila + "' and Columna = '" + columna + "'";
            OdbcCommand cmd = new OdbcCommand(sql, Con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetString(0);


            }
            return dato;
        }

    }

}
