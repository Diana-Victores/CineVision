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
        Sentencia Sn = new Sentencia();
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
        

    }
}
