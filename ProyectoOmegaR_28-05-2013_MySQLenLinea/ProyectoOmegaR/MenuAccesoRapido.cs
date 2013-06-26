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
    public partial class MenuAccesoRapido : Form
    {
        HomeOmega Local_contene;
        public MenuAccesoRapido(HomeOmega refcontene)
        {
            InitializeComponent();
            Local_contene = refcontene;
        }
    }
}
