/*
Escibi un programa que slicite al usuario su edad y la guarde en una variable. Que luego solicite la cantidad de articulos comprados
en una tienda y los guarde en otra variable. Finalmente mostrar en pantalla un valor de verdad que indique si el usuario es mayor de
18 años de edad y además compró mas de un articulo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, art;
            bool res;

            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos articulos compraste?");
            art = int.Parse(Console.ReadLine());

            if (edad > 18 && art > 1) res = true;
            else res = false;

            Console.Write("Tienes más de 18 años y comprase más de un artículo? " + res);
            Console.ReadKey();
        }
    }
}
