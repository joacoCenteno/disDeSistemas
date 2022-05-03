/*
 Escribi un programa que solicite al usuario el ingreso de una fecha formada por 8 numeros, dond elos primeros dos repesenten los dias
 los siguientes dos el mes y los utlimos cuatro el año (DD/MM/AAA)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fecha, dia, mes, año;

            Console.Write("Ingrese su numero: ");
            fecha = int.Parse(Console.ReadLine());

            dia = fecha / 1000000;
            mes = fecha % 1000000;
            mes = mes / 10000;
            año = fecha / 1000;
            año = fecha % 10000;

            Console.Write("fecha: "+dia+"/"+mes+"/"+año);

            Console.ReadKey();

        }
    }
}
