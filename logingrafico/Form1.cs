using System;
using System.Data.SqlClient;

namespace logingrafico
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source =.; Initial Catalog=acceso; Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtpassword.Text;

            if (validacionacceso(usuario, contrasena))
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }

           /* if (txtUsuario.Text == "rzorrilla" && txtpassword.Text == "12345")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");

            };*/

        }
        private bool validacionacceso(string usuario, string contrasena)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "SELECT COUNT(1) FROM USUARIOS WHERE USUARIO=@USUARIO AND CONTRASENA=@CONTRASENA";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                { 
                comando.Parameters.Add("@USUARIO", System.Data.SqlDbType.NVarChar).Value = usuario;
                comando.Parameters.Add("@CONTRASENA", System.Data.SqlDbType.NVarChar).Value = contrasena;

                    conexion.Open();

                    int count = (int)comando.ExecuteScalar();

                    return count == 1;
                }
            }
        
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
