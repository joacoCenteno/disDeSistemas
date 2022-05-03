/*
 Crea un programa que simule una calculadora muy rudimentaria. El usuario deberá ingresar dos numeros, despues de ingresar,
 los numeros deberá ingresar un operador matemático (+, -, *, /, %). El programa deberá devolver el resultado de operar
 entre los números y el operador ingresado acompañado de un mensaje adecuado.
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
            float num1, num2, res=0;
            char op;

            Console.Write("Ingrese su primer número: "); num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo número: "); num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Operación a realizar?... + Suma - Resta * Multipliación / División % Resto");
            Console.Write("Opcion: "); op = char.Parse(Console.ReadLine());

            

            switch (op)
            {
                case '+': res= num1 + num2;
                         Console.Write("El resultado de " + num1 + "+" + num2 + " es: " + res); break;
                case '-': res = num1 - num2;
                         Console.Write("El resultado de " + num1 + "-" + num2 + " es: " + res); break;
                case '*': res = num1 * num2;
                          Console.Write("El resultado de " + num1 + "*" + num2 + " es: " +res); break;
                case '/': res = num1 / num2;
                          Console.Write("El resultado de " + num1 + "/" + num2 + " es: " + res); break;
                case '%': res = num1 % num2;
                          Console.Write("El resultado de " + num1 + "%" + num2 + " es: " + res); break;
                default: Console.Write("Operacion inexistente"); break;
            }
            Console.ReadKey();
        }
    }
}
