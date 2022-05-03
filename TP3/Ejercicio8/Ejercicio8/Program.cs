/*
Escribi un programa que permita saber si un año es bisiesto. Para que una año sea bisiesto debe ser divisible por 4 y no debe ser divisible
 por 100, excepto que tambien sea divisible por 400
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.WriteLine("Ingrese su año...");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0) Console.Write("El año es bisiesto");
            else Console.Write("El año no es bisiesto");

            Console.ReadKey();

        }
    }
}
