/*
 Escribir un programa que pida al usuario un numero entero positivo y muestre por pantalla todos los numeros impares desde 1 hasta
 ese número separados por coma.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese su tope: "); num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0) Console.Write(i + ", ");

            }
            Console.ReadKey();
        }
    }
}

