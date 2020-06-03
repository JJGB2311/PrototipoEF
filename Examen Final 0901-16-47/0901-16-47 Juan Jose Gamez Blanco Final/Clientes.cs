using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0901_16_47_Juan_Jose_Gamez_Blanco_Final
{
    public partial class Clientes : Form
    {
        string usuario;
        public Clientes(string user)
        {
            InitializeComponent();
            usuario = user;
            LblUsuario.Text = usuario;
            string[] alias = { "No", "Nombre", "Direccion","Nit","Telefono","Vendedor","Estado" }; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#ffffff"); // Deficion de 
            navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.Blue);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 
            navegador1.asignarComboConTabla("proveedores", "nombre_proveedor", 1); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id
            navegador1.asignarTabla("clientes"); // tabla principal
            navegador1.asignarNombreForm("Clientes"); // Titulo y nombre del form
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }
    }
}
