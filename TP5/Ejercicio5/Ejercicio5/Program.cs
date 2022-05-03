/*
 Crear un programa donde ingrese un número del 1 al 12 que representen los meses del año y mostrar por consola a que estaión pertenece
 cierto mes
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;

            Console.Write("Ingrese el número de mes: ");
            val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1: Console.Write("ENERO: Verano"); break;
                case 2: Console.Write("FEBRERO: Verano"); break;
                case 3: Console.Write("MARZO: Verano y Otoño"); break;
                case 4: Console.Write("ABRIL: Otoño"); break;
                case 5: Console.Write("MAYO: Otoño"); break;
                case 6: Console.Write("JUNIO: Otoño e Invierno"); break;
                case 7: Console.Write("JULIO: Invierno"); break;
                case 8: Console.Write("AGOSTO: Invierno"); break;
                case 9: Console.Write("SEPTIEMBRE: Invierno y Primavera"); break;
                case 10: Console.Write("OCTUBRE: Primavera"); break;
                case 11: Console.Write("NOVIEMBRE: Primavera"); break;
                case 12: Console.Write("DICIEMBRE: Primavera y Verano"); break;
                default: Console.Write("Numero de mes inexistente"); break;
            }
            Console.ReadKey();
        }
    }
}
