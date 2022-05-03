/*
 Crear un programa donde el usuario introduzca tres numeros
 y muestre su suma, multiplicaión y división
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;
            float res = 0;

            Console.WriteLine("Ingrese sus 3 números: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            num3 = float.Parse(Console.ReadLine());


            res = num1 + num2 + num3;
            Console.WriteLine("Suma: " + res);
            res = num1 - num2 - num3;
            Console.WriteLine("Resta: " + res);
            res = num1 * num2 * num3;
            Console.WriteLine("Multiplicacion: " + res);
            res = num1 / num2 / num3;
            Console.WriteLine("Division: " + res);

            Console.ReadKey();
        }
    }
}
