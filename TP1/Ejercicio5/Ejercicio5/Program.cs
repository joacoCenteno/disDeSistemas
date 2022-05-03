/*
 Escribir un programa donde se introduzca un numero y deberá
 mostrar el numero ingresado, su anterior y posterior
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
            double num, res;

            Console.WriteLine("Ingrese su numero");
            num = int.Parse(Console.ReadLine());

            res = num - 1;


         
            Console.WriteLine("Anterior del numero: " + res);
            Console.WriteLine("Numero Ingresado: " + num);
            res = num + 1;
            Console.WriteLine("Posterior del numero: " + res);

            Console.ReadKey();
        }
    }
}
