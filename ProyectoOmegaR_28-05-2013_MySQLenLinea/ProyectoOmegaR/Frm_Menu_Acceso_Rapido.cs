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
    public partial class Frm_Menu_Acceso_Rapido : Form
    {
        Frm_Home_Omega Local_contene;
        public Frm_Menu_Acceso_Rapido(Frm_Home_Omega refcontene)
        {
            InitializeComponent();
            Local_contene = refcontene;
        }
    }
}
