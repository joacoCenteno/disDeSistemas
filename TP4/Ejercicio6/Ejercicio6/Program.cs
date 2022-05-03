/*
 Crea un programa que pida al usuario dos numeros enteros y diga si ambos son pares
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
            int num1, num2;

            Console.Write("Ingrese su primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0 && num2 % 2 == 0) Console.Write("Ambos números ingesados son pares");

            Console.ReadKey();
        }
    }
}
