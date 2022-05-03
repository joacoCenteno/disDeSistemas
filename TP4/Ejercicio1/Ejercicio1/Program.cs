/*
 Crear un programa donde solicite al usuario un numer, si el mismo es mayor que cero emitirá un mensaje que diga "El numero es positivo"
 * en caso contrario emitirá un mensaje diciendo el numero es cero o negativo
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
            float num;

            Console.Write("Ingresa tu numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0) Console.Write("El numero es positivo");
            else if (num < 0) Console.Write("El numero es negativo");
            else Console.Write("El numero es cero");

            Console.ReadKey();
        }
    }
}
