/*
 Escribi un programa que solicite al usaurio que ingrese a cuantos shows musicales
 ha visto en el ultimo año y almacene ese numero en una variable. A continuacion
 mostrar por pantalla el valor de verdad (true o false) que inidque si el usuario
 * ha visto mas de 3 shows
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
            float a;
            bool b;

            Console.WriteLine("Cuantos shows viste en el ultimo año?");
            a = float.Parse(Console.ReadLine());

            if (a > 3)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            Console.WriteLine("Usted vio mas de 3 shows el utlimo año?, pues " + b);
            Console.ReadKey();
        }
    }
}
