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
    public partial class Form_CrearTabla : Form
    {
        public Form_CrearTabla()
        {
            InitializeComponent();
        }

        private void Form_CrearTabla_Load(object sender, EventArgs e)
        {
            CargarComboBox_databases();
            //CargarComboBox_tablasCreadas();
        }

        

        private void CargarComboBox_databases()
        {
            string str = "server=localhost; port=5432; database=postgres; user id=postgres;password=sa123;";
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = str;
            cn.Open();


            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT datname FROM pg_database WHERE datistemplate = false;";
            cmd.Connection = cn;

            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_bd.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void CargarComboBox_tablasCreadas()
        {
            string baseSeleccionada = comboBox_bd.Text;

            string str = $"server=localhost; port=5432; database={baseSeleccionada}; user id=postgres; password=sa123;";
            string consulta = $"SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_catalog = '{baseSeleccionada}'; ";

            // crear el comando para ejecutar la consulta
            using (NpgsqlConnection connection = new NpgsqlConnection(str))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando para ejecutar la consulta
                using (NpgsqlCommand command = new NpgsqlCommand(consulta, connection))
                {
                    // Ejecutar la consulta y obtener el lector de datos
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpiar el ComboBox antes de cargar las tablas
                        comboBox_tablas.Items.Clear();

                        // Agregar los nombres de las tablas al ComboBox
                        while (reader.Read())
                        {
                            string nombreTabla = reader.GetString(0);
                            comboBox_tablas.Items.Add(nombreTabla);
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();
            }
        }


        private void button_crear_Click(object sender, EventArgs e)
        {
            CrearNuevaTabla();
        }

        private void CrearNuevaTabla()
        {
            string nombreTabla = textBox_nombreTabla.Text;
            string baseSeleccionada = comboBox_bd.Text;

            try
            {

                string str = $"server=localhost; port=5432; database={baseSeleccionada}; user id=postgres; password=sa123;";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"CREATE TABLE {nombreTabla}();";

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
                MessageBox.Show($"La tabla {nombreTabla} a sido creada exitosamente");
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            this.Close();
        }
    }
}
