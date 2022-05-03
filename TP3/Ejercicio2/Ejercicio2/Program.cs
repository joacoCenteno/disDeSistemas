/*
  Escribi un programa para solicitar al usuario el ingreso de un numero entero para que luego imprima un valor de verdad dependiendo
 * de si el numero es par o no. Recordar que un numero es par si el resto, al dividirlo por 2, es 0
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
            int num;
            bool res;

            Console.WriteLine("Ingrese su numero...");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) res = true;
            else res = false;

            Console.Write("El numero es par?... " + res);
            Console.ReadKey();



        }
    }
}
