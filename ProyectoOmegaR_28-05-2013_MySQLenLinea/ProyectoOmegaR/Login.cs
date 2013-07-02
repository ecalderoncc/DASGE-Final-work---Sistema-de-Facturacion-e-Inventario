using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoOmegaR
{
    public partial class Login : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        string fechaingreso;
        int f = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.LoginBTN();
        }
        private void LoginBTN()
        {
            f = 0;
            if (textBnombre.Text == "" || txtpass.Text == "")
            {
                lbl_status1.Text = "Complete los campos";
                f = 1;// si no ingresamos algun dato entonces no nos permitira continuar entonces tenemos q ingresar todos los datos
            }
            if (f == 0)
            {
                

                string observer = Link_BD.Login(textBnombre.Text, txtpass.Text);
                switch (observer)
                {
                    case "Usuario no existe":
                        {
                            lbl_status1.Text = "Usuario no existe";
                            break;
                        }
                    case "Pass incorrecto":
                        {
                            lbl_status1.Text = "Pass incorrecto";
                            break;
                        }
                    case "OK":
                        {
                            //--MECANISMO DE ESPERA--
                            BarraProgreso.Maximum = 1000000;
                            BarraProgreso.Minimum = 0;
                            BarraProgreso.Value = 0;
                            BarraProgreso.Step = 1;
                            for (int i = BarraProgreso.Minimum; i < BarraProgreso.Maximum; i = i + BarraProgreso.Step)
                            {
                                //esta instrucción avanza la posición actual de la barra
                                BarraProgreso.PerformStep();
                            }
                            //--TERMINO DE MECANISMO DE ESPERA--

                            HomeOmega A = new HomeOmega(Link_BD.get_CampoUsu("UsuNom"),this);
                            A.Show();
                            txtpass.Text = "";
                            this.Hide();
                            lbl_status1.Text = "";
                            string usucod;
                            string usuid;
                            usucod = Link_BD.get_CampoUsu("Usucod");
                            usuid = Link_BD.get_CampoUsu("UsuId");
                            fechaingreso = DateTime.Now.ToString();
                            Link_BD.RegistrarUsuLogging(usucod, usuid, fechaingreso);
                            break;

                        }
                    case "":
                        {
                            lbl_status1.Text = "Error BD";
                            break;
                        }

                }
            }
        }

        private void textBnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBTN();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBTN();
            }
        }
    }
}
