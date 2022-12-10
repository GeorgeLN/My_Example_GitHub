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
    public partial class FRM_Types : Form
    {
        clsConnection connection = new clsConnection();

        string option = "";
        string typeUpdate = "";
        string indUpdate = "";
        int R = 0;
        int G = 0;
        int B = 0;

        #region INICIALIZAR COMPONENTES
        public FRM_Types()
        {
            InitializeComponent();
        }
        #endregion

        #region FORMULARIO "TIPOS DE CATEGORÍAS"
        private void FRM_Types_Load(object sender, EventArgs e)
        {
            txtIndex.Enabled = false;
            txtType.Enabled = false;

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

            pnlContainer.BackColor = Color.FromArgb(23, 95, 228);
            btnReturn.BackColor = Color.FromArgb(23, 95, 228);

            string fillGrid = "SELECT tipo, indicio " +
                                "FROM tipos ";
            grdTypes.DataSource = connection.FillGrid(fillGrid);
        }
        #endregion

        #region AGREGAR
        private void btnAddType_Click(object sender, EventArgs e)
        {
            option = "ADD_T";

            txtIndex.Enabled = true;
            txtType.Enabled = true;
            txtIndex.Focus();

            btnUpdateType.Enabled = false;
            btnSearchType.Enabled = false;

            #region CAMBIO DE COLOR EN LOS BOTONES
            pnlContainer.BackColor = Color.FromArgb(23, 95, 228);

            btnAddType.BackColor = Color.White;
            btnAddType.ForeColor = Color.Black;
            btnAddType.IconColor = Color.Black;

            btnUpdateType.ForeColor = Color.White;
            btnUpdateType.IconColor = Color.White;

            btnSearchType.ForeColor = Color.White;
            btnSearchType.IconColor = Color.White;
            #endregion
        }
        #endregion

        #region MODIFICAR
        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (txtIndex.Text != "")
            {
                option = "UPDATE_T";

                txtType.Enabled = false;

                #region CAMBIO DE COLOR EN LOS BOTONES
                pnlContainer.BackColor = Color.FromArgb(23, 95, 228);

                btnUpdateType.BackColor = Color.White;
                btnUpdateType.ForeColor = Color.Black;
                btnUpdateType.IconColor = Color.Black;

                btnAddType.ForeColor = Color.White;
                btnAddType.IconColor = Color.White;

                btnSearchType.ForeColor = Color.White;
                btnSearchType.IconColor = Color.White;
                #endregion
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la tabla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BUSCAR
        private void btnSearchType_Click(object sender, EventArgs e)
        {
            option = "SEARCH_T";

            txtIndex.Enabled = true;
            txtType.Enabled = false;

            lblMessage.Text = "DIGITE EL ÍNDICE DE LA CATEGORÍA A BUSCAR";

            #region CAMBIO DE COLOR EN LOS BOTONES
            pnlContainer.BackColor = Color.FromArgb(23, 95, 228);

            btnSearchType.BackColor = Color.White;
            btnSearchType.ForeColor = Color.Black;
            btnSearchType.IconColor = Color.Black;

            btnUpdateType.ForeColor = Color.White;
            btnUpdateType.IconColor = Color.White;

            btnAddType.ForeColor = Color.White;
            btnAddType.IconColor = Color.White;
            #endregion
        }
        #endregion

        #region ACEPTAR
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string index = txtIndex.Text;
            string type = txtType.Text;

            string addRegister = "";
            string updateRegister = "";
            string searchRegister = "";
            bool consultI = false;
            bool consultT = false;

            string consultIndex = "SELECT * FROM categorias " +
                                    "WHERE indice='" + index + "' ";
            consultI = connection.Consult(consultIndex); //Consultar si existe el Índice de la categoría.

            string consultType = "SELECT * FROM tipos " +
                                    "WHERE tipo='" + type + "' ";
            consultT = connection.Consult(consultType); //Consultar si existe el Tipo de categoría.

            try
            {
                switch (option)
                {
                    #region CASO "AGREGAR NUEVO TIPO DE CATEGORÍA"
                    case "ADD_T":
                        if (consultI == true)
                        {
                            if (consultT != true)
                            {
                                addRegister = "INSERT INTO tipos(tipo, indicio) " +
                                                "VALUES('" + type + "','" + index + "') ";
                                connection.FillDB(addRegister);

                                MessageBox.Show("Tipo de categoría creado.", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CleanCamps(1);
                            }
                            else
                            {
                                MessageBox.Show("'" + type + "', Ya existe como tipo de categoría.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Índice no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                        break;
                    #endregion

                    #region CASO "ACTUALIZAR TIPO DE CATEGORÍA"
                    case "UPDATE_T":
                        if (consultI != true)
                        {
                            string idType = ConsultID(typeUpdate, indUpdate);

                            updateRegister = "UPDATE tipos SET tipo='" + type + "', indicio='" + index + "' " +
                                                "WHERE id_tipo='" + idType + "' ";
                            connection.FillDB(updateRegister);

                            MessageBox.Show("Datos actualizados.", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CleanCamps(1);
                        }
                        else
                        {
                            MessageBox.Show("Índice de categoría no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    #endregion

                    #region CASO "BUSCAR TIPO DE CATEGORÍA"
                    case "SEARCH_T":
                        if (txtIndex.Text != "")
                        {
                            if (consultI != false)
                            {
                                searchRegister = "SELECT tipo, indicio FROM tipos " +
                                                    "WHERE indicio='" + index + "' ";
                                grdTypes.DataSource = connection.FillGrid(searchRegister);
                            }
                            else
                            {
                                MessageBox.Show("Índice no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un Índice para buscar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    #endregion

                    #region DEFAULT
                    default:
                        MessageBox.Show("Seleccione una opción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    #endregion
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CANCELAR/LIMPIAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanCamps(1);
        }

        public void CleanCamps(int x)
        {
            option = "";

            if (x == 1) //Limpiar e inhabilitar.
            {
                txtType.Enabled = false;
                txtType.Text = "";
                txtIndex.Enabled = false;
                txtIndex.Text = "";

                btnAddType.Enabled = true;
                btnUpdateType.Enabled = true;
                btnSearchType.Enabled = true;

                string cleanTable = "SELECT tipo, indicio FROM tipos ";
                grdTypes.DataSource = connection.FillGrid(cleanTable);

                #region CAMBIO DE COLOR EN LOS BOTÓNES
                btnAddType.BackColor = Color.FromArgb(23, 95, 228);
                btnAddType.ForeColor = Color.White;
                btnAddType.IconColor = Color.White;

                btnUpdateType.BackColor = Color.FromArgb(23, 95, 228);
                btnUpdateType.ForeColor = Color.White;
                btnUpdateType.IconColor = Color.White;

                btnSearchType.BackColor = Color.FromArgb(23, 95, 228);
                btnSearchType.ForeColor = Color.White;
                btnSearchType.IconColor = Color.White;
                #endregion
            }
            else
            {
                if (x == 2) //Sólo limpiar.
                {
                    txtType.Text = "";
                    txtIndex.Text = "";

                    btnAddType.Enabled = true;
                    btnUpdateType.Enabled = true;
                    btnSearchType.Enabled = true;

                    string cleanTable = "SELECT tipo, indicio FROM tipos ";
                    grdTypes.DataSource = connection.FillGrid(cleanTable);
                }
            }
        }
        #endregion

        #region REGRESAR
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FRM_MenuCategories frmMenu = new FRM_MenuCategories();

            this.Hide();
            frmMenu.ShowDialog();
        }
        #endregion

        #region VISUALIZAR EN LOS TXT LOS DATOS DE LA TABLA
        private void grdTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIndex.Text = grdTypes.CurrentRow.Cells[1].Value.ToString();
                txtType.Text = grdTypes.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CONSULTAR EL "ID" DE LA CATEGORÍA
        public string ConsultID(string type, string indx)
        {
            string modify = "SELECT * tipos " +
                                "WHERE tipo='" + type + "' AND indicio='" + indx + "' ";
            grdTypes.DataSource = connection.FillGrid(modify);

            string idCat = grdTypes.CurrentRow.Cells[0].Value.ToString();

            modify = "SELECT tipo, indicio FROM tipos ";
            grdTypes.DataSource = connection.FillGrid(modify);
            
            return idCat;
        }
        #endregion
    }
}
