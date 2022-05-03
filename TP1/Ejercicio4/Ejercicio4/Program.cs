/*
 Escriba un programa donde se multiplique dos numeros introducidos por el
 * usuario. El programa deberá contener un comentario al principio, que recuerde
 * cual es su objetivo
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
            float num1, num2, mult = 0;

            Console.WriteLine("Ingrese sus 2 numeros a multiplicar: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());

            mult = num1 * num2;

            Console.WriteLine("La multiplicación de los numeros ingresados es: " + mult);

            Console.ReadKey();
        }
    }
}
