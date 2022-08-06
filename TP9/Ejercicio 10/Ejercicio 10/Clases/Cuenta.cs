using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10.Clases
{
    class Cuenta
    {
        //Propiedades
        private string titular = "";
        private double cantidad = 0;

        //Constructor
        public Cuenta()
        {
        }

        //Getters y Setters
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

         public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //Metodos
         public string Mostrar()
         {
             return "DATOS DE CUENTA__ Titular: " + this.titular; 
         }

         public void Ingresar(double cantidad)
         {
             if (cantidad > 0) this.cantidad += cantidad;
             else this.cantidad += 0;
         }

         public void Retirar(double cantidad)
         {
             if (cantidad > 0) this.cantidad -= cantidad;
             else this.cantidad -= 0;
         }

    }
}
