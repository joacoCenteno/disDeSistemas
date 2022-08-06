using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        //declaramos objeto
        Clases.Cuenta obj = new Clases.Cuenta();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            obj.Titular = txtTitular.Text;

            lblMostrar.Text = obj.Mostrar();

            //Verificando el valor de la propiedad Cantidad
            if (obj.Cantidad > 0) lblCantidad.ForeColor = Color.Green;
            else if (obj.Cantidad == 0) lblCantidad.ForeColor = Color.Gray;
            else lblCantidad.ForeColor = Color.Red;

            lblCantidad.Text = "Cantidad: $" + obj.Cantidad;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //todo cancelado
            txtTitular.Focus();
            btnMostrar.Enabled = false;
            txtRetirar.Enabled = false;
            txtIngresar.Enabled = false;
 
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            //verificando si el txtTitular tiene caracteres en el para habilitar las opciones
            if (txtTitular.Text.Length > 0)
            {
                btnMostrar.Enabled = true;
                txtIngresar.Enabled = true;
                txtRetirar.Enabled = true;
            }
            else
            {
                btnMostrar.Enabled = false;
                txtIngresar.Enabled = false;
                txtRetirar.Enabled = false;
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Preionando el boton se llama al metodo Ingresar que aumenta el valor de la propiedad Cantidad
           obj.Ingresar(double.Parse(txtIngresar.Text));
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Preionando el boton llama al Metodo Reitrar que le quita valor a la propiedad Cantidad
            obj.Retirar(double.Parse(txtRetirar.Text));
        }
    }
}
