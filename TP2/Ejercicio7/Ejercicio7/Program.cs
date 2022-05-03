/*
 Ecribi un programa que solicite al usuario un numero y le reste el 15%,
 almacenando todo en una unica variable. A continuacion mostrar el resultado
 por pantalla
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
             
            double num;

            Console.WriteLine("Ingrese su numero");
            num = float.Parse(Console.ReadLine());

            num = num - (0.15 * num);

            Console.WriteLine("La resta del 15% de su numero es: "+num);

            Console.ReadKey();


        }
    }
}
