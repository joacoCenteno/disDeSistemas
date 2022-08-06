/*
Pedir un número al usuario y decir si el número es par o impar mediante
un mensaje.
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

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNum.Text) % 2 != 0) lblResult.Text = "El número es impar";
            else lblResult.Text = "El número es par";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum.Focus();
        }
    }
}
