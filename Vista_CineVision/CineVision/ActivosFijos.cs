using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VistaContabilidad
{
    public partial class ActivosFijos : Form
    {
        public ActivosFijos()
        {
            InitializeComponent();
        }


        Controlador_CineVision.Controlador crud = new Controlador_CineVision.Controlador();

        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertProducto
                (textID.Text, textCliente.Text, textPelicula.Text, textHorarrio.Text, textSala.Text, textAsiento.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textID.Text, textCliente.Text, textPelicula.Text, textHorarrio.Text, textSala.Text, textAsiento.Text });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = crud.UpdateProducto(textID.Text, textCliente.Text, textPelicula.Text, textHorarrio.Text, textSala.Text, textAsiento.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textID.Text, textCliente.Text, textPelicula.Text, textHorarrio.Text, textSala.Text, textAsiento.Text });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool resultado = crud.DeleteProducto(textID.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textID.Text });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String col = "";
            String data = "";
            if (string.IsNullOrEmpty(textID.Text))
            {
                if (string.IsNullOrEmpty(textCliente.Text))
                {
                    if (string.IsNullOrEmpty(textPelicula.Text))
                    {
                        if (string.IsNullOrEmpty(textHorarrio.Text))
                        {
                            if (string.IsNullOrEmpty(textSala.Text))
                            {
                                if (string.IsNullOrEmpty(textAsiento.Text))
                                {
                                    if (string.IsNullOrEmpty(textAsiento.Text))
                                    {
                                        String textalert = " El campo buscar, se encuentra vacio. Debe llenar un solo campo para realizar la busqueda";
                                        MessageBox.Show(textalert);
                                    }
                                    else
                                    {
                                        data = textAsiento.Text;
                                        col = "EquipoComputo";
                                    }
                                }
                                else
                                {
                                    data = textAsiento.Text;
                                    col = "Herramientas";
                                }
                            }
                            else
                            {
                                data = textSala.Text;
                                col = "Maquinaria";
                            }
                        }
                        else
                        {
                            data = textHorarrio.Text;
                            col = "Equipos";
                        }
                    }
                    else
                    {
                        data = textPelicula.Text;
                        col = "Muebles";
                    }
                }
                else
                {
                    data = textCliente.Text;
                    col = "Edificaciones";
                }
            }
            else
            {
                data = textID.Text;
                col = "Codigo";
            }
            DataTable dt = new DataTable();
            //crud.BuscarProducto(data, col, dt);
            crud.BuscarDato(data, col, dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textCliente.Clear();
            textPelicula.Clear();
            textHorarrio.Clear();
            textAsiento.Clear();
            textAsiento.Clear();
            textSala.Clear();
            textID.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            String table = "";
            DataTable dt = new DataTable();
            table = "tbl_activosfijos";
            crud.ActualizarT(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivosFijos_Load(object sender, EventArgs e)
        {
            DataTable dt = crud.SelectProducto();
            foreach (DataRow item in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] { item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString() });
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
