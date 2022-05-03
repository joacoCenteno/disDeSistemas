/*
 Escribir un programa que solicite al usuario el ingreso de una temeratura en escala
 Fahrenheit( debe permitir decimales) y le muestre el equivalente en grados Celsius.
 * La formula de conversion que se usa para este calculo es: Celsius=(5/9)*(Fahrenheit-32)
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
            float f, g = 0;

            Console.WriteLine("Ingrese sus grados en Fahrenheit...");
            f = float.Parse(Console.ReadLine());

            g = (f-32)*5/9;

            Console.WriteLine("EL equivalente a grados Celsius es: "+g+"°");

            Console.ReadKey();
        }
    }
}
