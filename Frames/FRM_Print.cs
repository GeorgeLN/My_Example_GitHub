using MySql.Data.MySqlClient;
using Proyecto_InvHardware.Properties;
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
    public partial class FRM_Print : Form
    {
        clsConnection connection = new clsConnection();

        public int xl = 0;
        public int xr = 0;
        public int xn = 0;

        int R = 0;
        int G = 0;
        int B = 0;

        public FRM_Print()
        {
            InitializeComponent();
        }

        private void FRM_Print_Load(object sender, EventArgs e)
        {
            /*string SQL = "SELECT codigo, tipo_config, nueva_config " +
                "FROM configuraciones "; //La consulta para obtener el dato debe ser específica.

            string colors = connection.ObtainData(SQL, 2); //El número que se envía como parámetro corresponde a la fila de la tabla en la base de datos donde se encuentra el valor a buscar.
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
        }

        #region EVENTOS BOTONES
        private void btnQRLeft_Click(object sender, EventArgs e)
        {
            xl = 1;
            Image img2 = Resources.QR_Models_2_;
            Image img3 = Resources.QR_Models_3_;

            Bitmap QR_RightBW = new Bitmap(img2);
            btnQRRight.Image = QR_RightBW;
            Bitmap QR_LeftColor = new Bitmap(img3);
            btnQRLeft.Image = QR_LeftColor;
        }

        private void btnQRRight_Click(object sender, EventArgs e)
        {
            xr = 1;
            Image img1 = Resources.QR_Models_1_;
            Image img4 = Resources.QR_Models_4_;

            Bitmap QR_LeftBW = new Bitmap(img1);
            btnQRLeft.Image = QR_LeftBW;
            Bitmap QR_RightColor = new Bitmap(img4);
            btnQRRight.Image = QR_RightColor;
        }
        #endregion

        #region BOTÓN ACEPTAR
        private void btnCheck_Click(object sender, EventArgs e)
        {
            xn = 1;
        }
        #endregion
    }
}
