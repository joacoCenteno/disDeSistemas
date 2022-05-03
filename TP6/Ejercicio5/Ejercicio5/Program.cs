/*
 Crea un programa que muestre los primeros ocho numeros pares
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i = 0;

            Console.WriteLine("Los primeros ocho numeros pares (incluyendo el 0) son: ");
            Console.WriteLine(num);

            while (i < 8)
            {
                num++;
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
