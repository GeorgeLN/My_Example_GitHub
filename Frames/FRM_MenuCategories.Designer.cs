
namespace Proyecto_InvHardware
{
    partial class FRM_MenuCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MenuCategories));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTypes = new CodigoQR_jorge.clsButtons();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnCategories = new CodigoQR_jorge.clsButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE UNA OPCIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.White;
            this.btnTypes.BackGroundColor = System.Drawing.Color.White;
            this.btnTypes.BorderColor = System.Drawing.Color.Black;
            this.btnTypes.BorderRadius = 15;
            this.btnTypes.BorderSize = 1;
            this.btnTypes.FlatAppearance.BorderSize = 0;
            this.btnTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypes.ForeColor = System.Drawing.Color.Black;
            this.btnTypes.Image = ((System.Drawing.Image)(resources.GetObject("btnTypes.Image")));
            this.btnTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypes.Location = new System.Drawing.Point(61, 131);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTypes.Size = new System.Drawing.Size(212, 79);
            this.btnTypes.TabIndex = 77;
            this.btnTypes.Text = "      CONFIGURAR  CATEGORÍAS (TIPOS)";
            this.btnTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypes.TextColor = System.Drawing.Color.White;
            this.btnTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypes.UseVisualStyleBackColor = false;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
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
            this.btnReturn.Location = new System.Drawing.Point(216, 242);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReturn.Size = new System.Drawing.Size(115, 33);
            this.btnReturn.TabIndex = 79;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.White;
            this.btnCategories.BackGroundColor = System.Drawing.Color.White;
            this.btnCategories.BorderColor = System.Drawing.Color.Black;
            this.btnCategories.BorderRadius = 15;
            this.btnCategories.BorderSize = 1;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.Black;
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(61, 46);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(212, 79);
            this.btnCategories.TabIndex = 76;
            this.btnCategories.Text = "       CONFIGURAR CATEGORÍAS";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategories.TextColor = System.Drawing.Color.White;
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // FRM_MenuCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 279);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnTypes);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MenuCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ CATEGORÍAS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_SelectCategory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CodigoQR_jorge.clsButtons btnTypes;
        private CodigoQR_jorge.clsButtons btnCategories;
        public FontAwesome.Sharp.IconButton btnReturn;
    }
}