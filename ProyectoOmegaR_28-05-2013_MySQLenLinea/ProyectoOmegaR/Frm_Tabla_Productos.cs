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
    public partial class Frm_Tabla_Productos : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        static string busq = "";
        int flag = 0, upline = 0;
        Frm_Home_Omega Localcontene;
        Frm_Boleta_Principal Nboleta;
        Frm_Mantenimiento_Productos MantenimientoPro;
        Frm_Ingreso_Producto_Almacen ingresoalmacen_obj;
        Frm_FacturaPrincipal NFactura;
        public Frm_Tabla_Productos()
        {
            InitializeComponent();
        }
        public Frm_Tabla_Productos(Frm_Home_Omega Refconten)
        {
            InitializeComponent();
            Localcontene = Refconten;
            MantenimientoPro = new Frm_Mantenimiento_Productos(Localcontene);
            MantenimientoPro.MdiParent = Localcontene;
            MantenimientoPro.Show();
        }

        private void TablaProductos_Load(object sender, EventArgs e)
        {
            dataGrid_CLIENTES.DataSource = Link_BD.Busq_CadenaProductoBy("ProdNom", "");
            cmb_busqtipo.SelectedIndex = 0;
            txt_busqpro.Select();
        }
        public void setUpline(int ln,Frm_Mantenimiento_Productos mp)
        {
            upline = ln;
            MantenimientoPro = mp;
        }
        public void setUpline(int ln, Frm_Boleta_Principal NBoleta)
        {
            upline = ln;
            Nboleta = NBoleta;
        }
        public void setUpline(int ln, Frm_FacturaPrincipal Nfactura)
        {
            upline = ln;
            NFactura = Nfactura;
        }
        public void setUpline(int ln, Frm_Ingreso_Producto_Almacen objingreso)
        {
            upline = ln;
            ingresoalmacen_obj = objingreso;
        }
        private void btn_selec_cli_Click(object sender, EventArgs e)
        {
            //llamada de nuevo producto
            if (upline == 0)
            {
                if (dataGrid_CLIENTES.VisibleRowCount != 0)
                {
                    object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                    string codigo = selectedItem.ToString();
                    Frm_Mantenimiento_Productos mp = new Frm_Mantenimiento_Productos(); 
                    MantenimientoPro.LoadbyTxtCodigo(codigo);
                    this.Close();
                    this.Dispose();
                }
            }
            //llamada de boleta
            if (upline == 1)
            {
                if (dataGrid_CLIENTES.VisibleRowCount != 0)
                {
                    object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                    string codigo = selectedItem.ToString();
                    Nboleta.Show();
                    Nboleta.LoadbyTxtCodigo(codigo,"Productos");
                    this.Dispose();
                    upline = 0;
                }
            }
            //llamada de nuevo stock
            if (upline == 2)
            {
                if (dataGrid_CLIENTES.VisibleRowCount != 0)
                {
                    object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                    string codigo = selectedItem.ToString();
                    ingresoalmacen_obj.Show();
                    ingresoalmacen_obj.LoadbyTxtCodigo(codigo);
                    this.Dispose();
                    upline = 0;
                }
            }
            //llamada de nuevo factura
            if (upline == 3)
            {
                if (dataGrid_CLIENTES.VisibleRowCount != 0)
                {
                    object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                    string codigo = selectedItem.ToString();
                    NFactura.Show();
                    NFactura.LoadbyTxtCodigo(codigo, "Productos");
                    this.Dispose();
                    upline = 0;
                }
            }
        }

        private void cmb_busqtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_busqtipo.SelectedIndex)
            {
                case 0:
                    busq = "ProdNom";
                    break;
                case 1:
                    busq = "ProdCant";
                    break;
                case 2:
                    busq = "ProdUnidad";
                    break;
                case 3:
                    busq = "ProdCosto";
                    break;
                case 4:
                    busq = "ProdPrecio";
                    break;
            }
            if (flag == 0)
            {
                //dataTable = Link_BD.BuscarCliente(busq);
                dataGrid_CLIENTES.DataSource = Link_BD.BuscarProducto(busq);
            }
            flag = 0;
        }

        private void txt_busqpro_TextChanged(object sender, EventArgs e)
        {
            dataGrid_CLIENTES.DataSource = Link_BD.Busq_CadenaProductoBy(busq, txt_busqpro.Text);
        }

        private void dataGrid_CLIENTES_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
