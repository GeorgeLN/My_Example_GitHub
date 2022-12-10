namespace Proyecto_InvHardware
{
    partial class FRM_Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Category));
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchCtg = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnUpdateCtg = new FontAwesome.Sharp.IconButton();
            this.btnAddCtg = new FontAwesome.Sharp.IconButton();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAttributes = new System.Windows.Forms.Panel();
            this.chbMeasureRange = new System.Windows.Forms.CheckBox();
            this.chbMinWeight = new System.Windows.Forms.CheckBox();
            this.chbMaxWeight = new System.Windows.Forms.CheckBox();
            this.chbLastOneCertification = new System.Windows.Forms.CheckBox();
            this.chbPcName = new System.Windows.Forms.CheckBox();
            this.chbLicencedPrograms = new System.Windows.Forms.CheckBox();
            this.chbIP = new System.Windows.Forms.CheckBox();
            this.chbAntivirus = new System.Windows.Forms.CheckBox();
            this.chbProcessor = new System.Windows.Forms.CheckBox();
            this.chbRAM = new System.Windows.Forms.CheckBox();
            this.chbHDD = new System.Windows.Forms.CheckBox();
            this.chbOperativeSystem = new System.Windows.Forms.CheckBox();
            this.chbInch = new System.Windows.Forms.CheckBox();
            this.grdAtributes = new System.Windows.Forms.DataGridView();
            this.lblMarks = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.pnlAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtributes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(2, 71);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(454, 18);
            this.lblMessage.TabIndex = 70;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "Índice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 64;
            this.label5.Text = "Categoría";
            // 
            // txtCategory
            // 
            this.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategory.Location = new System.Drawing.Point(68, 101);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(201, 20);
            this.txtCategory.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "CONFIGURAR CATEGORÍAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchCtg
            // 
            this.btnSearchCtg.FlatAppearance.BorderSize = 0;
            this.btnSearchCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCtg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCtg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchCtg.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCtg.IconColor = System.Drawing.Color.White;
            this.btnSearchCtg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCtg.IconSize = 35;
            this.btnSearchCtg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCtg.Location = new System.Drawing.Point(257, 28);
            this.btnSearchCtg.Name = "btnSearchCtg";
            this.btnSearchCtg.Padding = new System.Windows.Forms.Padding(12, 0, 0, 5);
            this.btnSearchCtg.Size = new System.Drawing.Size(120, 38);
            this.btnSearchCtg.TabIndex = 51;
            this.btnSearchCtg.Text = "Buscar";
            this.btnSearchCtg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCtg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCtg.UseVisualStyleBackColor = true;
            this.btnSearchCtg.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 30;
            this.btnReturn.Location = new System.Drawing.Point(523, 330);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReturn.Size = new System.Drawing.Size(108, 35);
            this.btnReturn.TabIndex = 50;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateCtg
            // 
            this.btnUpdateCtg.FlatAppearance.BorderSize = 0;
            this.btnUpdateCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCtg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCtg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCtg.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdateCtg.IconColor = System.Drawing.Color.White;
            this.btnUpdateCtg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateCtg.IconSize = 35;
            this.btnUpdateCtg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCtg.Location = new System.Drawing.Point(131, 28);
            this.btnUpdateCtg.Name = "btnUpdateCtg";
            this.btnUpdateCtg.Padding = new System.Windows.Forms.Padding(7, 0, 0, 5);
            this.btnUpdateCtg.Size = new System.Drawing.Size(120, 38);
            this.btnUpdateCtg.TabIndex = 47;
            this.btnUpdateCtg.Text = "Modificar";
            this.btnUpdateCtg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCtg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateCtg.UseVisualStyleBackColor = true;
            this.btnUpdateCtg.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddCtg
            // 
            this.btnAddCtg.FlatAppearance.BorderSize = 0;
            this.btnAddCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCtg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCtg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCtg.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddCtg.IconColor = System.Drawing.Color.White;
            this.btnAddCtg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCtg.IconSize = 35;
            this.btnAddCtg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCtg.Location = new System.Drawing.Point(5, 28);
            this.btnAddCtg.Name = "btnAddCtg";
            this.btnAddCtg.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAddCtg.Size = new System.Drawing.Size(120, 38);
            this.btnAddCtg.TabIndex = 45;
            this.btnAddCtg.Text = "Nueva Categoría";
            this.btnAddCtg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCtg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCtg.UseVisualStyleBackColor = true;
            this.btnAddCtg.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndex.Location = new System.Drawing.Point(68, 139);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(40, 20);
            this.txtIndex.TabIndex = 75;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnCheck);
            this.pnlContainer.Controls.Add(this.btnSearchCtg);
            this.pnlContainer.Controls.Add(this.btnUpdateCtg);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.btnAddCtg);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(634, 68);
            this.pnlContainer.TabIndex = 77;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 35;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(509, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnCheck.IconColor = System.Drawing.Color.White;
            this.btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheck.IconSize = 35;
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(383, 28);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.btnCheck.Size = new System.Drawing.Size(120, 38);
            this.btnCheck.TabIndex = 62;
            this.btnCheck.Text = "Aceptar";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grdCategory
            // 
            this.grdCategory.AllowUserToAddRows = false;
            this.grdCategory.AllowUserToDeleteRows = false;
            this.grdCategory.AllowUserToResizeColumns = false;
            this.grdCategory.AllowUserToResizeRows = false;
            this.grdCategory.BackgroundColor = System.Drawing.Color.White;
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.indice});
            this.grdCategory.Location = new System.Drawing.Point(454, 71);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.ReadOnly = true;
            this.grdCategory.RowHeadersVisible = false;
            this.grdCategory.Size = new System.Drawing.Size(175, 253);
            this.grdCategory.TabIndex = 41;
            this.grdCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategory_CellClick);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Categoría";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
            // 
            // indice
            // 
            this.indice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.indice.DataPropertyName = "indice";
            this.indice.HeaderText = "Indice";
            this.indice.Name = "indice";
            this.indice.ReadOnly = true;
            this.indice.Width = 61;
            // 
            // pnlAttributes
            // 
            this.pnlAttributes.Controls.Add(this.lblMarks);
            this.pnlAttributes.Controls.Add(this.chbMeasureRange);
            this.pnlAttributes.Controls.Add(this.chbMinWeight);
            this.pnlAttributes.Controls.Add(this.chbMaxWeight);
            this.pnlAttributes.Controls.Add(this.chbLastOneCertification);
            this.pnlAttributes.Controls.Add(this.chbPcName);
            this.pnlAttributes.Controls.Add(this.chbLicencedPrograms);
            this.pnlAttributes.Controls.Add(this.chbIP);
            this.pnlAttributes.Controls.Add(this.chbAntivirus);
            this.pnlAttributes.Controls.Add(this.chbProcessor);
            this.pnlAttributes.Controls.Add(this.chbRAM);
            this.pnlAttributes.Controls.Add(this.chbHDD);
            this.pnlAttributes.Controls.Add(this.chbOperativeSystem);
            this.pnlAttributes.Controls.Add(this.chbInch);
            this.pnlAttributes.Enabled = false;
            this.pnlAttributes.Location = new System.Drawing.Point(5, 174);
            this.pnlAttributes.Name = "pnlAttributes";
            this.pnlAttributes.Size = new System.Drawing.Size(443, 150);
            this.pnlAttributes.TabIndex = 78;
            // 
            // chbMeasureRange
            // 
            this.chbMeasureRange.AutoSize = true;
            this.chbMeasureRange.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMeasureRange.Location = new System.Drawing.Point(332, 9);
            this.chbMeasureRange.Name = "chbMeasureRange";
            this.chbMeasureRange.Size = new System.Drawing.Size(102, 18);
            this.chbMeasureRange.TabIndex = 12;
            this.chbMeasureRange.Text = "Rango Medición";
            this.chbMeasureRange.UseVisualStyleBackColor = true;
            // 
            // chbMinWeight
            // 
            this.chbMinWeight.AutoSize = true;
            this.chbMinWeight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMinWeight.Location = new System.Drawing.Point(149, 124);
            this.chbMinWeight.Name = "chbMinWeight";
            this.chbMinWeight.Size = new System.Drawing.Size(85, 18);
            this.chbMinWeight.TabIndex = 11;
            this.chbMinWeight.Text = "Peso Mínimo";
            this.chbMinWeight.UseVisualStyleBackColor = true;
            // 
            // chbMaxWeight
            // 
            this.chbMaxWeight.AutoSize = true;
            this.chbMaxWeight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMaxWeight.Location = new System.Drawing.Point(149, 101);
            this.chbMaxWeight.Name = "chbMaxWeight";
            this.chbMaxWeight.Size = new System.Drawing.Size(89, 18);
            this.chbMaxWeight.TabIndex = 10;
            this.chbMaxWeight.Text = "Peso Máximo";
            this.chbMaxWeight.UseVisualStyleBackColor = true;
            // 
            // chbLastOneCertification
            // 
            this.chbLastOneCertification.AutoSize = true;
            this.chbLastOneCertification.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLastOneCertification.Location = new System.Drawing.Point(149, 78);
            this.chbLastOneCertification.Name = "chbLastOneCertification";
            this.chbLastOneCertification.Size = new System.Drawing.Size(109, 18);
            this.chbLastOneCertification.TabIndex = 9;
            this.chbLastOneCertification.Text = "Último Certificado";
            this.chbLastOneCertification.UseVisualStyleBackColor = true;
            // 
            // chbPcName
            // 
            this.chbPcName.AutoSize = true;
            this.chbPcName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPcName.Location = new System.Drawing.Point(149, 55);
            this.chbPcName.Name = "chbPcName";
            this.chbPcName.Size = new System.Drawing.Size(79, 18);
            this.chbPcName.TabIndex = 8;
            this.chbPcName.Text = "Nombre PC";
            this.chbPcName.UseVisualStyleBackColor = true;
            // 
            // chbLicencedPrograms
            // 
            this.chbLicencedPrograms.AutoSize = true;
            this.chbLicencedPrograms.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLicencedPrograms.Location = new System.Drawing.Point(149, 32);
            this.chbLicencedPrograms.Name = "chbLicencedPrograms";
            this.chbLicencedPrograms.Size = new System.Drawing.Size(139, 18);
            this.chbLicencedPrograms.TabIndex = 7;
            this.chbLicencedPrograms.Text = "Programas Licenciados";
            this.chbLicencedPrograms.UseVisualStyleBackColor = true;
            // 
            // chbIP
            // 
            this.chbIP.AutoSize = true;
            this.chbIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIP.Location = new System.Drawing.Point(149, 9);
            this.chbIP.Name = "chbIP";
            this.chbIP.Size = new System.Drawing.Size(82, 18);
            this.chbIP.TabIndex = 6;
            this.chbIP.Text = "Dirección IP";
            this.chbIP.UseVisualStyleBackColor = true;
            // 
            // chbAntivirus
            // 
            this.chbAntivirus.AutoSize = true;
            this.chbAntivirus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAntivirus.Location = new System.Drawing.Point(6, 124);
            this.chbAntivirus.Name = "chbAntivirus";
            this.chbAntivirus.Size = new System.Drawing.Size(69, 18);
            this.chbAntivirus.TabIndex = 5;
            this.chbAntivirus.Text = "Antivirus";
            this.chbAntivirus.UseVisualStyleBackColor = true;
            // 
            // chbProcessor
            // 
            this.chbProcessor.AutoSize = true;
            this.chbProcessor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbProcessor.Location = new System.Drawing.Point(6, 101);
            this.chbProcessor.Name = "chbProcessor";
            this.chbProcessor.Size = new System.Drawing.Size(82, 18);
            this.chbProcessor.TabIndex = 4;
            this.chbProcessor.Text = "Procesador";
            this.chbProcessor.UseVisualStyleBackColor = true;
            // 
            // chbRAM
            // 
            this.chbRAM.AutoSize = true;
            this.chbRAM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRAM.Location = new System.Drawing.Point(6, 78);
            this.chbRAM.Name = "chbRAM";
            this.chbRAM.Size = new System.Drawing.Size(92, 18);
            this.chbRAM.TabIndex = 3;
            this.chbRAM.Text = "Memoria RAM";
            this.chbRAM.UseVisualStyleBackColor = true;
            // 
            // chbHDD
            // 
            this.chbHDD.AutoSize = true;
            this.chbHDD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHDD.Location = new System.Drawing.Point(6, 55);
            this.chbHDD.Name = "chbHDD";
            this.chbHDD.Size = new System.Drawing.Size(79, 18);
            this.chbHDD.TabIndex = 2;
            this.chbHDD.Text = "Disco Duro";
            this.chbHDD.UseVisualStyleBackColor = true;
            // 
            // chbOperativeSystem
            // 
            this.chbOperativeSystem.AutoSize = true;
            this.chbOperativeSystem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOperativeSystem.Location = new System.Drawing.Point(6, 32);
            this.chbOperativeSystem.Name = "chbOperativeSystem";
            this.chbOperativeSystem.Size = new System.Drawing.Size(114, 18);
            this.chbOperativeSystem.TabIndex = 1;
            this.chbOperativeSystem.Text = "Sistema Operativo";
            this.chbOperativeSystem.UseVisualStyleBackColor = true;
            // 
            // chbInch
            // 
            this.chbInch.AutoSize = true;
            this.chbInch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbInch.Location = new System.Drawing.Point(6, 9);
            this.chbInch.Name = "chbInch";
            this.chbInch.Size = new System.Drawing.Size(70, 18);
            this.chbInch.TabIndex = 0;
            this.chbInch.Text = "Pulgadas";
            this.chbInch.UseVisualStyleBackColor = true;
            // 
            // grdAtributes
            // 
            this.grdAtributes.AllowUserToAddRows = false;
            this.grdAtributes.AllowUserToDeleteRows = false;
            this.grdAtributes.AllowUserToResizeColumns = false;
            this.grdAtributes.AllowUserToResizeRows = false;
            this.grdAtributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAtributes.Location = new System.Drawing.Point(5, 384);
            this.grdAtributes.Name = "grdAtributes";
            this.grdAtributes.ReadOnly = true;
            this.grdAtributes.RowHeadersVisible = false;
            this.grdAtributes.Size = new System.Drawing.Size(626, 23);
            this.grdAtributes.TabIndex = 79;
            // 
            // lblMarks
            // 
            this.lblMarks.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(337, 130);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(102, 16);
            this.lblMarks.TabIndex = 14;
            this.lblMarks.Text = "Marcar todos";
            this.lblMarks.Click += new System.EventHandler(this.lblMarks_Click);
            this.lblMarks.MouseLeave += new System.EventHandler(this.lblMarks_MouseLeave);
            this.lblMarks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMarks_MouseMove);
            // 
            // FRM_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 368);
            this.ControlBox = false;
            this.Controls.Add(this.grdAtributes);
            this.Controls.Add(this.pnlAttributes);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORÍAS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_Category_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.pnlAttributes.ResumeLayout(false);
            this.pnlAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtributes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnUpdateCtg;
        private FontAwesome.Sharp.IconButton btnAddCtg;
        private FontAwesome.Sharp.IconButton btnSearchCtg;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnCheck;
        private System.Windows.Forms.Panel pnlAttributes;
        private System.Windows.Forms.CheckBox chbMeasureRange;
        private System.Windows.Forms.CheckBox chbMinWeight;
        private System.Windows.Forms.CheckBox chbMaxWeight;
        private System.Windows.Forms.CheckBox chbLastOneCertification;
        private System.Windows.Forms.CheckBox chbPcName;
        private System.Windows.Forms.CheckBox chbLicencedPrograms;
        private System.Windows.Forms.CheckBox chbIP;
        private System.Windows.Forms.CheckBox chbAntivirus;
        private System.Windows.Forms.CheckBox chbProcessor;
        private System.Windows.Forms.CheckBox chbRAM;
        private System.Windows.Forms.CheckBox chbHDD;
        private System.Windows.Forms.CheckBox chbOperativeSystem;
        private System.Windows.Forms.CheckBox chbInch;
        private System.Windows.Forms.DataGridView grdAtributes;
        private System.Windows.Forms.Label lblMarks;
    }
}