namespace WindowsCuotasApp
{
    partial class FormReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReporteListadoAfiliadosDebito1 = new WindowsCuotasApp.ReporteListadoAfiliadosDebito();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.crystalReportViewer1, "crystalReportViewer1");
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ReporteListadoAfiliadosDebito1;
            // 
            // FormReporte
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.ResumeLayout(false);

        }

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ReporteListadoAfiliadosDebito ReporteListadoAfiliadosDebito1;
        //  private CrystalReport1 CrystalReport11;

        //private CrystalReport1 CrystalReport11;

        #endregion
        // private CrystalReport1 CrystalReport11;
    }
}