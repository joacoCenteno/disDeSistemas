/*Crear un programa donde el usuario ingrese dos numeros (a y b), el mismo deberá
 * mostrar el resultado de las operaciones (a+b)*(a-b) y el resultado de la operación
 * a^2-b^
 * */


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
            float num1, num2, op1 = 0, op2 = 0;

            Console.WriteLine("Ingrese sus dos numeros: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());

            op1 = (num1 + num2) * (num1 - num2);
            op2 = (num1*num1) - (num2*num2);

            Console.WriteLine("El resultado de la primera operacion es: " + op1);
            Console.WriteLine("El resultado de la segunda operacion es: " + op2);

            Console.ReadKey();
        }
    }
}
