/*
 Crea un programa que pida tres numeros y muestre cual es el mayor de los tres 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;

            Console.Write("Ingrese su primer numero: ");
            num1= int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3) Console.Write("El mayor es " + num1);
            else if (num2 > num1 && num2 > num3) Console.Write("El mayor es " + num2);
            else Console.Write("El mayor es " + num3);

            Console.ReadKey();
        }
    }
}
