/*
 Escribir un programa que realice un triangulo rectangulo con las lestras desde a-z
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
            string val="a";

            string[] abc = {"b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", ""};
    

            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(val);
                val += abc[i];

            }

            Console.ReadKey();
        }
    }
}
