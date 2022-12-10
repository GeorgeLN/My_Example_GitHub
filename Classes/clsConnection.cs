using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Proyecto_InvHardware
{
    public class clsConnection
    {
        #region CONEXIÓN A PHPMYADMIN.
        //String cn = ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
        #endregion

        String cn = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;

        public DataTable FillGrid(string fillG)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(cn))
            {
                using (MySqlCommand cmd = new MySqlCommand(fillG, con))
                {
                    con.Open();
                    MySqlDataReader read = cmd.ExecuteReader();
                    dt.Load(read);
                    con.Close();
                }
            }
            return dt;
        }

        public void FillDB(string fillG)
        {
            using (MySqlConnection con = new MySqlConnection(cn))
            {
                using (MySqlCommand cmd = new MySqlCommand(fillG, con))
                {
                    con.Open();
                    MySqlDataReader read = cmd.ExecuteReader();
                    con.Close();
                }
            }
        }

        public bool Consult(string fillG)
        {
            bool rCon = false;

            try
            {
                using (MySqlConnection con = new MySqlConnection(cn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(fillG, con))
                    {
                        con.Open();
                        MySqlDataReader read = cmd.ExecuteReader();

                        if (read.Read())
                        {
                            rCon = true;
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception error)
            {
                System.Windows.MessageBox.Show("Algo ha salido mal: \n" + error.Message);
            }
            return rCon;
        }

        public string ConsultQR(string str)
        {
            string encrypt = "";

            using (MySqlConnection con = new MySqlConnection(cn))
            {
                using (MySqlCommand cmd = new MySqlCommand(str, con))
                {
                    con.Open();
                    //MySqlDataReader read = cmd.ExecuteReader();
                    encrypt = Convert.ToString(cmd.ExecuteReader());
                    con.Close();
                }
            }
            return encrypt;
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
                    MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return variable;
        }

        public List<clsColors> Get() //Se crea una clase que contendrá los datos sacados de la base de datos.
        {
            List<clsColors> RGB = new List<clsColors>();

            return RGB;
        }      
    }
}