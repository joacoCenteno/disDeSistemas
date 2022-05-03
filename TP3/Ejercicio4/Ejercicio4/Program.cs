/*
Escribi un programa que dado un numero entero, muestre su valor absoluto, recuerde que para los numeros positivos su valor absoluto
 es igual al numero, mientras que, para los negativos, su valor absoluto es el numero mutliplicado por -1
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
            int num, res;
  

            Console.WriteLine("Ingrese su numero...");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.Write("El valor absuluto de tu numero es: " + num);

            }
            else
            {
                num = num * -1;
                Console.Write("El valor absuluto de tu numero es: " + num);
            }

            Console.ReadKey();
        }
    }
}
