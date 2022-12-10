using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using MySql.Data.MySqlClient;
using Proyecto_InvHardware.Frames;
using Proyecto_InvHardware.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware
{
    public partial class MOD_Ingress : Form
    {
        clsConnection connection = new clsConnection();
        
        public string _User;
        string option = "";
        string optionUpdate = "";
        string typeCategory = "";
        string encryptQR = "";
        int R = 0;
        int G = 0;
        int B = 0;

        #region INICIALIZAR COMPONENTES
        public MOD_Ingress()
        {
            InitializeComponent();
        }
        #endregion

        #region FORMULARIO DE INGRESOS
        private void MOD_Ingress_Load(object sender, EventArgs e)
        {
            btnAddDevice.Enabled = false;

            //Se cargan los colores del formulario.
            /*string SQL = "SELECT codigo, tipo_config, nueva_config " +
                            "FROM configuraciones "; //La consulta para obetener el dato debe ser específica.

            string colors = connection.ObtainData(SQL, 2);
            var selection = 0;
            char[] delimiter = { ',' };
            string[] RGB = colors.Split(delimiter);

            for (int i = 0; i < RGB.Length; i++)
            {
                if (R == 0)
                {
                    selection = int.Parse(RGB[i]);
                    R = selection;
                }
                else
                {
                    if (G == 0)
                    {
                        selection = int.Parse(RGB[i]);
                        G = selection;
                    }
                    else
                    {
                        if (B == 0)
                        {
                            selection = int.Parse(RGB[i]);
                            B = selection;
                        }
                    }
                }
            }*/

            //lblOption.Text = _Option;
            RefreshGrid();
            BlockCamps(2); //Se envía como parámetro 0 para que inhabilite todos los campos.
            ChargeCategory();

            gbxInvBoard.Visible = false;
        }
        #endregion

        #region AGREGAR
        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "ADD";

            CleanEnable(1);
            BlockCamps(1); //Se envía como parámetro el número 1 para que habilite todos los campos.

            txtPlaqueta_inv.Enabled = false;
            txtPulgadas.Enabled = false;
            txtSistema_operativo.Enabled = false;
            txtDisco_duro.Enabled = false;
            txtMemoria_ram.Enabled = false;
            txtProcesador.Enabled = false;
            txtAntivirus.Enabled = false;
            txtDireccion_ip.Enabled = false;
            txtProgramas_licenciados.Enabled = false;
            txtNombre_pc.Enabled = false;
            dtpUltimo_certificado.Enabled = false;
            txtPeso_maximo.Enabled = false;
            txtPeso_minimo.Enabled = false;
            txtRango_medicion.Enabled = false;

            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;
            btnAdd.IconColor = Color.Black;

            btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconColor = Color.White;
            btnSearch.BackColor = Color.FromArgb(23, 95, 228);
            btnSearch.ForeColor = Color.White;
            btnSearch.IconColor = Color.White;
            btnReport.BackColor = Color.FromArgb(23, 95, 228);
            btnReport.ForeColor = Color.White;
            btnReport.IconColor = Color.White;
            btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.IconColor = Color.White;
            btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.IconColor = Color.White;
        }
        #endregion

        #region AGREGAR DISPOSITIVO DE PROVEEDOR YA REGISTRADO.
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text != "")
            {
                option = "ADD_DEVICE";

                CleanEnable(2);
                BlockCamps(1);

                grdIngresss.Enabled = false;


                txtNit.Enabled = false;
                txtNombre.Enabled = false;
                txtTelefono.Enabled = false;
                txtCorreo.Enabled = false;

                btnAddDevice.BackColor = Color.White;
                btnAddDevice.ForeColor = Color.Black;
                btnAddDevice.IconColor = Color.Black;

                btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
                btnUpdate.ForeColor = Color.White;
                btnUpdate.IconColor = Color.White;
                btnSearch.BackColor = Color.FromArgb(23, 95, 228);
                btnSearch.ForeColor = Color.White;
                btnSearch.IconColor = Color.White;
                btnReport.BackColor = Color.FromArgb(23, 95, 228);
                btnReport.ForeColor = Color.White;
                btnReport.IconColor = Color.White;
                btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCategory.ForeColor = Color.White;
                btnAddCategory.IconColor = Color.White;
                btnAdd.BackColor = Color.FromArgb(23, 95, 228);
                btnAdd.ForeColor = Color.White;
                btnAdd.IconColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        #endregion

        #region AGREGAR NUEVA CATEGORÍA DE DISPOSITIVO
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            btnAddCategory.BackColor = Color.White;
            btnAddCategory.ForeColor = Color.Black;
            btnAddCategory.IconColor = Color.Black;

            btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconColor = Color.White;
            btnSearch.BackColor = Color.FromArgb(23, 95, 228);
            btnSearch.ForeColor = Color.White;
            btnSearch.IconColor = Color.White;
            btnReport.BackColor = Color.FromArgb(23, 95, 228);
            btnReport.ForeColor = Color.White;
            btnReport.IconColor = Color.White;
            btnAdd.BackColor = Color.FromArgb(23, 95, 228);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconColor = Color.White;
            btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.IconColor = Color.White;

            bool entryValid = ConsultAdmin();

            if (entryValid != false)
            {
                FRM_MenuCategories frmMenu = new FRM_MenuCategories();
                frmMenu.ShowDialog();
                BlockCamps(2);
            }
            else 
            {
                MessageBox.Show("No tiene acceso a ésta función", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCategory.ForeColor = Color.White;
                btnAddCategory.IconColor = Color.White;
            }
        }
        #endregion

        #region ACTUALIZAR
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text != "")
            {
                option = "UPDATE";

                txtPlaqueta_inv.Text = "";
                txtPlaqueta_inv.Text = ConsultInvBoard(txtSerial.Text);
                cbxSucursal.Enabled = true;
                txtSistema_operativo.Enabled = true;
                txtDisco_duro.Enabled = true;
                txtMemoria_ram.Enabled = true;
                txtAntivirus.Enabled = true;
                txtDireccion_ip.Enabled = true;
                txtProgramas_licenciados.Enabled = true;
                txtNombre_pc.Enabled = true;
                cbxArea.Enabled = true;
                dtpUltimo_certificado.Enabled = true;

                btnUpdate.BackColor = Color.White;
                btnUpdate.ForeColor = Color.Black;
                btnUpdate.IconColor = Color.Black;

                btnAdd.BackColor = Color.FromArgb(23, 95, 228);
                btnAdd.ForeColor = Color.White;
                btnAdd.IconColor = Color.White;
                btnSearch.BackColor = Color.FromArgb(23, 95, 228);
                btnSearch.ForeColor = Color.White;
                btnSearch.IconColor = Color.White;
                btnReport.BackColor = Color.FromArgb(23, 95, 228);
                btnReport.ForeColor = Color.White;
                btnReport.IconColor = Color.White;
                btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCategory.ForeColor = Color.White;
                btnAddCategory.IconColor = Color.White;
                btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
                btnAddDevice.ForeColor = Color.White;
                btnAddDevice.IconColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BUSCAR
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FRM_Search frmSearch = new FRM_Search();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnReport.Enabled = false;

            btnSearch.BackColor = Color.White;
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconColor = Color.Black;

            btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconColor = Color.White;
            btnAdd.BackColor = Color.FromArgb(23, 95, 228);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconColor = Color.White;
            btnReport.BackColor = Color.FromArgb(23, 95, 228);
            btnReport.ForeColor = Color.White;
            btnReport.IconColor = Color.White;
            btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.IconColor = Color.White;
            btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.IconColor = Color.White;

            string supplierNit = "";
            string deviceSerial = "";
            string search = ""; //Se crea una variable de busqueda que de acuerdo al campo que se llene "Cédula" o "Serial", realice la busqueda en la tabla relacionada.
            string fillGrid = "";
            string category = "";
            string catDevice = "";
            bool consultS = false;
            bool consultD = false;
            bool consultR = false;
            int onlyS = 0;
            int onlyD = 0;

            //using (FRM_Search frmSearch = new FRM_Search())
            //{
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    if (frmSearch.txtDeviceSerial.Text == "")
                    {
                        supplierNit = frmSearch.txtSupplierNit.Text;
                    }
                    else
                    {
                        if (frmSearch.txtSupplierNit.Text == "")
                        {
                            deviceSerial = frmSearch.txtDeviceSerial.Text;
                        }
                    }

                    if (frmSearch.chbOnlySupplier.Checked == true)
                    {
                        onlyS = 1;
                        onlyD = 0;
                    }
                    else
                    {
                        if (frmSearch.chbOnlyDevice.Checked == true)
                        {
                            onlyS = 0;
                            onlyD = 1;
                        }
                    }

                    try
                    {
                        #region BUSCAR PROVEEDOR EN LA TABLA (RELACIÓN)
                        if (supplierNit != "" && onlyS == 0) //Buscar proveedor en la relación.
                        {
                            search = " WHERE nit='" + supplierNit + "'";

                            string consultSupplier = "SELECT * FROM dispositivo_proveedor " +
                                                        "WHERE nit_proveedor='" + supplierNit + "'";
                            consultR = connection.Consult(consultSupplier);

                            if (consultR == true)
                            {
                                fillGrid = "SELECT d.categoria, d.tipo, d.serial, d.marca, d.modelo, d.sucursal, d.plaqueta_inv, d.pulgadas, d.sistema_operativo, d.disco_duro, d.memoria_ram, d.procesador, d.antivirus, d.direccion_ip, d.programas_licenciados, d.nombre_pc, d.area, dp.usuario, d.ultimo_certificado, d.peso_maximo, d.peso_minimo, d.rango_medicion, dp.estado_dispositivo, p.nit, p.nombre, p.telefono, p.correo, dp.id_dispositivo_proveedor, dp.fecha_ingreso, dp.fecha_garantia, dp.fecha_aseguramiento, dp.observacion " +
                                            "FROM dispositivo_proveedor dp " +
                                            "INNER JOIN proveedor p " +
                                            "ON p.nit = dp.nit_proveedor " +
                                            "INNER JOIN dispositivo d " +
                                            "ON d.plaqueta_inv = dp.plaqueta_inventarios " +
                                            "" + search + "";
                                grdIngresss.DataSource = connection.FillGrid(fillGrid);

                                btnAddDevice.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("El proveedor no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        #endregion
                        else
                        {
                            #region BUSCAR DISPOSITIVO EN LA TABLA (RELACIÓN)
                            if (deviceSerial != "" && onlyD == 0) //Buscar dispositivo en la relación.
                            {
                                string IBN = ConsultInvBoard(deviceSerial);

                                search = "WHERE serial='" + deviceSerial + "'";

                                string consultDevice = "SELECT * FROM dispositivo_proveedor " +
                                                        "WHERE plaqueta_inventarios='" + IBN + "'";
                                consultR = connection.Consult(consultDevice);

                                if (consultR == true)
                                {
                                    fillGrid = "SELECT d.categoria, d.tipo, d.serial, d.marca, d.modelo, d.sucursal, d.plaqueta_inv, d.pulgadas, d.sistema_operativo, d.disco_duro, d.memoria_ram, d.procesador, d.antivirus, d.direccion_ip, d.programas_licenciados, d.nombre_pc, d.area, d.ultimo_certificado, d.peso_maximo, d.peso_minimo, d.rango_medicion, dp.estado_dispositivo, p.nit, p.nombre, p.telefono, p.correo, dp.id_dispositivo_proveedor, dp.fecha_ingreso, dp.fecha_garantia, dp.fecha_aseguramiento, dp.observacion " +
                                                "FROM dispositivo_proveedor dp " +
                                                "INNER JOIN proveedor p " +
                                                "ON p.nit = dp.nit_proveedor " +
                                                "INNER JOIN dispositivo d " +
                                                "ON d.plaqueta_inv = dp.plaqueta_inventarios " +
                                                "" + search + "";
                                    grdIngresss.DataSource = connection.FillGrid(fillGrid);
                                }
                                else
                                {
                                    MessageBox.Show("El dispositivo no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            #endregion
                            else
                            {
                                #region BUSCAR SÓLO PROVEEDOR
                                if (onlyS == 1) //Buscar sólo los datos del proveedor.
                                {
                                    search = "WHERE nit ='" + supplierNit + "'";

                                    fillGrid = "SELECT * FROM proveedor " +
                                        "" + search + "";
                                    consultS = connection.Consult(fillGrid);

                                    if (consultS != false)
                                    {
                                        optionUpdate = "UPDATE SUPPLIER";

                                        grdSuppliers.DataSource = connection.FillGrid(fillGrid);

                                        txtNit.Text = grdSuppliers.CurrentRow.Cells[0].Value.ToString();
                                        txtNombre.Text = grdSuppliers.CurrentRow.Cells[1].Value.ToString();
                                        txtTelefono.Text = grdSuppliers.CurrentRow.Cells[2].Value.ToString();
                                        txtCorreo.Text = grdSuppliers.CurrentRow.Cells[3].Value.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Proveedor no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                #endregion
                                else
                                {
                                    #region BUSCAR SÓLO DISPOSITIVO
                                    if (onlyD == 1) //Buscar sólo los datos del dispositivo.
                                    {
                                        search = "WHERE serial ='" + deviceSerial + "'";

                                        fillGrid = "SELECT * FROM dispositivo " +
                                                    "" + search + "";
                                        consultD = connection.Consult(fillGrid);

                                        if (consultD != false)
                                        {
                                            optionUpdate = "UPDATE DEVICE";

                                            grdDevices.DataSource = connection.FillGrid(fillGrid);
                                            /*
                                            foreach (Control x in this.Controls)
                                            {
                                                if (x is ComboBox)
                                                {
                                                    try
                                                    {
                                                        switch ((((ComboBox)x).Name))
                                                        {
                                                            case "cbxTipo":
                                                                break;

                                                            default:
                                                                ((ComboBox)x).Text = grdDevices.CurrentRow.Cells[grdDevices.Columns[((ComboBox)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
                                                                break;
                                                        }
                                                    }
                                                    catch (Exception error)
                                                    {
                                                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }

                                                if (x is TextBox)
                                                {
                                                    try
                                                    {
                                                        //CONTINUE HERE!
                                                        switch ((((TextBox)x).Name))
                                                        {
                                                            case "txtIndex":
                                                                break;

                                                            case "txtNit":
                                                                break;

                                                            case "txtNombre":
                                                                break;

                                                            case "txtTelefono":
                                                                break;

                                                            case "txtCorreo":
                                                                break;

                                                            case "txtNumero_factura":
                                                                break;

                                                            case "txtPrecio":
                                                                break;

                                                            case "txtUsuario":
                                                                break;

                                                            default:
                                                                ((TextBox)x).Text = grdDevices.CurrentRow.Cells[grdDevices.Columns[((TextBox)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
                                                                break;
                                                        }
                                                    }
                                                    catch (Exception error)
                                                    {
                                                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }
                                            
                                            dtpUltimo_certificado.Text = grdDevices.CurrentRow.Cells[17].Value.ToString();

                                            string numberIB = grdDevices.CurrentRow.Cells[21].Value.ToString();
                                            var theNumber = int.Parse(numberIB);
                                            numberIB = theNumber.ToString("000000");
                                            txtPlaqueta_inv.Text = (catDevice + " " + numberIB);

                                            if (grdDevices.CurrentRow.Cells[22].Value.ToString() == "True")
                                            {
                                                chbEstado_dispositivo.Checked = true;
                                            }
                                            else
                                            {
                                                chbEstado_dispositivo.Checked = false;
                                            }
                                            */

                                            txtSerial.Text = grdDevices.CurrentRow.Cells[0].Value.ToString();
                                            txtMarca.Text = grdDevices.CurrentRow.Cells[1].Value.ToString();
                                            txtModelo.Text = grdDevices.CurrentRow.Cells[2].Value.ToString();
                                            cbxCategoria.Text = grdDevices.CurrentRow.Cells[3].Value.ToString();
                                            category = cbxCategoria.Text = grdDevices.CurrentRow.Cells[3].Value.ToString();
                                            catDevice = txtIndex.Text;

                                            cbxTipo.Text = grdDevices.CurrentRow.Cells[4].Value.ToString();
                                            cbxSucursal.Text = grdDevices.CurrentRow.Cells[5].Value.ToString();
                                            txtPulgadas.Text = grdDevices.CurrentRow.Cells[6].Value.ToString();
                                            txtSistema_operativo.Text = grdDevices.CurrentRow.Cells[7].Value.ToString();
                                            txtDisco_duro.Text = grdDevices.CurrentRow.Cells[8].Value.ToString();
                                            txtMemoria_ram.Text = grdDevices.CurrentRow.Cells[9].Value.ToString();
                                            txtProcesador.Text = grdDevices.CurrentRow.Cells[10].Value.ToString();
                                            txtAntivirus.Text = grdDevices.CurrentRow.Cells[11].Value.ToString();
                                            txtDireccion_ip.Text = grdDevices.CurrentRow.Cells[12].Value.ToString();
                                            txtProgramas_licenciados.Text = grdDevices.CurrentRow.Cells[13].Value.ToString();
                                            txtNombre_pc.Text = grdDevices.CurrentRow.Cells[14].Value.ToString();
                                            cbxArea.Text = grdDevices.CurrentRow.Cells[15].Value.ToString();
                                            dtpUltimo_certificado.Text = grdDevices.CurrentRow.Cells[16].Value.ToString();
                                            txtPeso_maximo.Text = grdDevices.CurrentRow.Cells[17].Value.ToString();
                                            txtPeso_minimo.Text = grdDevices.CurrentRow.Cells[18].Value.ToString();
                                            txtRango_medicion.Text = grdDevices.CurrentRow.Cells[19].Value.ToString();

                                            string numberIB = grdDevices.CurrentRow.Cells[20].Value.ToString();
                                            var theNumber = int.Parse(numberIB);
                                            numberIB = theNumber.ToString("000000");
                                            txtPlaqueta_inv.Text = (catDevice + " " + numberIB);

                                            txtObservacion.Text = grdDevices.CurrentRow.Cells[21].Value.ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El dispositivo no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            CleanEnable(1);
                                        }
                                    }
                                    #endregion
                                    else
                                    {
                                        search = ""; //No busca nada.
                                        MessageBox.Show("Ingrese Valores", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    BlockCamps(2);
                }
            //}
        }
        #endregion

        #region ACEPTAR
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Variables de validación
            string addRegister = "";
            string consultDevice = ""; //Consultar dispositivo
            string consultSupplier = ""; //Consultar proveedor
            bool consultD = false; //Resultado de consultar si el dispositivo existe.
            bool consultS = false; //Resultado de consultar si el proveedor existe.
            string updateDevice = "";
            string updateSupplier = "";
            string updateDS = "";
            //string consultStock = "";
            //bool consultDS = false; //Resultado de consultar estado del Stock (bool)
            //bool consultH = false; //Resultado de consultar datos en historial (bool)

            //Datos del dispositivo
            string deviceCategory = cbxCategoria.Text;
            string type = cbxTipo.Text;
            string deviceSerial = txtSerial.Text;
            string deviceBrand = txtMarca.Text;
            string deviceModel = txtModelo.Text;
            string branch = cbxSucursal.Text;
            string inventoryBoard = txtPlaqueta_inv.Text;
            string inch = txtPulgadas.Text;
            string operativeSystem = txtSistema_operativo.Text;
            string HDD = txtDisco_duro.Text;
            string RAM = txtMemoria_ram.Text;
            string processor = txtProcesador.Text;
            string maxWeight = txtPeso_maximo.Text;
            string minWeight = txtPeso_minimo.Text;
            string measure = txtRango_medicion.Text;
            string price = txtPrecio.Text;
            string invoice = txtNumero_factura.Text;
            string antivirus = txtAntivirus.Text;
            string IP = txtDireccion_ip.Text;
            string programs = txtProgramas_licenciados.Text;
            string pcName = txtNombre_pc.Text;
            string workArea = cbxArea.Text;
            DateTime certificationD = dtpUltimo_certificado.Value;
            string observation = txtObservacion.Text;
            DateTime deliveryD = dtpFecha_ingreso.Value;
            DateTime warrantyD = dtpFecha_garantia.Value;
            DateTime securityD = dtpFecha_aseguramiento.Value;

            //Datos del proveedor
            string supplierNIT = txtNit.Text;
            string supplierName = txtNombre.Text;
            string supplierPhone = txtTelefono.Text;
            string supplierMail = txtCorreo.Text;

            //Variables 
            string deliveryDate = deliveryD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //Se cambia el formato de "dd/MM/yyyy" a "yyyy/MM/dd"
            string warrantyDate = warrantyD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //Se cambia el formato de "dd/MM/yyyy" a "yyyy/MM/dd"
            string securityDate = securityD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //Se cambia el formato de "dd/MM/yyyy" a "yyyy/MM/dd"
            string certificationDate = certificationD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

            //CONSULTAS
            consultDevice = "SELECT * FROM dispositivo " +
                                "WHERE serial='" + deviceSerial + "'";
            consultD = connection.Consult(consultDevice);

            consultSupplier = "SELECT * FROM proveedor " +
                                "WHERE nit='" + supplierNIT + "'";
            consultS = connection.Consult(consultSupplier);

            switch (option)
            {
                #region CASO "AGREGAR"
                case "ADD":
                    try
                    {
                        if (deviceSerial != "" && supplierNIT != "") //Se valida que el txt donde se ingresa el serial y el txt del NIT proveedor contengan información.
                        {
                            if (consultD != true) //Se valida que el dispositivo exista en la base de datos.
                            {
                                if (consultS != true) //Se valida que el proveedor exista en la base de datos.
                                {
                                    if (txtSerial.Text != "") //El campo "Serial" es importante, por lo tanto se debe llenar.
                                    {
                                        if (txtMarca.Text != "")
                                        {
                                            if (txtModelo.Text != "")
                                            {
                                                if (cbxSucursal.Text != "")
                                                {
                                                    if (cbxArea.Text != "")
                                                    {
                                                        if (txtNumero_factura.Text != "")
                                                        {
                                                            if (txtPrecio.Text != "")
                                                            {
                                                                if (txtNit.Text != "")
                                                                {
                                                                    if (txtNombre.Text != "")
                                                                    {
                                                                        if (txtTelefono.Text != "")
                                                                        {
                                                                            if (txtCorreo.Text != "")
                                                                            {
                                                                                if (txtObservacion.Text.Length <= 250)
                                                                                {
                                                                                    addRegister = "INSERT INTO dispositivo(serial,marca,modelo,categoria,tipo,sucursal,pulgadas,sistema_operativo,disco_duro,memoria_ram,procesador,antivirus,direccion_ip,programas_licenciados,nombre_pc,area,ultimo_certificado,peso_maximo,peso_minimo,rango_medicion,precio,estado_actual,observacion) " +
                                                                                                    "VALUES('" + deviceSerial + "','" + deviceBrand + "','" + deviceModel + "','" + deviceCategory + "','" + type + "','" + branch + "','" + inch + "','" + operativeSystem + "','" + HDD + "','" + RAM + "','" + processor + "','" + antivirus + "','" + IP + "','" + programs + "','" + pcName + "','" + workArea + "','" + certificationDate + "','" + maxWeight + "','" + minWeight + "','" + measure + "','" + price + "','EN STOCK','" + observation + "')";
                                                                                    connection.FillDB(addRegister); //Agregamos el Dispositivo a la DB

                                                                                    //MessageBox.Show("Dispositivo agregado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                                                    addRegister = "INSERT INTO proveedor(nit,nombre,telefono,correo) " +
                                                                                                    "VALUES('" + supplierNIT + "','" + supplierName + "','" + supplierPhone + "','" + supplierMail + "')";
                                                                                    connection.FillDB(addRegister); //Agregamos el Proveedor a la DB

                                                                                    MessageBox.Show("Dispositivo ingresado correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                                                    RefreshGrid(); //Refrescamos la grilla para obtener la plaqueta de inventarios.

                                                                                    string value = grdInvBrd.CurrentRow.Cells[20].Value.ToString(); // En el campo 20 de la tabla se encuentra la Plaqueta de Inventarios del dispositivo.
                                                                                    var invBoard = int.Parse(value);
                                                                                    encryptQR = EncryptSHA1(value);

                                                                                    addRegister = "INSERT INTO dispositivo_proveedor(plaqueta_inventarios,nit_proveedor,numero_factura,fecha_ingreso,fecha_garantia,fecha_aseguramiento,estado_dispositivo,observacion,encriptado) " +
                                                                                                    "VALUES('" + invBoard + "','" + supplierNIT + "','" + invoice + "','" + deliveryDate + "','" + warrantyDate + "','" + securityDate + "','EN STOCK','" + observation + "','" + encryptQR + "') ";
                                                                                    connection.FillGrid(addRegister); //Llenamos la tabla de la relación

                                                                                    addRegister = "INSERT INTO historial_ingresos(categoria, plaqueta_inventarios, serial_dispositivo, nit_proveedor, observacion, fecha_ingreso, usuario_registra) " +
                                                                                                    "VALUES('" + deviceCategory + "','" + invBoard + "','" + deviceSerial + "','" + supplierNIT + "','" + observation + "','" + deliveryDate + "','JORGEL') ";
                                                                                    connection.FillDB(addRegister); //Llenamos la tabla del historial de ingresos

                                                                                    RefreshGrid(); //Actualizamos la tabla.
                                                                                    gbxInvBoard.Visible = true;
                                                                                }
                                                                                else
                                                                                {
                                                                                    lblErrBranch.Visible = true;
                                                                                    MessageBox.Show("Superó la cantidad de caracteres permitido... Sólo puede ingresar 250 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                lblErrMail.Visible = true;
                                                                                MessageBox.Show("Campo 'E-Mail' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            lblErrPhone.Visible = true;
                                                                            MessageBox.Show("Campo 'Teléfono' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        lblErrName.Visible = true;
                                                                        MessageBox.Show("Campo 'Nombre (Proveedor)' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    lblErrNit.Visible = true;
                                                                    MessageBox.Show("Campo 'NIT' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                lblErrPrice.Visible = true;
                                                                MessageBox.Show("Campo 'Precio' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            lblErrInvoice.Visible = true;
                                                            MessageBox.Show("Campo 'N. Factura' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        lblErrArea.Visible = true;
                                                        MessageBox.Show("Campo 'Área' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }
                                                }
                                                else
                                                {
                                                    lblErrBranch.Visible = true;
                                                    MessageBox.Show("Campo 'Sucursal' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                lblErrModel.Visible = true;
                                                MessageBox.Show("Campo 'Modelo' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            lblErrBrand.Visible = true;
                                            MessageBox.Show("Campo 'Marca' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        lblErrSerial.Visible = true;
                                        MessageBox.Show("Campo 'Serial' está vacío.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El proveedor ya existe en la base de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El dispositivo ya existe en la base de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                #endregion

                #region CASO "ACTUALIZAR"
                case "UPDATE":
                    deliveryD = dtpFecha_ingreso.Value;
                    deliveryDate = deliveryD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                    warrantyD = dtpFecha_garantia.Value;
                    warrantyDate = warrantyD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                    securityD = dtpFecha_aseguramiento.Value;
                    securityDate = securityD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

                    try
                    {
                        if (supplierNIT != "")
                        {
                            updateSupplier = "UPDATE proveedor SET  nit='" + supplierNIT + "', " +
                                                                    "nombre='" + supplierName + "', " +
                                                                    "telefono='" + supplierPhone + "', " +
                                                                    "correo='" + supplierMail + "' " +
                                                "WHERE nit='" + supplierNIT + "' ";
                            connection.FillDB(updateSupplier); //Actualizamos proveedor.
                        }

                        if (deviceSerial != "")
                        {
                            updateDevice = "UPDATE dispositivo SET  serial='" + deviceSerial + "', " +
                                                                    "marca='" + deviceBrand + "', " +
                                                                    "modelo='" + deviceModel + "', " +
                                                                    "categoria='" + deviceCategory + "', " +
                                                                    "tipo='" + type + "', " +
                                                                    "sucursal='" + branch + "', " +
                                                                    "pulgadas='" + inch + "', " +
                                                                    "sistema_operativo='" + operativeSystem + "', " +
                                                                    "disco_duro='" + HDD + "', " +
                                                                    "memoria_ram='" + RAM + "', " +
                                                                    "procesador='" + processor + "', " +
                                                                    "antivirus='" + antivirus + "', " +
                                                                    "direccion_ip='" + IP + "', " +
                                                                    "programas_licenciados='" + programs + "', " +
                                                                    "nombre_pc='" + pcName + "', " +
                                                                    "area='" + workArea + "', " +
                                                                    "ultimo_certificado='" + certificationDate + "', " +
                                                                    "peso_maximo='" + maxWeight + "', " +
                                                                    "peso_minimo='" + minWeight + "', " +
                                                                    "rango_medicion='" + measure + "', " +
                                                                    "plaqueta_inv='" + inventoryBoard + "', " +
                                                                    "precio='" + price + "', " +
                                                                    "estado_actual='EN STOCK', " +
                                                                    "observacion='" + observation + "' " +
                                            "WHERE serial='" + deviceSerial + "' ";
                            connection.FillDB(updateDevice); //Actualizamos dispositivo.
                        }

                        if (deviceSerial != "" && supplierNIT != "")
                        {
                            string invB = ConsultInvBoard(deviceSerial);

                            updateDS = "UPDATE dispositivo_proveedor SET    fecha_ingreso='" + deliveryDate + "', " +
                                                                            "fecha_garantia='" + warrantyDate + "', " +
                                                                            "fecha_aseguramiento='" + securityDate + "', " +
                                                                            "estado_dispositivo='EN STOCK', " +
                                                                            "observacion='" + observation + "' " +
                                        "WHERE plaqueta_inventarios='" + invB + "' AND nit_proveedor='" + supplierNIT + "' ";
                            connection.FillGrid(updateDS);
                        }
                        MessageBox.Show("Datos modificados", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshGrid();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                #endregion

                #region CASO "AGREGAR DISPOSITIVO DE UN PROVEEDOR YA REGISTRADO"
                case "ADD_DEVICE":
                    try
                    {
                        if (deviceSerial != "" && supplierNIT != "") //Se valida que el txt donde se ingresa el serial y el txt del NIT proveedor contengan información.
                        {
                            if (consultD != true) //Se valida que el dispositivo exista en la base de datos.
                            {
                                if (txtObservacion.Text.Length <= 250)
                                {
                                    addRegister = "INSERT INTO dispositivo(serial,marca,modelo,categoria,tipo,sucursal,pulgadas,sistema_operativo,disco_duro,memoria_ram,procesador,antivirus,direccion_ip,programas_licenciados,nombre_pc,area,ultimo_certificado,peso_maximo,peso_minimo,rango_medicion,precio,estado_actual,observacion) " +
                                                   "VALUES('" + deviceSerial + "','" + deviceBrand + "','" + deviceModel + "','" + deviceCategory + "','" + type + "','" + branch + "','" + inch + "','" + operativeSystem + "','" + HDD + "','" + RAM + "','" + processor + "','" + antivirus + "','" + IP + "','" + programs + "','" + pcName + "','" + workArea + "','" + certificationDate + "','" + maxWeight + "','" + minWeight + "','" + measure + "','" + price + "','EN STOCK','" + observation + "')";
                                    connection.FillDB(addRegister); //Agregamos el Dispositivo a la DB

                                    //MessageBox.Show("Dispositivo agregado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (consultS != true)
                                    {
                                        addRegister = "INSERT INTO proveedor(nit,nombre,telefono,correo) " +
                                                        "VALUES('" + supplierNIT + "','" + supplierName + "','" + supplierPhone + "','" + supplierMail + "')";
                                        connection.FillDB(addRegister); //Agregamos el Proveedor a la DB
                                    }

                                    MessageBox.Show("Dispositivo ingresado correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    RefreshGrid(); //Refrescamos la grilla para obtener la plaqueta de inventarios.

                                    string value = grdInvBrd.CurrentRow.Cells[20].Value.ToString(); // En el campo 20 de la tabla se encuentra la Plaqueta de Inventarios del dispositivo.
                                    var invBoard = int.Parse(value);
                                    encryptQR = EncryptSHA1(value);

                                    addRegister = "INSERT INTO dispositivo_proveedor(plaqueta_inventarios,nit_proveedor,numero_factura,fecha_ingreso,fecha_garantia,fecha_aseguramiento,estado_dispositivo,observacion,encriptado) " +
                                                    "VALUES('" + invBoard + "','" + supplierNIT + "','" + invoice + "','" + deliveryDate + "','" + warrantyDate + "','" + securityDate + "','EN STOCK','" + observation + "','" + encryptQR + "') ";
                                    connection.FillGrid(addRegister); //Llenamos la tabla de la relación

                                    addRegister = "INSERT INTO historial_ingresos(categoria, plaqueta_inventarios, serial_dispositivo, nit_proveedor, observacion, fecha_ingreso, usuario_registra) " +
                                                    "VALUES('" + deviceCategory + "','" + invBoard + "','" + deviceSerial + "','" + supplierNIT + "','" + observation + "','" + deliveryDate + "','JORGEL') ";
                                    connection.FillDB(addRegister); //Llenamos la tabla del historial de ingresos

                                    RefreshGrid(); //Actualizamos la tabla.
                                    gbxInvBoard.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("Superó la cantidad de caracteres permitido... Sólo puede ingresar 250 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("El dispositivo ya existe en la base de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                #endregion

                #region ACTUALIZAR SÓLO PROVEEDOR
                case "UPDATE SUPPLIER":
                    updateSupplier = "UPDATE proveedor SET  nit='" + supplierNIT + "', " +
                                                                    "nombre='" + supplierName + "', " +
                                                                    "telefono='" + supplierPhone + "', " +
                                                                    "correo='" + supplierMail + "' " +
                                                "WHERE nit='" + supplierNIT + "' ";
                    connection.FillDB(updateSupplier); //Actualizamos sólo el proveedor.

                    MessageBox.Show("Proveedor actualizado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                #endregion

                #region ACTUALIZAR SÓLO DISPOSITIVO
                case "UPDATE DEVICE":
                    updateDevice = "UPDATE dispositivo SET  serial='" + deviceSerial + "', " +
                                                                    "marca='" + deviceBrand + "', " +
                                                                    "modelo='" + deviceModel + "', " +
                                                                    "categoria='" + deviceCategory + "', " +
                                                                    "tipo='" + type + "', " +
                                                                    "sucursal='" + branch + "', " +
                                                                    "pulgadas='" + inch + "', " +
                                                                    "sistema_operativo='" + operativeSystem + "', " +
                                                                    "disco_duro='" + HDD + "', " +
                                                                    "memoria_ram='" + RAM + "', " +
                                                                    "procesador='" + processor + "', " +
                                                                    "antivirus='" + antivirus + "', " +
                                                                    "direccion_ip='" + IP + "', " +
                                                                    "programas_licenciados='" + programs + "', " +
                                                                    "nombre_pc='" + pcName + "', " +
                                                                    "area='" + workArea + "', " +
                                                                    "ultimo_certificado='" + certificationDate + "', " +
                                                                    "peso_maximo='" + maxWeight + "', " +
                                                                    "peso_minimo='" + minWeight + "', " +
                                                                    "rango_medicion='" + measure + "', " +
                                                                    "plaqueta_inv='" + inventoryBoard + "', " +
                                                                    "precio='" + price + "', " +
                                                                    "estado_actual='EN STOCK', " +
                                                                    "observacion='" + observation + "', " +
                                            "WHERE serial='" + deviceSerial + "' ";
                    connection.FillDB(updateDevice);

                    MessageBox.Show("Datos de dispositivos actualizados", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    break;
                #endregion

                #region DEFAULT
                default:
                    MessageBox.Show("Seleccione una opcíón");
                    break;
                #endregion
            }
            optionUpdate = "";
        }
        #endregion

        #region GENERAR REPORTE
        private void btnReport_Click(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.White;
            btnReport.ForeColor = Color.Black;
            btnReport.IconColor = Color.Black;

            btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconColor = Color.White;
            btnSearch.BackColor = Color.FromArgb(23, 95, 228);
            btnSearch.ForeColor = Color.White;
            btnSearch.IconColor = Color.White;
            btnAdd.BackColor = Color.FromArgb(23, 95, 228);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconColor = Color.White;
            btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.IconColor = Color.White;
            btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.IconColor = Color.White;

            REPORTES.FRM_ReporteIngresos repIng = new REPORTES.FRM_ReporteIngresos();
            repIng.ShowDialog();
        }
        #endregion

        #region HISTORIAL DE INGRESOS
        private void btnHistory_Click(object sender, EventArgs e)
        {
            REC_IngressHistory frmHistory = new REC_IngressHistory();

            frmHistory.ShowDialog();
        }
        #endregion

        #region CANCELAR/LIMPIAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            BlockCamps(2);
        }
        #endregion

        #region VISUALIZAR EN LOS TXT LOS DATOS DE LA  TABLA
        private void grdIngresss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string catDevice = ""; //Variable que guarda la categoría de forma resumidad -- EJ: IMPRESORA -> "IMP"
            int warrantyDays = 0;
            btnPrintIB.Enabled = true;

            btnUpdate.Enabled = true;
            cbxTipo.Enabled = false;
            txtSerial.Enabled = false;
            txtNit.Enabled = false;
            cbxCategoria.Enabled = false;

            try
            {                              
                foreach (Control x in this.Controls)
                {
                    if (x is ComboBox)
                    { 
                        try
                        {
                            ((ComboBox)x).Text = grdIngresss.CurrentRow.Cells[grdIngresss.Columns[((ComboBox)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (x is TextBox)
                    {
                        try
                        {
                            if (((TextBox)x).Name == "txtIndex")
                            {

                            }
                            else
                            {
                                ((TextBox)x).Text = grdIngresss.CurrentRow.Cells[grdIngresss.Columns[((TextBox)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    /*if( x is DateTimePicker) 
                    {
                        try
                        {
                            if (((DateTimePicker)x).Name == "dtpDate")
                            {
                                
                            }
                            else
                            {
                                ((DateTimePicker)x).Text = grdIngresss.CurrentRow.Cells[grdIngresss.Columns[((DateTimePicker)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Algo salió mal: \n" + error.Message);
                        }
                    }*/
                }
                
                string numberIB = grdIngresss.CurrentRow.Cells[6].Value.ToString(); //Se guarda el número de la placa de inventarios en una variable.
                var theNumber = int.Parse(numberIB); //Se convierte en entero para realizar la conversión.
                numberIB = theNumber.ToString("0000000"); //Se realiza la conversión de entero a "000000" -- EJ: 1 -> 000001
                txtPlaqueta_inv.Text = (catDevice + " " + numberIB); //Se une el indicativo de la categoría del inventario con el número convertido -- EJ: "IMP 000001"

                dtpUltimo_certificado.Text = grdIngresss.CurrentRow.Cells[17].Value.ToString();
                dtpFecha_ingreso.Text = grdIngresss.CurrentRow.Cells[29].Value.ToString();
                dtpFecha_garantia.Text = grdIngresss.CurrentRow.Cells[30].Value.ToString();
                dtpFecha_aseguramiento.Text = grdIngresss.CurrentRow.Cells[31].Value.ToString();
                encryptQR = grdIngresss.CurrentRow.Cells[33].Value.ToString();

                //Proceso para determinar cuantos días faltan para expiración de garantía.
                DateTime endDate = dtpFecha_garantia.Value.Date;
                DateTime currentDate = dtpDate.Value.Date;
                TimeSpan timeSpan = endDate - currentDate;
                warrantyDays = timeSpan.Days;

                if (warrantyDays > 0)
                {
                    lblDays.Text = "" + warrantyDays + " días para que expire la garantía!";
                }
                else
                {
                    if (warrantyDays < 0)
                    {
                        lblDays.Text = "La garantia ya expiró!";
                    }
                    else
                    {
                        if (warrantyDays == 0)
                        {
                            lblDays.Text = "La garantía expira HOY!";
                        }
                    }
                }

                //GENERAR CÓDIGO QR
                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(encryptQR, out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(75, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemp = new Bitmap(ms);
                var image = new Bitmap(imageTemp, new Size(new Point(75, 75)));
                pnlResult.BackgroundImage = image;
                
                txtEncrypt.Text = txtIndex.Text + txtPlaqueta_inv.Text;

                gbxInvBoard.Visible = true;
                option = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 

        #region CREAR QR
        public void CreateQR(string strQR)
        {
            //GENERAR CÓDIGO QR
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(encryptQR, out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(75, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemp = new Bitmap(ms);
            var image = new Bitmap(imageTemp, new Size(new Point(75, 75)));
            pnlResult.BackgroundImage = image;
        }
        #endregion

        #region REFRESCAR LA GRILLA
        public void RefreshGrid()
        {
            //string fillGrid = "CALL dispositivo_proveedor() "; //Se invoca el procedimiento almacenado que se creó en los Querys. Dicho procedimiento tiene la función cons |
            //grdIngresss.DataSource = FillGrid(fillGrid);

            string fillGrid =   "SELECT d.categoria, d.tipo, d.serial, d.marca, d.modelo, d.sucursal, d.plaqueta_inv, d.pulgadas, d.sistema_operativo, d.disco_duro, d.memoria_ram, d.procesador, d.antivirus, d.direccion_ip, d.programas_licenciados, d.nombre_pc, d.area, d.ultimo_certificado, d.peso_maximo, d.peso_minimo, d.rango_medicion, dp.numero_factura, d.precio, d.estado_actual, p.nit, p.nombre, p.telefono, p.correo, dp.id_dispositivo_proveedor, dp.fecha_ingreso, dp.fecha_garantia, dp.fecha_aseguramiento, dp.observacion, dp.encriptado " +
                                "FROM dispositivo_proveedor dp " +
                                "INNER JOIN proveedor p " +
                                "ON p.nit = dp.nit_proveedor " +
                                "INNER JOIN dispositivo d " +
                                "ON d.plaqueta_inv = dp.plaqueta_inventarios " +
                                "ORDER BY dp.id_dispositivo_proveedor DESC ";
            grdIngresss.DataSource = connection.FillGrid(fillGrid);

            fillGrid = "SELECT * FROM dispositivo " +
                        "ORDER BY plaqueta_inv DESC ";
            grdInvBrd.DataSource = connection.FillGrid(fillGrid);

            fillGrid = "SELECT * FROM categorias " +
                        "ORDER BY nombre ASC ";
            grdCategory.DataSource = connection.FillGrid(fillGrid);
        }
        #endregion

        #region AGREGAR LAS CATEGORÍAS Y TIPOS DE LA DB A LOS CBX
        private void ChargeCategory()
        {
            String cn = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;

            cbxCategoria.DataSource = null; //Se establece que el ComboBox se cargará con datos de la DB.
            cbxCategoria.Items.Clear(); //Se limpia el ComboBox.

            string mySql = "SELECT idCategoria, nombre, indice " +
                            "FROM categorias ORDER BY nombre ASC"; //Se realiza la consulta de las categorías.

            using (MySqlConnection con = new MySqlConnection(cn)) //Se crea la conexión a la DB.
            {
                using (MySqlCommand cmd = new MySqlCommand(mySql, con)) //Se crea la variable para ejecurar el comando.
                {
                    con.Open(); //Se abre la conexión.
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd); //Se crea la variable que ejecuta el comando.
                    DataTable dt = new DataTable(); //Se crea una variable que almacenará todo en una tabla.
                    data.Fill(dt); //Se ejecuta el comando MySql

                    cbxCategoria.ValueMember = "idCategoria"; //Se establece la PK de la tabla categorías.
                    cbxCategoria.DisplayMember = "nombre"; //Se establece el campo de la tabla que se mostrará.
                    cbxCategoria.DataSource = dt; //El ComboBox se llena con el contendio de la tabla.
                    con.Close(); //Se cierra la conexión.
                }
            }
        }

        private void ChargeTypes()
        {
            String cn = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;

            cbxTipo.DataSource = null;
            cbxTipo.Items.Clear();

            string mySql = "SELECT tipo, indicio from tipos " +
                            "WHERE indicio='" +typeCategory+ "'";

            using (MySqlConnection con = new MySqlConnection(cn))
            {
                using (MySqlCommand cmd = new MySqlCommand(mySql, con))
                {
                    con.Open(); //Se abre la conexión.
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    cbxTipo.ValueMember = "indicio";
                    cbxTipo.DisplayMember = "tipo";
                    cbxTipo.DataSource = dt;
                    con.Close();
                }
            }
        }
        #endregion

        #region VISUALIZAR EL INDICATIVO DE LA CATEGORÍA
        private void cbxDeviceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = int.Parse(cbxCategoria.SelectedValue.ToString());

            txtPulgadas.Enabled = false;
            txtSistema_operativo.Enabled = false;
            txtDisco_duro.Enabled = false;
            txtMemoria_ram.Enabled = false;
            txtProcesador.Enabled = false;
            txtAntivirus.Enabled = false;
            txtDireccion_ip.Enabled = false;
            txtProgramas_licenciados.Enabled = false;
            txtNombre_pc.Enabled = false;
            dtpUltimo_certificado.Enabled = false;
            txtPeso_maximo.Enabled = false;
            txtPeso_minimo.Enabled = false;
            txtRango_medicion.Enabled = false;

            try
            {
                string searchIndex = "SELECT * FROM categorias " +
                                        "WHERE idCategoria='" + idCategory + "'";
                grdCategory.DataSource = connection.FillGrid(searchIndex); //Se realiza la consulta de acuerdo al ID seleccionado.

                txtIndex.Text = grdCategory.CurrentRow.Cells[2].Value.ToString(); //Se muestra en el txt el campo[2] de la tabla, éste equivale al indicativo de la categoría seleccionada. Ej: MONEDERO - MON
                typeCategory = grdCategory.CurrentRow.Cells[2].Value.ToString();

                ChargeTypes(); //Invoco el métodO que carga los tipos de categoría de acuerdo a la categoría del dispositivo.

                if (cbxTipo.Text != "") //Validación para habilitar o inhabilitar el ComboBox de acuerdo a la categoría.
                {
                    cbxTipo.Enabled = true; //Si la categoría tiene "Tipos", se habilita para mostrarLOS.
                }
                else
                {
                    cbxTipo.Enabled = false; //Si la categoría no tiene "Tipos", se inhabilita ya que no tiene datos.
                }

                for (int i = 0; i < grdCategory.RowCount; i++)
                {
                    if (grdCategory.Rows[i].Cells[2].Value.ToString() == txtIndex.Text)
                    {
                        EnableTextBox(i);
                        break;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        
        #region LIMPIAR CAMPOS SIN HABILITAR LOS TXT
        public void CleanEnable(int num)
        {
            if (num == 1)
            {
                //Limpiar y habilitar campos del formulario.
                cbxCategoria.Text = " ";
                cbxTipo.Text = "";
                txtSerial.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                cbxSucursal.Text = "";
                txtPlaqueta_inv.Text = "";
                txtPulgadas.Text = "";
                txtSistema_operativo.Text = "";
                txtDisco_duro.Text = "";
                txtMemoria_ram.Text = "";
                txtProcesador.Text = "";
                txtPeso_maximo.Text = "";
                txtPeso_minimo.Text = "";
                txtRango_medicion.Text = "";
                txtPrecio.Text = "";
                txtNumero_factura.Text = "";
                txtAntivirus.Text = "";
                txtDireccion_ip.Text = "";
                txtProgramas_licenciados.Text = "";
                txtNombre_pc.Text = "";
                cbxArea.Text = "";
                dtpUltimo_certificado.ResetText();

                txtNit.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";

                dtpFecha_ingreso.ResetText();
                dtpFecha_garantia.ResetText();
                dtpFecha_aseguramiento.ResetText();
                lblDays.Text = "";
                txtObservacion.Text = "";
            }
            else
            {
                if (num == 2)
                {
                    //Limpiar y habilitar campos del formulario cuando se selecciona la opción de "Agregar Dispositivo".
                    cbxCategoria.Text = " ";
                    cbxTipo.Text = "";
                    txtSerial.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    cbxSucursal.Text = "";
                    txtPlaqueta_inv.Text = "";
                    txtPulgadas.Text = "";
                    txtSistema_operativo.Text = "";
                    txtDisco_duro.Text = "";
                    txtMemoria_ram.Text = "";
                    txtProcesador.Text = "";
                    txtPeso_maximo.Text = "";
                    txtPeso_minimo.Text = "";
                    txtRango_medicion.Text = "";
                    txtPrecio.Text = "";
                    txtNumero_factura.Text = "";
                    txtAntivirus.Text = "";
                    txtDireccion_ip.Text = "";
                    txtProgramas_licenciados.Text = "";
                    txtNombre_pc.Text = "";
                    cbxArea.Text = "";
                    dtpUltimo_certificado.ResetText();

                    dtpFecha_ingreso.ResetText();
                    dtpFecha_garantia.ResetText();
                    dtpFecha_aseguramiento.ResetText();
                    lblDays.Text = "";
                    txtObservacion.Text = "";
                }
            }    
        }
        #endregion

        #region LIMPIAR CAMPOS E INHABILITAR LOS TXT
        public void BlockCamps(int var)
        {
            if (var != 1) //Limpiar y habilitar campos del formulario.
            {
                option = "";

                btnAdd.Enabled = true;
                btnAddDevice.Enabled = true;
                btnUpdate.Enabled = false;

                cbxCategoria.Text = " ";
                cbxCategoria.Enabled = false;
                cbxTipo.Text = "";
                cbxTipo.Enabled = false;
                cbxCategoria.Enabled = false;
                txtSerial.Text = "";
                txtSerial.Enabled = false;
                txtMarca.Text = "";
                txtMarca.Enabled = false;
                txtModelo.Text = "";
                txtModelo.Enabled = false;
                cbxSucursal.Text = "";
                cbxSucursal.Enabled = false;
                txtPlaqueta_inv.Text = "";
                txtPlaqueta_inv.Enabled = false;
                txtPulgadas.Text = "";
                txtPulgadas.Enabled = false;
                txtSistema_operativo.Text = "";
                txtSistema_operativo.Enabled = false;
                txtDisco_duro.Text = "";
                txtDisco_duro.Enabled = false;
                txtMemoria_ram.Text = "";
                txtMemoria_ram.Enabled = false;
                txtProcesador.Text = "";
                txtProcesador.Enabled = false;
                txtPeso_maximo.Text = "";
                txtPeso_maximo.Enabled = false;
                txtPeso_minimo.Text = "";
                txtPeso_minimo.Enabled = false;
                txtRango_medicion.Text = "";
                txtRango_medicion.Enabled = false;
                txtPrecio.Text = "";
                txtPrecio.Enabled = false;
                txtNumero_factura.Text = "";
                txtNumero_factura.Enabled = false;
                txtNumero_factura.Text = "";
                txtNumero_factura.Enabled = false;
                txtPrecio.Text = "";
                txtPrecio.Enabled = false;
                txtAntivirus.Text = "";
                txtAntivirus.Enabled = false;
                txtDireccion_ip.Text = "";
                txtDireccion_ip.Enabled = false;
                txtProgramas_licenciados.Text = "";
                txtProgramas_licenciados.Enabled = false;
                txtNombre_pc.Text = "";
                txtNombre_pc.Enabled = false;
                cbxArea.Text = "";
                cbxArea.Enabled = false;
                dtpUltimo_certificado.ResetText();
                dtpUltimo_certificado.Enabled = false;

                txtNit.Text = "";
                txtNit.Enabled = false;
                txtNombre.Text = "";
                txtNombre.Enabled = false;
                txtTelefono.Text = "";
                txtTelefono.Enabled = false;
                txtCorreo.Text = "";
                txtCorreo.Enabled = false;

                dtpFecha_ingreso.ResetText();
                dtpFecha_ingreso.Enabled = false;
                dtpFecha_garantia.ResetText();
                dtpFecha_garantia.Enabled = false;
                dtpFecha_aseguramiento.ResetText();
                dtpFecha_aseguramiento.Enabled = false;
                lblDays.Text = "";
                txtObservacion.Text = "";
                txtObservacion.Enabled = false;

                btnPrintIB.Enabled = false;

                gbxInvBoard.Visible = false;

                RefreshGrid();

                #region CAMBIO DE COLOR EN LOS BOTÓNES
                pnlContainer.BackColor = Color.FromArgb(23, 95, 228);

                btnAdd.BackColor = Color.FromArgb(23, 95, 228);
                btnAdd.ForeColor = Color.White;
                btnAdd.IconColor = Color.White;

                btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCategory.ForeColor = Color.White;
                btnAddCategory.IconColor = Color.White;

                btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
                btnAddDevice.ForeColor = Color.White;
                btnAddDevice.IconColor = Color.White;

                btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
                btnUpdate.ForeColor = Color.White;
                btnUpdate.IconColor = Color.White;

                btnSearch.BackColor = Color.FromArgb(23, 95, 228);
                btnSearch.ForeColor = Color.White;
                btnSearch.IconColor = Color.White;

                btnReport.BackColor = Color.FromArgb(23, 95, 228);
                btnReport.ForeColor = Color.White;
                btnReport.IconColor = Color.White;
                #endregion
            }
            else //Habilitar campos del formulario.
            {
                cbxCategoria.Enabled = true;
                cbxTipo.Enabled = true;
                txtSerial.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                cbxSucursal.Enabled = true;
                txtPlaqueta_inv.Enabled = true;
                txtPulgadas.Enabled = true;
                txtSistema_operativo.Enabled = true;
                txtDisco_duro.Enabled = true;
                txtMemoria_ram.Enabled = true;
                txtProcesador.Enabled = true;
                txtPeso_maximo.Enabled = true;
                txtPeso_minimo.Enabled = true;
                txtNumero_factura.Enabled = true;
                txtPrecio.Enabled = true;
                txtRango_medicion.Enabled = true;
                txtPrecio.Enabled = true;
                txtNumero_factura.Enabled = true;
                txtAntivirus.Enabled = true;
                txtDireccion_ip.Enabled = true;
                txtProgramas_licenciados.Enabled = true;
                txtNombre_pc.Enabled = true;
                cbxArea.Enabled = true;
                dtpUltimo_certificado.Enabled = true;

                txtNit.Enabled = true;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                txtCorreo.Enabled = true;

                dtpFecha_ingreso.Enabled = true;
                dtpFecha_garantia.Enabled = true;
                dtpFecha_aseguramiento.Enabled = true;
                txtObservacion.Enabled = true;
                lblDays.Text = "";

                gbxInvBoard.Visible = false;

                RefreshGrid();

                #region CAMBIO DE COLOR EN LOS BOTÓNES
                //pnlContainer.BackColor = Color.FromArgb(23, 95, 228);

                btnAdd.BackColor = Color.FromArgb(23, 95, 228);
                btnAdd.ForeColor = Color.White;
                btnAdd.IconColor = Color.White;

                btnAddCategory.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCategory.ForeColor = Color.White;
                btnAddCategory.IconColor = Color.White;

                btnAddDevice.BackColor = Color.FromArgb(23, 95, 228);
                btnAddDevice.ForeColor = Color.White;
                btnAddDevice.IconColor = Color.White;

                btnUpdate.BackColor = Color.FromArgb(23, 95, 228);
                btnUpdate.ForeColor = Color.White;
                btnUpdate.IconColor = Color.White;

                btnSearch.BackColor = Color.FromArgb(23, 95, 228);
                btnSearch.ForeColor = Color.White;
                btnSearch.IconColor = Color.White;

                btnReport.BackColor = Color.FromArgb(23, 95, 228);
                btnReport.ForeColor = Color.White;
                btnReport.IconColor = Color.White;
                #endregion
            }
        }
        #endregion

        #region CONSULTAR LA PLACA DE INVENTARIOS
        public string ConsultInvBoard(string devSer)
        {
            string fillGrid = "SELECT d.categoria, d.tipo, d.serial, d.marca, d.modelo, d.sucursal, d.plaqueta_inv, d.pulgadas, d.sistema_operativo, d.disco_duro, d.memoria_ram, d.procesador, d.antivirus, d.direccion_ip, d.programas_licenciados, d.nombre_pc, d.area, d.ultimo_certificado, d.peso_maximo, d.peso_minimo, d.rango_medicion, dp.estado_dispositivo, p.nit, p.nombre, p.telefono, p.correo, dp.id_dispositivo_proveedor, dp.fecha_ingreso, dp.fecha_garantia, dp.fecha_aseguramiento, dp.observacion, dp.encriptado " +
                                "FROM dispositivo_proveedor dp " +
                                "INNER JOIN proveedor p " +
                                "ON p.nit = dp.nit_proveedor " +
                                "INNER JOIN dispositivo d " +
                                "ON d.plaqueta_inv = dp.plaqueta_inventarios " +
                                "WHERE serial='" +devSer+ "'";
            grdIngresss.DataSource = connection.FillGrid(fillGrid);

            string numberIB = grdIngresss.CurrentRow.Cells[6].Value.ToString(); //Se guarda el número de la placa de inventarios en una variable.
            //var theNumber = int.Parse(numberIB); //Se convierte en entero para retornar un valor entero.

            return numberIB;
        }
        #endregion

        #region CONTROL DE TIEMPO
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            dtpDate.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region EVENTOS TEXTBOX
        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtInch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtHDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMaxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMinWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMeasureRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSupplierNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSupplierPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            /*Sólo permite un punto decimal.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }
        #endregion

        #region CONSULTAR EL ORDEN DE LAS COLUMNAS EN LA TABLA
        public void consultColumn()
        {
            String columnas = "";
            for (int i = 0; i < grdIngresss.ColumnCount; i++)
            {
                columnas = columnas + " Col [" + i.ToString() + "], " + grdIngresss.Columns[i].HeaderText.ToString();
            }
            MessageBox.Show(columnas);
        }
        #endregion

        #region IMPRIMIR
        private void btnPrintIB_Click(object sender, EventArgs e)
        {
            bool noOption = true;
            bool L = false;
            bool R = false;

            using (FRM_Print frmPrint = new FRM_Print())
            {
                if (frmPrint.ShowDialog() == DialogResult.OK)
                {
                    if (frmPrint.xl == 1)
                    {
                        noOption = false;
                        L = true;
                        R = false;
                        clsPrint clsPrint = new clsPrint(L, R);

                        if (clsPrint.xLeft == true)
                        {
                            pbxMercaLogo.SizeMode = PictureBoxSizeMode.Zoom;

                            PrintDialog printDiag = new PrintDialog();
                            PrintDocument printDoc = new PrintDocument();

                            printDoc.PrintPage += PrintQR_Left;
                            printDiag.Document = printDoc;

                            if (printDiag.ShowDialog() == DialogResult.OK)
                            {
                                printDoc.Print();
                            }
                        }
                    }
                    else
                    {
                        if (frmPrint.xr == 1)
                        {
                            noOption = false;
                            L = false;
                            R = true;
                            clsPrint clsPrint = new clsPrint(L, R);

                            if (clsPrint.xRight == true && noOption == false)
                            {
                                pbxMercaLogo.SizeMode = PictureBoxSizeMode.Zoom;

                                PrintDialog printDiag = new PrintDialog();
                                PrintDocument printDoc = new PrintDocument();

                                printDoc.PrintPage += PrintQR_Rigth;
                                printDiag.Document = printDoc;

                                if (printDiag.ShowDialog() == DialogResult.OK)
                                {
                                    printDoc.Print();
                                }
                            }
                        }
                        else
                        {
                            if (frmPrint.xn == 1)
                            {
                                MessageBox.Show("Debe seleccionar una opción", "EERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                BlockCamps(2);
            }
        }

        private void PrintQR_Left(object sender, PrintPageEventArgs e)
        {
            try
            {
                Bitmap btMap = new Bitmap(pbxMercaLogo.Width, pbxMercaLogo.Height);
                pbxMercaLogo.DrawToBitmap(btMap, new Rectangle(0, 0, pbxMercaLogo.Width, pbxMercaLogo.Height));
                
                //pbxMercaLogo.DrawToBitmap(btMap, new Rectangle(0, 0, pbxMercaLogo.Width, pbxMercaLogo.Height)); - PARA IMPRIMIR EN BIXOLON
                e.Graphics.DrawImage(btMap, 260, 18);
                e.Graphics.DrawImage(pnlResult.BackgroundImage, new Rectangle(205, 20, 75, 75));
                e.Graphics.DrawString(txtEncrypt.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(286, 70)); // Print a text in TextBox.
                //Continue Here

                //e.Graphics.DrawImage(pnlResult.BackgroundImage, new Rectangle(160, -10, 100, 100)); - PARA IMPRIMIR EN BIXOLON

                btMap.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo ha salido mal: \n" + error.Message);
            }

        }

        private void PrintQR_Rigth(object sender, PrintPageEventArgs e)
        {
            try
            {
                Bitmap btMap = new Bitmap(pbxMercaLogo.Width, pbxMercaLogo.Height);
                pbxMercaLogo.DrawToBitmap(btMap, new Rectangle(0, 0, pbxMercaLogo.Width, pbxMercaLogo.Height));
                //pbxMercaLogo.DrawToBitmap(btMap, new Rectangle(0, 0, pbxMercaLogo.Width, pbxMercaLogo.Height)); - PARA IMPRIMIR EN BIXOLON
                e.Graphics.DrawImage(btMap, 182, 18);
                e.Graphics.DrawImage(pnlResult.BackgroundImage, new Rectangle(305, 20, 75, 75));
                e.Graphics.DrawString(txtEncrypt.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(205, 70)); // Print a text in TextBox.
                //e.Graphics.DrawImage(pnlResult.BackgroundImage, new Rectangle(160, -10, 100, 100)); - PARA IMPRIMIR EN BIXOLON

                btMap.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo ha salido mal: \n" + error.Message);
            }
        }
        #endregion

        #region ENCRIPTAR
        public string EncryptSHA1(string str)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hsha = sha1.ComputeHash(Encoding.UTF8.GetBytes(str));
                var sb = new StringBuilder(hsha.Length * 2);

                foreach (byte b in hsha)
                {
                    sb.Append(b.ToString());
                }
                return sb.ToString();
            }
        }
        #endregion

        #region HABILITADO DE TEXTBOX
        public void EnableTextBox(int pos)
        {
            //string value = "";
            int row = pos;
            int col = 3;

            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtPulgadas.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtSistema_operativo.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtDisco_duro.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtMemoria_ram.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtProcesador.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtAntivirus.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtDireccion_ip.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtProgramas_licenciados.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtNombre_pc.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                dtpUltimo_certificado.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtPeso_maximo.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtPeso_minimo.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdCategory.Rows[row].Cells[col].Value.ToString() == "True")
            {
                txtRango_medicion.Enabled = true;
                col++;
            }
            else
            {
                col++;
            }
        }
        #endregion

        #region CONSULTAR ADMINISTRADOR
        public bool ConsultAdmin()
        {
            string consultAccess = "SELECT acceso_admin FROM login " +
                            "WHERE usuario='JAIME' ";
            grdAdmin.DataSource = connection.FillGrid(consultAccess);

            if (grdAdmin.CurrentRow.Cells[0].Value.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}