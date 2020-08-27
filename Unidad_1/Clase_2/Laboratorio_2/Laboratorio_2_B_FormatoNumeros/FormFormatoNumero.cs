using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_B_FormatoFecha
{
    public partial class FormFormatoNumero : Form
    {
        public FormFormatoNumero()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            double auxiliar;
            double auxiliar1;
            double auxiliar2;
            auxiliar = double.Parse(txtIngreso.Text);
            textBox1.Text = string.Format("{0:c}", auxiliar);
            auxiliar1 = (auxiliar / 100);
            textBox2.Text = string.Format("{0:N}", auxiliar);
            textBox3.Text = string.Format("{0:N4}", auxiliar);
            textBox4.Text = string.Format("{0:D8}", Convert.ToInt32(auxiliar));
            textBox5.Text = string.Format("{0:f3}", auxiliar);
            textBox6.Text = string.Format("{0:E3}", auxiliar);
            textBox7.Text = string.Format("{0:p}", auxiliar1);// Se corrigio error variable erronea
            textBox8.Text = string.Format("el valor es {0:c}", auxiliar);
            auxiliar2 = (auxiliar + 10);
            textBox9.Text = string.Format("{0:c} {1:c}", auxiliar, auxiliar2);
        }
    }
}
