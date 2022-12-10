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
    public partial class REC_IngressHistory : Form
    {
        clsConnection connection = new clsConnection();

        public REC_IngressHistory()
        {
            InitializeComponent();
        }

        private void REC_IngressHistory_Load(object sender, EventArgs e)
        {
            if (txtSearchSupplier.Enabled == false)
            {
                txtSearchSupplier.BackColor = Color.White; //Cambio de color al txt cuando está inhabilitado.
            }

            if (txtSearchDevice.Enabled == false)
            {
                txtSearchDevice.BackColor = Color.White; //Cambio de color al txt cuando está inhabilitado.
            }

            string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, nit_proveedor, observacion, fecha_ingreso, usuario_registra " +
                    "FROM historial_ingresos ";
            grdRecords.DataSource = connection.FillGrid(fillGrid);
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            txtSearchSupplier.Enabled = true;
            txtSearchSupplier.Focus();

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

            if (txtSearchSupplier.Enabled == true)
            {
                txtSearchSupplier.Enabled = false;
                txtSearchSupplier.BackColor = Color.White;
            }
        }

        private void txtSearchSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string supplierDocument = txtSearchSupplier.Text;

                    string consultSupllier = "SELECT * FROM dispositivo_proveedor " +
                                                "WHERE nit_proveedor='" + supplierDocument + "' ";
                    bool consultS = connection.Consult(consultSupllier);

                    if (consultS != false)
                    {
                        string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, nit_proveedor, observacion, fecha_ingreso, usuario_registra " +
                            "FROM historial_ingresos " +
                            "WHERE nit_proveedor='" + supplierDocument + "' ";
                        grdRecords.DataSource = connection.FillGrid(fillGrid);

                        grdRecords.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtSearchSupplier.Text = "";
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

                    if (invBoard != 0)
                    {
                        string consultDevice = "SELECT * FROM dispositivo_proveedor " +
                                                    "WHERE plaqueta_inventarios='" + invBoard + "' ";
                        bool consultD = connection.Consult(consultDevice);

                        if (consultD != false)
                        {
                            string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, nit_proveedor, observacion, fecha_ingreso, usuario_registra " +
                                                "FROM historial_ingresos " +
                                                "WHERE serial_dispositivo='" + deviceSerial + "' ";
                            grdRecords.DataSource = connection.FillGrid(fillGrid);

                            grdRecords.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Dispositivo no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string fillGrid = "SELECT categoria, plaqueta_inventarios, serial_dispositivo, nit_proveedor, observacion, fecha_ingreso, usuario_registra " +
                    "FROM historial_ingresos ";
            grdRecords.DataSource = connection.FillGrid(fillGrid);

            grdRecords.Visible = true;
            txtSearchSupplier.Enabled = false;
            txtSearchSupplier.Text = "";
            txtSearchDevice.Enabled = false;
            txtSearchDevice.Text = "";
        }

        public int ObtainInvBoard(string devSerial)
        {
            string a = "";

            try
            {
                bool consultDevice = false;

                string querySql = "SELECT * FROM dispositivo " +
                                    "WHERE serial='" +devSerial+ "' ";
                consultDevice = connection.Consult(querySql);
                
                if (consultDevice != false)
                {
                    string searchInvBoard = "SELECT * FROM dispositivo " +
                                            "WHERE serial='" + devSerial + "' ";
                    grdInvBoard.DataSource = connection.FillGrid(searchInvBoard);

                    a = grdInvBoard.CurrentRow.Cells[20].Value.ToString();

                    Int32 newIB = Convert.ToInt32(a);
                    return newIB;
                }
                else
                {
                    a = "0";
                    Int32 newIB = Convert.ToInt32(a);
                    return newIB;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
