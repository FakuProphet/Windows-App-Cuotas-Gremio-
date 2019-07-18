namespace WindowsCuotasApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.afiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionAfiliadosConDébitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarListadoDeAfiliadosADebitarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisiónCuotasAfiliadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.efectuarPagoCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVentanaInformaciónBásicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiliadoToolStripMenuItem,
            this.cuotasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // afiliadoToolStripMenuItem
            // 
            this.afiliadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.afiliadoToolStripMenuItem.Image = global::WindowsCuotasApp.Properties.Resources.icons8_User_Groups_64;
            resources.ApplyResources(this.afiliadoToolStripMenuItem, "afiliadoToolStripMenuItem");
            this.afiliadoToolStripMenuItem.Name = "afiliadoToolStripMenuItem";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cuotasToolStripMenuItem
            // 
            this.cuotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.toolStripMenuItem2});
            this.cuotasToolStripMenuItem.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Todo_List3_64;
            resources.ApplyResources(this.cuotasToolStripMenuItem, "cuotasToolStripMenuItem");
            this.cuotasToolStripMenuItem.Name = "cuotasToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionAfiliadosConDébitoToolStripMenuItem,
            this.generarListadoDeAfiliadosADebitarPagoToolStripMenuItem,
            this.revisiónCuotasAfiliadosToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Debit_Card_48;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // administracionAfiliadosConDébitoToolStripMenuItem
            // 
            this.administracionAfiliadosConDébitoToolStripMenuItem.Name = "administracionAfiliadosConDébitoToolStripMenuItem";
            resources.ApplyResources(this.administracionAfiliadosConDébitoToolStripMenuItem, "administracionAfiliadosConDébitoToolStripMenuItem");
            this.administracionAfiliadosConDébitoToolStripMenuItem.Click += new System.EventHandler(this.administracionAfiliadosConDébitoToolStripMenuItem_Click);
            // 
            // generarListadoDeAfiliadosADebitarPagoToolStripMenuItem
            // 
            this.generarListadoDeAfiliadosADebitarPagoToolStripMenuItem.Name = "generarListadoDeAfiliadosADebitarPagoToolStripMenuItem";
            resources.ApplyResources(this.generarListadoDeAfiliadosADebitarPagoToolStripMenuItem, "generarListadoDeAfiliadosADebitarPagoToolStripMenuItem");
            this.generarListadoDeAfiliadosADebitarPagoToolStripMenuItem.Click += new System.EventHandler(this.generarListadoDeAfiliadosADebitarPagoToolStripMenuItem_Click);
            // 
            // revisiónCuotasAfiliadosToolStripMenuItem
            // 
            this.revisiónCuotasAfiliadosToolStripMenuItem.Name = "revisiónCuotasAfiliadosToolStripMenuItem";
            resources.ApplyResources(this.revisiónCuotasAfiliadosToolStripMenuItem, "revisiónCuotasAfiliadosToolStripMenuItem");
            this.revisiónCuotasAfiliadosToolStripMenuItem.Click += new System.EventHandler(this.revisiónCuotasAfiliadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efectuarPagoCuotaToolStripMenuItem});
            this.toolStripMenuItem2.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Receive_Cash_48;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // efectuarPagoCuotaToolStripMenuItem
            // 
            this.efectuarPagoCuotaToolStripMenuItem.Name = "efectuarPagoCuotaToolStripMenuItem";
            resources.ApplyResources(this.efectuarPagoCuotaToolStripMenuItem, "efectuarPagoCuotaToolStripMenuItem");
            this.efectuarPagoCuotaToolStripMenuItem.Click += new System.EventHandler(this.efectuarPagoCuotaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abriToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Business_Report_64;
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            // 
            // abriToolStripMenuItem
            // 
            this.abriToolStripMenuItem.Name = "abriToolStripMenuItem";
            resources.ApplyResources(this.abriToolStripMenuItem, "abriToolStripMenuItem");
            this.abriToolStripMenuItem.Click += new System.EventHandler(this.abriToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Shutdown_64;
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirVentanaInformaciónBásicaToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Todo_List5_64;
            resources.ApplyResources(this.consultasToolStripMenuItem, "consultasToolStripMenuItem");
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            // 
            // abrirVentanaInformaciónBásicaToolStripMenuItem
            // 
            this.abrirVentanaInformaciónBásicaToolStripMenuItem.Name = "abrirVentanaInformaciónBásicaToolStripMenuItem";
            resources.ApplyResources(this.abrirVentanaInformaciónBásicaToolStripMenuItem, "abrirVentanaInformaciónBásicaToolStripMenuItem");
            this.abrirVentanaInformaciónBásicaToolStripMenuItem.Click += new System.EventHandler(this.abrirVentanaInformaciónBásicaToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administracionAfiliadosConDébitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarListadoDeAfiliadosADebitarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem efectuarPagoCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisiónCuotasAfiliadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem abriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVentanaInformaciónBásicaToolStripMenuItem;
    }
}

