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
            this.dgvListadoSalida.Location = new System.Drawing.Point(14, 15);
            this.dgvListadoSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoSalida.Name = "dgvListadoSalida";
            this.dgvListadoSalida.ReadOnly = true;
            this.dgvListadoSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoSalida.Size = new System.Drawing.Size(930, 200);
            this.dgvListadoSalida.TabIndex = 0;
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
            this.dgvListadoEntrada.Location = new System.Drawing.Point(16, 15);
            this.dgvListadoEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoEntrada.Name = "dgvListadoEntrada";
            this.dgvListadoEntrada.ReadOnly = true;
            this.dgvListadoEntrada.Size = new System.Drawing.Size(644, 172);
            this.dgvListadoEntrada.TabIndex = 1;
            this.dgvListadoEntrada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoEntrada_CellDoubleClick);
            // 
            // NroComprobante
            // 
            this.NroComprobante.HeaderText = "NRO COMPROBANTE";
            this.NroComprobante.Name = "NroComprobante";
            this.NroComprobante.ReadOnly = true;
            this.NroComprobante.Width = 170;
            // 
            // AFILIADO
            // 
            this.AFILIADO.HeaderText = "NOMBRE AFILIADO";
            this.AFILIADO.Name = "AFILIADO";
            this.AFILIADO.ReadOnly = true;
            this.AFILIADO.Width = 158;
            // 
            // NRODNI
            // 
            this.NRODNI.HeaderText = "NRO. DOCUMENTO";
            this.NRODNI.Name = "NRODNI";
            this.NRODNI.ReadOnly = true;
            this.NRODNI.Width = 159;
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
            this.txtFiltrar.CustomButton.Image = null;
            this.txtFiltrar.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtFiltrar.CustomButton.Name = "";
            this.txtFiltrar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrar.CustomButton.TabIndex = 1;
            this.txtFiltrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrar.CustomButton.UseSelectable = true;
            this.txtFiltrar.CustomButton.Visible = false;
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(189, 17);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.ShortcutsEnabled = true;
            this.txtFiltrar.Size = new System.Drawing.Size(131, 23);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltrar.Click += new System.EventHandler(this.txtFiltrar_Click);
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(16, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Buscar por nro documento";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Down_Arrow_32;
            this.button1.Location = new System.Drawing.Point(969, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtFiltrar);
            this.panel1.Location = new System.Drawing.Point(24, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 54);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvListadoSalida);
            this.panel2.Location = new System.Drawing.Point(24, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 229);
            this.panel2.TabIndex = 9;
            // 
            // btnEfectuarCambios
            // 
            this.btnEfectuarCambios.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectuarCambios.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Update_321;
            this.btnEfectuarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEfectuarCambios.Location = new System.Drawing.Point(685, 141);
            this.btnEfectuarCambios.Name = "btnEfectuarCambios";
            this.btnEfectuarCambios.Size = new System.Drawing.Size(122, 46);
            this.btnEfectuarCambios.TabIndex = 10;
            this.btnEfectuarCambios.Text = "Efectuar cambios";
            this.btnEfectuarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEfectuarCambios.UseVisualStyleBackColor = true;
            this.btnEfectuarCambios.Click += new System.EventHandler(this.btnEfectuarCambios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnEfectuarCambios);
            this.panel3.Controls.Add(this.dgvListadoEntrada);
            this.panel3.Location = new System.Drawing.Point(24, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 202);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsCuotasApp.Properties.Resources.icons8_Debit_Card_64;
            this.pictureBox1.Location = new System.Drawing.Point(499, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 61);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormEditarDebitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
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
    }
}