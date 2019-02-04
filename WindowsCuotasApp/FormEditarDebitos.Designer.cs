namespace WindowsCuotasApp
{
    partial class FormEditarDebitos
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
            this.dgvListadoSalida = new System.Windows.Forms.DataGridView();
            this.dgvListadoEntrada = new System.Windows.Forms.DataGridView();
            this.NroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFILIADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEntrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoSalida
            // 
            this.dgvListadoSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSalida.Location = new System.Drawing.Point(21, 37);
            this.dgvListadoSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoSalida.Name = "dgvListadoSalida";
            this.dgvListadoSalida.ReadOnly = true;
            this.dgvListadoSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoSalida.Size = new System.Drawing.Size(793, 203);
            this.dgvListadoSalida.TabIndex = 0;
            // 
            // dgvListadoEntrada
            // 
            this.dgvListadoEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroComprobante,
            this.AFILIADO,
            this.NRODNI});
            this.dgvListadoEntrada.Location = new System.Drawing.Point(29, 39);
            this.dgvListadoEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoEntrada.Name = "dgvListadoEntrada";
            this.dgvListadoEntrada.ReadOnly = true;
            this.dgvListadoEntrada.Size = new System.Drawing.Size(785, 172);
            this.dgvListadoEntrada.TabIndex = 1;
            // 
            // NroComprobante
            // 
            this.NroComprobante.HeaderText = "NRO COMPROBANTE";
            this.NroComprobante.Name = "NroComprobante";
            this.NroComprobante.ReadOnly = true;
            this.NroComprobante.Width = 186;
            // 
            // AFILIADO
            // 
            this.AFILIADO.HeaderText = "NOMBRE AFILIADO";
            this.AFILIADO.Name = "AFILIADO";
            this.AFILIADO.ReadOnly = true;
            this.AFILIADO.Width = 177;
            // 
            // NRODNI
            // 
            this.NRODNI.HeaderText = "NRO. DOCUMENTO";
            this.NRODNI.Name = "NRODNI";
            this.NRODNI.ReadOnly = true;
            this.NRODNI.Width = 170;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListadoSalida);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(836, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListadoEntrada);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(901, 306);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(61, 43);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FormEditarDebitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 708);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormEditarDebitos";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.Resizable = false;
            this.Text = "Editar débitos";
            this.Load += new System.EventHandler(this.FormEditarDebitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEntrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoSalida;
        private System.Windows.Forms.DataGridView dgvListadoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFILIADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}