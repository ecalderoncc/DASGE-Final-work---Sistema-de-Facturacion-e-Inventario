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
    public partial class HomeOmega : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        Login login;

        //
        MantenimientoCliente mant_cli;
        BoletaPrincipal NuevaBoleta;
        FacturaPrincipal NuevaFactura;
        TablaClientes tablacli;
        MantenimientoProductos mant_pro;
        TablaProductos tablapro;
        MenuAccesoRapido menurapido;
        IngresoProductoAlmacen ingresoalmacen_obj;
        MaestroProveedores NProveedor;
        public HomeOmega(string nombre, Login log)
        {
            InitializeComponent();
            lbl_nombre.Text = "Bienvenido: " + nombre;
            login = log;
            menurapido = new MenuAccesoRapido(this);
            /*tablapro = new TablaProductos(this);
            mant_pro = new MantenimientoProductos(this);
            tablacli = new TablaClientes(this);
            NuevaBoleta = new BoletaPrincipal(this);
            mant_cli = new MantenimientoCliente(this);*/
        }
        private void MenuClientesNuevo_Click(object sender, EventArgs e)
        {
            mant_cli = new MantenimientoCliente(this);
            mant_cli.MdiParent = this;
            //a.LayoutMdi(MdiLayout.ArrangeIcons);
            mant_cli.Show();
        }

        private void MenuClientesTabla_Click(object sender, EventArgs e)
        {
            tablacli = new TablaClientes(this);
            tablacli.ShowDialog();
        }

        private void MenuProductosnuevo_Click(object sender, EventArgs e)
        {
            mant_pro = new MantenimientoProductos(this);
            mant_pro.MdiParent = this;
            mant_pro.Show();
        }

        private void menutablaproductos_Click(object sender, EventArgs e)
        {
            tablapro = new TablaProductos(this);
            tablapro.ShowDialog();
        }

        private void MenuBoletaNuevo_Click(object sender, EventArgs e)
        {
            NuevaBoleta = new BoletaPrincipal(this);
            NuevaBoleta.MdiParent = this;
            NuevaBoleta.Show();
        }
        private void MenuFacturaNuevo_Click(object sender, EventArgs e)
        {
            NuevaFactura = new FacturaPrincipal(this);
            NuevaFactura.MdiParent = this;
            NuevaFactura.Show();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
            this.Dispose();
        }
        private void HomeOmega_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void HomeOmega_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro?","Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        

        private void HomeOmega_Load(object sender, EventArgs e)
        {
            string rolUsuario = Link_BD.get_CampoUsu("UsuRol");
            //Vendedor
            if (rolUsuario == "1")
            {
                MenuClientesNuevo.Visible = true; // Menu cliente mantenimiento
            }
            //Administrador Local
            if (rolUsuario == "2")
            {
                MenuProductosnuevo.Visible = true; // menu mantenimiento productos
                ingresoAlmacenToolStripMenuItem.Visible = true; // menu ingreso almacen
                MenuClientesNuevo.Visible = true; // Menu cliente mantenimiento
            }
            //Super Usuario
            if (rolUsuario == "3")
            {
                MenuProductosnuevo.Visible = true; // menu mantenimiento productos
                ingresoAlmacenToolStripMenuItem.Visible = true; // menu ingreso almacen
                MenuClientesNuevo.Visible = true; // Menu cliente mantenimiento
                mantenimientoToolStripMenuItem.Visible = true;
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambiar_Contraseña nPass = new Cambiar_Contraseña();
            nPass.ShowDialog();
        }

        private void ingresoAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoalmacen_obj = new IngresoProductoAlmacen(this);
            ingresoalmacen_obj.MdiParent = this;
            ingresoalmacen_obj.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant_cli = new MantenimientoCliente(this);
            mant_cli.MdiParent = this;
            //a.LayoutMdi(MdiLayout.ArrangeIcons);
            mant_cli.Show();
        }

        private void almacenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant_pro = new MantenimientoProductos(this);
            mant_pro.MdiParent = this;
            mant_pro.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NProveedor = new MaestroProveedores(this);
            NProveedor.MdiParent = this;
            NProveedor.Show();
        }
    }
}
