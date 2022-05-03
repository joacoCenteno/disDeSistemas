/*
Escribi un programa que solicite al suario ingresar tres numeros para luego mostrar
el promedio de los tres
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
            float num1,num2,num3, res=0;

            Console.WriteLine("Ingrese 3 numeros...");
            num1= float.Parse(Console.ReadLine());
            num2= float.Parse(Console.ReadLine());
            num3= float.Parse(Console.ReadLine());

            res = num1 + num2 + num3;
            res = res / 3;

            Console.WriteLine("El promedio de los numeros es: " + res);

            Console.ReadKey();

        }
    }
}
