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
    public partial class FRM_MenuCategories : Form
    {
        clsConnection connection = new clsConnection();

        int R = 0;
        int G = 0;
        int B = 0;

        #region INICIALIZAR COMPONENTES
        public FRM_MenuCategories()
        {
            InitializeComponent();
        }
        #endregion

        #region FORMULARIO "MENÚ CATEGORÍAS"
        private void FRM_SelectCategory_Load(object sender, EventArgs e)
        {
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

            btnReturn.BackColor = Color.FromArgb(23, 95, 228);
        }
        #endregion

/*      #region OBTENER DATO DE LA BASE DE DATOS
        public List<clsColors> Get() //Se crea una clase que contendrá los datos sacados de la base de datos.
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
        #endregion  */

        #region CONFIGURAR CATEGORÍAS
        private void btnCategories_Click(object sender, EventArgs e)
        {
            FRM_Category frmCat1 = new FRM_Category();

            frmCat1.Show();
            this.Hide();
        }
        #endregion

        #region CONFIGURAR CATEGORÍAS (TIPOS)
        private void btnTypes_Click(object sender, EventArgs e)
        {
            FRM_Types frmType1 = new FRM_Types();

            frmType1.Show();
            this.Hide();
        }
        #endregion

        #region REGRESAR
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MOD_Ingress frmIngress = new MOD_Ingress();

            this.Hide();
        }
        #endregion
    }
}
