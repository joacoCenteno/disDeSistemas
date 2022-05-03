/*
Crea un programa que pida al usaurio dos numeros enteros y diga si son iguales o, en caso contrario, cual es el mayor de ellos
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Ingrese su primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2) Console.Write("Los dos numeros son iguales");
            else if (num1 > num2) Console.Write("El mayor es " + num1);
            else Console.Write("El mayor es: " + num2);

            Console.ReadKey();
        }
    }
}
