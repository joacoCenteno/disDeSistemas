/*
 Escribir un programa que solicite al usuario ingresar un numero con decimales
 * y alamacenalo en una variable. A continuacion el programa debe solicitar al 
 * usuario que ingrese un numero entero y guardarlo en otra variable. En una 
 * tercer variable se deberá guardar el resultado de la suma de los dos numeros
 * ingresados por el usuario. Poe ultimo se debe mostrar en pantalla el texto
 * "El resultado de la suma es [suma]", donde [suma] se reemplazara por el 
 * resultado de la operación
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
            float num1, res=0;
            int num2;
            

            Console.WriteLine("Ingrese su numero decimal");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su numero entero");
            num2 = int.Parse(Console.ReadLine());

            res = num1+num2;
            
            Console.WriteLine("El resultado de la suma es: " + res);

            Console.ReadKey();
        }
    }
}
