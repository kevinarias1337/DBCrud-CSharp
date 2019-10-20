using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplicacionMVC
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=SALA403-7\\SQLEXPRESS; database=dbempresa; integrated security=true;");

        public Form1()
        {
            InitializeComponent();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO empleado(cedula,nombre,apellido,nacimiento,cargo) VALUES (@cedula,@nombre,@apellido,@nacimiento,@cargo)";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue(@"cedula", txtcedula.Text);
            comando.Parameters.AddWithValue(@"nombre", txtnombre.Text);
            comando.Parameters.AddWithValue(@"apellido", txtapellido.Text);
            comando.Parameters.AddWithValue(@"nacimiento", txtnacimiento.Text);
            comando.Parameters.AddWithValue(@"cargo", txtcargo.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Empleado registrado correctamente.");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM empleado WHERE cedula=@cedula";
            
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@cedula", txtcedula.Text);
            comando.ExecuteNonQuery();
            
            MessageBox.Show("Empleado eliminado correctamente.");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM empleado", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dbempresa.DataSource = tabla;
            
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Se ha conectado con la base de datos exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Conectese a la base de datos.");
        }
    }
}
