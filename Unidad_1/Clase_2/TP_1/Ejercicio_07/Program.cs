using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular cuántos bits hay en cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión.

            //    teniendo cuenta que la relacione es
            //1 byte 8 bits
            //        1 kilobyte 1000 bytes
            //        Se llega a la siguiente solucion

            long cantKBytes = 0;
            long cantBytes = 0;
            long cantBits = 0;
            const long bitsInBytes = 8;
            const long bytesInKiloBytes = 1000;

            //Ingresar KiloBytes
            Console.WriteLine("Ingrese cantidad de KiloBytes:");
            cantKBytes= Convert.ToInt32(Console.ReadLine());
            // calcluar bytes
            cantBytes = cantKBytes * bytesInKiloBytes;
            // multiplicar cantidad de bytes * 8 bits
            cantBits = cantBytes * bitsInBytes;
            
            Console.Clear();//limpiamos pantalla
            

            Console.WriteLine("La cantidad de bits en {0} : {1}",cantKBytes, cantBits);//muestra de datos

            Console.ReadKey();





        }
    }
}
