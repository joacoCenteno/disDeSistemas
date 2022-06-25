/*
 Para guradar información sobre libros, vamos a comenzar por crear la clase Libro, que contendrá atributos "autor", "titulo", "ubicación"
 (todos ellos string) y metodos Get y Set adecuados para leer su valor y cambiarlo. Desde el main cree un objeto de la clase Libro,
 darle valores a sus tres atributos y luego los muestre.
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
            Libro obj1 = new Libro();

            Console.Write("Ingrese el autor: "); obj1.Autor = Console.ReadLine();
            Console.Write("Ingrese el titulo: "); obj1.Titulo = Console.ReadLine();
            Console.Write("Ingrese la ubicacion: ");  obj1.Ubicacion = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("DATOS DEL LIBRO");
            Console.WriteLine("Autor: {0}", obj1.Autor);
            Console.WriteLine("Titulo: {0}", obj1.Titulo);
            Console.WriteLine("Ubicacion: {0}", obj1.Ubicacion);

            Console.ReadKey();

        }
    }
}
