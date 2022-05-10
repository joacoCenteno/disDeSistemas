/*
 Escribir un programa que pida al usuario un numero entero y muestre por pantalla la cuenta atras desde ese numero 
 hasta cero separados por comas
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

            Console.Write("Ingrese su numero de comienzo: "); num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 0; i--)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();
          

        }
    }
}
