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
    public partial class Cambiar_Contraseña : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string passact = Link_BD.get_CampoUsu("UsuPass");
            if(txt_passACT.Text == passact){
                if(txt_npassRE.Text == txt_npass.Text){
                    Link_BD.UpdatePassword(txt_npass.Text);
                    this.Close();
                    this.Dispose();
                }
                else
                    lbl_status1.Text = "No coinciden caracteres.";
            }
            else{
                lbl_status1.Text="Contraseña Incorrecta.";
            }
        }
    }
}
