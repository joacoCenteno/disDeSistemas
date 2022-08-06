/*
Pedir el nombre de un dia al usuario y decirle si es fin de semana
o no. En caso de error, indicarlo.
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

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDia.Focus();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtDia.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string dia = txtDia.Text;

            switch (dia)
            {
                case "Lunes":
                case "Martes":
                case "Miercoles":
                case "Jueves":
                case "Viernes": lblResult.Text = "No ingresó un dia de fin de semana"; break;
                case "Sabado":
                case "Domingo": lblResult.Text = "Ingresó un día de fin de semana"; break;
                default: lblResult.Text = "Por favor ingrese su dia correctamente"; break ;
            }
        }
    }
}
