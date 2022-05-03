/*
 Crea un programa que lea un letra  tecleada por el usuario y diga si se trata de un signo de puntuacion, una cifra numerica o algun
 otro caracter.
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
            char val;

            Console.Write("Teclee un caracter: ");
            val= char.Parse(Console.ReadLine());

            switch (val)
            {
                case '.': 
                case ',': 
                case ';':
                case ':': Console.Write("Tecleeó un caracter de puntuacion");
                    break;
                case '0': 
                case '1': 
                case '2': 
                case '3':
                case '4': 
                case '5': 
                case '6':
                case '7': 
                case '8':
                case '9': Console.Write("Tecleeó un caracter numérico");
                    break;
                default: Console.Write("Tecleeó otro carácter"); break;
                
            }

            Console.ReadKey();
        }
    }
}
