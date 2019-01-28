namespace WindowsCuotasApp
{
    partial class FormListadoSociosCuotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de socios a cobrar por débito";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(23, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 73);
            this.label1.TabIndex = 1;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnGenerarPDF.Image = global::WindowsCuotasApp.Properties.Resources.icons8_PDF_32;
            this.btnGenerarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenerarPDF.Location = new System.Drawing.Point(779, 475);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(156, 40);
            this.btnGenerarPDF.TabIndex = 6;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            // 
            // FormListadoSociosCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 549);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListadoSociosCuotas";
            this.Text = "Generar Listado ";
            this.Load += new System.EventHandler(this.FormListadoSociosCuotas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPDF;
    }
}