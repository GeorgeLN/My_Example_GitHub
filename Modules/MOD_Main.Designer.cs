namespace Proyecto_InvHardware
{
    partial class MOD_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOD_Main));
            this.gbxContainer = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSearchDevice = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.btnAssing = new FontAwesome.Sharp.IconButton();
            this.btnAccess = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnRepare = new FontAwesome.Sharp.IconButton();
            this.btnTransfer = new FontAwesome.Sharp.IconButton();
            this.btnLow = new FontAwesome.Sharp.IconButton();
            this.btnIngress = new FontAwesome.Sharp.IconButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnMinimizeBox = new FontAwesome.Sharp.IconButton();
            this.btnMaximizeBox = new FontAwesome.Sharp.IconButton();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxContainer
            // 
            this.gbxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.gbxContainer.Controls.Add(this.lblUser);
            this.gbxContainer.Controls.Add(this.iconPictureBox1);
            this.gbxContainer.Controls.Add(this.btnSearchDevice);
            this.gbxContainer.Controls.Add(this.label13);
            this.gbxContainer.Controls.Add(this.lblUp);
            this.gbxContainer.Controls.Add(this.lblLeft);
            this.gbxContainer.Controls.Add(this.btnAssing);
            this.gbxContainer.Controls.Add(this.btnAccess);
            this.gbxContainer.Controls.Add(this.btnExit);
            this.gbxContainer.Controls.Add(this.btnRepare);
            this.gbxContainer.Controls.Add(this.btnTransfer);
            this.gbxContainer.Controls.Add(this.btnLow);
            this.gbxContainer.Controls.Add(this.btnIngress);
            this.gbxContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxContainer.Location = new System.Drawing.Point(0, 0);
            this.gbxContainer.Name = "gbxContainer";
            this.gbxContainer.Size = new System.Drawing.Size(184, 728);
            this.gbxContainer.TabIndex = 38;
            this.gbxContainer.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1, 106);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(183, 21);
            this.lblUser.TabIndex = 57;
            this.lblUser.Text = " ";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 108;
            this.iconPictureBox1.ImageLocation = "";
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(108, 108);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.FlatAppearance.BorderSize = 0;
            this.btnSearchDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDevice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchDevice.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnSearchDevice.IconColor = System.Drawing.Color.White;
            this.btnSearchDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchDevice.IconSize = 40;
            this.btnSearchDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDevice.Location = new System.Drawing.Point(1, 456);
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchDevice.Size = new System.Drawing.Size(182, 45);
            this.btnSearchDevice.TabIndex = 148;
            this.btnSearchDevice.Text = "Localizar Dispositivo";
            this.btnSearchDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchDevice.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(183, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 9);
            this.label13.TabIndex = 147;
            // 
            // lblUp
            // 
            this.lblUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.lblUp.Location = new System.Drawing.Point(1, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(182, 7);
            this.lblUp.TabIndex = 146;
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.lblLeft.Location = new System.Drawing.Point(0, 2);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(1, 784);
            this.lblLeft.TabIndex = 64;
            // 
            // btnAssing
            // 
            this.btnAssing.FlatAppearance.BorderSize = 0;
            this.btnAssing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssing.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssing.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssing.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.btnAssing.IconColor = System.Drawing.Color.White;
            this.btnAssing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssing.IconSize = 40;
            this.btnAssing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssing.Location = new System.Drawing.Point(1, 228);
            this.btnAssing.Name = "btnAssing";
            this.btnAssing.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAssing.Size = new System.Drawing.Size(182, 45);
            this.btnAssing.TabIndex = 58;
            this.btnAssing.Text = "Asignaciones";
            this.btnAssing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssing.UseVisualStyleBackColor = true;
            this.btnAssing.Click += new System.EventHandler(this.btnAssing_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccess.FlatAppearance.BorderSize = 0;
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccess.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnAccess.IconColor = System.Drawing.Color.White;
            this.btnAccess.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccess.IconSize = 40;
            this.btnAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess.Location = new System.Drawing.Point(1, 514);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAccess.Size = new System.Drawing.Size(182, 45);
            this.btnAccess.TabIndex = 53;
            this.btnAccess.Text = "Gestión de Accesos";
            this.btnAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccess.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1, 682);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnExit.Size = new System.Drawing.Size(182, 45);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "SALIR";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnExit_KeyDown);
            // 
            // btnRepare
            // 
            this.btnRepare.FlatAppearance.BorderSize = 0;
            this.btnRepare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepare.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRepare.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnRepare.IconColor = System.Drawing.Color.White;
            this.btnRepare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRepare.IconSize = 40;
            this.btnRepare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepare.Location = new System.Drawing.Point(1, 285);
            this.btnRepare.Name = "btnRepare";
            this.btnRepare.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRepare.Size = new System.Drawing.Size(182, 45);
            this.btnRepare.TabIndex = 49;
            this.btnRepare.Text = "Reparaciones";
            this.btnRepare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepare.UseVisualStyleBackColor = true;
            this.btnRepare.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransfer.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnTransfer.IconColor = System.Drawing.Color.White;
            this.btnTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransfer.IconSize = 40;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(1, 342);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(182, 45);
            this.btnTransfer.TabIndex = 47;
            this.btnTransfer.Text = "Traslados";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLow
            // 
            this.btnLow.FlatAppearance.BorderSize = 0;
            this.btnLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLow.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLow.IconColor = System.Drawing.Color.White;
            this.btnLow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLow.IconSize = 40;
            this.btnLow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLow.Location = new System.Drawing.Point(1, 399);
            this.btnLow.Name = "btnLow";
            this.btnLow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLow.Size = new System.Drawing.Size(182, 45);
            this.btnLow.TabIndex = 46;
            this.btnLow.Text = "Bajas";
            this.btnLow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // btnIngress
            // 
            this.btnIngress.FlatAppearance.BorderSize = 0;
            this.btnIngress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngress.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngress.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnIngress.IconColor = System.Drawing.Color.White;
            this.btnIngress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngress.IconSize = 40;
            this.btnIngress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngress.Location = new System.Drawing.Point(1, 171);
            this.btnIngress.Name = "btnIngress";
            this.btnIngress.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIngress.Size = new System.Drawing.Size(182, 45);
            this.btnIngress.TabIndex = 45;
            this.btnIngress.Text = "Ingresos";
            this.btnIngress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngress.UseVisualStyleBackColor = true;
            this.btnIngress.Click += new System.EventHandler(this.btnIngress_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.lblDate);
            this.pnlContainer.Controls.Add(this.lblClock);
            this.pnlContainer.Location = new System.Drawing.Point(190, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1120, 704);
            this.pnlContainer.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 143);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÓDULO DE ACTIVOS FIJOS Y PERISFERICOS";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(832, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(265, 43);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClock.Location = new System.Drawing.Point(759, 12);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(349, 101);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "lblClock";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 40;
            this.btnReturn.Location = new System.Drawing.Point(1316, 114);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(45, 45);
            this.btnReturn.TabIndex = 145;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMinimizeBox
            // 
            this.btnMinimizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnMinimizeBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeBox.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimizeBox.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizeBox.IconColor = System.Drawing.Color.White;
            this.btnMinimizeBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizeBox.IconSize = 40;
            this.btnMinimizeBox.Location = new System.Drawing.Point(1316, 12);
            this.btnMinimizeBox.Name = "btnMinimizeBox";
            this.btnMinimizeBox.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMinimizeBox.Size = new System.Drawing.Size(45, 45);
            this.btnMinimizeBox.TabIndex = 146;
            this.btnMinimizeBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizeBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MyToolTip.SetToolTip(this.btnMinimizeBox, "Minimizar");
            this.btnMinimizeBox.UseVisualStyleBackColor = false;
            this.btnMinimizeBox.Click += new System.EventHandler(this.btnMinimizeBox_Click);
            // 
            // btnMaximizeBox
            // 
            this.btnMaximizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnMaximizeBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaximizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeBox.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMaximizeBox.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizeBox.IconColor = System.Drawing.Color.White;
            this.btnMaximizeBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizeBox.IconSize = 40;
            this.btnMaximizeBox.Location = new System.Drawing.Point(1316, 63);
            this.btnMaximizeBox.Name = "btnMaximizeBox";
            this.btnMaximizeBox.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMaximizeBox.Size = new System.Drawing.Size(45, 45);
            this.btnMaximizeBox.TabIndex = 147;
            this.btnMaximizeBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximizeBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MyToolTip.SetToolTip(this.btnMaximizeBox, "Minimizar/Maximizar, tamaño");
            this.btnMaximizeBox.UseVisualStyleBackColor = false;
            this.btnMaximizeBox.Click += new System.EventHandler(this.btnMaximizeBox_Click);
            // 
            // MOD_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.ControlBox = false;
            this.Controls.Add(this.btnMaximizeBox);
            this.Controls.Add(this.btnMinimizeBox);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.gbxContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MOD_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIXINVENMER";
            this.Load += new System.EventHandler(this.MOD_Main_Load);
            this.gbxContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxContainer;
        public System.Windows.Forms.Label lblUser; //Public
        private FontAwesome.Sharp.IconButton btnAccess;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnRepare;
        private FontAwesome.Sharp.IconButton btnTransfer;
        private FontAwesome.Sharp.IconButton btnLow;
        private FontAwesome.Sharp.IconButton btnIngress;
        private FontAwesome.Sharp.IconButton btnAssing;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer tmrTime;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUp;
        private FontAwesome.Sharp.IconButton btnSearchDevice;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimizeBox;
        private FontAwesome.Sharp.IconButton btnMaximizeBox;
        private System.Windows.Forms.ToolTip MyToolTip;
    }
}

