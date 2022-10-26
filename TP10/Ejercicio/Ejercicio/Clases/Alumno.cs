using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    class Alumno
    {
        private int legajo;
        private string apellido;
        private string nombre;
        private string fecha_nacimiento;

        public Alumno()
        {
        }


        public Alumno(int legajo, string apellido, string nombre, string fecha_nacimiento)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
            this.fecha_nacimiento = fecha_nacimiento;
        }


        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
    }
}
