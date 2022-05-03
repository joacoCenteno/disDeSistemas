/*
Escribi un programa que solicite al usuario el ingreso de dos numeros diferentes y muestre en pantalla el mayor de ellos
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
            int num1,num2;

            Console.WriteLine("Ingrese sus dos numeros...");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) Console.Write("El mayor de los dos numeros ingresados es el " + num1);
            else if (num2 > num1) Console.Write("El mayor de los dos numeros ingreados es el " + num2);
            else Console.Write("Los numeros son iguales");

            Console.ReadKey();
        }
    }
}
