using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;


namespace _0901_16_47_Juan_Jose_Gamez_Blanco_Final
{
    public partial class MDIMENU : Form
    {
        private int childFormNumber = 0;
        string usuarioact;
        public MDIMENU()
        {
          
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
      
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void procecsoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIMENU_Load(object sender, EventArgs e)
        {

            frm_login login = new frm_login();
            login.ShowDialog();
            LblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = LblUsuario.Text;
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(LblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = LblUsuario.Text;
            seguridad.ShowDialog();
        }

        private void mantenimiento1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Bodega nuevo = new Bodega(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linea nuevo = new linea(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Clientes nuevo = new Clientes(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();

        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendedores nuevo = new vendedores(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Marca nuevo = new Marca(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Producto nuevo = new Producto(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores nuevo = new Proveedores(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporteproductos nuevo = new Reporteproductos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void reprteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Clientes nuevo = new Reporte_Clientes(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Existencia nuevo = new Existencia(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas nuevo = new Ventas(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }
    }
}
