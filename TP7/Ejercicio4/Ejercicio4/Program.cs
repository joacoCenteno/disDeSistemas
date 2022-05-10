/*
 Escribir un programa que muestre el eco de todo lo que el usuario introduzca gasta que el usuario escriba "salir" que terminará.
 Por ejemplo el usuario introduce la palabra "hola" y deberá escribir 7 veces "hola" o cualquier palabra se repetirá 7 veces.
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
            string msj;

            do
            {
                Console.Write("Ingrese el mensaje: "); msj = Console.ReadLine();

                if (msj != "salir")
                { 

                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine(msj);
                    }
                }
            } while (msj != "salir");
            Console.Write("Ejecución finalizada");
            Console.ReadKey();

        }
    }
}
