namespace WindowsCuotasApp
{
    partial class FormAnotaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnotaciones));
            this.txtAnotacion = new System.Windows.Forms.TextBox();
            this.btnNuevaNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFechaAnotaciones = new System.Windows.Forms.ComboBox();
            this.btnGrabarNota = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaLarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnotacion
            // 
            resources.ApplyResources(this.txtAnotacion, "txtAnotacion");
            this.txtAnotacion.Name = "txtAnotacion";
            // 
            // btnNuevaNota
            // 
            resources.ApplyResources(this.btnNuevaNota, "btnNuevaNota");
            this.btnNuevaNota.Name = "btnNuevaNota";
            this.btnNuevaNota.UseVisualStyleBackColor = true;
            this.btnNuevaNota.Click += new System.EventHandler(this.btnNuevaNota_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cboFechaAnotaciones
            // 
            this.cboFechaAnotaciones.FormattingEnabled = true;
            this.cboFechaAnotaciones.Items.AddRange(new object[] {
            resources.GetString("cboFechaAnotaciones.Items")});
            resources.ApplyResources(this.cboFechaAnotaciones, "cboFechaAnotaciones");
            this.cboFechaAnotaciones.Name = "cboFechaAnotaciones";
            this.cboFechaAnotaciones.SelectedIndexChanged += new System.EventHandler(this.cboFechaAnotaciones_SelectedIndexChanged);
            // 
            // btnGrabarNota
            // 
            resources.ApplyResources(this.btnGrabarNota, "btnGrabarNota");
            this.btnGrabarNota.Name = "btnGrabarNota";
            this.btnGrabarNota.UseVisualStyleBackColor = true;
            this.btnGrabarNota.Click += new System.EventHandler(this.btnGrabarNota_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblHora
            // 
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.ForeColor = System.Drawing.Color.Red;
            this.lblHora.Name = "lblHora";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblFechaLarga
            // 
            resources.ApplyResources(this.lblFechaLarga, "lblFechaLarga");
            this.lblFechaLarga.Name = "lblFechaLarga";
            // 
            // FormAnotaciones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFechaLarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGrabarNota);
            this.Controls.Add(this.cboFechaAnotaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevaNota);
            this.Controls.Add(this.txtAnotacion);
            this.MaximizeBox = false;
            this.Name = "FormAnotaciones";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormAnotaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnotacion;
        private System.Windows.Forms.Button btnNuevaNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFechaAnotaciones;
        private System.Windows.Forms.Button btnGrabarNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaLarga;
    }
}