/*
 Crear un programa donde se muestre la suma, resta, multiplicación y
 * división de los numeros 313 y 301
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
            int num1 = 313, num2 = 301, suma = 0, resta = 0, mult = 0;
            float div = 0;

            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("La suma de los numeros es: " + suma);
            Console.WriteLine("La resta de los numeros es: " + resta);
            Console.WriteLine("La multiplicación de los numeros es: " + mult);
            Console.WriteLine("La división de los numeros es: " + div);

            Console.ReadKey();
        }
    }
}
