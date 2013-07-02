using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProyectoOmegaR
{
    class BDPrincipal
    {
        static MySqlConnection ConexionAccess;
        MySqlConnection con = new MySqlConnection();
        //static DataSet dataSet = new DataSet();
        DataTable dataTable = new DataTable();
        static MySqlDataAdapter DataAdapter;
        static int sw = 0; // variable login
        static string IDUSU; // variale id del usuario
        // Nueva cadena de conexion SQL en Linea
        string ConexionString;
        
        public BDPrincipal()
        {
            if (sw == 0)
            {
                ConexionString = "Server=50.63.244.72;user=OmegaR;password=Honguito!1;database=OmegaR;port=3306;";
                ConexionAccess = new MySqlConnection(ConexionString);
                string selectCommand = "SELECT * FROM Marcas";
                DataAdapter = new MySqlDataAdapter(selectCommand, ConexionAccess);
                IDUSU = "";
                sw = 1;
            }
        }
        //disponible para registrar y ruc
        public bool DisponibleCliente(string RUC)
        {
            DataTable ds = new DataTable();
            string outp = "";
            try
            {
                ConexionAccess.Open();
                DataAdapter.SelectCommand.CommandText = "SELECT `CliCod` From `clientes` Where `CliRUC` ='" + RUC + "'";
                DataAdapter.Fill(ds);
                outp = ds.Rows[0][0].ToString();
                if (outp != "")
                {
                    MessageBox.Show("El Cliente ya existe en COD: " + outp);
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                if (ConexionAccess.State == ConnectionState.Open)
                    ConexionAccess.Close();
            }
            return true;
        }
        public bool DisponibleProducto(string RUC)
        {
            DataTable ds = new DataTable();
            string outp = "";
            try
            {
                ConexionAccess.Open();
                DataAdapter.SelectCommand.CommandText = "SELECT `ProCod` From `productos` Where `ProdNom` ='" + RUC + "'";
                DataAdapter.Fill(ds);
                outp = ds.Rows[0][0].ToString();
                if (outp != "")
                {
                    MessageBox.Show("El Producto ya existe en COD: " + outp);
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                if (ConexionAccess.State == ConnectionState.Open)
                    ConexionAccess.Close();
            }
            return true;
        }
        public void RegistrarUsuLogging(string usucod, string usuid, string fecha)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO LOGGING(UsuCod, UsuId, DateIn) VALUES ('" + usucod + "', '" + usuid + "', '" + fecha + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bienvenido "+ usuid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public string get_CampoUsu(string valor)
        {
            DataTable dt = new DataTable();
            try
            {
                ConexionAccess.Open();
                DataAdapter.SelectCommand.CommandText = "SELECT `" + valor + "` from `Usuarios` where `UsuId` ='" + IDUSU + "'";
                DataAdapter.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario no logeado");
            }
            finally
            {
                if (ConexionAccess.State == ConnectionState.Open)
                    ConexionAccess.Close();
            }
            return "";
        }
        public string Login(string usuario, string pass)
        {
            DataTable dt = new DataTable();
            string outusu="", outpass;
            IDUSU ="";
            int sw = 0;
            try
            {
                ConexionAccess.Open();
                DataAdapter.SelectCommand.CommandText = "SELECT UsuId,UsuPass From Usuarios Where UsuId ='" + usuario + "'";
                DataAdapter.Fill(dt);
                outusu = dt.Rows[0][0].ToString();
                outpass = dt.Rows[0][1].ToString();
                if (outusu == usuario)
                {
                    IDUSU = outusu;
                    sw = 1;
                    ConexionAccess.Close();
                }
                if (sw == 1)
                {
                    if (outpass == pass)
                    {
                        return "OK";
                    }
                    else
                        return "Pass incorrecto";
                }
                if (sw != 1)
                {
                    return "Usuario no existe";
                }
            }
            catch (Exception)
            {
                return "Usuario no existe";
            }
            finally
            {
                if (ConexionAccess.State == ConnectionState.Open)
                    ConexionAccess.Close();
            }
            return "";
        }

        //Actualizar contraseña
        public void UpdatePassword(string pass)
        {
            string usucod = this.get_CampoUsu("UsuCod");
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE `Usuarios` SET `UsuPass`='" + pass + "' WHERE `UsuCod`='" + usucod + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        //Metodos de Busqueda
        public DataTable Busq_AllinCadena(string cad_busq, string txtprin, string tabla)
        {
            DataTable data1 = new DataTable();
           
            try
            {
                if (cad_busq == "")
                    MessageBox.Show("Error Busc_Cadena");

                DataAdapter.SelectCommand.CommandText = "SELECT * FROM `" + tabla + "` WHERE `" + cad_busq + "` ='" + txtprin + "'";
                DataAdapter.Fill(data1);
            }
            catch (Exception ex)
            {
            }
            return data1;
        }
        //Busqueda cliente
        public DataTable BuscarCliente(string cad_busq)
        {
           
            DataTable data1 = new DataTable();
            DataAdapter.SelectCommand.CommandText = "SELECT `CliCod` AS Codigo,`CliNom` AS Nombre, `CliDir` AS Direccion, `CliRUC` AS RUC, `CliPais` AS Pais,`CliDepa` AS Departamento, `CliTelef` AS Telefono, `CliEmail` AS Email, `CliContac` AS Contacto FROM `clientes` ORDER BY `" + cad_busq + "` ASC";
            DataAdapter.Fill(data1);
            return data1;
        }
        public DataTable Busq_CadenaClienteBy(string camp_busq, string txt)
        {
            DataTable data1 = new DataTable();
            try
            {
                if (camp_busq == "")
                    camp_busq = "CliNom";

                DataAdapter.SelectCommand.CommandText = "SELECT `CliCod` AS Codigo,`CliNom` AS Nombre, `CliDir` AS Direccion, `CliRUC` AS RUC, `CliPais` AS Pais,`CliDepa` AS Departamento, `CliTelef` AS Telefono, `CliEmail` AS Email, `CliContac` AS Contacto FROM `clientes` WHERE `" + camp_busq + "` LIKE '%" + txt + "%'";
                DataAdapter.Fill(data1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data1;
        }
        public DataTable Busq_CadenaActivi(string txt, string n)
        {
            DataTable data1 = new DataTable();
            try
            {
                DataAdapter.SelectCommand.CommandText = "SELECT `CliCod` AS Codigo,`CliNom` AS Nombre, `CliDir` AS Direccion, `CliRUC` AS RUC, `CliPais` AS Pais,`CliDepa` AS Departamento, `CliTelef` AS Telefono, `CliEmail` AS Email, `CliContac` AS Contacto FROM `clientes` WHERE `ACTIVI`='" + n + "' AND `CliNom` LIKE '%" + txt + "%'";
                DataAdapter.Fill(data1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data1;
        }
        //Busqueda producto
        //Buscar marcas y modelos Modificar sentencias
        public DataTable Buscar_Marca(string marca)
        {
            DataTable dt = new DataTable();
            DataAdapter.SelectCommand.CommandText = "SELECT CodModel,NomModel FROM ModelosProd INNER JOIN MarcasProd ON ModelosProd.CodMarca = MarcasProd.CodMarca WHERE MarcasProd.CodMarca = '" + marca + "'";
            DataAdapter.Fill(dt);
            return dt;
        }
        public DataTable MostrarMarca()
        {
            DataTable dt = new DataTable();
            DataAdapter.SelectCommand.CommandText = "SELECT * from MarcasProd";
            DataAdapter.Fill(dt);
            return dt;
        }
        public DataTable BuscarProducto(string cad_busq)
        {

            DataTable data1 = new DataTable();
            DataAdapter.SelectCommand.CommandText = "SELECT ProCod AS Codigo,ProdNom AS Nombre, ProdUnidad AS Unidad, ProdCosto AS Costo,ProdPrecio AS Precio FROM productos ORDER BY " + cad_busq + " ASC";
            DataAdapter.Fill(data1);
            return data1;
        }
        public DataTable Busq_CadenaProductoBy(string camp_busq, string txt)
        {
            DataTable data1 = new DataTable();
            try
            {
                if (camp_busq == "")
                    camp_busq = "ProdNom";

                DataAdapter.SelectCommand.CommandText = "SELECT ProCod AS Codigo,ProdNom AS Nombre, ProdUnidad AS Unidad, ProdCosto AS Costo,ProdPrecio AS Precio FROM productos WHERE " + camp_busq + " LIKE '%" + txt + "%'";
                DataAdapter.Fill(data1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data1;
        }
        //Insert - Update Cliente
        public void RegistrarProveedor(string cod, string Nombre, string Direccion, string RUC, string ciudad, string Telefo, string email, string contacto, string celular, string rubro, string productos)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Proveedores(`CodProveedor`, `NomProveedor`,  `DirProveedor`,`RUCProveedor`, `CiudadProveedor`, `TelefProveedor`, `ContacProveedor`, `emailProveedor`, `CelularProveedor`, `RubroProveedor`, `ProductosProveedor`) VALUES ('" + cod + "', '" + Nombre + "', '" + Direccion + "', '"
                    + RUC + "', '" + ciudad + "', '" + Telefo + "', '" + contacto + "', '" + email + "', '" + celular + "', '" + rubro + "', '" + productos + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos correctamente guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void UpdateProveedor(string cod, string Nombre, string Direccion, string RUC, string ciudad, string Telefo, string email, string contacto, string celular, string rubro, string productos)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE clientes SET NomProveedor='" + Nombre + "', DirProveedor='" + Direccion + "', RUCProveedor='" + RUC + "', CiudadProveedor='" + ciudad + "', TelefProveedor='" + Telefo +
                    "', ContacProveedor='" + contacto + "', emailProveedor='" + email + "', CelularProveedor='" + celular + "', RubroProveedor='" + rubro + "', ProductosProveedor='" + productos + "' WHERE CodProveedor='" + cod + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        //Insert - Update Cliente
        public void RegistrarCliente(string cod, string Nombre, string Direccion, string RUC, string ciudad, string Telefo, string email, string contacto, string Activ)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO clientes(CliCod, CliNom, CliDir, CliRUC, CliCiudad,CliTelef,CliEmail,CliContac,ACTIVI) VALUES ('" + cod + "', '" + Nombre + "', '" + Direccion + "', '"
                    + RUC + "', '" + ciudad + "', '" + Telefo + "', '" + email + "', '" + contacto + "', '" + Activ + "')";
                MessageBox.Show(cmd.CommandText);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos correctamente guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void UpdateCliente(string cod, string Nombre, string Direccion, string RUC, string ciudad, string Telefo, string email, string contacto, string Activ)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE clientes SET CliNom='" + Nombre + "', CliDir='" + Direccion + "', CliRUC='" + RUC + "', CliCiudad='" + ciudad + "', CliTelef='" + Telefo + "', CliEmail='" + email + "', CliContac='" + contacto + "', ACTIVI='" + Activ + "' WHERE CliCod='" + cod + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        
		public DataTable GetDetalleBoleta(string bolcod)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAdapter.SelectCommand.CommandText = "SELECT det_bol.ProdCod,productos.ProdNom,det_bol.DetBolCant, det_bol.DetBolPUni, det_bol.DetBolPTot from det_bol  INNER JOIN productos ON det_bol.ProdCod = productos.ProCod WHERE det_bol.BolCod ='" + bolcod + "'";
                DataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }
        
        //Insert - Update Producto
        public void RegistrarProducto(string cod, string Nombre, string unidad, string costo, string precio, string igv, string marca, string modelo,string r_img)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO productos(ProCod, ProdNom,ProdUnidad, ProdCosto,ProdIGV,ProdPrecio,ProdMarca,ProdModelo,ProductoImg) VALUES ('" + cod + "', '" + Nombre + "', '"
                    + unidad + "', '" + costo + "', '" + igv + "', '" + precio + "', '" + marca + "', '" + modelo + "', '" + r_img + "')";
                MessageBox.Show(cmd.CommandText);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos correctamente guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void UpdateProducto(string cod, string Nombre, string unidad, string costo, string precio, string igv, string marca, string modelo, string r_img)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE productos SET ProdNom='" + Nombre + "', ProdUnidad='" + unidad + "', ProdCosto='" + costo +
                    "', ProdPrecio='" + precio + "', ProdIGV='" + igv + "', ProdMarca='" + marca + "', ProdModelo='" + modelo + "', ProductoImg='" + r_img + "' WHERE ProCod='" + cod + "'";
                con.Open();
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        //Registrar Boleta
        public void RegistrarBoleta(string cod, string num, string codcli, string preciovent, string fecha, string almacen, string codusu)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO boleta(BolCod, BolNum, BolClieCod, BolPV, BolFecha,BolLocal,BolCodUsu) VALUES ('" + cod + "', '" + num + "', '" + codcli + "', '"
                    + preciovent + "', '" + fecha + "', '" + almacen + "', '"+ codusu + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos correctamente guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void RegistrarDetalleBoleta(string bolcod, string prodcod, int cantidad, string dcto, string precioU, string precioTot)
        {
            string cod = this.CompletarCeros4(this.LastRegistro("DetBolCod", "DET_BOL"));
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO det_bol(DetBolCod, BolCod, ProdCod, DetBolCant, DetBolDcto,DetBolPUni,DetBolPTot) VALUES ('" + cod + "', '" + bolcod + "', '" + prodcod + "', '"
                    + cantidad + "', '" + dcto +"', '" + precioU + "', '" + precioTot + "')";
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        //Combos de Busqueda
        public DataTable cmbDepa(string cod_pais)
        {
            try
            {
                DataTable dt = new DataTable();
                DataAdapter.SelectCommand.CommandText = "SELECT `DepaCod`,`DepaDesc` FROM `departamento` WHERE `PaisCod` = '" + cod_pais + "'";
                DataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception) {
                return null;
            }
        }
        public DataTable cmbPais()
        {
            try
            {
                DataTable dt = new DataTable();
                DataAdapter.SelectCommand.CommandText = "SELECT `PaisCod`,`PaisDesc` from `pais`";
                DataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable cmbCliente()
        {
            DataTable execu = new DataTable();
            DataAdapter.SelectCommand.CommandText = "SELECT `CliCod`,`CliNom`,`CliRUC` FROM `clientes`";
            DataAdapter.Fill(execu);
            return execu;
        }
        public DataTable cmbAlmacen()
        {
            DataTable execu = new DataTable();
            DataAdapter.SelectCommand.CommandText = "SELECT `AlmCod`, `AlmNombre` FROM `almacen`";
            DataAdapter.Fill(execu);
            return execu;
        }
        //Set Stock
        public void IngresoStock(string APSCod, string Almcod, string prodcod, string procant, string usucod)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO alm_prod_stock(APSCod, Almcod, ProCod, ProCant, UsuCod) VALUES ('" + APSCod + "', '" + Almcod + "', '" + prodcod + "', '"
                    + procant + "', '" + usucod + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos correctamente guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        //Get stock producto
        public int GetStockProducto(string alm, string codpro)
        {
            try
            {
                DataTable dt = new DataTable();
                DataAdapter.SelectCommand.CommandText = "SELECT `ProCant` FROM `alm_prod_stock` where `AlmCod`='" + alm + "' and `ProCod`='" + codpro + "'";
                DataAdapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "")
                    dt.Rows[0][0] = "-1";
                return Int32.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Update Stock
        public void UpdateStock(string almcod, string procod, int procant, string usucod, string opcion)
        {
            int cantidad = 0;
            MessageBox.Show(almcod + "  " + procod);
            cantidad = this.GetStockProducto(almcod, procod);
            MessageBox.Show(cantidad.ToString());
            try
            {
                if (opcion == "quitar")
                {
                    cantidad = cantidad - procant;
                }
                if (opcion == "agregar")
                {
                    cantidad = cantidad + procant;
                }
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE alm_prod_stock SET AlmCod='" + almcod + "', ProCod='" + procod + "', ProCant='" + cantidad + "' Where AlmCod ='" + almcod + "' AND ProCod ='" + procod + "'";
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void IngresoHistoricoInAlm(string APSCod, string Almcod, string prodcod, string procant,string fecha, string usucod)
        {
            try
            {
                con.ConnectionString = ConexionString;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO historico_inAlm(inAlmCod, Almcod, ProCod, ProCant,inAlmFecha, UsuCod) VALUES ('" + APSCod + "', '" + Almcod + "', '" + prodcod + "', '"
                    + fecha + "', '" + procant + "', '" + usucod + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos correctamente guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: BD");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        
        //Ultimo registro
        public int LastRegistro(string campo, string tabla) // Saca el ultimo cliente
        {
            try
            {
                DataTable dt = new DataTable();
                DataAdapter.SelectCommand.CommandText = "select `" + campo + "` from `" + tabla + "` order by " + campo + " desc limit 1";
                //DataAdapter.SelectCommand.CommandText = "select last(" + campo + ") from " + tabla;
                DataAdapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "")
                    dt.Rows[0][0] = "0";
                return Int32.Parse(dt.Rows[0][0].ToString()) + 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public string CompletarCeros4(int CodCli)
        {
            string cod = "";
            if (CodCli < 10)
                cod = "000" + CodCli.ToString();
            else
                if (CodCli < 100)
                    cod = "00" + CodCli.ToString();
                else
                    if (CodCli + 1 < 1000)
                        cod = "0" + CodCli.ToString();
                    else
                        if (CodCli + 1 < 10000)
                            cod = "0" + CodCli.ToString();
                        else
                            if (CodCli < 100000)
                                cod = CodCli.ToString();
            return cod;
        }
        public string CompletarCeros2(int CodCli)
        {
            string cod = "";
            if (CodCli < 10)
                cod = "0" + CodCli.ToString();
            else
                cod = CodCli.ToString();
            return cod;
        }
    }
}
