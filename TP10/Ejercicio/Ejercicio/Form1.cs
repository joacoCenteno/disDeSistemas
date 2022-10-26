using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        Clases.Alumno alumno = new Clases.Alumno();
        List<Clases.Alumno> listAlumno = new List<Clases.Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            alumno.Legajo = aleatorio.Next(1000, 9999);
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.Fecha_nacimiento = dtFecha.Value.ToString("dd/MM/yyyy");

            listAlumno.Add(alumno);

            txtNombre.Text = "";
            txtApellido.Text = "";
            dtFecha.Value = DateTime.Now;

            txtApellido.Focus();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            foreach (var datos in listAlumno)
            {
                dgAlumnos.Rows.Add(datos.Legajo, datos.Apellido, datos.Nombre, datos.Fecha_nacimiento);
            }

            listAlumno.Remove(alumno);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgAlumnos.Rows.Remove(dgAlumnos.CurrentRow);
        }

        private void dgAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string apellido = this.dgAlumnos.SelectedRows[0].Cells[1].Value.ToString();
            string nombre = this.dgAlumnos.SelectedRows[0].Cells[2].Value.ToString();
            string fecha = this.dgAlumnos.SelectedRows[0].Cells[3].Value.ToString();

            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            dtFecha.Value = DateTime.Parse(fecha);
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=proy_sistemas;Uid=root;Pwd=;";

            String legajo = dgAlumnos.CurrentRow.Cells[0].Value.ToString();
            String apellido = dgAlumnos.CurrentRow.Cells[1].Value.ToString(); 
            String nombre = dgAlumnos.CurrentRow.Cells[2].Value.ToString();
            String fecha_nacimiento = dgAlumnos.CurrentRow.Cells[3].Value.ToString(); 

            string sql = "INSERT INTO alumnos (id, legajo, nombre, apellido, fecha_nacimiento) VALUES (DEFAULT,'"+legajo+"','"+nombre+"','"+apellido+"','"+fecha_nacimiento +"');";

            MySqlConnection conexion = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            try
            {
                conexion.Open();

                int res = comando.ExecuteNonQuery();
                MessageBox.Show("Registro Insertado en la BD :" + res);

                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
            finally 
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    comando.Dispose();
                }
            }
        }
    }
}
