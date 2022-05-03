/*
 Escribi un programa que solicite ingresar un nombre de usuario y una contraseña. Si el nombre es "epet5" y la contraseña es "escuela"
 mostrar en pantalla "Usuario y Contraseña correctos. Puede ingresar a la escuela". Si el nombre o la contraseña no coinciden, mostrar
 * "Acceso Denegado"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass;

            Console.WriteLine("BIENVENIDO");
            Console.Write("Usario: ");
            user = Console.ReadLine();
            Console.Write("Contraseña: ");
            pass = Console.ReadLine();

            if(user=="epet5" && pass=="escuela") Console.Write("Usuario y Contraseña correctos, puede ingresar a la escuela");
            else Console.Write("Acceso Denegado!");

            Console.ReadKey();
        }
    }
}
