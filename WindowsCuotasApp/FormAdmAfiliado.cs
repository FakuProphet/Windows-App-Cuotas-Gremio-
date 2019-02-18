using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;



namespace WindowsCuotasApp
{
    public partial class FormAdmAfiliados : MetroFramework.Forms.MetroForm
    {

        GestorAfiliados g;
        ArrayList listado;
        Validar validar;
        private bool bandera;
        public FormAdmAfiliados()
        {
            InitializeComponent();
            g = new GestorAfiliados();
            validar = new Validar();
            bandera = false;
        }


        private void FormAdmAfiliado_Load(object sender, EventArgs e)
        {
            Inicio();
        }


        private void CargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = g.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
        }


        private void CargarLista()
        {
            listado = g.ListadoAfiliados();
            foreach (Afiliado a in listado)
            {
                listBox1.Items.Add(a.nroDoc);
            }
        }


        private void Inicio()
        {
            CargarTodosLosCombos();
            btnGrabar.Show();
            listBox1.Enabled = true;
            groupBox1.Enabled = false;
            btnGrabar.Enabled = false;
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            lblEstadoGremial.Show();
            cboEstadosGremiales.Show();
            listBox1.Items.Clear();
            CargarLista();
            ComprobarLista();
            txtBuscar.Enabled = true;
            txtFechaNac.Show();
            btnUpdate.Hide();
            Cantidades();
            listBox1.SelectedIndex = 1;
        }

        private void Cantidades()
        {
            int cantAfilInac = g.Get("SP_CANTIDAD_AFIL_IANCTIVOS");
            int cantAfilActivos = g.Get("SP_CANTIDAD_AFIL_ACTIVOS");
            int totalAfiliados = g.Get("SP_CANTIDAD_AFILIADOS");
            lblCantAfilAct.Text = cantAfilActivos.ToString();
            lblCantAfiliInact.Text = cantAfilInac.ToString();
            lblTotalAfil.Text = totalAfiliados.ToString();
        }

        private void NuevoAfiliado()
        {
            groupBox1.Enabled = true;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = false;
            lblEstadoGremial.Hide();
            cboEstadosGremiales.Hide();
            listBox1.Enabled = false;
            LimpiarCampos();
            txtBuscar.Enabled = false;
            txtNombre.Focus();
            txtFechaNac.Hide();
        }

        void ActualizarAfiliado()
        {
            btnGrabar.Hide();
            txtFechaNac.Hide();
            btnActualizar.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            listBox1.Enabled = false;
            txtBuscar.Enabled = false;
            groupBox1.Enabled = true;
            btnUpdate.Show();
            txtNombre.Focus();
        }

        private void CargarCampos(int x)
        {
            Afiliado[] miVector = convertir();
            txtNombre.Text = miVector[x].nombre;
            txtApellido.Text = miVector[x].apellido;
            txtNroDoc.Text = miVector[x].nroDoc.ToString();
            txtEmail.Text = miVector[x].email;
            txtNroTel.Text = miVector[x].nroTel;
            txtDir.Text = miVector[x].direccion;
            txtBarrio.Text = miVector[x].barrio;
            cboLocalidades.SelectedValue = miVector[x].localidad;
            cboTipoAfil.SelectedValue = miVector[x].tipoAfiliado;
            cboForma.SelectedValue = miVector[x].formaPago;
            txtCbu.Text = miVector[x].cbu;
            cboEstadosGremiales.SelectedValue = miVector[x].estadoGremialID;
            lblAfiliadoID.Text = miVector[x].afiliadoID.ToString();
            txtFechaNac.Text = miVector[x].fechaNac.ToString();
        }



        private void CargarTodosLosCombos()
        {
            CargarCombo(cboLocalidades, "localidades");
            CargarCombo(cboForma, "formasPago");
            CargarCombo(cboTipoAfil, "tiposAfiliado");
            CargarCombo(cboEstadosGremiales, "estadosGremiales");
            CombosPorDefecto();
        }


