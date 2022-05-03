/*
Crea un programa que pida al usuario dos numeros enteros y diga "Uno de los números positivos", "Los dos numeros son positivos" o bine
 "Ninguno de los numeros es positivo", segun corresponda
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;

            Console.Write("Ingrese su primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > 0 && num2 > 0) Console.Write("Los dos numeros son positivos");
            else if (num1 > 0 || num2 > 0) Console.Write("Uno de los numeros es positivo");
            else Console.Write("Ninguno de los numeros es positivo");

            Console.ReadKey();

        }
    }
}
