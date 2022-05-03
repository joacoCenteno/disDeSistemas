/*
Crear un programa que pida al usuario un numero entero y responda si es mutliplo de 2 o de 3
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
            int num;

            Console.Write("Ingrese su numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 || num % 3 == 0) Console.Write("El numero ingresado es multiplo de 2 o de 3");
           

            Console.ReadKey();
            
        }
    }
}
