/*
 Haz una tabla de multiplicar utilizando el ciclo for. El usuario deberá ingresar un numero y el programa deberá mostrar la tabla
 de multiplicar de dicho numero
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Que tabla de multiplicar desea realizar: "); num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(num + "x" + i + "= " + num * i);
            }

            Console.ReadKey();
        }
    }
}
