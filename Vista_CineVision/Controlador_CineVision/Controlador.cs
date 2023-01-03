using Modelo_CineVision;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controlador_CineVision
{
    public class Controlador
    {
        Modelo_CineVision.Sentencia  Sn = new Modelo_CineVision.Sentencia();
        Controlador cns = new Controlador();
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=cinevision");


        private static string ids;
        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }
        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = Sn.estadotabla(tabla);

            return resultado;
        }

        public void llenarfiltro(string ntabla, DataGridView tabla, string tipo, string dato)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = Sn.filtro(ntabla, tipo, dato);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }


        public void crearid(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = Sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox.Text = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox.Text = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        public string crearidwo(string tabla, string campo)//Crea el id siguiente a ingresar
        {
            string textbox = "";
            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = Sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return textbox;
        }

        public void verificarhorario(string idpelicula, TextBox[] textBoxes)
        {
            string[] horario = Sn.llenarhorario(idpelicula);

            textBoxes[0].Text = horario[0];
            textBoxes[1].Text = horario[1];

        }

        public void llenartotal(string idsala, TextBox total)
        {
            string to = Sn.llenartotalsala(idsala);

            total.Text = to;


        }

        public void iniciocompraboleto(TextBox id, TextBox[] bloqueado, TextBox[] todos, ComboBox[] combo)
        {


            for (int x = 0; x < bloqueado.Length; x++)
            {
                bloqueado[x].Enabled = false;
            }

            for (int x = 0; x < todos.Length; x++)
            {
                todos[x].Clear();
            }

            combo[0].Items.Clear();
            combo[1].Items.Clear();

            crearid(id, "Reservaciones", "", "idReservaciones");
        }


        public void llenarcombos(ComboBox[] comboBoxes, string sala)
        {
            OdbcDataAdapter dt = Sn.llenartablapcombof("Asientos", sala);
            DataTable table = new DataTable();
            dt.Fill(table);


            int contador = 0;
            comboBoxes[0].Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                comboBoxes[0].Items.Add(table.Rows[contador][0].ToString());

                contador++;
            }

            OdbcDataAdapter dt1 = Sn.llenartablapcomboc("Asientos", sala);
            DataTable table2 = new DataTable();
            dt1.Fill(table2);
            int contador2 = 0;
            comboBoxes[1].Items.Clear();

            foreach (DataRow row in table2.Rows)
            {
                comboBoxes[1].Items.Add(table2.Rows[contador2][0].ToString());

                contador2++;
            }

        }

        public void llenarcompraboleto(TextBox[] textBoxes, ComboBox[] comboBoxes, TextBox id, TextBox[] bloqueados)
        {
            string idf = crearidwo("factura", "idFactura");
            string metodo = "efectivo";

            /*FACTURA*/
            string consultafactura = "'" + idf + "', '" + textBoxes[3].Text + "', '" + metodo + "','" + textBoxes[2].Text + "', 0";
            string consultafactura_campos = "idFactura, fkCliente, metodoPago, subTotal, impuesto";
            Sn.insertar(consultafactura, consultafactura_campos, "factura");
            /*ASIENTO*/
            string asiento = Sn.buscarasiento(textBoxes[1].Text, comboBoxes[0].SelectedItem.ToString(), comboBoxes[1].SelectedItem.ToString());
            string consultareservaciones = "'" + textBoxes[0].Text + "', '" + asiento + "', '" + textBoxes[2].Text + "','" + idf + "'";
            string consultareservaciones_campos = "idReservaciones, fkAsientos, subTotalAsiento, fkFactura";
            Sn.insertar(consultareservaciones, consultareservaciones_campos, "reservaciones");

            string mensaje = "Compra exitosa";
            MessageBox.Show(mensaje, "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iniciocompraboleto(id, bloqueados, bloqueados, comboBoxes);



        }

        public bool InsertProducto(
            string _Pk, string _Edi, string _Mue, string _Equi,
            string _Maqui, string _Herra)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=cinevision"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO
                    compra_boletos
                    (idboleto,  fkCliente,fkPelicula,idhorarioCine,idSalas,
                     fkidAsientos)VALUE(?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@idboleto", OdbcType.Int).Value = _Pk;
                    cmd.Parameters.Add("@fkCliente", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@fkPelicula", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@idhorarioCine", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@idSalas", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@fkidAsientos", OdbcType.VarChar).Value = _Herra;
                    
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=cinevision"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE compra_boletos SET compra_boletos.idboleto = ?,
                    compra_boletos.fkCliente = ?, 
                    compra_boletos.fkPelicula = ?,
                    compra_boletos.idhorarioCine = ? , 
                    compra_boletos.idSalas = ? , 
                    compra_boletos.fkidAsientos = ?
                    WHERE compra_boletos.idboleto = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@fkCliente", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@fkPelicula", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@idhorarioCine", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@idSalas", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@fkidAsientos", OdbcType.VarChar).Value = _Herra;
                    
                    cmd.Parameters.Add("@idboleto", OdbcType.Int).Value = _Pk;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteProducto(string _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=cinevision"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM compra_boletos
                    WHERE compra_boletos.idboleto = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@idboleto", OdbcType.VarChar).Value = _Pk;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable BuscarDato(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=cinevision");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM compra_boletos WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }
        public DataTable ActualizarT(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=cinevision");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }
        public DataTable SelectProducto()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM compra_boletos;", "FIL=MS Access;DSN=cinevision"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
