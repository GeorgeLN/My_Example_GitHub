namespace Proyecto_InvHardware
{
    partial class FRM_Types
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Types));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.btnSearchType = new FontAwesome.Sharp.IconButton();
            this.btnUpdateType = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddType = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.grdTypes = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnCheck);
            this.pnlContainer.Controls.Add(this.btnSearchType);
            this.pnlContainer.Controls.Add(this.btnUpdateType);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.btnAddType);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(634, 68);
            this.pnlContainer.TabIndex = 85;
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
            // btnSearchType
            // 
            this.btnSearchType.FlatAppearance.BorderSize = 0;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchType.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchType.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchType.IconColor = System.Drawing.Color.White;
            this.btnSearchType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchType.IconSize = 35;
            this.btnSearchType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchType.Location = new System.Drawing.Point(257, 28);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 5);
            this.btnSearchType.Size = new System.Drawing.Size(120, 38);
            this.btnSearchType.TabIndex = 51;
            this.btnSearchType.Text = "Buscar";
            this.btnSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchType.UseVisualStyleBackColor = true;
            this.btnSearchType.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // btnUpdateType
            // 
            this.btnUpdateType.FlatAppearance.BorderSize = 0;
            this.btnUpdateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateType.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateType.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdateType.IconColor = System.Drawing.Color.White;
            this.btnUpdateType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateType.IconSize = 35;
            this.btnUpdateType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateType.Location = new System.Drawing.Point(131, 28);
            this.btnUpdateType.Name = "btnUpdateType";
            this.btnUpdateType.Padding = new System.Windows.Forms.Padding(7, 0, 0, 5);
            this.btnUpdateType.Size = new System.Drawing.Size(120, 38);
            this.btnUpdateType.TabIndex = 47;
            this.btnUpdateType.Text = "Modificar";
            this.btnUpdateType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateType.UseVisualStyleBackColor = true;
            this.btnUpdateType.Click += new System.EventHandler(this.btnUpdateType_Click);
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
            this.label1.Text = "CONFIGURAR CATEGORÍAS (TIPOS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddType
            // 
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddType.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddType.IconColor = System.Drawing.Color.White;
            this.btnAddType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddType.IconSize = 35;
            this.btnAddType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddType.Location = new System.Drawing.Point(5, 28);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAddType.Size = new System.Drawing.Size(120, 38);
            this.btnAddType.TabIndex = 45;
            this.btnAddType.Text = "Nuevo Tipo";
            this.btnAddType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
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
            this.btnReturn.Location = new System.Drawing.Point(521, 282);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReturn.Size = new System.Drawing.Size(108, 35);
            this.btnReturn.TabIndex = 79;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdTypes
            // 
            this.grdTypes.AllowUserToAddRows = false;
            this.grdTypes.AllowUserToDeleteRows = false;
            this.grdTypes.AllowUserToResizeColumns = false;
            this.grdTypes.AllowUserToResizeRows = false;
            this.grdTypes.BackgroundColor = System.Drawing.Color.White;
            this.grdTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.indice});
            this.grdTypes.Location = new System.Drawing.Point(409, 76);
            this.grdTypes.Name = "grdTypes";
            this.grdTypes.ReadOnly = true;
            this.grdTypes.RowHeadersVisible = false;
            this.grdTypes.Size = new System.Drawing.Size(219, 200);
            this.grdTypes.TabIndex = 78;
            this.grdTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTypes_CellContentClick);
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.FillWeight = 200F;
            this.Tipo.HeaderText = "Categoría (Tipo)";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // indice
            // 
            this.indice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.indice.DataPropertyName = "indicio";
            this.indice.HeaderText = "Indice";
            this.indice.Name = "indice";
            this.indice.ReadOnly = true;
            this.indice.Width = 61;
            // 
            // txtIndex
            // 
            this.txtIndex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndex.Location = new System.Drawing.Point(121, 134);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(40, 20);
            this.txtIndex.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 82;
            this.label4.Text = "Índice";
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(22, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(337, 18);
            this.lblMessage.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 81;
            this.label5.Text = "Nuevo tipo";
            // 
            // txtType
            // 
            this.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtType.Location = new System.Drawing.Point(121, 175);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(201, 20);
            this.txtType.TabIndex = 80;
            // 
            // FRM_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 321);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grdTypes);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Types";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIPOS CATEGORÍAS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_Types_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnCheck;
        private FontAwesome.Sharp.IconButton btnSearchType;
        private FontAwesome.Sharp.IconButton btnUpdateType;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAddType;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.DataGridView grdTypes;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn indice;
    }
}