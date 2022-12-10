using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware.Frames
{
    public partial class FRM_SearchAssing : Form
    {
        public FRM_SearchAssing()
        {
            InitializeComponent();
        }

        #region EVENTOS DE LOS CHECKBOX, RADIOBUTTONS Y TEXTBOX
        private void chbOnlyDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOnlyDevice.Checked == true)
            {
                btnSearch.Enabled = true;
                txtDeviceSerial.Enabled = true;
                txtEmployeeDocument.Enabled = false;
                chbOnlyEmployee.Checked = false;
                rbtSerial.Checked = false;
                rbtDocument.Checked = false;
                txtEmployeeDocument.Text = "";

                txtDeviceSerial.Focus();
            }
        }

        private void chbOnlyEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOnlyEmployee.Checked == true)
            {
                btnSearch.Enabled = true;
                txtEmployeeDocument.Enabled = true;
                txtDeviceSerial.Enabled = false;
                chbOnlyDevice.Checked = false;
                rbtDocument.Checked = false;
                rbtSerial.Checked = false;
                txtDeviceSerial.Text = "";

                txtEmployeeDocument.Focus();
            }
        }

        private void rbtSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSerial.Checked == true)
            {
                btnSearch.Enabled = true;
                txtDeviceSerial.Enabled = true;
                txtEmployeeDocument.Enabled = false;
                chbOnlyDevice.Checked = false;
                chbOnlyEmployee.Checked = false;
                txtEmployeeDocument.Text = "";

                txtDeviceSerial.Focus();
            }
        }

        private void rbtDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDocument.Checked == true)
            {
                btnSearch.Enabled = true;
                txtEmployeeDocument.Enabled = true;
                txtDeviceSerial.Enabled = false;
                chbOnlyDevice.Checked = false;
                chbOnlyEmployee.Checked = false;
                txtDeviceSerial.Text = "";

                txtEmployeeDocument.Focus();
            }
        }

        private void txtDeviceSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

        private void txtEmployeeDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }
        #endregion
    }
}
