namespace WindowsCuotasApp
{
    partial class FormPagoCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoCuota));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstadoAfil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTipoAfiliado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreAfil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigoAfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblEstadoAfil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNroDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblTipoAfiliado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNombreAfil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCodigoAfil);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblEstadoAfil
            // 
            resources.ApplyResources(this.lblEstadoAfil, "lblEstadoAfil");
            this.lblEstadoAfil.Name = "lblEstadoAfil";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblNroDoc
            // 
            resources.ApplyResources(this.lblNroDoc, "lblNroDoc");
            this.lblNroDoc.Name = "lblNroDoc";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // lblTipoAfiliado
            // 
            resources.ApplyResources(this.lblTipoAfiliado, "lblTipoAfiliado");
            this.lblTipoAfiliado.Name = "lblTipoAfiliado";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Name = "label2";
            // 
            // lblNombreAfil
            // 
            resources.ApplyResources(this.lblNombreAfil, "lblNombreAfil");
            this.lblNombreAfil.Name = "lblNombreAfil";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblCodigoAfil
            // 
            resources.ApplyResources(this.lblCodigoAfil, "lblCodigoAfil");
            this.lblCodigoAfil.Name = "lblCodigoAfil";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnOperar
            // 
            resources.ApplyResources(this.btnOperar, "btnOperar");
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsCuotasApp.Properties.Resources.Cash__96px1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMes
            // 
            resources.ApplyResources(this.lblMes, "lblMes");
            this.lblMes.Name = "lblMes";
            // 
            // FormPagoCuota
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormPagoCuota";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormPagoCuota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipoAfiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreAfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigoAfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEstadoAfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMes;
    }
}