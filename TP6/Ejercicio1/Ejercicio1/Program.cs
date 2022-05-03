/*
Mostrar la suma y los numeros impares que hay entre 100 al 200
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=100, suma = 0;

            Console.WriteLine("Los numeros impares del 100 al 200 son: ");

            while (num <= 199)
            {
                num++;
                if (num % 2 != 0)
                {
                    Console.WriteLine(num); suma += num;
                }
                
            }

            Console.WriteLine("La suma de los numeros impares del 100 al 200 es: " + suma);
            Console.ReadKey();
        }
    }
}
