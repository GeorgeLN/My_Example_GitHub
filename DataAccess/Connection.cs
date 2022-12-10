using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    public abstract class MySqlConnection
    {
        public readonly string connectionString;
        
        public connectionToMySql()
        {
            connectionString = "server=10.140.10.6; database=inv_hardware; Uid=consultorm10; pwd=4aRUdli6NvRIetXo; Convert Zero Datetime=True;";
        }

        protected static MySqlConnection GetConnection()
        {

        }

        String cn = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;

        public DataTable FillGrid(string fillG)
        {
            DataTable dt = new DataTable();

            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cn))
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
            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cn))
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
                using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cn))
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
                Console.WriteLine("Algo ha salido mal: \n" + error.Message);
            }
            return rCon;
        }

        public string ConsultQR(string str)
        {
            string encrypt = "";

            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cn))
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

            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cn))
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

        public List<clsColors> Get() //Se crea una clase que contendrá los datos sacados de la base de datos.
        {
            List<clsColors> RGB = new List<clsColors>();

            return RGB;
        }
    }
}
}
