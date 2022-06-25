using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Persona
    {
        private string nombre = " ";
        private byte edad = 0;
        private string DNI;
        private char sexo = 'M';
        private double peso = 0;
        private double altura = 0;

        //Constructores
        public Persona()
        {
        }

        public Persona(string nombre, byte edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, byte edad,string DNI, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;    
        }
 
        //Metodos SET
        public string Nombre
                {
                    set { nombre = value; }
                }

        public byte Edad
                {
                    set { edad = value; }
                }

        public char Sexo
                {
                    set { sexo = value; }
                }

        public double Peso
                {
                    set { peso = value; }
                }

        public double Altura
                {
                    set { altura = value; }
                }

        


        //Metodo IMC
        public double calcularIMC()
        {
            double calc;
            calc = this.peso / (this.altura * this.altura);
            if (calc < 20) return -1;
            else if (calc >= 20 && calc <= 25) return 0;
            else return 1;
            
        }



        //Metodo de mayor de edad
        public bool esMayorDeEdad()
        {
            if (this.edad < 18) return false;
            else return true;
        }



        //Metodo de comprobacion de sexo
        private void comprobarSexo(char sexo)
        {
            if ((sexo != 'M' && sexo != 'F') && sexo != 'F') this.sexo = 'M';
        }



        //Metodo de informacion general
        public void toString()
        {
            Console.WriteLine("INFORMACION");
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Edad: {0}", this.edad);
            Console.WriteLine("DNI: {0}", this.DNI);
            Console.WriteLine("Sexo: {0}", this.sexo);
            Console.WriteLine("Peso: {0}", this.peso);
            Console.WriteLine("Peso: {0}", this.altura);
            
        }



        //Metodo de generacion de DNI
        public void generaDNI()
        {
            Random aleatorio = new Random();
            string dni = "" ;

            for (int i = 0; i <= 7; i++)
            {
                dni = dni + aleatorio.Next(9);
            }

            this.DNI = dni;
        }
  
        

    }
}
