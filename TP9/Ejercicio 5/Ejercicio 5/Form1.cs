/*
Mostrar ls numeros impares del 1 al 100
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 31; i++)
            {
                if (i % 2 != 0) lblUno.Text += " - " + i.ToString();
            }

            for (int i = 31; i <= 59; i++)
            {
                if (i % 2 != 0) lblDos.Text += " - " + i.ToString();
            }

            for (int i = 59; i <= 87; i++)
            {
                if (i % 2 != 0) lblTres.Text += " - " + i.ToString();
            }

            for (int i = 87; i <= 100; i++)
            {
                if (i % 2 != 0) lblCuatro.Text += " - " + i.ToString();
            }
        }
    }
}
