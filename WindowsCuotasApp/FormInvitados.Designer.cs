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
            // FormInvitados
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}