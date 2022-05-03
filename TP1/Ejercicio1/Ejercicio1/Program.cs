/*
 Crear un programa donde se pueda visualizar los siguientes datos:
 nombre,  apellido, curso y año
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
            string nombre = "Joaquín", apellido = "Centeno", curso = "6to Informática", año = "2022";

            Console.WriteLine("Nombre completo: "+nombre + " " + apellido);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Año: "+año);

            Console.ReadKey();
        }
    }
}