        private void LimpiarCampos()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                    CombosPorDefecto();
                }
            }
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }



        private void ComprobarLista()
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Lista Vacia.");
                btnActualizar.Enabled = false;
                btnCancelar.Enabled = false;
                btnGrabar.Enabled = false;
                groupBox1.Enabled = false;
            }
            else
                listBox1.SelectedIndex = 0;
        }


        private void CombosPorDefecto()
        {

            if (cboLocalidades.Items.Count != 0)
            {
                cboLocalidades.SelectedValue = 59;
            }

        }



        private void seleccionCombo()
        {
            if (cboForma.SelectedIndex == 1)
            {
                txtCbu.Enabled = true;
            }
            else
            {
                txtCbu.Enabled = false;
            }
        }



        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }



        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void soloTexto(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
        }



        private void cboForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionCombo();
        }

        private bool comprobarCampos()
        {
            bool b = false;
            int seleccion = cboForma.SelectedIndex;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtNombre.Focus();
                b = false;
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtApellido.Focus();
                b = false;
            }
            else if (string.IsNullOrEmpty(txtNroTel.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtNroTel.Focus();
                b = false;
            }
            else if (string.IsNullOrEmpty(txtDir.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtDir.Focus();
                b = false;
            }
            else if (string.IsNullOrEmpty(txtBarrio.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtBarrio.Focus();
                b = false;
            }
            else if (string.IsNullOrEmpty(txtNroTel.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtNroTel.Focus();
                b = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("El campo esta vacio", "Campo vacio");
                txtEmail.Focus();
                b = false;
            }
            
            else
            {
                b = true;
            }

          

            return b;
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                if (comprobarCampos())
                {
                    Afiliado nuevo = new Afiliado();
                    nuevo.nombre = txtNombre.Text;
                    nuevo.apellido = txtApellido.Text;
                    nuevo.nroDoc = Convert.ToInt32(txtNroDoc.Text);
                    nuevo.nroTel = txtNroTel.Text;
                    nuevo.email = txtEmail.Text;
                    nuevo.fechaNac = dtpFechaNac.Value.ToShortDateString();
                    nuevo.localidad = Convert.ToInt32(cboLocalidades.SelectedValue);
                    nuevo.formaPago = Convert.ToInt32(cboForma.SelectedValue);
                    nuevo.tipoAfiliado = Convert.ToInt32(cboTipoAfil.SelectedValue);
                    nuevo.barrio = txtBarrio.Text;
                    nuevo.direccion = txtDir.Text;
                    nuevo.cbu = txtCbu.Text;

                    if (MetroFramework.MetroMessageBox.Show(this, "Desea registrar el afiliado dni nro: " + nuevo.nroDoc + "?", "Alta de afiliado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        g.RegistrarAfiliado(nuevo, "SP_REGISTRAR_AFILIADO", 0);
                        Inicio();
                    }

                    else
                    {

                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Error en el registro del afiliado: " + ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }


        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }


        private void txtNroTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        /*
         * Convertirmos el ArrayList a un vector, para facilitar el recorrido
         * y cargar los campos correspondientes a cada item del ListBox
         */
        Afiliado[] convertir()
        {
            Afiliado[] vector = listado.ToArray(typeof(Afiliado)) as Afiliado[];
            return vector;
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCampos(listBox1.SelectedIndex);
        }



        private void txtNroDoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNroDoc.Text))
            {
                if (txtNroDoc.TextLength is 8)
                {
                    int nroDoc = Convert.ToInt32(txtNroDoc.Text);
                    bandera = validar.existeDocumento(nroDoc);
                    if (bandera)
                    {
                        lblCheck.ForeColor = Color.Red;
                        btnGrabar.Enabled = false;
                    }
                    else
                    {
                        lblCheck.ForeColor = Color.Green;
                        btnGrabar.Enabled = true; 
                    }
                }
                else
                {
                    lblCheck.ForeColor = Color.Black;
                    btnGrabar.Enabled = false;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoAfiliado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarAfiliado();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int i = listBox1.SelectedIndex;
            int seleccionFormaPago = Convert.ToInt32(cboForma.SelectedValue);

            try
            {
                Afiliado afiliadoUpdate = new Afiliado();
                afiliadoUpdate.nombre = txtNombre.Text;
                afiliadoUpdate.apellido = txtApellido.Text;
                afiliadoUpdate.nroDoc = Convert.ToInt32(txtNroDoc.Text);
                afiliadoUpdate.nroTel = txtNroTel.Text;
                afiliadoUpdate.email = txtEmail.Text;
                afiliadoUpdate.fechaNac = dtpFechaNac.Value.ToShortDateString();
                afiliadoUpdate.localidad = Convert.ToInt32(cboLocalidades.SelectedValue);
                afiliadoUpdate.formaPago = Convert.ToInt32(cboForma.SelectedValue);
                afiliadoUpdate.tipoAfiliado = Convert.ToInt32(cboTipoAfil.SelectedValue);
                afiliadoUpdate.barrio = txtBarrio.Text;
                afiliadoUpdate.direccion = txtDir.Text;
                afiliadoUpdate.cbu = txtCbu.Text;
                afiliadoUpdate.afiliadoID = Convert.ToInt32(lblAfiliadoID.Text);
                afiliadoUpdate.estadoGremialID = Convert.ToInt32(cboEstadosGremiales.SelectedValue);
                afiliadoUpdate.cbu = txtCbu.Text;    

                if (MetroFramework.MetroMessageBox.Show(this, "Desea proseguir con la actualización de los datos del afiliado DNI nro: " + afiliadoUpdate.nroDoc + "?", "Actualizar datos de afiliado " + afiliadoUpdate.apellido.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    g.RegistrarAfiliado(afiliadoUpdate, "NewUpdateComando",2);
                    Inicio();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en el registro del afiliado: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BuscarDoc(string searchString)
        {

            if (searchString != string.Empty)
            {

                int index = listBox1.FindString(searchString);

                if (index != -1)
                    listBox1.SetSelected(index, true);
                else
                    MetroFramework.MetroMessageBox.Show(this, "El nro de documento no existe...");
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string docParametro = txtBuscar.Text;
            BuscarDoc(docParametro);
        }


        private void FormAdmAfiliados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Desea salir de la administración de afiliados?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
