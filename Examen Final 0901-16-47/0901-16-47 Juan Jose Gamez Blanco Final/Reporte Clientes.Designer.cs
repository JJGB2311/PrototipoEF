namespace _0901_16_47_Juan_Jose_Gamez_Blanco_Final
{
    partial class Reporte_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.REP_Client1 = new _0901_16_47_Juan_Jose_Gamez_Blanco_Final.REP_Client();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.REP_Client1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(955, 653);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // Reporte_Clientes
            // 
            this.ClientSize = new System.Drawing.Size(955, 653);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "Reporte_Clientes";
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.Reporte_Clientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private REP_Client REP_Client1;
    }
}