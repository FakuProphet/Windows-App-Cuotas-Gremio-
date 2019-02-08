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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarDebitos));
            this.dgvListadoSalida = new System.Windows.Forms.DataGridView();
            this.dgvListadoEntrada = new System.Windows.Forms.DataGridView();
            this.NroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFILIADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEfectuarCambios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEntrada)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoSalida
            // 
            this.dgvListadoSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvListadoSalida, "dgvListadoSalida");
            this.dgvListadoSalida.Name = "dgvListadoSalida";
            this.dgvListadoSalida.ReadOnly = true;
            this.dgvListadoSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgvListadoEntrada
            // 
            this.dgvListadoEntrada.AllowUserToAddRows = false;
            this.dgvListadoEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroComprobante,
            this.AFILIADO,
            this.NRODNI});
            resources.ApplyResources(this.dgvListadoEntrada, "dgvListadoEntrada");
            this.dgvListadoEntrada.Name = "dgvListadoEntrada";
            this.dgvListadoEntrada.ReadOnly = true;
            this.dgvListadoEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoEntrada_CellDoubleClick);
            // 
            // NroComprobante
            // 
            resources.ApplyResources(this.NroComprobante, "NroComprobante");
            this.NroComprobante.Name = "NroComprobante";
            this.NroComprobante.ReadOnly = true;
            // 
            // AFILIADO
            // 
            resources.ApplyResources(this.AFILIADO, "AFILIADO");
            this.AFILIADO.Name = "AFILIADO";
            this.AFILIADO.ReadOnly = true;
            // 
            // NRODNI
            // 
            resources.ApplyResources(this.NRODNI, "NRODNI");
            this.NRODNI.Name = "NRODNI";
            this.NRODNI.ReadOnly = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // txtFiltrar
            // 
            // 
            // 
            // 
            this.txtFiltrar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtFiltrar.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtFiltrar.CustomButton.Name = "";
            this.txtFiltrar.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtFiltrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrar.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtFiltrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrar.CustomButton.UseSelectable = true;
            this.txtFiltrar.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtFiltrar.Lines = new string[0];
            resources.ApplyResources(this.txtFiltrar, "txtFiltrar");
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.ShortcutsEnabled = true;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltrar.Click += new System.EventHandler(this.txtFiltrar_Click);
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Down_Arrow_32;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtFiltrar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvListadoSalida);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnEfectuarCambios
            // 
            resources.ApplyResources(this.btnEfectuarCambios, "btnEfectuarCambios");
            this.btnEfectuarCambios.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Update_321;
            this.btnEfectuarCambios.Name = "btnEfectuarCambios";
            this.btnEfectuarCambios.UseVisualStyleBackColor = true;
            this.btnEfectuarCambios.Click += new System.EventHandler(this.btnEfectuarCambios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnContinuar);
            this.panel3.Controls.Add(this.btnEfectuarCambios);
            this.panel3.Controls.Add(this.dgvListadoEntrada);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnContinuar
            // 
            resources.ApplyResources(this.btnContinuar, "btnContinuar");
            this.btnContinuar.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Update_321;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Debit_Card_64;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormEditarDebitos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "FormEditarDebitos";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormEditarDebitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEntrada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoSalida;
        private System.Windows.Forms.DataGridView dgvListadoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFILIADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODNI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEfectuarCambios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinuar;
    }
}