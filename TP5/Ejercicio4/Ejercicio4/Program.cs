/*
 Crear un programa donde el usuario ingresara por teclado el numero que representa la cantidad de lados de una figura geométrica. Cuando se ingrese dicho numero
 el programa emitirá un mensaje por consola diciendo si es figura o no, si es triangulo, cuadrado o rectángulo, pentágono, hexágono, octágono o no está registrada
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
            int val;

            Console.Write("Ingrese la cantidad de lados: ");
            val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 3: Console.Write("La figura es un triángulo"); break;
                case 4: Console.Write("La figura es un triángulo o un rectángulo"); break;
                case 5: Console.Write("La figura es un pentágono"); break;
                case 6: Console.Write("La figura es un hexágono"); break;
                case 8: Console.Write("La figura es un octágono"); break;
                default: Console.Write("Figura no registrada"); break;
                
            }
            Console.ReadKey();
        }
    }
}
