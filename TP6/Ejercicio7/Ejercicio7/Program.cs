/*
 Escribir un programa a partir de un diagrama de flujo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma=0;
            Console.Write("Ingrese un numero: "); n= int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.WriteLine("El valor de a es: " + a + " y el valor de b es: " + b);

            do
            {
                suma = a + b;
                Console.WriteLine("Valor de la suma hasta el momento: " + suma);
                a = b;
                b = suma;
            } while (suma < n);

            Console.ReadKey();
        }
    }
}
