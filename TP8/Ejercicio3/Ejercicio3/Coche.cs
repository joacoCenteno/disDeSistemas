using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Coche
    {
        private string marca;
        private string modelo;
        private byte cilindrada;
        private double potencia;

        

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public byte Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public double Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
    }
}
