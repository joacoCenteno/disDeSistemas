/*
 Crea un programa que pida al usuario dos numeros enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el pirmer
 * y el segundo numero. Por el contrario, si el segundo numero es cero, escribirá "Error: No se puede dividir entre 0"
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
            float num1, num2, res = 0;

            Console.Write("Ingrese su primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                res = num1 / num2;
                Console.Write("El resultado es: " + res);
            }
            else Console.Write("Error: No se puede dividir entre 0");

            Console.ReadKey();

        }
    }
}
