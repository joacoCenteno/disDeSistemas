using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        Clases.Libro obj = new Clases.Libro();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            obj.Nombre = txtNombre.Text;
            obj.Autor = txtAutor.Text;
            obj.Editorial = txtEditorial.Text;
            obj.Precio = double.Parse(txtPrecio.Text);

            lblMostrar.Text = obj.Mostrar();
            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            txtNombre.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtPrecio.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            obj.Nombre = txtNombre.Text;
            lblMostrar.Text = "Nombre: " + obj.Nombre;
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            obj.Autor = txtAutor.Text;
            lblMostrar.Text = "Autor: " + obj.Autor;
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            obj.Editorial = txtEditorial.Text;
            lblMostrar.Text = "Editorial: " + obj.Editorial;
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            obj.Precio = double.Parse(txtPrecio.Text);
            lblMostrar.Text = "Precio: $" + obj.Precio;
        }
    }
}
