/*
 Crea un programa que escriba en pantalla los numeros pares del 26 al 10 usando do-while
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 26;

            Console.WriteLine("Los números pares del 26 al 10 son: ");

            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num--;
            } while (num >= 10);

            Console.ReadKey();
        }
    }
}
