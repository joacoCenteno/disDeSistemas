/*
 Crea un programa que pida al usuario su codigo de usuario (un string) y su contraseña númerica (un entero), el usuario y la contraseña
 correcta son epet52022 y 4567, al no ingresar el usuario o la contraseña correctas deberá dar aviso con un mensaje para que el usaurio 
 corrija el error. Al introducir el usuario y la contraseña correctas emitir un mensaje que haga mencion que se introdujo correctamente
 y saldrá del programa. El usuario solo tendrá 3 oportunidades, cumplidas las 3 oportunidades deberá emitir un mensaje dando aviso
 y deberá salir del programa
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
            string user;
            int pass, i=3;


            do
            {
                Console.Write("Ingrese su usuario: "); user= Console.ReadLine();
                Console.Write("Ingrese su contraseña: "); pass = int.Parse(Console.ReadLine());

                if (user != "epet52022" || pass != 4567)
                {
                    i--;
                    Console.WriteLine("Inicio de sesión incorrecta");
                    Console.WriteLine("Te quedan " + i + " intentos");
                }

            } while ((user != "epet52022" || pass != 4567) && i != 0);


            if (i!=0)
            {
                Console.WriteLine("Inicio de sesión correcta!");
                Console.WriteLine("DISFRUTE SU ESTADÍA :D");
            }
            else
            {
               Console.WriteLine("Inicio de sesión fallida"); Console.WriteLine("INTENTÉLO NUEVAMENTE"); 
            }
            

            Console.ReadKey();

        }
    }
}
