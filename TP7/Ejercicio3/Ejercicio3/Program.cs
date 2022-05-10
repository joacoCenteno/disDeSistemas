/*
 Escribir un porgrama que pida al usuario un numero entero y muestre or pantalla un triangulo rectangulo, de altura el 
 numero introducido
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
            int num;
            string l="*";

            Console.Write("Ingrese la altura de su triangulo rectangulo: "); num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(l);
                l+="*";
                
            }
         
            Console.ReadKey();
        }
    }
}
