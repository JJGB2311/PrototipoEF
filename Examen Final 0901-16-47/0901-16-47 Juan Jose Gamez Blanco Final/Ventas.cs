using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Net;

namespace _0901_16_47_Juan_Jose_Gamez_Blanco_Final
{
    public partial class Ventas : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        public Ventas(string user)
        {
            InitializeComponent();
            llenartbl();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
          dateTimePicker1.Format = DateTimePickerFormat.Custom;
            llenartbl2();
        }


        void llenartbl()
        {
            //codigo para llevar el DataGridView
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT documento_ventaenca,codigo_cliente,fecha_ventaenca FROM `ventas_encabezado` WHERE estado=1;");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                dataGridView1.DataSource = datos;
                eje.Update(datos);
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }
        void llenartbl2()
        {
            //codigo para llevar el DataGridView
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT documento_ventaenca, codigo_producto, cantidad_ventadet, costo_ventadet, precio_ventadet, codigo_bodega from ventas_detalle WHERE estado=1;");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                dataGridView2.DataSource = datos;
                eje.Update(datos);
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR" + e.ToString());
                conn.Close();
            }
        }
            void Insertar()
             {
                 conn.Close();
                 string query = "INSERT INTO `ventas_encabezado` (`documento_ventaenca`, `codigo_cliente`, `fecha_ventaenca`, `estado`) VALUES ('"+txtno.Text+"', '"+ comboBox1.Text+ "', '"+dateTimePicker1.Text+"', '1');";

                 conn.Open();
                 OdbcCommand consulta = new OdbcCommand(query, conn);
                 try
                 {
                     consulta.ExecuteNonQuery();
                     MessageBox.Show(" Se Registro Corectamente");
                     llenartbl();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("\t Error! \n\n " + ex.ToString());
                     conn.Close();
                 }
             }
        void Insertar2()
        {
            conn.Close();
            string query = "INSERT INTO `ventas_detalle` (`documento_ventaenca`, `codigo_producto`, `cantidad_ventadet`, `costo_ventadet`, `precio_ventadet`, `codigo_bodega`, `estado`) VALUES ('"+txtnoo.Text+"', '"+comboBox2.Text+"', '"+txtcant.Text+"', '"+txtprev.Text+"', '"+txtven.Text+"', '"+comboBox3.Text+"', '1');";

            conn.Open();
            OdbcCommand consulta = new OdbcCommand(query, conn);
            try
            {
                consulta.ExecuteNonQuery();
                MessageBox.Show("El Empleado se Registro Corectamente");
                llenartbl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t Error! \n\n " + ex.ToString());
                conn.Close();
            }
        }
        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insertar();
            llenartbl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Insertar2();
            llenartbl2();
        }
    }
}
