using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataService;

namespace ProyectoOmegaR
{
    public partial class Frm_Maestro_Proveedores : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        Frm_Home_Omega Local_contene;
        private void MaestroProveedores_Load(object sender, EventArgs e)
        {
            txtcod.Text = Link_BD.CompletarCeros2(Link_BD.LastRegistro("CodProveedor", "Proveedores"));
            lblstatus.Text = "Modo Nuevo";
        }
        public Frm_Maestro_Proveedores(Frm_Home_Omega Refconten)
        {
            InitializeComponent();
            Local_contene = Refconten;
        }
        public Frm_Maestro_Proveedores()
        {
            InitializeComponent();
        }
        private void BuscarCodigo()
        {
            DataTable dt = Link_BD.Busq_AllinCadena("CodProveedor", txtcod.Text.ToString(), "Proveedores");
            if (dt.Rows.Count != 0)
            {
                txtNombre.Text = dt.Rows[0][1].ToString();
                txtDir.Text = dt.Rows[0][3].ToString();
                txtRUC.Text = dt.Rows[0][2].ToString();
                txtTelef.Text = dt.Rows[0][5].ToString();
                txt_email.Text = dt.Rows[0][9].ToString();
                txtcelular.Text = dt.Rows[0][7].ToString();
                txtciudad.Text = dt.Rows[0][4].ToString();
                txtcli_contac.Text = dt.Rows[0][6].ToString();
                txtproductos.Text = dt.Rows[0][10].ToString();
                txtrubro.Text = dt.Rows[0][8].ToString();
                btnEditar.Visible = true;
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
            txtcod.Text = Link_BD.CompletarCeros2(Link_BD.LastRegistro("CodProveedor","Proveedores"));
            txtNombre.Clear();
            txtDir.Clear();
            txtRUC.Clear();
            txtTelef.Clear();
            txt_email.Clear();
            txtcelular.Clear();
            txtciudad.Clear();
            txtcli_contac.Clear();
            txtproductos.Clear();
            txtrubro.Clear();
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
            btn_modificarCli.Visible = false;
            btnGrabar.Visible = true;
            btn_atras.Visible = false;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Limpiar();
            SetBontonesDefault();
        }

        private void btn_modificarCli_Click(object sender, EventArgs e)
        {
            if (txtcod.Text != "")
            {
                Link_BD.UpdateProveedor(txtcod.Text, txtNombre.Text, txtDir.Text, txtRUC.Text, txtciudad.Text, txtTelef.Text, txt_email.Text, txtcli_contac.Text, txtcelular.Text, txtrubro.Text, txtproductos.Text);
                Limpiar();
                SetBontonesDefault();
            }
            else
            {
                MessageBox.Show("Verifique el Codigo");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == Link_BD.CompletarCeros4(Link_BD.LastRegistro("CodProveedor", "Proveedores")))
            {
                if (Link_BD.DisponibleCliente(txtRUC.Text) == true)
                {
                    Link_BD.RegistrarProveedor(txtcod.Text, txtNombre.Text, txtDir.Text, txtRUC.Text,txtciudad.Text, txtTelef.Text, txt_email.Text, txtcli_contac.Text,txtcelular.Text,txtrubro.Text,txtproductos.Text);
                    Limpiar();
                    SetBontonesDefault();
                }
            }
            else
            {
                MessageBox.Show("No modifique el codigo.");
                txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("CodProveedor", "Proveedores"));
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblstatus.Text = "Modo Edicion";
            this.ModoEdicion(true);
            btnEditar.Visible = false;
        }
        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BuscarCodigo();
                this.ModoEdicion(false);
            }
        }
        private void ModoEdicion(bool estado)
        {
            //enable= significa habilitado
            //se invierte para el caso readonlystado = !estado;
            estado = !estado;
            txtNombre.ReadOnly = estado;
            txtDir.ReadOnly = estado;
            txtRUC.ReadOnly = estado;
            txtTelef.ReadOnly = estado;
            txt_email.ReadOnly = estado;
            txtcelular.ReadOnly = estado;
            txtciudad.ReadOnly = estado;
            txtcli_contac.ReadOnly = estado;
            txtproductos.ReadOnly = estado;
            txtrubro.ReadOnly = estado;
        }
    }
}
