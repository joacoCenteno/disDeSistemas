/*
Escribi un programa que solicite el ingreso de 3 numeros y mostrar en pantalla el menor de los 3
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
            int n1, n2, n3;

            Console.WriteLine("Ingrese sus tres numeros...");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if(n1<n2 && n1<n3) Console.Write("El menor es: "+n1);
            else if(n2<n1 && n2<n3) Console.Write("El menor es: "+n2);
            else if(n3<n1 && n3<n2) Console.Write("El menor es: "+n3);
            else Console.Write("Los numeros ingresados son iguales");

            Console.ReadKey();


        }
    }
}
