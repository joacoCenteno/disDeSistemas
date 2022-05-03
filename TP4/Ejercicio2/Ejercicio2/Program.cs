/*
Crear un programa que multiplique dos numeros enteros de la siguiente forma, pedirá al usuario un primer numero entero. Si el numero que
se teclee es 0, escribirá en pantalla "El producto de 0 por cualquier numero es 0". Si se ha tecleado un numero distinto que cero
se pedirá al usaurio el ingreso de un segundo numero y se mostrara el producto de ambos
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
            int num1, num2, res=0;

            Console.Write("Ingrese su prime numero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0) Console.Write("El producto de 0 por cualquier numero es 0");
            else
            {
                Console.Write("Ingrese su segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                if (num2 == 0) Console.Write("El producto de 0 por cualquier numero es 0");

                else
                {
                    res = num1 * num2;
                    Console.Write("El producto es: " + res);
                }

                
            }

            Console.ReadKey();
        }
    }
}
