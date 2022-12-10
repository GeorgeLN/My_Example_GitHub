
namespace Proyecto_InvHardware.Frames
{
    partial class FRM_Print
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQRRight = new CodigoQR_jorge.clsButtons();
            this.btnQRLeft = new CodigoQR_jorge.clsButtons();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnQRRight);
            this.panel1.Controls.Add(this.btnQRLeft);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 316);
            this.panel1.TabIndex = 1;
            // 
            // btnQRRight
            // 
            this.btnQRRight.BackColor = System.Drawing.Color.White;
            this.btnQRRight.BackGroundColor = System.Drawing.Color.White;
            this.btnQRRight.BorderColor = System.Drawing.Color.Black;
            this.btnQRRight.BorderRadius = 15;
            this.btnQRRight.BorderSize = 1;
            this.btnQRRight.FlatAppearance.BorderSize = 0;
            this.btnQRRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRRight.ForeColor = System.Drawing.Color.White;
            this.btnQRRight.Image = global::Proyecto_InvHardware.Properties.Resources.QR_Models_2_;
            this.btnQRRight.Location = new System.Drawing.Point(56, 126);
            this.btnQRRight.Name = "btnQRRight";
            this.btnQRRight.Size = new System.Drawing.Size(212, 79);
            this.btnQRRight.TabIndex = 80;
            this.btnQRRight.TextColor = System.Drawing.Color.White;
            this.btnQRRight.UseVisualStyleBackColor = false;
            this.btnQRRight.Click += new System.EventHandler(this.btnQRRight_Click);
            // 
            // btnQRLeft
            // 
            this.btnQRLeft.BackColor = System.Drawing.Color.White;
            this.btnQRLeft.BackGroundColor = System.Drawing.Color.White;
            this.btnQRLeft.BorderColor = System.Drawing.Color.Black;
            this.btnQRLeft.BorderRadius = 15;
            this.btnQRLeft.BorderSize = 1;
            this.btnQRLeft.FlatAppearance.BorderSize = 0;
            this.btnQRLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRLeft.ForeColor = System.Drawing.Color.White;
            this.btnQRLeft.Image = global::Proyecto_InvHardware.Properties.Resources.QR_Models_1_;
            this.btnQRLeft.Location = new System.Drawing.Point(56, 41);
            this.btnQRLeft.Name = "btnQRLeft";
            this.btnQRLeft.Size = new System.Drawing.Size(212, 79);
            this.btnQRLeft.TabIndex = 79;
            this.btnQRLeft.TextColor = System.Drawing.Color.White;
            this.btnQRLeft.UseVisualStyleBackColor = false;
            this.btnQRLeft.Click += new System.EventHandler(this.btnQRLeft_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 30;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(211, 274);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReturn.Size = new System.Drawing.Size(115, 33);
            this.btnReturn.TabIndex = 78;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(95)))), ((int)(((byte)(228)))));
            this.btnCheck.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnCheck.IconColor = System.Drawing.SystemColors.Control;
            this.btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheck.Location = new System.Drawing.Point(104, 211);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnCheck.Size = new System.Drawing.Size(124, 42);
            this.btnCheck.TabIndex = 77;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 18);
            this.label1.TabIndex = 76;
            this.label1.Text = "MODO DE IMPRESIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 318);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Print";
            this.Load += new System.EventHandler(this.FRM_Print_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CodigoQR_jorge.clsButtons btnQRRight;
        private CodigoQR_jorge.clsButtons btnQRLeft;
        public FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnCheck;
        private System.Windows.Forms.Label label1;
    }
}