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
    public partial class Bodega : Form
    {
        string usuario;
        public Bodega(string user)
        {
            InitializeComponent();

            usuario = user;
            LblUsuario.Text = usuario;
            string[] alias = { "No", "Nombre", "Estado" }; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#ffffff"); // Deficion de 
            navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.Blue);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 

            navegador1.asignarTabla("bodegas"); // tabla principal
            navegador1.asignarNombreForm("Bodegas"); // Titulo y nombre del form
        }

        private void Mantenimiento1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }
    }
}
