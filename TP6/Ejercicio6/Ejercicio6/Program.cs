/*
 Observar los términos de la siguiente serie: 200, 198, 196, 194,..., t n-1, tn,t0 con t 0 > 0 mostrar la suma de la serie completa.
 Hacer uso de la estructura do-while
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 200, suma=0;

            do
            {
                if (num % 2 == 0)
                {
                    suma += num;
                }
                num--;
            } while (num > 0);

            Console.Write("La suma es: " + suma);
            Console.ReadKey();
        }
    }
}
