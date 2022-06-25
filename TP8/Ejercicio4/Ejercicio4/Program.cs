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
            Persona obj1 = new Persona();

            
            obj1.Nombre = "Juan";
            obj1.Edad = 13;
            obj1.generaDNI();
            obj1.Sexo = 'M';
            obj1.Peso = 70;
            obj1.Altura = 1.80;
            
            obj1.toString();
            Console.WriteLine("Mayor de Edad: {0}",obj1.esMayorDeEdad());
            Console.WriteLine("IMC: {0}",obj1.calcularIMC());
            

            Console.ReadKey();
        }
    }
}
