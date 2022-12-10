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
using System.Windows.Controls;
using System.Windows.Forms;
using ToolTip = System.Windows.Controls.ToolTip;

namespace Proyecto_InvHardware
{
    public partial class MOD_Main : Form
    {
        public string _User; //Se crea una variable pública que sirve como puente para pasar el nombre de usuario desde el formulario de LOGIN hasta el formulario de GESTIÓN QR.
        String cn = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;
        clsConnection connection = new clsConnection();
        int R = 0;
        int G = 0;
        int B = 0;
        int sw = 0;

        #region INICIALIZAR COMPONENTES
        public MOD_Main()
        {
            InitializeComponent();            
        }
        #endregion

        #region FORMULARIO MAIN
        private void MOD_Main_Load(object sender, EventArgs e)
        {
            lblUser.Text = _User;

            //Se cargan los colores del formulario.
            /*string SQL = "SELECT codigo, tipo_config, nueva_config " +
                            "FROM configuraciones "; //La consulta para obetener el dato debe ser específica.

            string colors = connection.ObtainData(SQL, 2);
            var selection = 0;
            char[] delimiter = { ',' };
            string[] RGB = colors.Split(delimiter);

            for (int i=0; i<RGB.Length; i++)
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

            gbxContainer.BackColor = Color.FromArgb(23, 95, 228);
            lblUp.BackColor = Color.FromArgb(23, 95, 228);
            lblLeft.BackColor = Color.FromArgb(23, 95, 228);
            btnReturn.BackColor = Color.FromArgb(23, 95, 228);
        }   
        #endregion

        #region ABRIR LOS FOMULARIOS EN EL MAIN Y BOTÓNES "INGRESOS", "ASIGNACIONES", "REPARACIÓNES", "TRASLADOS", "BAJAS"
        private void OpenPanels(object forms)
        {
            try
            {
                if (this.pnlContainer.Controls.Count > 0) //Se valida que el Panel donde se visualizarán los formularios no tenga nada.
                {
                    this.pnlContainer.Controls.Clear(); //En caso de que tenga objetos, se limpia con el método Clean().
                }

                Form frmForms = forms as Form; //Se crea un objeto de tipo FORM.
                frmForms.TopLevel = false; //Al hacer falso la propiedad "TopLevel", decimos que en el panel irá un formulario de 2do nivel... No será principal.
                frmForms.Dock = DockStyle.Fill; //Dock permite ajustar el tamaño del formulario al del panel.
                this.pnlContainer.Controls.Add(frmForms); //Se agrega el forumlario al panel.
                this.pnlContainer.Tag = frmForms; //Se establece la instancia como contenedor de datos.

                frmForms.Show(); //Se muestra el formulario.

                MOD_Ingress frmIngress = new MOD_Ingress();
                MOD_Assing frmAssing = new MOD_Assing();
                MOD_Low frmLow = new MOD_Low();
                MOD_Repair frmRepair = new MOD_Repair();
                MOD_Tranfer frmTransfer = new MOD_Tranfer();

                frmIngress._User = "JORGEL";
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message);
            }
        }
        #endregion

        #region INGRESAR
        private void btnIngress_Click(object sender, EventArgs e)
        {
            MOD_Ingress frmIngress = new MOD_Ingress();

            OpenPanels(new MOD_Ingress()); //Se invoca el método OpenPanels ("Abrir paneles" para los que no saben inglés) y como parámetro se coloca el nombre del formulario que se desea ver.
            btnReturn.Visible = true; // Se hace visible el botón de regresar para cerrar un panel con una interfaz.

            //Se cambia el color del botón para saber que está seleccionado.
            btnIngress.BackColor = Color.White;
            btnIngress.ForeColor = Color.Black;
            btnIngress.IconColor = Color.Black;

            //Los colores de los demás botónes regresan a la normalidad.
            btnAssing.BackColor = Color.FromArgb(23, 95, 228);
            btnAssing.ForeColor = Color.White;
            btnAssing.IconColor = Color.White;

            btnRepare.BackColor = Color.FromArgb(23, 95, 228);
            btnRepare.ForeColor = Color.White;
            btnRepare.IconColor = Color.White;

            btnTransfer.BackColor = Color.FromArgb(23, 95, 228);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.IconColor = Color.White;

            btnLow.BackColor = Color.FromArgb(23, 95, 228);
            btnLow.ForeColor = Color.White;
            btnLow.IconColor = Color.White;
        }
        #endregion

        #region ASIGNAR
        private void btnAssing_Click(object sender, EventArgs e)
        {
            OpenPanels(new MOD_Assing());
            btnReturn.Visible = true;

            //Se cambia el color del botón para saber que está seleccionado.
            btnAssing.BackColor = Color.White;
            btnAssing.ForeColor = Color.Black;
            btnAssing.IconColor = Color.Black;

            //Los colores de los demás botónes regresan a la normalidad.
            btnIngress.BackColor = Color.FromArgb(23, 95, 228);
            btnIngress.ForeColor = Color.White;
            btnIngress.IconColor = Color.White;

            btnRepare.BackColor = Color.FromArgb(23, 95, 228);
            btnRepare.ForeColor = Color.White;
            btnRepare.IconColor = Color.White;

            btnTransfer.BackColor = Color.FromArgb(23, 95, 228);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.IconColor = Color.White;

            btnLow.BackColor = Color.FromArgb(23, 95, 228);
            btnLow.ForeColor = Color.White;
            btnLow.IconColor = Color.White;
        }
        #endregion

        #region REPARACIONES
        private void btnRepair_Click(object sender, EventArgs e)
        {
            OpenPanels(new MOD_Repair());
            btnReturn.Visible = true;

            //Se cambia el color del botón para saber que está seleccionado.
            btnRepare.BackColor = Color.White;
            btnRepare.ForeColor = Color.Black;
            btnRepare.IconColor = Color.Black;

            //Los colores de los demás botónes regresan a la normalidad.
            btnIngress.BackColor = Color.FromArgb(23, 95, 228);
            btnIngress.ForeColor = Color.White;
            btnIngress.IconColor = Color.White;

            btnAssing.BackColor = Color.FromArgb(23, 95, 228);
            btnAssing.ForeColor = Color.White;
            btnAssing.IconColor = Color.White;

            btnTransfer.BackColor = Color.FromArgb(23, 95, 228);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.IconColor = Color.White;

            btnLow.BackColor = Color.FromArgb(23, 95, 228);
            btnLow.ForeColor = Color.White;
            btnLow.IconColor = Color.White;
        }
        #endregion

        #region TRASLADOS
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OpenPanels(new MOD_Tranfer());
            btnReturn.Visible = true;

            //Se cambia el color del botón para saber que está seleccionado.
            btnTransfer.BackColor = Color.White;
            btnTransfer.ForeColor = Color.Black;
            btnTransfer.IconColor = Color.Black;

            //Los colores de los demás botónes regresan a la normalidad.
            btnIngress.BackColor = Color.FromArgb(23, 95, 228);
            btnIngress.ForeColor = Color.White;
            btnIngress.IconColor = Color.White;

            btnAssing.BackColor = Color.FromArgb(23, 95, 228);
            btnAssing.ForeColor = Color.White;
            btnAssing.IconColor = Color.White;

            btnRepare.BackColor = Color.FromArgb(23, 95, 228);
            btnRepare.ForeColor = Color.White;
            btnRepare.IconColor = Color.White;

            btnLow.BackColor = Color.FromArgb(23, 95, 228);
            btnLow.ForeColor = Color.White;
            btnLow.IconColor = Color.White;
        }
        #endregion

        #region BAJAS
        private void btnLow_Click(object sender, EventArgs e)
        {
            OpenPanels(new MOD_Low());
            btnReturn.Visible = true;

            //Se cambia el color del botón para saber que está seleccionado.
            btnLow.BackColor = Color.White;
            btnLow.ForeColor = Color.Black;
            btnLow.IconColor = Color.Black;

            //Los colores de los demás botónes regresan a la normalidad.
            btnIngress.BackColor = Color.FromArgb(23, 95, 228);
            btnIngress.ForeColor = Color.White;
            btnIngress.IconColor = Color.White;

            btnAssing.BackColor = Color.FromArgb(23, 95, 228);
            btnAssing.ForeColor = Color.White;
            btnAssing.IconColor = Color.White;

            btnRepare.BackColor = Color.FromArgb(23, 95, 228);
            btnRepare.ForeColor = Color.White;
            btnRepare.IconColor = Color.White;

            btnTransfer.BackColor = Color.FromArgb(23, 95, 228);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.IconColor = Color.White;
        }
        #endregion

        #region REGRESAR
        private void btnReturn_Click(object sender, EventArgs e)
        {
            OpenPanels(new MainFrame());
            btnReturn.Visible = false;
            btnReturn.ForeColor = Color.FromArgb(23, 95, 228);

            //Se regresan a la normalidad los colores de los botónes principales del menú.
            btnAssing.BackColor = Color.FromArgb(23, 95, 228);
            btnAssing.ForeColor = Color.White;
            btnAssing.IconColor = Color.White;

            btnIngress.BackColor = Color.FromArgb(23, 95, 228);
            btnIngress.ForeColor = Color.White;
            btnIngress.IconColor = Color.White;

            btnLow.BackColor = Color.FromArgb(23, 95, 228);
            btnLow.ForeColor = Color.White;
            btnLow.IconColor = Color.White;

            btnRepare.BackColor = Color.FromArgb(23, 95, 228);
            btnRepare.ForeColor = Color.White;
            btnRepare.IconColor = Color.White;

            btnTransfer.BackColor = Color.FromArgb(23, 95, 228);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.IconColor = Color.White;
        }
        #endregion

        #region BOTÓN SALIR
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitEvent();
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            ExitEvent();
        }
        #endregion

        #region EVENTOS ADICIONALES DEL FORMULARIO
        public void ExitEvent()
        {
            DialogResult dr = MessageBox.Show("¿Desea salir?.", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Form frmLogin = new Login();

                string updateAccess = "UPDATE login SET acceso_admin = 0 " +
                            "WHERE usuario='JAIMET' ";
                connection.FillDB(updateAccess);

                frmLogin.Show();
                this.Hide();
            }
        }
        #endregion

        #region HORA Y FECHA
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        private void btnMinimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeBox_Click(object sender, EventArgs e)
        {
            if (sw == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                sw = 1;
            }
            else
            {
                if (sw == 1)
                {
                    this.WindowState = FormWindowState.Normal;
                    sw = 0;
                }
            }
        }
    }
}
