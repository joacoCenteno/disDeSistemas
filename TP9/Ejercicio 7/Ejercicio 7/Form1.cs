/*
Escriba un programa donde ingrese el Apellido y Nombre en ese orden
 y todo junto. El ususario al presionar un botón deberá mostrar el apellido
 y el nombre por separado. Además deberámostrar cuantos caracteres tiene
 el apellido y el nombre
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

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = txtPrincipal.Text;
            int index = texto.IndexOf(" ");

            string apellido = texto.Substring(0, index);
            string nombre = texto.Substring(index, texto.Length - apellido.Length).Trim();

            lblNombre.Text = "Nombre: " + nombre + ". Tiene " + nombre.Length + " caracteres.";
            lblApellido.Text = "Nombre: " + apellido + ". Tiene " + apellido.Length + " caracteres.";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrincipal.Focus();
        }
    }
}
