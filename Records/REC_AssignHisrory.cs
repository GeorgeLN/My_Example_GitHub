using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware.Records
{
    public partial class REC_AssignHisrory : Form
    {
        clsConnection connection = new clsConnection();

        public REC_AssignHisrory()
        {
            InitializeComponent();
        }

        private void REC_AssignHisrory_Load(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Enabled == false)
            {
                txtSearchEmployee.BackColor = Color.White; //Cambio de color al txt cuando está inhabilitado.
            }

            if (txtSearchDevice.Enabled == false)
            {
                txtSearchDevice.BackColor = Color.White; //Cambio de color al txt cuando está inhabilitado.
            }

            string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra " +
                                "FROM historial_asignaciones ";
            grdRecords.DataSource = connection.FillGrid(fillGrid);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            txtSearchEmployee.Enabled = true;
            txtSearchEmployee.Focus();

            if (txtSearchDevice.Enabled == true)
            {
                txtSearchDevice.Enabled = false;
                txtSearchDevice.BackColor = Color.White;
            }
        }

        private void btnSearchDevice_Click(object sender, EventArgs e)
        {
            txtSearchDevice.Enabled = true;
            txtSearchDevice.Focus();

            if (txtSearchEmployee.Enabled == true)
            {
                txtSearchEmployee.Enabled = false;
                txtSearchEmployee.BackColor = Color.White;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra " +
                    "FROM historial_asignaciones ";
            grdRecords.DataSource = connection.FillGrid(fillGrid);

            grdRecords.Visible = true;
            txtSearchEmployee.Enabled = false;
            txtSearchEmployee.Text = "";
            txtSearchDevice.Enabled = false;
            txtSearchDevice.Text = "";
        }

        private void txtSearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string employeeDocument = txtSearchEmployee.Text;

                    string consultSupllier = "SELECT * FROM dispositivo_empleado  " +
                                                "WHERE cedula_empleado='" + employeeDocument + "' ";
                    bool consultS = connection.Consult(consultSupllier);

                    if (consultS != false)
                    {
                        string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra " +
                            "FROM historial_asignaciones " +
                            "WHERE documento_empleado='" + employeeDocument + "' ";
                        grdRecords.DataSource = connection.FillGrid(fillGrid);

                        grdRecords.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtSearchEmployee.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchDevice_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string deviceSerial = txtSearchDevice.Text;
                    int invBoard = ObtainInvBoard(deviceSerial);

                    string consultDevice = "SELECT * FROM dispositivo_empleado " +
                                                "WHERE plaqueta_inventarios='" + invBoard + "' ";
                    bool consultD = connection.Consult(consultDevice);

                    if (consultD != false)
                    {
                        string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, documento_empleado, area_empleado, observacion, fecha_ingreso, usuario_registra " +
                                            "FROM historial_asignaciones " +
                                            "WHERE serial_dispositivo='" + deviceSerial + "' ";
                        grdRecords.DataSource = connection.FillGrid(fillGrid);

                        grdRecords.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Dispositivo no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtSearchDevice.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ObtainInvBoard(string devSerial)
        {
            string a = "";
            try
            {
                string searchInvBoard = "SELECT plaqueta_inv FROM dispositivo " +
                                            "WHERE serial='" + devSerial + "' ";
                grdInvBoard.DataSource = connection.FillGrid(searchInvBoard);

                a = grdInvBoard.CurrentRow.Cells[0].Value.ToString();
                Int32 newIB = Convert.ToInt32(a);
                return newIB;
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
