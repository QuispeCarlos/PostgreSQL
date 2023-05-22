using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form_CrearBaseDatos : Form
    {
        public Form_CrearBaseDatos()
        {
            InitializeComponent();
        }

        private void Form_CrearBaseDatos_Load(object sender, EventArgs e)
        {
            
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            CrearNuevaBaseDatos();
        }

        private void CrearNuevaBaseDatos()
        {

            try
            {
                string nombreBase = textBox_nombreBaseDatos.Text;

                string str = "server=localhost; port=5432; database=postgres; user id=postgres; password=sa123;";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"CREATE DATABASE {nombreBase}";

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
