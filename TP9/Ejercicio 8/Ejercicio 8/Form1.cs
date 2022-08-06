using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {

        Clases.Persona obj = new Clases.Persona();
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            obj.Nombre = txtNombre.Text;
            obj.Edad = int.Parse(txtEdad.Text);
            obj.DNI1 = txtDNI.Text;

            lblInfo.Text = obj.Mostrar();
            
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            obj.Edad = int.Parse(txtEdad.Text);

            if (obj.esMayorDeEdad()) lblEdad.Text = "Es mayor de edad";
            else lblEdad.Text = "Es menor de edad";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDNI.Text = "";
            obj.Reiniciar();
            lblEdad.Text = "";
            lblInfo.Text = "";
        }
    }
}
