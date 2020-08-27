using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_A_5_BarraProgreso
{
    public partial class FormBarraProgreso : Form
    {
        public FormBarraProgreso()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            long contador;
            progressBar1.Value = 0;//inicializo el valor inicial del progresbar
            progressBar1.Maximum = 100;//valor maximo para el progressbar
            while ((progressBar1.Value < progressBar1.Maximum))
            {
                progressBar1.Value++;
                // Bucle para simular el delay, esto es mejor hacerlo con hilos
                for (contador = 1; (contador <= 100000000); contador++)
                {
                    
                }
              
            }
            string message = " Finalizo el Proceso";
            MessageBox.Show(message);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
