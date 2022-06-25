using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        private string nombre;

        public void SETNombre(string nom)
        {
            this.nombre = nom;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy {0}",this.nombre);
        }


    }
}
