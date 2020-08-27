using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_A_OperacionesConVectores
{
    public partial class OperacionesVectores : Form
    {
        public OperacionesVectores()
        {
            AllocConsole();
            InitializeComponent();

        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        string dato;
        int[] vector; //declaro mi vector
       // int i;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //limpio los items de la lista
            vector = new int[10];//inicializo mi vector
                                 //recorro con el ciclo for las 10 posiciones del vector para cargar el mismo
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector[i] = Int32.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos");
            //Recorro nuevamente el vector, para cargar los datos en mi listBox
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("En la posición : " + i + " el valor es: " + vector[i]);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(vector);//esta instrucción ordena el vector
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("El valor es: " + vector[i] + " en la posición : " + i);
            }
        }

        private void btnCopoar_Click(object sender, EventArgs e)
        {
            int[] vectorDestino = new int[20];
            Array.Copy(vector, 0, vectorDestino, 0, 10);
            for (int i = 0; i < 10; i++) {
                listBox1.Items.Add(vectorDestino[i] + " en la posición " + i);
            }
        }

        private void btnLimites_Click(object sender, EventArgs e)
        {
            int superior; int inferior;
            listBox1.Items.Clear(); superior = vector.GetUpperBound(0);//Obtiene el índice del último elemento de la dimensión especificada en la matriz. 
            inferior = vector.GetLowerBound(0);
            // Obtiene el índice del primer elemento de la dimensión especificada en la matriz. 
            listBox1.Items.Add("El límite inferior es " + inferior + " y el superior es " + superior);
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            int posicion; posicion = Array.BinarySearch(vector, 9);
            listBox1.Items.Clear();
            listBox1.Items.Add("En la posicion " + posicion + " se encuentra el número 9");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

