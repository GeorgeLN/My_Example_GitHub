
namespace Proyecto_InvHardware.Records
{
    partial class REC_IngressHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REC_IngressHistory));
            this.pnlDevice = new System.Windows.Forms.Panel();
            this.txtSearchDevice = new System.Windows.Forms.TextBox();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.grdRecords = new System.Windows.Forms.DataGridView();
            this.grdInvBoard = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnSearchDevice = new FontAwesome.Sharp.IconButton();
            this.btnSearchSupplier = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plaqueta_inventarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_registra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDevice.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDevice
            // 
            this.pnlDevice.BackColor = System.Drawing.Color.White;
            this.pnlDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDevice.Controls.Add(this.txtSearchDevice);
            this.pnlDevice.Location = new System.Drawing.Point(246, 68);
            this.pnlDevice.Name = "pnlDevice";
            this.pnlDevice.Size = new System.Drawing.Size(283, 35);
            this.pnlDevice.TabIndex = 19;
            // 
            // txtSearchDevice
            // 
            this.txtSearchDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchDevice.Enabled = false;
            this.txtSearchDevice.Location = new System.Drawing.Point(1, 10);
            this.txtSearchDevice.Name = "txtSearchDevice";
            this.txtSearchDevice.Size = new System.Drawing.Size(281, 13);
            this.txtSearchDevice.TabIndex = 6;
            this.txtSearchDevice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchDevice_KeyDown);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.White;
            this.pnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployee.Controls.Add(this.txtSearchSupplier);
            this.pnlEmployee.Location = new System.Drawing.Point(246, 12);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(283, 35);
            this.pnlEmployee.TabIndex = 17;
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSupplier.Enabled = false;
            this.txtSearchSupplier.Location = new System.Drawing.Point(1, 10);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(281, 13);
            this.txtSearchSupplier.TabIndex = 5;
            this.txtSearchSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSupplier_KeyDown);
            // 
            // grdRecords
            // 
            this.grdRecords.AllowUserToAddRows = false;
            this.grdRecords.AllowUserToDeleteRows = false;
            this.grdRecords.BackgroundColor = System.Drawing.Color.White;
            this.grdRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria,
            this.plaqueta_inventarios,
            this.serialDispositivo,
            this.cedulaEmpleado,
            this.observacion,
            this.fechaIngreso,
            this.usuario_registra});
            this.grdRecords.Location = new System.Drawing.Point(12, 116);
            this.grdRecords.Name = "grdRecords";
            this.grdRecords.ReadOnly = true;
            this.grdRecords.RowHeadersVisible = false;
            this.grdRecords.Size = new System.Drawing.Size(869, 450);
            this.grdRecords.TabIndex = 16;
            // 
            // grdInvBoard
            // 
            this.grdInvBoard.AllowUserToAddRows = false;
            this.grdInvBoard.AllowUserToDeleteRows = false;
            this.grdInvBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvBoard.Location = new System.Drawing.Point(856, 166);
            this.grdInvBoard.Name = "grdInvBoard";
            this.grdInvBoard.Size = new System.Drawing.Size(10, 10);
            this.grdInvBoard.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnRefresh.IconColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 30;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(535, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(41, 34);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSearchDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDevice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchDevice.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnSearchDevice.IconColor = System.Drawing.SystemColors.Control;
            this.btnSearchDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchDevice.IconSize = 30;
            this.btnSearchDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDevice.Location = new System.Drawing.Point(12, 68);
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.btnSearchDevice.Size = new System.Drawing.Size(228, 35);
            this.btnSearchDevice.TabIndex = 15;
            this.btnSearchDevice.Text = "Buscar por Serial";
            this.btnSearchDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchDevice.UseVisualStyleBackColor = false;
            this.btnSearchDevice.Click += new System.EventHandler(this.btnSearchDevice_Click);
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchSupplier.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnSearchSupplier.IconColor = System.Drawing.SystemColors.Control;
            this.btnSearchSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchSupplier.IconSize = 30;
            this.btnSearchSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSupplier.Location = new System.Drawing.Point(12, 12);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.btnSearchSupplier.Size = new System.Drawing.Size(228, 35);
            this.btnSearchSupplier.TabIndex = 14;
            this.btnSearchSupplier.Text = "Buscar por Proveedor";
            this.btnSearchSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 30;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(773, 575);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReturn.Size = new System.Drawing.Size(117, 35);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 79;
            // 
            // plaqueta_inventarios
            // 
            this.plaqueta_inventarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.plaqueta_inventarios.DataPropertyName = "plaqueta_inventarios";
            this.plaqueta_inventarios.HeaderText = "Placa de Inventarios";
            this.plaqueta_inventarios.Name = "plaqueta_inventarios";
            this.plaqueta_inventarios.ReadOnly = true;
            this.plaqueta_inventarios.Width = 118;
            // 
            // serialDispositivo
            // 
            this.serialDispositivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serialDispositivo.DataPropertyName = "serial_dispositivo";
            this.serialDispositivo.HeaderText = "Serial dispositivo";
            this.serialDispositivo.Name = "serialDispositivo";
            this.serialDispositivo.ReadOnly = true;
            this.serialDispositivo.Width = 101;
            // 
            // cedulaEmpleado
            // 
            this.cedulaEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cedulaEmpleado.DataPropertyName = "nit_proveedor";
            this.cedulaEmpleado.HeaderText = "NIT Proveedor";
            this.cedulaEmpleado.Name = "cedulaEmpleado";
            this.cedulaEmpleado.ReadOnly = true;
            this.cedulaEmpleado.Width = 94;
            // 
            // observacion
            // 
            this.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Observación";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 92;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaIngreso.DataPropertyName = "fecha_ingreso";
            this.fechaIngreso.HeaderText = "Fecha de Ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            this.fechaIngreso.Width = 105;
            // 
            // usuario_registra
            // 
            this.usuario_registra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.usuario_registra.DataPropertyName = "usuario_registra";
            this.usuario_registra.HeaderText = "Usuario Ingresa";
            this.usuario_registra.Name = "usuario_registra";
            this.usuario_registra.ReadOnly = true;
            this.usuario_registra.Width = 97;
            // 
            // REC_IngressHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 612);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlDevice);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.btnSearchDevice);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grdRecords);
            this.Controls.Add(this.grdInvBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REC_IngressHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIAL DE INGRESOS";
            this.Load += new System.EventHandler(this.REC_IngressHistory_Load);
            this.pnlDevice.ResumeLayout(false);
            this.pnlDevice.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.Panel pnlDevice;
        private System.Windows.Forms.TextBox txtSearchDevice;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private FontAwesome.Sharp.IconButton btnSearchDevice;
        private FontAwesome.Sharp.IconButton btnSearchSupplier;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.DataGridView grdRecords;
        private System.Windows.Forms.DataGridView grdInvBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaqueta_inventarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_registra;
    }
}