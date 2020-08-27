using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorios_2_C_2_OperacionesConFechas1
{
    public partial class FormOperacionesConFecha2 : Form
    {
        public FormOperacionesConFecha2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = this.dateTimePicker1.Value;
            DateTime fecha2 = this.dateTimePicker2.Value;
            txtResultado.Text = fecha1.Subtract(fecha2).ToString();
        }
    }
}
