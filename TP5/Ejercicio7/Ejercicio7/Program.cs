/*
 Crear un programa donde simule que tiene 6 habitaciones las cuales se identifican con un numero(los que se elijan).
 Cuando el usuario ingrese un numero de habitacion deberá mostrar datos ficticios de la habitacion, cuantas camas tiene, precio,
 si dispone de servicio a la habitacón, etc.
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
            int hab;

            Console.WriteLine("Bienvenido, elija entre una de las siguientes habitaciones");
            Console.WriteLine("Habitación 23");
            Console.WriteLine("Habitación 10");
            Console.WriteLine("Habitación 5");
            Console.WriteLine("Habitación 12");
            Console.WriteLine("Habitación 8");
            Console.WriteLine("Habitación 1");
            Console.Write("Opcion: ");
            hab = int.Parse(Console.ReadLine());

            switch (hab)
            {
                case 23: Console.WriteLine("Camas: 2");
                         Console.WriteLine("Servicio al cliente: true");
                         Console.WriteLine("TV: true");
                         Console.WriteLine("WiFi: true");
                         Console.WriteLine("Precio: $5000"); break;
                case 10: Console.WriteLine("Camas: 1");
                         Console.WriteLine("Servicio al cliente: true");
                         Console.WriteLine("TV: true");
                         Console.WriteLine("WiFi: false");
                         Console.WriteLine("Precio: $3000"); break;
                case 5: Console.WriteLine("Camas: 4");
                        Console.WriteLine("Servicio al cliente: true");
                        Console.WriteLine("TV: true");
                        Console.WriteLine("WiFi: true");
                        Console.WriteLine("Precio: $8000"); break;
                case 12: Console.WriteLine("Camas: 1");
                         Console.WriteLine("Servicio al cliente: false");
                         Console.WriteLine("TV: false");
                         Console.WriteLine("WiFi: true");
                         Console.WriteLine("Precio: $2000"); break;
                case 8: Console.WriteLine("Camas: 1");
                        Console.WriteLine("Servicio al cliente: true");
                        Console.WriteLine("TV: true");
                        Console.WriteLine("WiFi: true");
                        Console.WriteLine("Precio: $4000"); break;
                case 1: Console.WriteLine("Camas: 2");
                        Console.WriteLine("Servicio al cliente:  false");
                        Console.WriteLine("TV: true");
                        Console.WriteLine("WiFi: true");
                        Console.WriteLine("Precio: $4000"); break;
                default: Console.Write("Habitación inexistente"); break;
            }
            Console.ReadKey();

        }
    }
}
