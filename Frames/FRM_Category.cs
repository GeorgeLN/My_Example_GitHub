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
    public partial class FRM_Category : Form
    {
        clsConnection connection = new clsConnection();

        string option = "";
        string catUpdate = "";
        string indUpdate = "";
        int R = 0;
        int G = 0;
        int B = 0;

        #region INICIALIZAR COMPONENTES
        public FRM_Category()
        {
            InitializeComponent();
        }
        #endregion

        #region FORMULARIO CATEGORÍAS Y TIPOS
        private void FRM_Category_Load(object sender, EventArgs e)
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

            pnlContainer.BackColor = Color.FromArgb(23, 95, 228);
            btnReturn.BackColor = Color.FromArgb(23, 95, 228);

            txtCategory.Enabled = false;
            txtIndex.Enabled = false;


            string fillGrid = "SELECT nombre, indice " +
                                "FROM categorias ";
            grdCategory.DataSource = connection.FillGrid(fillGrid);

            fillGrid = "SELECT * " +
                                " FROM categorias ";
            grdAtributes.DataSource = connection.FillGrid(fillGrid);

            fillGrid = "SELECT indice, siPulgadas, siSistemaOpe, siHDD, siRAM, siProcesador, siAntivirus, siIP, siProgramas, siNombrePC, siCertificado, siPesoMax, siPesoMin, siRango " +
                            "FROM categorias ";
            grdAtributes.DataSource = connection.FillGrid(fillGrid);
        }
        #endregion

        #region AGREGAR
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            option = "ADD_C";
            pnlAttributes.Enabled = true;

            txtCategory.Enabled = true;
            txtIndex.Enabled = true;
            txtCategory.Focus();

            btnSearchCtg.Enabled = false;
            btnUpdateCtg.Enabled = false;

            #region CAMBIO DE COLOR EN LOS BOTONES.
            pnlContainer.BackColor = Color.FromArgb(23, 95, 228);

            btnAddCtg.BackColor = Color.White;
            btnAddCtg.ForeColor = Color.Black;
            btnAddCtg.IconColor = Color.Black;

            //btnUpdateCtg.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdateCtg.ForeColor = Color.White;
            btnUpdateCtg.IconColor = Color.White;

            //btnSearchCtg.BackColor = Color.FromArgb(23, 95, 228);
            btnSearchCtg.ForeColor = Color.White;
            btnSearchCtg.IconColor = Color.White;
            #endregion
        }
        #endregion+

        #region BUSCAR
        private void btnSearch_Click(object sender, EventArgs e)
        {
            option = "SEARCH_C";

            txtCategory.Enabled = true;
            txtIndex.Enabled = true;
            lblMessage.Text = "DIGITE LA CATEGORÍA O EL ÍNDICE A BUSCAR";

            #region CAMBIO DE COLOR EN LOS BOTONES.
            btnSearchCtg.BackColor = Color.White;
            btnSearchCtg.ForeColor = Color.Black;
            btnSearchCtg.IconColor = Color.Black;

            btnAddCtg.BackColor = Color.FromArgb(23, 95, 228);
            btnAddCtg.ForeColor = Color.White;
            btnAddCtg.IconColor = Color.White;

            btnUpdateCtg.BackColor = Color.FromArgb(23, 95, 228);
            btnUpdateCtg.ForeColor = Color.White;
            btnUpdateCtg.IconColor = Color.White;
            #endregion
        }
        #endregion

        #region MODIFICAR
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "")
            {
                option = "UPDATE_C";
                txtCategory.Enabled = true;

                chbInch.Enabled = true;
                chbOperativeSystem.Enabled = true;
                chbHDD.Enabled = true;
                chbRAM.Enabled = true;
                chbProcessor.Enabled = true;
                chbAntivirus.Enabled = true;
                chbIP.Enabled = true;
                chbLicencedPrograms.Enabled = true;
                chbPcName.Enabled = true;
                chbLastOneCertification.Enabled = true;
                chbMaxWeight.Enabled = true;
                chbMinWeight.Enabled = true;
                chbMeasureRange.Enabled = true;

                pnlAttributes.Enabled = true;
                /*chbInch.Enabled = true;
                chbOperativeSystem.Enabled = true;
                chbHDD.Enabled = true;
                chbRAM.Enabled = true;
                chbProcessor.Enabled = true;
                chbAntivirus.Enabled = true;
                chbIP.Enabled = true;
                chbLicencedPrograms.Enabled = true;
                chbPcName.Enabled = true;
                chbLastOneCertification.Enabled = true;
                chbMaxWeight.Enabled = true;
                chbMinWeight.Enabled = true;
                chbMeasureRange.Enabled = true;*/

                #region CAMBIO DE COLOR EN LOS BOTONES.
                btnUpdateCtg.BackColor = Color.White;
                btnUpdateCtg.ForeColor = Color.Black;
                btnUpdateCtg.IconColor = Color.Black;

                btnAddCtg.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCtg.ForeColor = Color.White;
                btnAddCtg.IconColor = Color.White;

                btnSearchCtg.BackColor = Color.FromArgb(23, 95, 228);
                btnSearchCtg.ForeColor = Color.White;
                btnSearchCtg.IconColor = Color.White;
                #endregion
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la tabla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ACEPTAR
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text;
            string index = txtIndex.Text;

            string addRegister = "";
            string addCategories = "";
            string updateRegister = "";
            string searchRegister = "";
            bool consultC = false;
            bool consultI = false;

            string consultCategory = "SELECT * FROM categorias " +
                                        "WHERE nombre ='" + category + "'";
            consultC = connection.Consult(consultCategory); //Consultar si existe la categoría.

            string consultIndex = "SELECT * FROM categorias " +
                                    "WHERE indice='" + index + "'";
            consultI = connection.Consult(consultIndex); //Consultar si existe el índice.

            try
            {
                switch (option)
                {
                    #region CASO AGREGAR CATEGORÍA
                    case "ADD_C":
                        if (consultC != true)
                        {
                            if (consultI != true)
                            {
                                if (txtIndex.Text.Length <= 3)
                                {
                                    //Continue Here
                                    addRegister = "INSERT INTO categorias(nombre, indice, siPulgadas, siSistemaOpe, siHDD, siRAM, siProcesador, siAntivirus, siIP, siProgramas, siNombrePC, siCertificado, siPesoMax, siPesoMin, siRango) " +
                                                    "VALUES('" + category + "','" + index + "', False, False, False, False, False, False, False, False, False, False, False, False, False)";
                                    connection.FillDB(addRegister);

                                    MessageBox.Show("Categoría creada", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (chbInch.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siPulgadas=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbOperativeSystem.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siSistemaOpe=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbHDD.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siHDD=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbRAM.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siRAM=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbProcessor.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siProcesador=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbAntivirus.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siAntivirus=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbIP.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siIP=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbLicencedPrograms.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siProgramas=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbPcName.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siNombrePC=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbLastOneCertification.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siCertificado=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbMaxWeight.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siPesoMax=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbMinWeight.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siPesoMin=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }

                                    if (chbMeasureRange.Checked == true)
                                    {
                                        addCategories = "UPDATE categorias SET siRango=True " +
                                                            "WHERE indice='" + index + "' ";
                                        connection.FillDB(addCategories);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Los índices para los dispositivos deben ser de 3 dígitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Índice ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Categoría ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        CleanCamps(1);
                        break;
                    #endregion

                    #region CASO ACTUALIZAR
                    case "UPDATE_C":
                        if (consultC != true)
                        {
                            string idCategory = ConsultID(catUpdate, indUpdate);

                            updateRegister = "UPDATE categorias SET  nombre='" + category + "', indice='" + index + "' " +
                                                    "WHERE idCategoria='" + idCategory + "' ";
                            connection.FillDB(updateRegister);

                            MessageBox.Show("Datos actualizados.", "PROCESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Categoría ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        CleanCamps(1);
                        break;
                    #endregion

                    #region CASO BUSCAR
                    case "SEARCH_C":
                        int sw = 0;

                        if (txtCategory.Text != "")
                        {
                            if (consultC != false)
                            {
                                searchRegister = "SELECT nombre,indice FROM categorias " +
                                                    "WHERE nombre='" + category + "'";
                                grdCategory.DataSource = connection.FillGrid(searchRegister);

                                sw = 1;
                            }
                            else
                            {
                                MessageBox.Show("La categoría no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (txtIndex.Text != "")
                            {
                                if (consultI != false && sw == 0)
                                {
                                    searchRegister = "SELECT nombre,indice FROM categorias " +
                                                        "WHERE indice='" + index + "'";
                                    grdCategory.DataSource = connection.FillGrid(searchRegister);
                                }
                                else
                                {
                                    MessageBox.Show("El índice no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        CleanCamps(1);
                        break;
                    #endregion

                    #region DEFAULT
                    default:
                        MessageBox.Show("No ha seleccionado una opción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                pnlAttributes.Enabled = false;
                txtCategory.Enabled = false;
                txtCategory.Text = "";
                txtIndex.Enabled = false;
                txtIndex.Text = "";

                btnAddCtg.Enabled = true;
                btnUpdateCtg.Enabled = true;
                btnSearchCtg.Enabled = true;

                string cleanTable = "SELECT nombre, indice FROM categorias ";
                grdCategory.DataSource = connection.FillGrid(cleanTable);

                chbInch.Checked = false;
                chbOperativeSystem.Checked = false;
                chbHDD.Checked = false;
                chbRAM.Checked = false;
                chbProcessor.Checked = false;
                chbAntivirus.Checked = false;
                chbIP.Checked = false;
                chbLicencedPrograms.Checked = false;
                chbPcName.Checked = false;
                chbLastOneCertification.Checked = false;
                chbMaxWeight.Checked = false;
                chbMinWeight.Checked = false;
                chbMeasureRange.Checked = false;

                #region CAMBIO DE COLOR EN LOS BOTÓNES
                btnAddCtg.BackColor = Color.FromArgb(23, 95, 228);
                btnAddCtg.ForeColor = Color.White;
                btnAddCtg.IconColor = Color.White;

                btnUpdateCtg.BackColor = Color.FromArgb(23, 95, 228);
                btnUpdateCtg.ForeColor = Color.White;
                btnUpdateCtg.IconColor = Color.White;

                btnSearchCtg.BackColor = Color.FromArgb(23, 95, 228);
                btnSearchCtg.ForeColor = Color.White;
                btnSearchCtg.IconColor = Color.White;
                #endregion
            }
            else
            {
                if (x == 2) //Sólo limpiar.
                {
                    txtCategory.Text = "";
                    txtIndex.Text = "";

                    btnAddCtg.Enabled = true;
                    btnUpdateCtg.Enabled = true;
                    btnSearchCtg.Enabled = true;

                    string cleanTable = "SELECT nombre, indice FROM categorias ";
                    grdCategory.DataSource = connection.FillGrid(cleanTable);
                }
            }
        }
        #endregion

        #region REGRESAR
        private void btnExit_Click(object sender, EventArgs e)
        {
            FRM_MenuCategories frmMenu = new FRM_MenuCategories();
            this.Hide();
            frmMenu.ShowDialog();
        }
        #endregion

        #region VISUALIZAR EN LOS TXT LOS DATOS DE LA TABLA
        private void grdCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCategory.Text = grdCategory.CurrentRow.Cells[0].Value.ToString();
                catUpdate = grdCategory.CurrentRow.Cells[0].Value.ToString();

                txtIndex.Text = grdCategory.CurrentRow.Cells[1].Value.ToString();
                indUpdate = grdCategory.CurrentRow.Cells[1].Value.ToString();

                chbInch.Checked = false;
                chbOperativeSystem.Checked = false;
                chbHDD.Checked = false;
                chbRAM.Checked = false;
                chbProcessor.Checked = false;
                chbAntivirus.Checked = false;
                chbIP.Checked = false;
                chbLicencedPrograms.Checked = false;
                chbPcName.Checked = false;
                chbLastOneCertification.Checked = false;
                chbMaxWeight.Checked = false;
                chbMinWeight.Checked = false;
                chbMeasureRange.Checked = false;

                for (int i = 0; i < grdAtributes.RowCount; i++) //Buscar la categoría y sus componentes.
                {
                    if (grdAtributes.Rows[i].Cells[0].Value.ToString() == txtIndex.Text)
                    {
                        MarkedBoxes(i);
                        break;
                    }
                }                
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo salió mal: \n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CONSULTAR EL "ID" DE LA CATEGORÍA
        public string ConsultID(string ctgr, string indx)
        {
            string modify = "SELECT * FROM categorias " +
                                "WHERE nombre='" + ctgr + "' AND indice='" + indx + "' ";
            grdCategory.DataSource = connection.FillGrid(modify);

            string idCat = grdCategory.CurrentRow.Cells[0].Value.ToString();

            modify = "SELECT nombre, indice FROM categorias ";
            grdCategory.DataSource = connection.FillGrid(modify);

            return idCat;
        }
        #endregion

        #region MARCADO DE CHECKBOX
        public void MarkedBoxes(int pos)
        {
            //string value = "";
            int row = pos;
            int col = 1;

            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbInch.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbOperativeSystem.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbHDD.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbRAM.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbProcessor.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbAntivirus.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbIP.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbLicencedPrograms.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbPcName.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbLastOneCertification.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbMaxWeight.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbMinWeight.Checked = true;
                col++;
            }
            else
            {
                col++;
            }


            if (grdAtributes.Rows[row].Cells[col].Value.ToString() == "True")
            {
                chbMeasureRange.Checked = true;
                col++;
            }
            else
            {
                col++;
            }
        }
        #endregion

        #region EVENTOS LABELS
        private void lblMarks_Click(object sender, EventArgs e)
        {
            if (lblMarks.Text == "Marcar todos")
            {
                lblMarks.Text = "Desmarcar todos";

                chbInch.Checked = true;
                chbOperativeSystem.Checked = true;
                chbHDD.Checked = true;
                chbRAM.Checked = true;
                chbProcessor.Checked = true;
                chbAntivirus.Checked = true;
                chbIP.Checked = true;
                chbLicencedPrograms.Checked = true;
                chbPcName.Checked = true;
                chbLastOneCertification.Checked = true;
                chbMaxWeight.Checked = true;
                chbMinWeight.Checked = true;
                chbMeasureRange.Checked = true;
            }
            else
            {
                if (lblMarks.Text == "Desmarcar todos")
                {
                    lblMarks.Text = "Marcar todos";

                    chbInch.Checked = false;
                    chbOperativeSystem.Checked = false;
                    chbHDD.Checked = false;
                    chbRAM.Checked = false;
                    chbProcessor.Checked = false;
                    chbAntivirus.Checked = false;
                    chbIP.Checked = false;
                    chbLicencedPrograms.Checked = false;
                    chbPcName.Checked = false;
                    chbLastOneCertification.Checked = false;
                    chbMaxWeight.Checked = false;
                    chbMinWeight.Checked = false;
                    chbMeasureRange.Checked = false;
                }
            }
        }

        private void lblMarks_MouseMove(object sender, MouseEventArgs e)
        {
            lblMarks.ForeColor = Color.DodgerBlue;
            lblMarks.Cursor = Cursors.Hand;
        }

        private void lblMarks_MouseLeave(object sender, EventArgs e)
        {
            lblMarks.ForeColor = Color.Black;
        }
        #endregion
    }
}