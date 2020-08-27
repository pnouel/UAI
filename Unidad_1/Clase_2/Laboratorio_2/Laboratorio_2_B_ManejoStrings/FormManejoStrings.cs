using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_B_ManejoStrings
{
    public partial class FormManejoStrings : Form
    {
        public FormManejoStrings()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //asigno el valor a la variable del texbox1
            string variable = textBox1.Text;
            //asigno al texbox2 el tamaño de la palabra ingresada
            textBox2.Text = variable.Length.ToString();
            //si en el txtdato es > 0, devuelvo, el caracter en la posicion indicada
            if (txtDato.Text.Length > 0)
            {
                int pos = Convert.ToInt32(txtDato.Text);
                textBox3.Text = (variable[pos]).ToString();
            }
            //a la cadena le inserto 12345
            textBox5.Text = variable.Insert(3, "12345");
            //quito los espacion en blanco la final de la cadena
            textBox4.Text = variable.TrimStart();
            //
            if ((variable.Length < 10))
            {
                //le agrego 0 a la derecha si no posee 10 caracteres, hasta llegar a ellos
                // FORMA DE HACERLO ELEGANTE
                textBox7.Text = variable.PadRight(10, '0');
            }
            
            textBox8.Text = string.Concat(textBox9.Text, variable);
            // A agrega propidead startsWith para evaluar si comuenza o no y el condicional devuelva una respuesta logica.
            if (textBox1.Text.StartsWith("ABC") )
            {
                textBox6.Text = "SI";
            }
            else { textBox6.Text = "NO"; }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
