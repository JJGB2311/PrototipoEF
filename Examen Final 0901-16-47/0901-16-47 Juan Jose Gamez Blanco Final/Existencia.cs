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
    public partial class Existencia : Form
    {
        string usuario;
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        public Existencia(string user)
        {
            InitializeComponent();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            llenartbl();
        }
        void llenartbl()
        {
            //codigo para llevar el DataGridView
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT codigo_bodega,codigo_producto,saldo_existencia FROM `existencias` WHERE estado=1;");
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


        void Insertar()
        {
            conn.Close();
            string query = "INSERT INTO `existencias` (`codigo_bodega`, `codigo_producto`, `saldo_existencia`, `estado`) VALUES ('"+comboBox1.Text+"', '"+comboBox2.Text+"', '"+txtexis.Text+"', '1');";

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
        private void Existencia_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertar();
            llenartbl();
        }
    }
}
