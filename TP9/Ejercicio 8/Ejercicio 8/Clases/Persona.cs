using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8.Clases
{
    class Persona
    {
        /*Atributos*/
        private string nombre;
        private int edad;
        private string DNI;


        /*Constructor*/
        public Persona()
        {
        }

        public Persona(string nombre, int edad, string DNI)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
        }

        /*Getters y Setters*/
        public string Nombre
        {
              get { return nombre; }
              set { nombre = value; }
        }


        public int Edad
        {
             get { return edad; }
             set { edad = value; }
        }


        public string DNI1
        {
          get { return DNI; }
          set { DNI = value; }
        }

        public string Mostrar()
        {
            return "Nombre: " + this.nombre + "     Edad: " + this.edad +
                "   DNI: " + this.DNI;
        }

        public bool esMayorDeEdad()
        {
            if (this.edad >= 18) return true;
            else return false;
        }

        public void Reiniciar()
        {
            this.nombre = " ";
            this.edad = 0;
            this.DNI = " ";
        }


    }
}
