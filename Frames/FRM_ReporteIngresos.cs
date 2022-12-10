using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware.REPORTES
{
    public partial class FRM_ReporteIngresos : Form
    {
        public FRM_ReporteIngresos()
        {
            InitializeComponent();
        }

        private void FRM_ReporteIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_InvHardware.dispositivo_proveedor' Puede moverla o quitarla según sea necesario.
            //this.dispositivo_proveedorTableAdapter.Fill(this.dS_InvHardware.dispositivo_proveedor);

            this.REP_Ingress.RefreshReport();
        }
    }
}
