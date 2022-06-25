/*
 Crea una clase Coche, con atributos "marca" (texto), "modelo" (texto), "clindrada (numero entero), potencia (numeo real).
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
            Coche obj1 = new Coche();

            Console.WriteLine("Ingrese caracterisiticas de su coche");
            Console.Write("Modelo: "); obj1.Marca = Console.ReadLine();
            Console.Write("Marca: "); obj1.Modelo = Console.ReadLine();
            Console.Write("Cilindrada: "); obj1.Cilindrada = byte.Parse(Console.ReadLine());
            Console.Write("Potencia: "); obj1.Potencia = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("CARACTERISTICAS DEL COCHE");
            Console.WriteLine("Marca: {0}", obj1.Marca);
            Console.WriteLine("Modelo: {0}", obj1.Modelo);
            Console.WriteLine("Cilindrada: {0}", obj1.Cilindrada);
            Console.WriteLine("Potencia: {0}", obj1.Potencia);

            Console.ReadKey();
        }
    }
}
