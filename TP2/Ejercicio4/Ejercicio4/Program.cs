/*
 Escribi un programa que solicite al usuario ingresar la cantidad de kilometros
 * recorridos por una motocicleta y la cantidad de litros de combustible que 
 * consumió en ese recorrido. Mostrar el consumo de combustible por km.
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
            float km, lts, res = 0;

            Console.WriteLine("Ingrese la cantidad de kilometros recorrido");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de combustible consumido");
            lts = float.Parse(Console.ReadLine());

            res = lts / km;

            Console.WriteLine("La cantidad de litros consumidos en cada kilometro fue de: " + res);

            Console.ReadKey();
        }
    }
}
