using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorios_2_C_2_OperacionesConFechas2
{
    public partial class FormOperacionesConFecha : Form
    {
        public FormOperacionesConFecha()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);

            txtResultado.Text = (fecha1.AddDays(Convert.ToInt32(txtDias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);

            txtResultado.Text = (fecha1.AddDays(-1 * Convert.ToInt32(txtDias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
