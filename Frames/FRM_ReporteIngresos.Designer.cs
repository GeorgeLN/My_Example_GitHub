namespace Proyecto_InvHardware.REPORTES
{
    partial class FRM_ReporteIngresos
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
            this.components = new System.ComponentModel.Container();
            this.REP_Ingress = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dispositivoproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_InvHardware = new Proyecto_InvHardware.DS_InvHardware();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoproveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_InvHardware)).BeginInit();
            this.SuspendLayout();
            // 
            // REP_Ingress
            // 
            this.REP_Ingress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dispositivoproveedorBindingSource, "modelo", true));
            this.REP_Ingress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.REP_Ingress.Location = new System.Drawing.Point(0, 0);
            this.REP_Ingress.Name = "REP_Ingress";
            this.REP_Ingress.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.REP_Ingress.ServerReport.BearerToken = null;
            this.REP_Ingress.Size = new System.Drawing.Size(872, 493);
            this.REP_Ingress.TabIndex = 0;
            // 
            // dispositivoproveedorBindingSource
            // 
            this.dispositivoproveedorBindingSource.DataMember = "dispositivo_proveedor";
            this.dispositivoproveedorBindingSource.DataSource = this.dS_InvHardware;
            // 
            // dS_InvHardware
            // 
            //this.dS_InvHardware.DataSetName = "DS_InvHardware";
            //this.dS_InvHardware.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FRM_ReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 493);
            this.Controls.Add(this.REP_Ingress);
            this.Name = "FRM_ReporteIngresos";
            this.Text = "Reporte de Ingresos";
            this.Load += new System.EventHandler(this.FRM_ReporteIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispositivoproveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_InvHardware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer REP_Ingress;
        private DS_InvHardware dS_InvHardware;
        private System.Windows.Forms.BindingSource dispositivoproveedorBindingSource;
        //private DS_InvHardwareTableAdapters.dispositivo_proveedorTableAdapter dispositivo_proveedorTableAdapter;
    }
}