namespace WindowsCuotasApp
{
    partial class FormInvitados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvitados));
            this.cboMesesHabilitados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMesActual = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroDni = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVerInactivos = new System.Windows.Forms.Button();
            this.txtFiltroDniEnPasado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalAdherentes = new System.Windows.Forms.Label();
            this.lblTotalAfil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantAct = new System.Windows.Forms.Label();
            this.lblCantInac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMesesHabilitados
            // 
            this.cboMesesHabilitados.FormattingEnabled = true;
            resources.ApplyResources(this.cboMesesHabilitados, "cboMesesHabilitados");
            this.cboMesesHabilitados.Name = "cboMesesHabilitados";
            this.cboMesesHabilitados.SelectedIndexChanged += new System.EventHandler(this.cboMesesHabilitados_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblMesActual
            // 
            resources.ApplyResources(this.lblMesActual, "lblMesActual");
            this.lblMesActual.ForeColor = System.Drawing.Color.Blue;
            this.lblMesActual.Name = "lblMesActual";
            // 
            // btnFiltro
            // 
            resources.ApplyResources(this.btnFiltro, "btnFiltro");
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            this.btnFiltro.MouseHover += new System.EventHandler(this.btnFiltro_MouseHover);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtFiltroDni
            // 
            resources.ApplyResources(this.txtFiltroDni, "txtFiltroDni");
            this.txtFiltroDni.Name = "txtFiltroDni";
            this.txtFiltroDni.TextChanged += new System.EventHandler(this.txtFiltroDni_TextChanged);
            // 
            // btnVerInactivos
            // 
            resources.ApplyResources(this.btnVerInactivos, "btnVerInactivos");
            this.btnVerInactivos.Name = "btnVerInactivos";
            this.btnVerInactivos.UseVisualStyleBackColor = true;
            this.btnVerInactivos.Click += new System.EventHandler(this.btnVerInactivos_Click);
            // 
            // txtFiltroDniEnPasado
            // 
            resources.ApplyResources(this.txtFiltroDniEnPasado, "txtFiltroDniEnPasado");
            this.txtFiltroDniEnPasado.Name = "txtFiltroDniEnPasado";
            this.txtFiltroDniEnPasado.TextChanged += new System.EventHandler(this.txtFiltroDniEnPasado_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblTotalAdherentes
            // 
            resources.ApplyResources(this.lblTotalAdherentes, "lblTotalAdherentes");
            this.lblTotalAdherentes.Name = "lblTotalAdherentes";
            // 
            // lblTotalAfil
            // 
            resources.ApplyResources(this.lblTotalAfil, "lblTotalAfil");
            this.lblTotalAfil.Name = "lblTotalAfil";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lblCantAct
            // 
            resources.ApplyResources(this.lblCantAct, "lblCantAct");
            this.lblCantAct.ForeColor = System.Drawing.Color.Blue;
            this.lblCantAct.Name = "lblCantAct";
            // 
            // lblCantInac
            // 
            resources.ApplyResources(this.lblCantInac, "lblCantInac");
            this.lblCantInac.ForeColor = System.Drawing.Color.Red;
            this.lblCantInac.Name = "lblCantInac";
            // 
            // FormInvitados
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCantInac);
            this.Controls.Add(this.lblCantAct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalAfil);
            this.Controls.Add(this.lblTotalAdherentes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiltroDniEnPasado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerInactivos);
            this.Controls.Add(this.txtFiltroDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblMesActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMesesHabilitados);
            this.MaximizeBox = false;
            this.Name = "FormInvitados";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormInvitados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMesesHabilitados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMesActual;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroDni;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVerInactivos;
        private System.Windows.Forms.TextBox txtFiltroDniEnPasado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAdherentes;
        private System.Windows.Forms.Label lblTotalAfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCantAct;
        private System.Windows.Forms.Label lblCantInac;
    }
}