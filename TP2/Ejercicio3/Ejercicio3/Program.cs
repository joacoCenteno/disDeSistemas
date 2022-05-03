/*
 Escribi un programa que solicite al usuario dos numeros y los alamcene en dos 
 * variables. En otra variable almacena el resultado de la suma de esos dos 
 * numeros y luego muestre el reusltado por pantalla. A continuacion, el programa
 *  debe solicitar al usuaio que ingrese un tercer numero, el cual se debe 
 *  almacenar en una nueva variable. Por ultimo, muestre por pantalla el resultado
 *  de la multiplicacion de este numero por el resultado de la suma anterior
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
            float num1, num2, num3, res = 0;

            Console.WriteLine("Ingrese su primer numero..");
            num1= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo numero...");
            num2 = float.Parse(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("La suma de los numeros es: " + res);

            Console.WriteLine("Ingrese un tercer numero...");
            num3 = float.Parse(Console.ReadLine());
            res = res * num3;

            Console.WriteLine("La multiplicacion de la suma y el ultimo numero es: " + res);

                
        

            Console.ReadKey();
        }
    }
}
