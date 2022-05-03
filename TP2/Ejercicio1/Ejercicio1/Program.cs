/*
 Escribi un programa que solicite al usuario que ingrese su nombre. El nombre se
 * debe almacenar en una variable llamada nombre. A continuación se debe mostrar 
 * el texto "Ahora estas en ña matrix, [usuario], donde [usuario] se reemplazará
 * por el nombre que el usuario haya ingresado
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
            string nombre;

            Console.WriteLine("Ingrese su nombre...");
            nombre = Console.ReadLine();

            Console.WriteLine("Ahora estás en la matrix, " + nombre);

            Console.ReadKey() ;
        }
    }
}
