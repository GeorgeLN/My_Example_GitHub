using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware
{
    public partial class FRM_Search : Form
    {
        String cn = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;

        int R = 0;
        int G = 0;
        int B = 0;

        #region INICIALIZAR COMPONENTES
        public FRM_Search()
        {
            InitializeComponent();
        }
        #endregion

        #region FORMULARIO BUSCAR
        private void FRM_Buscar_Load(object sender, EventArgs e)
        {
           /* string SQL = "SELECT codigo, tipo_config, nueva_config " +
                "FROM configuraciones "; //La consulta para obetener el dato debe ser específica.

            string colors = ObtainData(SQL, 2);
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

            txtSupplierNit.Enabled = false;
            txtDeviceSerial.Enabled = false;
        }
        #endregion

        #region EVENTOS DE LOS CHECKBOX, RADIOBUTTONS Y TEXTBOX
        private void chbOnlyDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOnlyDevice.Checked == true)
            {
                btnSearch.Enabled = true;
                txtDeviceSerial.Enabled = true;
                txtSupplierNit.Enabled = false;
                chbOnlySupplier.Checked = false;
                rbtSerial.Checked = false;
                rbtNIT.Checked = false;
                txtSupplierNit.Text = "";

                txtDeviceSerial.Focus();
            }
        }

        private void chbOnlySupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOnlySupplier.Checked == true)
            {
                btnSearch.Enabled = true;
                txtSupplierNit.Enabled = true;
                txtDeviceSerial.Enabled = false;
                chbOnlyDevice.Checked = false;
                rbtNIT.Checked = false;
                rbtSerial.Checked = false;
                txtDeviceSerial.Text = "";

                txtSupplierNit.Focus();
            }
        }

        private void rbtSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSerial.Checked == true)
            {
                btnSearch.Enabled = true;
                txtDeviceSerial.Enabled = true;
                txtSupplierNit.Enabled = false;
                chbOnlyDevice.Checked = false;
                chbOnlySupplier.Checked = false;
                txtSupplierNit.Text = "";

                txtDeviceSerial.Focus();
            }
        }

        private void rbtNIT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNIT.Checked == true)
            {
                btnSearch.Enabled = true;
                txtSupplierNit.Enabled = true;
                txtDeviceSerial.Enabled = false;
                chbOnlyDevice.Checked = false;
                chbOnlySupplier.Checked = false;
                txtDeviceSerial.Text = "";

                txtSupplierNit.Focus();
            }
        }

        private void txtDeviceSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }

        private void txtSupplierNit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }
        #endregion

        #region OBTENER DATO DE LA BASE DE DATOS
        public List<clsColors> GetString() //Se crea una clase que contendrá los datos sacados de la base de datos.
        {
            List<clsColors> RGB = new List<clsColors>();

            return RGB;
        }

        public string ObtainData(string MySQL, int location)
        {
            string variable = "";

            using (MySqlConnection con = new MySqlConnection(cn))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(MySQL, con);

                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        variable = reader.GetString(location);

                        clsColors newColor = new clsColors(variable);
                    }
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Algo salió mal: \n " + error.Message);
                }
            }

            return variable;
        }

        #endregion
    }
}
