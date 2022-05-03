/*
 Crea un programa que pida al usuario un numero del 1 al 5, y escriba el nombre de ese número, usando "switch" (por ejemplo si introduce "1", 
 el programa escribirá "uno"
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
            int num;

            Console.Write("Ingrese un numero del 1 al 5: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: Console.Write("uno"); break;
                case 2: Console.Write("dos"); break;
                case 3: Console.Write("tres"); break;
                case 4: Console.Write("cuatro"); break;
                case 5: Console.Write("cinco"); break;
                default: Console.Write("Fuera de rango"); break;
            }

            Console.ReadKey();
        }
    }
}
