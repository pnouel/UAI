using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Cronometro : Form
    {
        int hora = 0;
        int min = 0;
        int seg = 0;

        public Cronometro()
        {
            InitializeComponent();
            
        }

        private void Cronometro_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if (min == 60)
            {
                hora++;
                min = 0;
            }
            lblCronometro.Text = hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        
    }

        private void btnComezar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // habilito el timer
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblCronometro.Text = "00:00:00";
            seg = 0;
            min = 0;
            hora = 0;
        }
    }
}
