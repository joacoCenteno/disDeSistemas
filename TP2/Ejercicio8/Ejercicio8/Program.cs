/*
 Ecribi un programa  que solicite al usuario el ingreso de dos palabras, las cuales
 se guardan en dos variables distintas. A continuacion, alamcena en una variable 
 la concatenacion de la primera, mas un espacio, mas la segunda palabra. Muestra
 el resultado por pantalla
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
            string a, b, c;

            Console.WriteLine("Ingrese sus 2 palabras...");
            a = Console.ReadLine();
            b = Console.ReadLine();

            c = a + " " + b;
            Console.WriteLine("Tu resultado-- " + c);

            Console.ReadKey();

        }
    }
}
