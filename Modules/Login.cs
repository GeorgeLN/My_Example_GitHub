using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Threading;
//using Proyecto_InvHardware;

namespace Proyecto_InvHardware
{
    public partial class Login : Form
    {
        clsConnection connection = new clsConnection(); //Objeto de tipo Conexión.

        #region INICIALIZAR COMPONENTES
        public Login()
        {
            InitializeComponent();
        }
        clsWaitWindow waitForm = new clsWaitWindow();
        #endregion

        #region FORMULARIO LOGIN
        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblImage; //Se asigna el focus inicial al Label con imagen, para que no se inicie en el txtUser.

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(txtUser_KeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(txtPassword_KeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(btnExit_KeyDown);
        }
        #endregion

        #region EVENTOS DE LOS "TXT_USUARIO" Y "TXT_CONTRASEÑA"
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "INGRESE SU USUARIO")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "INGRESE SU USUARIO";
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "INGRESE SU CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "INGRESE SU CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntry.Focus();
            }
        }

        private void btnEntry_Enter(object sender, EventArgs e)
        {
            btnEntry.BackColor = Color.WhiteSmoke;
            btnEntry.ForeColor = Color.Black;
        }

        private void btnEntry_Leave(object sender, EventArgs e)
        {
            btnEntry.BackColor = Color.SteelBlue;
            btnEntry.ForeColor = Color.White;
        }

        private void btnExix_Enter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.ForeColor = Color.Black;
        }

        private void btnExix_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.SteelBlue;
            btnExit.ForeColor = Color.White;
        }
        #endregion

        #region BOTÓN INGRESAR
        private void btnEntry_Click(object sender, EventArgs e)
        {
            bool userExist;
            bool passwordExist;
            bool accessAdmin;

            MOD_Main frmMain = new MOD_Main();
            MOD_Ingress frmIngres = new MOD_Ingress();

            string user = txtUser.Text;
            string password = txtPassword.Text;

            try
            {
                string consultUser = "SELECT usuario FROM login " +
                                        "WHERE usuario='" + user + "'";
                userExist = connection.Consult(consultUser);

                string consultPassword = "SELECT contrasena FROM login " +
                            "WHERE contrasena='" + password + "' AND usuario='" + user + "'";
                passwordExist = connection.Consult(consultPassword);

                string constultAdmin = "SELECT usuario_admin FROM login " +
                                            "WHERE usuario='" + user + "' AND usuario_admin=" + 1;
                accessAdmin = connection.Consult(constultAdmin);

                if (txtUser.Text != "INGRESE SU USUARIO" && txtPassword.Text != "INGRESE SU CONTRASEÑA")
                {
                    if (userExist != false && passwordExist != false)
                    {
                        frmMain._User = txtUser.Text;

                        if (user == "JAIME")
                        {
                            string online = "UPDATE login SET acceso_admin = 1 " +
                                                "WHERE usuario='" + user + "' ";
                            connection.FillDB(online);
                        }

                        waitForm.Show(this);
                        Thread.Sleep(3000);
                        frmMain.Show();
                        waitForm.Close();
                        this.Hide();
                    }
                    else
                    {
                        if (userExist != true)
                        {
                            MessageBox.Show("Usuario incorrecto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnEntry.BackColor = Color.RoyalBlue;
                            btnEntry.ForeColor = Color.White;
                        }
                        else
                        {
                            if (passwordExist != true)
                            {
                                MessageBox.Show("Contraseña incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btnEntry.BackColor = Color.RoyalBlue;
                                btnEntry.ForeColor = Color.White;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el usuario y la clave", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEntry.BackColor = Color.RoyalBlue;
                    btnEntry.ForeColor = Color.White;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BOTÓN SALIR
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        #endregion

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(34, 36, 49);
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.Cursor = Cursors.Hand;
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Black;
        }

        private void btnEntry_MouseMove(object sender, MouseEventArgs e)
        {
            btnEntry.Cursor = Cursors.Hand;
        }
    }
}
