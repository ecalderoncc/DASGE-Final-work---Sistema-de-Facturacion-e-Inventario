using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace ProyectoOmegaR
{
    public partial class TipodeCancelacion : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        string lCODBol;
        string lCODCli;
        public TipodeCancelacion()
        {
            InitializeComponent();

        }
        public void setDatosBoleta(string codb, string codcliente,string preciototal) {
            lCODBol = codb;
            lCODCli = codcliente;
            txttotal.Text = preciototal;
        }
        private void TipodeCancelacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'OmegaRDataSet.boleta' Puede moverla o quitarla según sea necesario.
            this.boletaTableAdapter.Fill(this.OmegaRDataSet.boleta, lCODBol);
            // TODO: esta línea de código carga datos en la tabla 'OmegaRDataSet.DatosCliente' Puede moverla o quitarla según sea necesario.
            this.DatosClienteTableAdapter.Fill(this.OmegaRDataSet.DatosCliente, lCODCli);
            // TODO: esta línea de código carga datos en la tabla 'DataSetOmegaRealNube.DetalleBoleta' Puede moverla o quitarla según sea necesario.
            this.DetalleBoletaTableAdapter.Fill(this.OmegaRDataSet.DetalleBoleta, lCODBol);
            
            this.reportViewer1.RefreshReport();
        }

        private void txtefectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int cambio = Int32.Parse(txtefectivo.Text) - Int32.Parse(txttotal.Text);
                txtcambio.Text = cambio.ToString();
            }
        }
    }
}
