/*
  Crea un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica o una consonante,
  usando switch
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
            char val;

            Console.Write("Ingrese una tecla: ");
            val = char.Parse(Console.ReadLine());

                switch (val)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u': Console.Write("Ingresó una vocal"); break;          
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': Console.Write("Ingresó un valor numérico"); break;

                    default: Console.Write("Ingresó una consonante o un valor especial"); break;

                }

                Console.ReadKey();
          }
     }
 }