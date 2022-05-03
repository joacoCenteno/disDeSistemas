/*
Crear un programa que muestre los numeros del 15 al 50 de forma descendente
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=50;

            Console.WriteLine("Los numeros del 50 al 15 son: ");

            while (num >= 15)
            {
                Console.WriteLine(num); num--;
            }
            Console.ReadKey();
        }
    }
}
