/*
 Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra
 de la siguiente con un espacio. Ej Juan --- J u a n
 
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

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            lblResultado.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            foreach (char item in nombre)
            {
                lblResultado.Text += item.ToString() + " ";
            }

           

        }
    }
}
