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
    public partial class Frm_FacturaPrincipal : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        Frm_Home_Omega Local_contene;
        string CODCLIENTE;
        int FlagBusqProd = 0, rowIndex = 0;
        bool modoBuqueda = false, isRowSeleccionada = false;
        bool existeusuario = false;
        float tempIGV;
        public Frm_FacturaPrincipal()
        {
            InitializeComponent();
        }
        public Frm_FacturaPrincipal(Frm_Home_Omega Refconten)
        {
            InitializeComponent();
            Local_contene = Refconten;
        }

        private void FacturaPrincipal_Load(object sender, EventArgs e)
        {
            txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("BolCod", "boleta"));
            //autocomplete cmbcliente
            DataTable dt2 = Link_BD.cmbCliente();
            cmbcliente.SelectedText = "";
            cmbcliente.DataSource = dt2;
            cmbcliente.DisplayMember = "CliNom";
            cmbcliente.ValueMember = "CliCod";
            cmbcliente.AutoCompleteCustomSource = AutoComplete(dt2, "CliNom");
            cmbcliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbcliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataGVProductos.Rows.Add();
            txttot_boleta.Text = "0";
            txtIGV.Text = "0";
            txtsubtotal.Text = "0";
            txtfecha.Text = DateTime.Now.Date.ToString();
            btnGrabar.Enabled = false;
            btnquitarprod.Enabled = false;
        }
        private AutoCompleteStringCollection AutoComplete(DataTable dt, string cadena)
        {

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row[cadena]));
            }
            return stringCol;
        }
        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            Frm_Tabla_Clientes cliente = new Frm_Tabla_Clientes();
            //se le nada 2 para que sepa q es la factura
            cliente.setUpline(2, this);
            cliente.ShowDialog();
        }
        //METODOS INTERNOS
        //Busquedas
        private void Limpiar()
        {

            txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("BolCod", "boleta"));
            DataGVProductos.Rows.Clear();
            DataGVProductos.Rows.Add();
            txtRUC.Text = "";
            txtDir.Text = "";
            txttot_boleta.Text = "0";
            cmbcliente.SelectedText = "";
        }
        public void LoadbyTxtCodigo(string codigo, string opcion)
        {
            if (opcion == "Clientes")
            {
                CODCLIENTE = codigo;
                this.BuscarCodigoClienteby("CliCod", CODCLIENTE);
            }
            if (opcion == "Productos")
            {
                if (modoBuqueda == true)
                {
                    this.BuscarCodigoProductoby("ProCod", codigo, rowIndex + 1);
                    modoBuqueda = false;
                    MessageBox.Show(modoBuqueda.ToString()+"puto");
                    CalculaPreciototalProducto();
                }
                else
                    this.BuscarCodigoProductoby("ProCod", codigo, rowIndex);
            }
        }
        private void BuscarCodigoClienteby(string campo, string codigo)
        {
            DataTable dt = Link_BD.Busq_AllinCadena(campo, codigo, "clientes");
            if (dt.Rows.Count != 0)
            {
                cmbcliente.Text = "";
                cmbcliente.SelectedText = dt.Rows[0][1].ToString();
                txtRUC.Text = dt.Rows[0][6].ToString();
                txtDir.Text = dt.Rows[0][2].ToString();
            }
        }
        private void BuscarCodigoProductoby(string campo, string codigo, int currentrow)
        {

            DataTable dt = Link_BD.Busq_AllinCadena(campo, codigo, "productos");
            DataGVProductos.Rows[currentrow].Cells["Codigo"].Value = dt.Rows[0][0].ToString();
            DataGVProductos.Rows[currentrow].Cells["Nombre"].Value = dt.Rows[0][1].ToString();
            DataGVProductos.Rows[currentrow].Cells["Unidad"].Value = dt.Rows[0][2].ToString();
            DataGVProductos.Rows[currentrow].Cells["PrecioUnitario"].Value = dt.Rows[0][4].ToString();
            DataGVProductos.Rows[currentrow].Cells["Cantidad"].Value = "1";
            tempIGV = Convert.ToInt32(dt.Rows[0][5]);
        }

        private bool AgregarElemento(int index)//return verdadero si se agrego un producto
        {

            if (DataGVProductos.Rows[index].Cells["Codigo"].Value != null)//siel campo de codigo esta vacio no agrega una nueva fila
            {
                btnGrabar.Enabled = true;
                //cantidad por precio unitario
                int subtotal = Convert.ToInt32(DataGVProductos.Rows[index].Cells["Precio"].Value);
                //totaldecadapructo * (igv/100) -> acumulado
                txtIGV.Text = (Int32.Parse(txtIGV.Text) + (subtotal * (tempIGV / 100))).ToString();
                //calcula total y aumenta al anterior
                txttot_boleta.Text = (Int32.Parse(txttot_boleta.Text) + subtotal).ToString();
                txtsubtotal.Text = (Int32.Parse(txttot_boleta.Text) - Int32.Parse(txtIGV.Text)).ToString();
                btnquitarprod.Enabled = true;
                FlagBusqProd = 0;
                return true;
            }
            else
            {
                MessageBox.Show("No hay productos para Agregar");
                return false;
            }
        }
        private void BuscarElemento()
        {
            Frm_Tabla_Productos productos = new Frm_Tabla_Productos();
            productos.setUpline(3, this);
            productos.ShowDialog();
        }
        private void QuitarElemento(int index)
        {
            int currentrow = DataGVProductos.CurrentRow.Index;
            if (DataGVProductos.Rows[currentrow].Cells["Codigo"].Value != null)
            //if (DataGVProductos.Rows[currentrow].Cells["Codigo"] != null)
            {
                DialogResult dialogResult = MessageBox.Show(DataGVProductos.Rows[currentrow].Cells["Nombre"].Value.ToString(), "Desea Quitar este producto", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int total = Convert.ToInt32(txttot_boleta.Text) - Convert.ToInt32(DataGVProductos.Rows[currentrow].Cells["Precio"].Value);
                    txttot_boleta.Text = total.ToString();
                    DataGVProductos.Rows.RemoveAt(currentrow);
                    rowIndex--;
                    MessageBox.Show(rowIndex.ToString());
                    if (rowIndex == -1)
                        btnquitarprod.Enabled = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
                MessageBox.Show("Seleccione un elemento");
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string codcliente = "";
            int f = 0;//bandera para comprobar que se haya agregado un usuario
            if (cmbcliente.SelectedValue == null)//si no existe o lo registra o crea la boleta como nulo
            {
                DialogResult dialogResult = MessageBox.Show("Desea Agregar a:" + cmbcliente.Text, "Sugerencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.AgregarCliente();//Se crea el cliente y despues hay q volver a precionar Grabar para que no hayan erores
                }
                else if (dialogResult == DialogResult.No)
                {
                    Link_BD.UpdateCliente("0000", cmbcliente.Text, txtDir.Text, txtRUC.Text, "", "", "", "", "1");
                    codcliente = "0000";
                    f = 1;
                }
            }
            else
            {
                codcliente = cmbcliente.SelectedValue.ToString();
                f = 1;
            }
            if (f == 1)
            {
                string usulocal = Link_BD.get_CampoUsu("UsuLocal");
                string usucod = Link_BD.get_CampoUsu("UsuCod");
                if (txtcod.Text == Link_BD.CompletarCeros4(Link_BD.LastRegistro("BolCod", "boleta")))
                {
                    //codcliente se pone segun la decicison del usuario
                    Link_BD.RegistrarBoleta(txtcod.Text, txtcod.Text, codcliente, txttot_boleta.Text, txtfecha.Text, usulocal, usucod);
                    for (int i = 0; i <= rowIndex; i++)
                    {
                        string codprod = DataGVProductos.Rows[i].Cells["Codigo"].Value.ToString();
                        int cantidad = Convert.ToInt32(DataGVProductos.Rows[i].Cells["Cantidad"].Value);
                        string precioU = DataGVProductos.Rows[i].Cells["PrecioUnitario"].Value.ToString();
                        string precioTot = DataGVProductos.Rows[i].Cells["Precio"].Value.ToString();
                        Link_BD.RegistrarDetalleBoleta(txtcod.Text, codprod, cantidad, "", precioU, precioTot);
                        Link_BD.UpdateStock(usulocal, codprod, cantidad, usucod, "quitar");
                    }
                    /*TipodeCancelacion objTipocan = new TipodeCancelacion();
                    objTipocan.setDatosBoleta(txtcod.Text, codcliente, txttot_boleta.Text);
                    objTipocan.Show();*/
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No modifique el codigo.");
                    txtcod.Text = Link_BD.CompletarCeros4(Link_BD.LastRegistro("BolCod", "boleta"));
                }
            }
        }
        private void cmbcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbcliente.SelectedValue !=null)
                {
                    this.BuscarCodigoClienteby("CliCod", cmbcliente.SelectedValue.ToString());
                }
            }
        }

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BuscarCodigoClienteby("CliRuc", txtRUC.Text);
            }
        }

        private void btnbuscarprod_Click(object sender, EventArgs e)
        {
            this.BuscarElemento();
            modoBuqueda = true;
        }
        //BUsqueda en celda
        void text_KeyUp(object sender, KeyEventArgs e)
        {
            rowIndex = ((DataGridViewTextBoxEditingControl)(sender)).EditingControlRowIndex;
            if (e.KeyCode == Keys.Delete)
            {
                this.QuitarElemento(rowIndex);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                this.BuscarElemento();
                DataGVProductos.EndEdit();
                FlagBusqProd = 1;
            }
            if (e.KeyCode == Keys.Tab)
            {
                if (FlagBusqProd == 0)
                {
                    string valueEntered = DataGVProductos.Rows[rowIndex].Cells["Codigo"].Value.ToString();
                    this.BuscarCodigoProductoby("ProCod", valueEntered.ToString(), rowIndex);
                    FlagBusqProd = 1;
                    DataGVProductos.EndEdit();
                    //this.AgregarElemento(rowIndex);
                }

            }
            if (FlagBusqProd == 1)
            {
                CalculaPreciototalProducto();
            }
        }
        private void DataGVProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGVProductos.BeginEdit(false);
            DataGVProductos[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.DarkGray;
        }
        private void DataGVProductos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGVProductos[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.DarkGray;
        }
        private void DataGVProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
            dText.KeyUp -= new KeyEventHandler(text_KeyUp);
            dText.KeyUp += new KeyEventHandler(text_KeyUp);
        }

        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            //Si tiene mas de una linea se agrega
            if (this.AgregarElemento(rowIndex))
                DataGVProductos.Rows.Add();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnquitarprod_Click(object sender, EventArgs e)
        {
            this.QuitarElemento(rowIndex - 1);
        }

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            this.AgregarCliente();
        }
        private void AgregarCliente()
        { // llama al form para que se cree un nuevo cliente
            Frm_Mantenimiento_Cliente n_cliente = new Frm_Mantenimiento_Cliente();
            n_cliente.setUpline(1, this);
            n_cliente.ShowDialog();
        }
        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGVProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DataGVProductos.Rows[rowIndex].Cells["Codigo"].Value != null)//x si se apreta cualquier tecla y el codigo esta vacio
                {
                    if (FlagBusqProd == 0) // Primero Buca
                    {
                        string valueEntered = DataGVProductos.Rows[rowIndex].Cells["Codigo"].Value.ToString();
                        this.BuscarCodigoProductoby("ProCod", valueEntered.ToString(), rowIndex);
                        FlagBusqProd = 1;
                        DataGVProductos.EndEdit();
                        //this.AgregarElemento(rowIndex);
                    }
                }

            }
            if (FlagBusqProd == 1)//Luego calcula el precio de lo que busco
            {
                CalculaPreciototalProducto();
            }


        }
        private void CalculaPreciototalProducto()
        {
            int total = Convert.ToInt32(DataGVProductos.Rows[rowIndex].Cells["Cantidad"].Value) * Convert.ToInt32(DataGVProductos.Rows[rowIndex].Cells["PrecioUnitario"].Value);
            DataGVProductos.Rows[rowIndex].Cells["Precio"].Value = total.ToString();
          
            DataGVProductos.EndEdit();
        }
    }
}
