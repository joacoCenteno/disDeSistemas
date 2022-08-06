/*
Pedir dos números al usuario y mostrar que número es el mayor mediante
 * un mensaje.
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

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int may = int.Parse(txtNum1.Text);

            if (int.Parse(txtNum2.Text) > may) may = int.Parse(txtNum2.Text);

            lblMostrar.Text = "El número mayor es: " + may.ToString();
        }
    }
}
