/*
 Crear un programa que ingrese numeros del 1 al 6 y muestre el dia de la semana correspondiente
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
            int val;

            Console.Write("Ingrese su número de día de semana: ");
            val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1: Console.Write("Día Domingo"); break;
                case 2: Console.Write("Día Lunes"); break;
                case 3: Console.Write("Día Martes"); break;
                case 4: Console.Write("Día Miercoles"); break;
                case 5: Console.Write("Día Jueves"); break;
                case 6: Console.Write("Día Viernes"); break;
                case 7: Console.Write("Día Sábado"); break;
                default: Console.Write("Día de semana inexistente"); break;
            }
            Console.ReadKey();
        }
    }
}
