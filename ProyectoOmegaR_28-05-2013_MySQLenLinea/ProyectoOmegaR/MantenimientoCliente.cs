using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoOmegaR
{
    public partial class MantenimientoCliente : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        BoletaPrincipal Nboleta;
        FacturaPrincipal Nfactura;
        HomeOmega Local_contene;
        //NuevoContrato nc;
        static string busq = "";
        int flag = 0, upline = 0;
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public MantenimientoCliente(HomeOmega Refconten)
        {
            InitializeComponent();
            Local_contene = Refconten;
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {
            txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("CliCod", "clientes"));
            lblstatus.Text = "Modo Nuevo";
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string codcliente = "";
            //Si se llama por defecto
            string check = "0";
            if (rdSI.Checked)
                check = "1";
            if (rdNO.Checked)
                check = "0";
            if (txtcod.Text == Link_BD.CompletarCeros4(Link_BD.LastRegistro("CliCod", "clientes")))
            {
                if (Link_BD.DisponibleCliente(txtRUC.Text) == true)
                {
                    Link_BD.RegistrarCliente(txtcod.Text, txtNombre.Text, txtDir.Text, txtRUC.Text, txtciudad.Text, txtTelef.Text, txt_email.Text, txtcli_contac.Text, check);
                    codcliente = txtcod.Text;
                    Limpiar();
                    SetBontonesDefault();
                }
            }
            else
            {
                MessageBox.Show("No modifique el codigo.");
                txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("CliCod", "clientes"));
            }
            //Si lo llama nueva boleta
            if (upline == 1) {
                //Nboleta.Show();
                Nboleta.LoadbyTxtCodigo(codcliente, "Clientes");
                this.Dispose();
                upline = 0;
            }
                 
        }
        private void btn_modificarCli_Click(object sender, EventArgs e)
        {
            string check = "0";
            if (rdSI.Checked)
                check = "1";
            if (rdNO.Checked)
                check = "0";
            if (txtcod.Text != "")
            {
                Link_BD.UpdateCliente(txtcod.Text, txtNombre.Text, txtDir.Text, txtRUC.Text, txtciudad.Text, txtTelef.Text, txt_email.Text, txtcli_contac.Text, check);
                Limpiar();
                SetBontonesDefault();
            }
            else
            {
                MessageBox.Show("Verifique el Codigo");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
            btn_modificarCli.Visible = false;
            btnGrabar.Visible = true;
            btn_atras.Visible = false;
        }

        private void btn_busq_cod_Click(object sender, EventArgs e)
        {
            TablaClientes buscarcliente = new TablaClientes(this);
            buscarcliente.Show();
           // this.Dispose();
        }
        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BuscarCodigo();
                this.ModoEdicion(false);
            }
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            Limpiar();
            SetBontonesDefault();
        }
        //Metodos Codigo interno
        public void setUpline(int ln, BoletaPrincipal NBoleta)
        {
            upline = ln;
            Nboleta = NBoleta;
        }
        public void setUpline(int ln, FacturaPrincipal NFactura)
        {
            upline = ln;
            Nfactura = NFactura;
        }
        public void LoadbyTxtCodigo(string codigo) {
            txtcod.Text = codigo;
            this.BuscarCodigo();
        }
        private void BuscarCodigo()
        {
            DataTable dt = Link_BD.Busq_AllinCadena("CliCod", txtcod.Text.ToString(), "clientes");
            if (dt.Rows.Count != 0)
            {
                txtNombre.Text = dt.Rows[0][1].ToString();
                txtDir.Text = dt.Rows[0][2].ToString();

                txtciudad.Text = dt.Rows[0][8].ToString();

                txtTelef.Text = dt.Rows[0][3].ToString();
                txtRUC.Text = dt.Rows[0][6].ToString();
                txt_email.Text = dt.Rows[0][7].ToString();
                txtcli_contac.Text = dt.Rows[0][8].ToString();
                btnEditar.Visible = true;
                if (dt.Rows[0][4].ToString() == "1")
                {
                    rdNO.Checked = false;
                    rdSI.Checked = true;
                }
                else
                {
                    rdNO.Checked = true;
                    rdSI.Checked = false;
                }
                if (txtNombre.Text != "")
                {
                    btn_modificarCli.Visible = true;
                    btnGrabar.Visible = false;
                    btnClear.Visible = false;
                    btn_atras.Visible = true;
                    txtcod.Enabled = false;
                }
            }
            else
                MessageBox.Show("Codigo no encontrado");
        }
        private void Limpiar()
        {
            rdNO.Checked = false;
            rdSI.Checked = true;
            txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("CliCod","clientes"));
            txtciudad.Clear();
            txtNombre.Clear();
            txtDir.Clear();
            txtTelef.Clear();
            txtRUC.Clear();
            txtcli_contac.Clear();
            txt_email.Clear();
            lblstatus.Text = "Modo Nuevo";
        }
        private void SetBontonesDefault() {
            btn_modificarCli.Visible = false;
            btnGrabar.Visible = true;
            btn_atras.Visible = false;
            txtcod.Enabled = true;
            btnClear.Visible = true;
            btnEditar.Visible = false;
        }
        //Restricciones
        private void txtTelef_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{6,9}$");
            if (!regex.IsMatch(txtTelef.Text))
            {
                txtTelef.BackColor = Color.Tomato;
                label8.Text = "Campo Telefono incorrecto.";
            }
            else
            {
                this.txtTelef.BackColor = Color.LightCyan;
                label8.Text = "";

            }
        }
        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            Regex regexDNI = new Regex(@"^[0-9]{11}$");
            if (!regexDNI.IsMatch(txtRUC.Text))
            {
                txtRUC.BackColor = Color.Tomato;
                label8.Text = "Campo RUC incorrecto.";
            }
            else
            {
                this.txtRUC.BackColor = Color.LightCyan;
                label8.Text = "";

            }
        }
        //RadioButton
        private void rdNO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNO.Checked == true)
                rdSI.Checked = false;
        }
        private void rdSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSI.Checked == true)
                rdNO.Checked = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Modo Edicion";
            this.ModoEdicion(true);
            btnEditar.Visible = false;
        }
        private void ModoEdicion(bool estado)
        {
            //enable= significa habilitado
            rdSI.Enabled = estado;
            rdNO.Enabled = estado;

            //se invierte para el caso readonlystado = !estado;
            estado = !estado;
            txtciudad.ReadOnly = estado;
            txtNombre.ReadOnly = estado;
            txtDir.ReadOnly = estado;
            txtTelef.ReadOnly = estado;
            txtRUC.ReadOnly = estado;
            txtcli_contac.ReadOnly = estado;
            txt_email.ReadOnly = estado;
        }
    }
}
