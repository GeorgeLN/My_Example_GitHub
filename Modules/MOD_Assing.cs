using Proyecto_InvHardware.Frames;
using Proyecto_InvHardware.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware
{
    public partial class MOD_Assing : Form
    {
        clsConnection connection = new clsConnection();

        #region DECLARACIÓN DE VARIABLES GLOBALES
        string option = "";
        string optionUpdate = "";
        int sw1 = 0, sw2 = 0, sw3 = 0, sw4 = 0, sw5 = 0, sw6 = 0, sw7 = 0, sw8 = 0, sw9 = 0, sw10 = 0, quantity = 0;
        #endregion

        #region INICIALIZAR COMPONENTES
        public MOD_Assing()
        {
            InitializeComponent();
        }
        #endregion

        #region FORMULARIO ASIGNACIONES
        private void MOD_Assing_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            gbxEmployee.Enabled = false;
            gbxDevice.Enabled = false;
            gbxAvailableDev.Enabled = false;
            gbxCancelButtons.Enabled = false;
            gbxObservations.Enabled = false;
        }
        #endregion

        #region REFRESCAR LAS TABLAS
        public void RefreshGrid()
        {
            string fillGrid = "SELECT e.documento, e.nombre, e.area_empleado, e.sucursal_empleado, d.categoria, d.tipo, d.serial, d.marca, d.modelo, d.plaqueta_inv, d.estado_actual, de.id_empleado_dispositivo, de.fecha_entrega, de.observacion " +
                                    "FROM dispositivo_empleado de " +
                                    "INNER JOIN empleado e " +
                                    "ON e.documento = de.cedula_empleado " +
                                    "INNER JOIN dispositivo d " +
                                    "ON d.plaqueta_inv = de.plaqueta_inventarios " +
                                    "ORDER BY de.id_empleado_dispositivo DESC ";
            grdAssign.DataSource = connection.FillGrid(fillGrid);
        }
        #endregion

        #region ASIGNAR
        private void btnAssing_Click(object sender, EventArgs e)
        {
            option = "ASSIGN";
            ResetCamps(1);

            grdAssign.Enabled = false;
            gbxEmployee.Enabled = true;
            gbxDevice.Enabled = false;
            grdAvailableDev.Enabled = false;
            grdAssign.Enabled = false;

            lblInfo.Text = ".: NOTA :. \nUna vez ingresados los datos del usuario, seleccione en la tabla el dispositivo a asignar.";

            btnAssing.BackColor = Color.White;
            btnAssing.ForeColor = Color.Black;
            btnAssing.IconColor = Color.Black;

            btnAssingToEmployee.BackColor = Color.FromArgb(23, 95, 228);
            btnAssingToEmployee.ForeColor = Color.White;
            btnAssingToEmployee.IconColor = Color.White;
            btnUpdateEmployee.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdateEmployee.ForeColor = Color.White;
            btnUpdateEmployee.IconColor = Color.White;
            btnSearchEmp.BackColor = Color.FromArgb(23, 95, 228);
            btnSearchEmp.ForeColor = Color.White;
            btnSearchEmp.IconColor = Color.White;
            btnAssingReport.BackColor = Color.FromArgb(23, 95, 228);
            btnAssingReport.ForeColor = Color.White;
            btnAssingReport.IconColor = Color.White;
            btnHistory.BackColor = Color.FromArgb(23, 95, 228);
            btnHistory.ForeColor = Color.White;
            btnHistory.IconColor = Color.White;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string branchEmployee = cbxSucursal_Empleado.Text;

            if (txtDocumento.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (cbxArea_Empleado.Text != "")
                    {
                        if (cbxSucursal_Empleado.Text != "")
                        {
                            gbxDevice.Visible = true;
                            gbxAvailableDev.Visible = true;
                            grdAvailableDev.Enabled = true;
                            lblInfo.Visible = false;

                            lblErrDocument.Visible = false;
                            lblErrName.Visible = false;
                            lblErrArea.Visible = false;
                            lblErrBranch.Visible = false;

                            string fillDevices = "SELECT categoria, tipo, serial, marca, modelo, plaqueta_inv, estado_actual " +
                                                    "FROM dispositivo " +
                                                        "WHERE estado_actual = 'EN STOCK' AND sucursal='" + branchEmployee + "' ";
                            grdAvailableDev.DataSource = connection.FillGrid(fillDevices);

                            buttonSelection.Name = "btnSelect";
                            buttonSelection.Text = "ASIGNAR";
                            buttonSelection.UseColumnTextForButtonValue = true;
                        }
                        else
                        {
                            lblErrBranch.Visible = true;
                            MessageBox.Show("No se ha ingresado la sucursal del Empleado." +
                                                "\nCampo 'Sucursal'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        lblErrArea.Visible = true;
                        MessageBox.Show("No se ha ingresado el área del Empleado." +
                                            "\nCampo 'Área'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lblErrName.Visible = true;
                    MessageBox.Show("No se ha ingresado el nombre del Empleado." +
                                        "\nCampo 'Nombre'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblErrDocument.Visible = true;
                MessageBox.Show("No se ha ingresado el documento del Empleado." +
                                    "\nCampo 'Documento'.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ASIGNAR A EMPLEADO EXISTENTE
        private void btnAssingToEmployee_Click(object sender, EventArgs e)
        {
            if (txtSerial1.Text != "")
            {
                option = "ASSIGN_DEV";

                gbxEmployee.Enabled = false;

                gbxDevice.Enabled = true;
                txtCategoria1.Text = "";
                txtCategoria1.Enabled = false;
                txtTipo1.Text = "";
                txtTipo1.Enabled = false;
                txtSerial1.Text = "";
                txtSerial1.Enabled = false;
                txtMarca1.Text = "";
                txtMarca1.Enabled = false;
                txtModelo1.Text = "";
                txtModelo1.Enabled = false;
                txtPlaqueta_Inv1.Text = "";
                txtPlaqueta_Inv1.Enabled = false;
                txtObservacion.Text = "";
                dtpFecha_asigna.ResetText();
                dtpFecha_asigna.Enabled = false;

                gbxAvailableDev.Visible = true;

                string fillDevices = "SELECT categoria, tipo, serial, marca, modelo, plaqueta_inv, estado_actual " +
                                                    "FROM dispositivo " +
                                                        "WHERE estado_actual = 'EN STOCK'";
                grdAvailableDev.DataSource = connection.FillGrid(fillDevices);

                btnAssingToEmployee.BackColor = Color.White;
                btnAssingToEmployee.ForeColor = Color.Black;
                btnAssingToEmployee.IconColor = Color.Black;

                btnAssing.BackColor = Color.FromArgb(23, 95, 228);
                btnAssing.ForeColor = Color.White;
                btnAssing.IconColor = Color.White;
                btnUpdateEmployee.BackColor = Color.FromArgb(23, 95, 228);
                btnUpdateEmployee.ForeColor = Color.White;
                btnUpdateEmployee.IconColor = Color.White;
                btnSearchEmp.BackColor = Color.FromArgb(23, 95, 228);
                btnSearchEmp.ForeColor = Color.White;
                btnSearchEmp.IconColor = Color.White;
                btnAssingReport.BackColor = Color.FromArgb(23, 95, 228);
                btnAssingReport.ForeColor = Color.White;
                btnAssingReport.IconColor = Color.White;
                btnHistory.BackColor = Color.FromArgb(23, 95, 228);
                btnHistory.ForeColor = Color.White;
                btnHistory.IconColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seleccione un empleado de la tabla de registros.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region VISUALIZAR DATOS DE LA TABLA EN LOS TEXTBOX
        private void grdAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*foreach (Control x in this.Controls)
                {
                    if (x is ComboBox)
                    {
                        try
                        {
                            ((ComboBox)x).Text = grdAssign.CurrentRow.Cells[grdAssign.Columns[((ComboBox)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
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
                            if (((TextBox)x).Name == "txtInvBoard")
                            {
                                //Do nothing!
                            }
                            else
                            {
                                ((TextBox)x).Text = grdAssign.CurrentRow.Cells[grdAssign.Columns[((TextBox)x).Name.ToString().Remove(0, 3)].Index].Value.ToString();
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }*/
                txtDocumento.Text =         grdAssign.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text =            grdAssign.CurrentRow.Cells[1].Value.ToString();
                cbxArea_Empleado.Text =     grdAssign.CurrentRow.Cells[2].Value.ToString();
                cbxSucursal_Empleado.Text = grdAssign.CurrentRow.Cells[3].Value.ToString();
                txtCategoria1.Text =         grdAssign.CurrentRow.Cells[4].Value.ToString();
                txtTipo1.Text =              grdAssign.CurrentRow.Cells[5].Value.ToString();
                txtSerial1.Text =            grdAssign.CurrentRow.Cells[6].Value.ToString();
                txtMarca1.Text =             grdAssign.CurrentRow.Cells[7].Value.ToString();
                txtModelo1.Text =            grdAssign.CurrentRow.Cells[8].Value.ToString();
                txtPlaqueta_Inv1.Text =      grdAssign.CurrentRow.Cells[9].Value.ToString();
                dtpFecha_asigna.Text =      grdAssign.CurrentRow.Cells[12].Value.ToString();
                txtObservacion.Text =       grdAssign.CurrentRow.Cells[13].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdAvailableDev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.grdAvailableDev.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                if (txtCategoria1.Text == "")
                {
                    txtCategoria1.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                    txtTipo1.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                    txtSerial1.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                    txtMarca1.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                    txtModelo1.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                    txtPlaqueta_Inv1.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                }
                else
                {
                    if (txtCategoria2.Text == "")
                    {
                        txtCategoria2.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                        txtTipo2.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                        txtSerial2.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                        txtMarca2.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                        txtModelo2.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                        txtPlaqueta_Inv2.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                    }
                    else
                    {
                        if (txtCategoria3.Text == "")
                        {
                            txtCategoria3.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                            txtTipo3.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                            txtSerial3.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                            txtMarca3.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                            txtModelo3.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                            txtPlaqueta_Inv3.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                        }
                        else
                        {
                            if (txtCategoria4.Text == "")
                            {
                                txtCategoria4.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                txtTipo4.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                txtSerial4.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                txtMarca4.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                txtModelo4.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                txtPlaqueta_Inv4.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                            }
                            else
                            {
                                if (txtCategoria5.Text == "")
                                {
                                    txtCategoria5.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                    txtTipo5.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                    txtSerial5.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                    txtMarca5.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                    txtModelo5.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                    txtPlaqueta_Inv5.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                                }
                                else
                                {
                                    if (txtCategoria6.Text == "")
                                    {
                                        txtCategoria6.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                        txtTipo6.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                        txtSerial6.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                        txtMarca6.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                        txtModelo6.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                        txtPlaqueta_Inv6.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                                    }
                                    else
                                    {
                                        if (txtCategoria7.Text == "")
                                        {
                                            txtCategoria7.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                            txtTipo7.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                            txtSerial7.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                            txtMarca7.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                            txtModelo7.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                            txtPlaqueta_Inv7.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                                        }
                                        else
                                        {
                                            if (txtCategoria8.Text == "")
                                            {
                                                txtCategoria8.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                                txtTipo8.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                                txtSerial8.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                                txtMarca8.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                                txtModelo8.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                                txtPlaqueta_Inv8.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                                            }
                                            else
                                            {
                                                if (txtCategoria9.Text == "")
                                                {
                                                    txtCategoria9.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                                    txtTipo9.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                                    txtSerial9.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                                    txtMarca9.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                                    txtModelo9.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                                    txtPlaqueta_Inv9.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                                                }
                                                else
                                                {
                                                    if (txtCategoria10.Text == "")
                                                    {
                                                        txtCategoria10.Text = grdAvailableDev.CurrentRow.Cells[1].Value.ToString();
                                                        txtTipo10.Text = grdAvailableDev.CurrentRow.Cells[2].Value.ToString();
                                                        txtSerial10.Text = grdAvailableDev.CurrentRow.Cells[3].Value.ToString();
                                                        txtMarca10.Text = grdAvailableDev.CurrentRow.Cells[4].Value.ToString();
                                                        txtModelo10.Text = grdAvailableDev.CurrentRow.Cells[5].Value.ToString();
                                                        txtPlaqueta_Inv10.Text = grdAvailableDev.CurrentRow.Cells[6].Value.ToString();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Sólo puede asigar 10 dispositivos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region ACEPTAR
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string addRegister = "";
            string consultEmploye = "";
            string updateStatus = "";
            string editRegister = "";
            DateTime assignD = dtpFecha_asigna.Value;

            //Variables Empleado
            string employeeDocument = txtDocumento.Text;
            string employeeName = txtNombre.Text;
            string employeeArea = cbxArea_Empleado.Text;
            string employeeBranch = cbxSucursal_Empleado.Text;

            //Variables Dispositivo
            string deviceCategory = txtCategoria1.Text;
            string deviceType = txtTipo1.Text;
            string deviceSerial = txtSerial1.Text;
            string deviceBrand = txtMarca1.Text;
            string deviceModel = txtModelo1.Text;           
            string inventoryBoard = txtPlaqueta_Inv1.Text;
            string assignDate = assignD.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); //Se cambia el formato de "dd/MM/yyyy" a "yyyy/MM/dd"
            string observation = txtObservacion.Text;

            //Validaciones
            bool consultE = false;

            consultEmploye = "SELECT * FROM empleado " +
                                "WHERE documento = '" + employeeDocument + "' ";
            consultE = connection.Consult(consultEmploye);

            switch (option)
            {
                #region CASO ASIGNAR
                case "ASSIGN":
                    try
                    {
                        if (txtObservacion.Text != "")
                        {
                            if (txtObservacion.Text.Length <= 250)
                            {
                                if (txtCategoria1.Text != "")
                                {
                                    if (consultE != true)
                                    {
                                        addRegister = "INSERT INTO empleado(documento, nombre, area_empleado, sucursal_empleado) " +
                                                        "VALUES('" + employeeDocument + "','" + employeeName + "','" + employeeArea + "','" + employeeBranch + "') ";
                                        connection.FillDB(addRegister); //Add into employee table.

                                        addRegister = "INSERT INTO dispositivo_empleado(cedula_empleado, plaqueta_inventarios, fecha_entrega, observacion) " +
                                                        "VALUES('" + employeeDocument + "','" + inventoryBoard + "','" + assignDate + "','" + observation + "') ";
                                        connection.FillDB(addRegister); //Add into relation table.

                                        addRegister = "INSERT INTO historial_asignaciones(categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra) " +
                                                        "VALUES('" + deviceCategory + "','" + inventoryBoard + "','" + deviceSerial + "','" + employeeDocument + "','" + employeeArea + "','" + observation + "','" + assignDate + "','JORGEL') ";
                                        connection.FillDB(addRegister); //Add into history table.

                                        updateStatus = "UPDATE dispositivo SET estado_actual = 'ASIGNADO' " +
                                                        "WHERE plaqueta_inv = '" + inventoryBoard + "' ";
                                        connection.FillDB(updateStatus);

                                        RefreshGrid();

                                        MessageBox.Show("Dispositivo asignado correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        ResetCamps(1);
                                    }
                                    else
                                    {
                                        addRegister = "INSERT INTO dispositivo_empleado(cedula_empleado, plaqueta_inventarios, fecha_entrega, observacion) " +
                                                        "VALUES('" + employeeDocument + "','" + inventoryBoard + "','" + assignDate + "','" + observation + "') ";
                                        connection.FillDB(addRegister); //Add into relation table.

                                        addRegister = "INSERT INTO historial_asignaciones(categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra) " +
                                                        "VALUES('" + deviceCategory + "','" + inventoryBoard + "','" + deviceSerial + "','" + employeeDocument + "','" + employeeArea + "','" + observation + "','" + assignDate + "','JORGEL') ";
                                        connection.FillDB(addRegister); //Add into history table.

                                        updateStatus = "UPDATE dispositivo SET estado_actual = 'ASIGNADO' " +
                                                        "WHERE plaqueta_inv = '" + inventoryBoard + "' ";
                                        connection.FillDB(updateStatus);

                                        RefreshGrid();

                                        MessageBox.Show("Dispositivo asignado correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        ResetCamps(1);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione un dispositivo de la tabla para asignar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Superó la cantidad de caracteres permitidos en la observación... Sólo puede ingresar 250 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            lblErrObservation.Visible = true;
                            MessageBox.Show("No se ha ingresado la observación." +
                                                "\nCampo 'Observación'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;
                #endregion

                #region CASO ACTUALIZAR
                case "UPDATE":
                    try
                    {
                        if (employeeDocument != "")
                        {
                            editRegister = "UPDATE empleado SET nombre='" + employeeName + "', " +
                                                                "area_empleado='" + employeeArea + "', " +
                                                                "sucursal_empleado='" + employeeBranch + "' " +
                                                "WHERE documento='" + employeeDocument + "' ";
                            connection.FillDB(editRegister);

                            MessageBox.Show("Datos del empleado modificados correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;
                #endregion

                case "ASSIGN_DEV":
                    try
                    {
                        if (txtObservacion.Text != "")
                        {
                            if (txtObservacion.Text.Length <= 250)
                            {
                                if (txtCategoria1.Text != "")
                                {
                                    addRegister = "INSERT INTO dispositivo_empleado(cedula_empleado, plaqueta_inventarios, fecha_entrega, observacion) " +
                                                    "VALUES('" + employeeDocument + "','" + inventoryBoard + "','" + assignDate + "','" + observation + "') ";
                                    connection.FillDB(addRegister); //Add into relation table.

                                    addRegister = "INSERT INTO historial_asignaciones(categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra) " +
                                                    "VALUES('" + deviceCategory + "','" + inventoryBoard + "','" + deviceSerial + "','" + employeeDocument + "','" + employeeArea + "','" + observation + "','" + assignDate + "','JORGEL') ";
                                    connection.FillDB(addRegister); //Add into history table.

                                    updateStatus = "UPDATE dispositivo SET estado_actual = 'ASIGNADO' " +
                                                    "WHERE plaqueta_inv = '" + inventoryBoard + "' ";
                                    connection.FillDB(updateStatus);

                                    RefreshGrid();

                                    MessageBox.Show("Dispositivo asignado correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ResetCamps(1);
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione un dispositivo de la tabla para asignar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Superó la cantidad de caracteres permitidos en la observación... Sólo puede ingresar 250 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            lblErrObservation.Visible = true;
                            MessageBox.Show("No se ha ingresado la observación." +
                                                "\nCampo 'Observación'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        #endregion

        #region LIMPIAR CAMPOS
        public void ResetCamps(int n)
        {
            if (n == 1)
            {
                gbxAvailableDev.Visible = false;
                lblErrArea.Visible = false;
                lblErrBranch.Visible = false;
                lblErrDate.Visible = false;
                lblErrDocument.Visible = false;
                lblErrName.Visible = false;
                lblErrObservation.Visible = false;

                txtDocumento.Text = "";
                txtNombre.Text = "";
                cbxArea_Empleado.Text = "";
                cbxSucursal_Empleado.Text = "";

                txtCategoria1.Text = "";
                txtTipo1.Text = "";
                txtSerial1.Text = "";
                txtMarca1.Text = "";
                txtModelo1.Text = "";
                txtPlaqueta_Inv1.Text = "";
                dtpFecha_asigna.ResetText();
                txtObservacion.Text = "";
            }
            else
            {
                if (n == 2)
                {
                    option = "";

                    grdAssign.Enabled = true;
                    gbxAvailableDev.Visible = false;
                    gbxCancelButtons.Enabled = false;
                    gbxObservations.Enabled = false;
                    lblErrArea.Visible = false;
                    lblErrBranch.Visible = false;
                    lblErrDate.Visible = false;
                    lblErrDocument.Visible = false;
                    lblErrName.Visible = false;
                    lblErrObservation.Visible = false;

                    txtDocumento.Text = "";
                    txtNombre.Text = "";
                    cbxArea_Empleado.Text = " ";
                    cbxSucursal_Empleado.Text = " ";
                    gbxEmployee.Enabled = false;

                    txtCategoria1.Text = "";
                    txtTipo1.Text = "";
                    txtSerial1.Text = "";
                    txtMarca1.Text = "";
                    txtModelo1.Text = "";
                    txtPlaqueta_Inv1.Text = "";
                    dtpFecha_asigna.ResetText();
                    txtObservacion.Text = "";
                    gbxDevice.Visible = false;

                    btnAssing.BackColor = Color.FromArgb(23, 95, 228);
                    btnAssing.ForeColor = Color.White;
                    btnAssing.IconColor = Color.White;
                    btnAssingToEmployee.BackColor = Color.FromArgb(23, 95, 228);
                    btnAssingToEmployee.ForeColor = Color.White;
                    btnAssingToEmployee.IconColor = Color.White;
                    btnUpdateEmployee.BackColor = Color.FromArgb(23, 95, 228);
                    btnUpdateEmployee.ForeColor = Color.White;
                    btnUpdateEmployee.IconColor = Color.White;
                    btnSearchEmp.BackColor = Color.FromArgb(23, 95, 228);
                    btnSearchEmp.ForeColor = Color.White;
                    btnSearchEmp.IconColor = Color.White;
                    btnAssingReport.BackColor = Color.FromArgb(23, 95, 228);
                    btnAssingReport.ForeColor = Color.White;
                    btnAssingReport.IconColor = Color.White;
                    btnHistory.BackColor = Color.FromArgb(23, 95, 228);
                    btnHistory.ForeColor = Color.White;
                    btnHistory.IconColor = Color.White;

                    RefreshGrid();
                }
            }
        }
        #endregion

        #region MODIFICAR DATOS DEL EMPLEADO
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (txtSerial1.Text != "")
            {
                option = "UPDATE";

                gbxEmployee.Enabled = true;
                btnContinue.Enabled = false;
                txtDocumento.Enabled = false;

                gbxAvailableDev.Visible = false;
                lblErrArea.Visible = false;
                lblErrBranch.Visible = false;
                lblErrDate.Visible = false;
                lblErrDocument.Visible = false;
                lblErrName.Visible = false;
                lblErrObservation.Visible = false;
                gbxAvailableDev.Visible = false;

                txtCategoria1.Text = "";
                txtTipo1.Text = "";
                txtSerial1.Text = "";
                txtMarca1.Text = "";
                txtModelo1.Text = "";
                txtPlaqueta_Inv1.Text = "";
                dtpFecha_asigna.ResetText();
                txtObservacion.Text = "";

                btnUpdateEmployee.BackColor = Color.White;
                btnUpdateEmployee.ForeColor = Color.Black;
                btnUpdateEmployee.IconColor = Color.Black;

                btnAssing.BackColor = Color.FromArgb(23, 95, 228);
                btnAssing.ForeColor = Color.White;
                btnAssing.IconColor = Color.White;
                btnAssingToEmployee.BackColor = Color.FromArgb(23, 95, 228);
                btnAssingToEmployee.ForeColor = Color.White;
                btnAssingToEmployee.IconColor = Color.White;
                btnSearchEmp.BackColor = Color.FromArgb(23, 95, 228);
                btnSearchEmp.ForeColor = Color.White;
                btnSearchEmp.IconColor = Color.White;
                btnAssingReport.BackColor = Color.FromArgb(23, 95, 228);
                btnAssingReport.ForeColor = Color.White;
                btnAssingReport.IconColor = Color.White;
                btnHistory.BackColor = Color.FromArgb(23, 95, 228);
                btnHistory.ForeColor = Color.White;
                btnHistory.IconColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla de registros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CANCELAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetCamps(2);
        }
        #endregion

        #region EVENTOS TEXTBOX
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region HISTORIAL DE ASIGNACIONES
        private void btnHistory_Click(object sender, EventArgs e)
        {
            REC_AssignHisrory frmAssign = new REC_AssignHisrory();

            frmAssign.ShowDialog();
        }
        #endregion

        #region BUSCAR EMPLEADO
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            FRM_SearchAssing frmSearch = new FRM_SearchAssing();

            btnAssing.Enabled = false;
            btnUpdateEmployee.Enabled = false;
            btnAssingReport.Enabled = false;

            btnSearchEmp.BackColor = Color.White;
            btnSearchEmp.ForeColor = Color.Black;
            btnSearchEmp.IconColor = Color.Black;

            btnUpdateEmployee.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdateEmployee.ForeColor = Color.White;
            btnUpdateEmployee.IconColor = Color.White;
            btnAssing.BackColor = Color.FromArgb(23, 95, 228);
            btnAssing.ForeColor = Color.White;
            btnAssing.IconColor = Color.White;
            btnAssingReport.BackColor = Color.FromArgb(23, 95, 228);
            btnAssingReport.ForeColor = Color.White;
            btnAssingReport.IconColor = Color.White;
            btnAssingToEmployee.BackColor = Color.FromArgb(23, 95, 228);
            btnAssingToEmployee.ForeColor = Color.White;
            btnAssingToEmployee.IconColor = Color.White;

            string employeeDocument = "";
            string deviceSerial = "";
            string search = ""; //Se crea una variable de busqueda que de acuerdo al campo que se llene "Cédula" o "Serial", realice la busqueda en la tabla relacionada.
            string fillGrid = "";
            bool consultS = false;
            bool consultD = false;
            bool consultR = false;
            int onlyE = 0;
            int onlyD = 0;

            if (frmSearch.ShowDialog() == DialogResult.OK)
            {
                if (frmSearch.txtDeviceSerial.Text == "")
                {
                    employeeDocument = frmSearch.txtEmployeeDocument.Text;
                }
                else
                {
                    if (frmSearch.txtEmployeeDocument.Text == "")
                    {
                        deviceSerial = frmSearch.txtDeviceSerial.Text;
                    }
                }

                if (frmSearch.chbOnlyEmployee.Checked == true)
                {
                    onlyE = 1;
                    onlyD = 0;
                }
                else
                {
                    if (frmSearch.chbOnlyDevice.Checked == true)
                    {
                        onlyE = 0;
                        onlyD = 1;
                    }
                }

                try
                {
                    #region BUSCAR EMPLEADO EN LA TABLA (RELACIÓN)
                    if (employeeDocument != "" && onlyE == 0) //Buscar empleado en la relación.
                    {
                        search = " WHERE nit='" + employeeDocument + "'";

                        string consultSupplier = "SELECT * FROM dispositivo_empleado " +
                                                    "WHERE documento='" + employeeDocument + "'";
                        consultR = connection.Consult(consultSupplier);

                        if (consultR == true)
                        {
                            fillGrid = "CALL Dispositivo_Empleado()";
                            grdAssign.DataSource = connection.FillGrid(fillGrid);

                            btnAssingToEmployee.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("El empleado no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            string consultDevice = "SELECT * FROM dispositivo_empleado " +
                                                    "WHERE plaqueta_inventarios='" + IBN + "' ";
                            consultR = connection.Consult(consultDevice);

                            if (consultR == true)
                            {
                                fillGrid = "select e.documento, e.nombre, e.area_empleado, e.sucursal_empleado, d.categoria, d.tipo, d.serial, d.marca, d.modelo, d.plaqueta_inv, d.estado_actual, de.id_empleado_dispositivo, de.fecha_entrega, de.observacion " +
                                            "from dispositivo_empleado de " +
                                            "inner join empleado e " +
                                            "on e.documento = de.cedula_empleado " +
                                            "inner join dispositivo d " +
                                            "on d.plaqueta_inv = de.plaqueta_inventarios " +
                                            "" +search + "";
                                grdAssign.DataSource = connection.FillGrid(fillGrid);
                            }
                            else
                            {
                                MessageBox.Show("El dispositivo no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        #endregion
                        else
                        {
                            #region BUSCAR SÓLO EMPLEADO
                            if (onlyE == 1) //Buscar sólo los datos del empleado.
                            {
                                search = "WHERE documento ='" + employeeDocument + "'";

                                fillGrid = "SELECT * FROM empleado " +
                                    "" + search + "";
                                consultS = connection.Consult(fillGrid);

                                if (consultS != false)
                                {
                                    optionUpdate = "UPDATE EMPLOYEE";

                                    grdEmployees.DataSource = connection.FillGrid(fillGrid);

                                    txtDocumento.Text = grdEmployees.CurrentRow.Cells[0].Value.ToString();
                                    txtNombre.Text = grdEmployees.CurrentRow.Cells[1].Value.ToString();
                                    cbxArea_Empleado.Text = grdEmployees.CurrentRow.Cells[2].Value.ToString();
                                    cbxSucursal_Empleado.Text = grdEmployees.CurrentRow.Cells[3].Value.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Empleado no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                        string consultDate = "CALL Dispositivo_Empleado() ";
                                        grdDevices.DataSource = connection.FillGrid(consultDate);
                                        dtpFecha_asigna.Text = grdDevices.CurrentRow.Cells[12].Value.ToString();

                                        grdDevices.DataSource = connection.FillGrid(fillGrid);
                                        txtSerial1.Text = grdDevices.CurrentRow.Cells[0].Value.ToString();
                                        txtMarca1.Text = grdDevices.CurrentRow.Cells[1].Value.ToString();
                                        txtModelo1.Text = grdDevices.CurrentRow.Cells[2].Value.ToString();
                                        txtCategoria1.Text = grdDevices.CurrentRow.Cells[3].Value.ToString();
                                        txtTipo1.Text = grdDevices.CurrentRow.Cells[4].Value.ToString();

                                        string numberIB = grdDevices.CurrentRow.Cells[20].Value.ToString();
                                        var theNumber = int.Parse(numberIB);
                                        numberIB = theNumber.ToString("000000");
                                        txtPlaqueta_Inv1.Text = numberIB;

                                        txtObservacion.Text = grdDevices.CurrentRow.Cells[23].Value.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El dispositivo no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        CleanEnable();
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
        }
        #endregion

        #region CONSULTAR PLACA DE INVENTARIOS
        public string ConsultInvBoard(string devSer)
        {
            string fillGrid = "CALL Dispositivo_Empleado() "; //Procedimiento almacenado.
            grdAssign.DataSource = connection.FillGrid(fillGrid);

            string numberIB = grdAssign.CurrentRow.Cells[9].Value.ToString(); //Se guarda el número de la placa de inventarios en una variable.

            return numberIB;
        }
        #endregion

        #region PROCEDIMIENTO "CleanEnable" and "BlockCamps"
        public void CleanEnable()
        {
            //Limpiar y habilitar campos del formulario.
            txtCategoria1.Text = " ";
            txtTipo1.Text = "";
            txtSerial1.Text = "";
            txtMarca1.Text = "";
            txtModelo1.Text = "";
            cbxSucursal_Empleado.Text = "";
            txtPlaqueta_Inv1.Text = "";

            txtDocumento.Text = "";
            txtNombre.Text = "";
            cbxArea_Empleado.Text = "";
            cbxSucursal_Empleado.Text = "";

            dtpFecha_asigna.ResetText();
            txtObservacion.Text = "";
        }

        public void BlockCamps(int var)
        {
            if (var == 1)
            {

            }
            else
            {
                if (var == 2)
                {
                    txtCategoria1.Enabled = true;
                    txtTipo1.Enabled = true;
                    txtSerial1.Enabled = true;
                    txtMarca1.Enabled = true;
                    txtModelo1.Enabled = true;
                    txtPlaqueta_Inv1.Enabled = true;

                    txtDocumento.Enabled = true;
                    txtNombre.Enabled = true;
                    cbxArea_Empleado.Enabled = true;
                    cbxSucursal_Empleado.Enabled = true;

                    dtpFecha_asigna.Enabled = true;
                    txtObservacion.Enabled = true;

                    RefreshGrid();

                    #region CAMBIO DE COLOR EN LOS BOTÓNES
                    //pnlContainer.BackColor = Color.FromArgb(R, G, B);

                    btnAssing.BackColor = Color.FromArgb(23, 95, 228);
                    btnAssing.ForeColor = Color.White;
                    btnAssing.IconColor = Color.White;

                    btnAssingToEmployee.BackColor = Color.FromArgb(23, 95, 228);
                    btnAssingToEmployee.ForeColor = Color.White;
                    btnAssingToEmployee.IconColor = Color.White;

                    btnUpdateEmployee.BackColor = Color.FromArgb(23, 95, 228);
                    btnUpdateEmployee.ForeColor = Color.White;
                    btnUpdateEmployee.IconColor = Color.White;

                    btnSearchEmp.BackColor = Color.FromArgb(23, 95, 228);
                    btnSearchEmp.ForeColor = Color.White;
                    btnSearchEmp.IconColor = Color.White;

                    btnAssingReport.BackColor = Color.FromArgb(23, 95, 228);
                    btnAssingReport.ForeColor = Color.White;
                    btnAssingReport.IconColor = Color.White;
                    #endregion
                }
            }
        }
        #endregion

        #region BOTÓNES LIMPIAR CAMPOS DE TXT
        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtCategoria1.Text = "";
            txtTipo1.Text = "";
            txtSerial1.Text = "";
            txtMarca1.Text = "";
            txtModelo1.Text = "";
            txtPlaqueta_Inv1.Text = "";
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtCategoria2.Text = "";
            txtTipo2.Text = "";
            txtSerial2.Text = "";
            txtMarca2.Text = "";
            txtModelo2.Text = "";
            txtPlaqueta_Inv2.Text = "";
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            txtCategoria3.Text = "";
            txtTipo3.Text = "";
            txtSerial3.Text = "";
            txtMarca3.Text = "";
            txtModelo3.Text = "";
            txtPlaqueta_Inv3.Text = "";
        }

        private void btnClear4_Click(object sender, EventArgs e)
        {
            txtCategoria4.Text = "";
            txtTipo4.Text = "";
            txtSerial4.Text = "";
            txtMarca4.Text = "";
            txtModelo4.Text = "";
            txtPlaqueta_Inv4.Text = "";
        }

        private void btnClear5_Click(object sender, EventArgs e)
        {
            txtCategoria5.Text = "";
            txtTipo5.Text = "";
            txtSerial5.Text = "";
            txtMarca5.Text = "";
            txtModelo5.Text = "";
            txtPlaqueta_Inv5.Text = "";
        }

        private void btnClear6_Click(object sender, EventArgs e)
        {
            txtCategoria6.Text = "";
            txtTipo6.Text = "";
            txtSerial6.Text = "";
            txtMarca6.Text = "";
            txtModelo6.Text = "";
            txtPlaqueta_Inv6.Text = "";
        }

        private void btnClear7_Click(object sender, EventArgs e)
        {
            txtCategoria7.Text = "";
            txtTipo7.Text = "";
            txtSerial7.Text = "";
            txtMarca7.Text = "";
            txtModelo7.Text = "";
            txtPlaqueta_Inv7.Text = "";
        }

        private void btnClear8_Click(object sender, EventArgs e)
        {
            txtCategoria8.Text = "";
            txtTipo8.Text = "";
            txtSerial8.Text = "";
            txtMarca8.Text = "";
            txtModelo8.Text = "";
            txtPlaqueta_Inv8.Text = "";
        }

        private void btnClear9_Click(object sender, EventArgs e)
        {
            txtCategoria9.Text = "";
            txtTipo9.Text = "";
            txtSerial9.Text = "";
            txtMarca9.Text = "";
            txtModelo9.Text = "";
            txtPlaqueta_Inv9.Text = "";
        }

        private void btnClear10_Click(object sender, EventArgs e)
        {
            txtCategoria10.Text = "";
            txtTipo10.Text = "";
            txtSerial10.Text = "";
            txtMarca10.Text = "";
            txtModelo10.Text = "";
            txtPlaqueta_Inv10.Text = "";
        }
        #endregion
    }
}
