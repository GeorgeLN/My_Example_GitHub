
namespace Proyecto_InvHardware.Frames
{
    partial class FRM_SearchAssing
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
            this.label2 = new System.Windows.Forms.Label();
            this.chbOnlyDevice = new System.Windows.Forms.CheckBox();
            this.chbOnlyEmployee = new System.Windows.Forms.CheckBox();
            this.txtDeviceSerial = new System.Windows.Forms.TextBox();
            this.txtEmployeeDocument = new System.Windows.Forms.TextBox();
            this.rbtSerial = new System.Windows.Forms.RadioButton();
            this.rbtDocument = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "BUSCAR EN LA TABLA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbOnlyDevice
            // 
            this.chbOnlyDevice.AutoSize = true;
            this.chbOnlyDevice.Location = new System.Drawing.Point(11, 28);
            this.chbOnlyDevice.Name = "chbOnlyDevice";
            this.chbOnlyDevice.Size = new System.Drawing.Size(173, 17);
            this.chbOnlyDevice.TabIndex = 29;
            this.chbOnlyDevice.Text = "BUSCAR SÓLO DISPOSITIVO";
            this.chbOnlyDevice.UseVisualStyleBackColor = true;
            this.chbOnlyDevice.CheckedChanged += new System.EventHandler(this.chbOnlyDevice_CheckedChanged);
            // 
            // chbOnlyEmployee
            // 
            this.chbOnlyEmployee.AutoSize = true;
            this.chbOnlyEmployee.Location = new System.Drawing.Point(203, 28);
            this.chbOnlyEmployee.Name = "chbOnlyEmployee";
            this.chbOnlyEmployee.Size = new System.Drawing.Size(164, 17);
            this.chbOnlyEmployee.TabIndex = 28;
            this.chbOnlyEmployee.Text = "BUSCAR SÓLO EMPLEADO";
            this.chbOnlyEmployee.UseVisualStyleBackColor = true;
            this.chbOnlyEmployee.CheckedChanged += new System.EventHandler(this.chbOnlyEmployee_CheckedChanged);
            // 
            // txtDeviceSerial
            // 
            this.txtDeviceSerial.Location = new System.Drawing.Point(72, 137);
            this.txtDeviceSerial.Name = "txtDeviceSerial";
            this.txtDeviceSerial.Size = new System.Drawing.Size(236, 20);
            this.txtDeviceSerial.TabIndex = 25;
            this.txtDeviceSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeviceSerial_KeyDown);
            // 
            // txtEmployeeDocument
            // 
            this.txtEmployeeDocument.Location = new System.Drawing.Point(72, 163);
            this.txtEmployeeDocument.Name = "txtEmployeeDocument";
            this.txtEmployeeDocument.Size = new System.Drawing.Size(236, 20);
            this.txtEmployeeDocument.TabIndex = 24;
            this.txtEmployeeDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeDocument_KeyDown);
            // 
            // rbtSerial
            // 
            this.rbtSerial.AutoSize = true;
            this.rbtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSerial.Location = new System.Drawing.Point(84, 86);
            this.rbtSerial.Name = "rbtSerial";
            this.rbtSerial.Size = new System.Drawing.Size(73, 20);
            this.rbtSerial.TabIndex = 23;
            this.rbtSerial.TabStop = true;
            this.rbtSerial.Text = "SERIAL";
            this.rbtSerial.UseVisualStyleBackColor = true;
            this.rbtSerial.CheckedChanged += new System.EventHandler(this.rbtSerial_CheckedChanged);
            // 
            // rbtDocument
            // 
            this.rbtDocument.AutoSize = true;
            this.rbtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDocument.Location = new System.Drawing.Point(221, 86);
            this.rbtDocument.Name = "rbtDocument";
            this.rbtDocument.Size = new System.Drawing.Size(114, 20);
            this.rbtDocument.TabIndex = 22;
            this.rbtDocument.TabStop = true;
            this.rbtDocument.Text = "DOCUMENTO";
            this.rbtDocument.UseVisualStyleBackColor = true;
            this.rbtDocument.CheckedChanged += new System.EventHandler(this.rbtDocument_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "BUSCAR DISPOSITIVO O EMPLEADO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 40;
            this.btnReturn.Location = new System.Drawing.Point(348, 213);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(37, 34);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 40;
            this.btnSearch.Location = new System.Drawing.Point(119, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(166, 40);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FRM_SearchAssing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 253);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbOnlyDevice);
            this.Controls.Add(this.chbOnlyEmployee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtDeviceSerial);
            this.Controls.Add(this.txtEmployeeDocument);
            this.Controls.Add(this.rbtSerial);
            this.Controls.Add(this.rbtDocument);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "FRM_SearchAssing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chbOnlyDevice;
        public System.Windows.Forms.CheckBox chbOnlyEmployee;
        private FontAwesome.Sharp.IconButton btnReturn;
        public System.Windows.Forms.TextBox txtDeviceSerial;
        public System.Windows.Forms.TextBox txtEmployeeDocument;
        private System.Windows.Forms.RadioButton rbtSerial;
        private System.Windows.Forms.RadioButton rbtDocument;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label1;
    }
}