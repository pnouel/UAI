using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_A_7_MensajesDeTexto
{
    public partial class FormMensajesTxt : Form
    {
        public FormMensajesTxt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Este es un mensaje", "Este es Un titulo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es otro mensaje", "Este es otro Mensaje", MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ah! pero anoche", "Mas titulos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
