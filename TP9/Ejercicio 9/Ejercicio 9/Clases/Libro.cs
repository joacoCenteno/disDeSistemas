using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9.Clases
{
    class Libro
    {
        //Propiedades
        private string nombre= "";
        private string autor = "";
        private string editorial = "";
        private double precio = 0;

       
        //Constructor
        public Libro()
        {
        }

        //Getters y Setters
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //Metodos
        public string Mostrar()
        {
            return "Nombre: " + this.nombre + "  Autor: " + this.autor + "  Editorial: " + this.editorial + "  Precio: $" + this.precio;
        }

        public void Reiniciar()
        {
            this.nombre = "";
            this.autor = "";
            this.editorial = "";
            this.precio = 0;
        }

    }
}
