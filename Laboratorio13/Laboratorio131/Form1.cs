using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        // Cadena de conexión al servidor SQL Server Express y la base de datos Northwind
        string connectionString =
            @"Server=.\SQLEXPRESS;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        // BOTÓN 1: Conectar a SQL Server
        private void btnConectar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos Northwind.",
                                "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor SQL Server:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BOTÓN 2: Listar productos del catálogo
        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductName FROM [dbo].[Products]";
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        listBox1.Items.Add(lector["ProductName"].ToString());
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar los productos:\n" + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

