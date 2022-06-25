/*
 Crea una clase llamada Persona, en el fichero "Persaona.cs". Esta clase deberá tene un artibuto "nombre", de tipo string. Tambien deberá
 tener un método "SetNombre", de tipo void y con un parametro string, que permita cambiar el valor del nombre. Finalmente tambien tendrá
 un método "Saludar", que escribirá en pantalla "Hola soy" seguido de su nombre. Desde el programa principal de la función Main, creará dos objetos
 * de tipo Persona, le asignará un nombre a cada uno y les pedirá que saluden.
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
            Persona obj1= new Persona();
            Persona obj2 = new Persona();

            Console.WriteLine("Ingrese dos nombres: ");
            obj1.SETNombre(Console.ReadLine());
            obj1.Saludar();
            obj2.SETNombre(Console.ReadLine());
            obj2.Saludar();

            Console.ReadKey();
        }
    }
}
