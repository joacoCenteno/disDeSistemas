/*
 Crea un programa que pida al usuario un numero entero y responda si no es multiplo de 2 ni de 3
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
            int num;

            Console.Write("Ingrese su numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 != 0 && num % 3 != 0) Console.Write("El numero ingresado no es multiplo de 2 ni de 3");

            Console.ReadKey();
        }
    }
}
