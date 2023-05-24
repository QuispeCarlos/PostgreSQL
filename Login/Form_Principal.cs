using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Login
{
    public partial class Form_Principal : Form
    {

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            CargarComboBox_databases();


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
                comboBox_databases.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            CrearBaseDeDatos();
        }

        private void CrearBaseDeDatos()
        {
            Form_CrearBaseDatos formBaseDatos = new Form_CrearBaseDatos();
            formBaseDatos.ShowDialog();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarBaseDatos();
        }

        private void EliminarBaseDatos()
        {
            string baseAEliminar = comboBox_databases.Text;

            DialogResult dr =  MessageBox.Show($"Estas seguro de eliminar las base de datos: {baseAEliminar}?", "Borrar la base?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes)
            {
                try
                {               
                    string str = "server=localhost; port=5432; database=postgres; user id=postgres; password=sa123;";

                    using (NpgsqlConnection connection = new NpgsqlConnection(str))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = $"DROP DATABASE {baseAEliminar}";

                            command.ExecuteNonQuery();

                        }
                        connection.Close();
                    }

                    MessageBox.Show($"La base de datos: {baseAEliminar} a sido eliminada exitosamente");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show($"La base de datos: {baseAEliminar} no ha sido eliminada");
            }

            

        }

        private void button_refrescar_Click(object sender, EventArgs e)
        {
            ActualizarRegistroBases();
        }



        private void ActualizarRegistroBases()
        {
            try
            {
                string str = "server=localhost; port=5432; database=postgres; user id=postgres; password=sa123;";

                using (NpgsqlConnection connection = new NpgsqlConnection(str))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand())
                    {
                        //string sql = "SELECT datname FROM pg_database WHERE datistemplate = false;";
                        comboBox_databases.Items.Clear();
                        CargarComboBox_databases();

                    }
                    connection.Close();
                }

                

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void crearTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CrearTabla crearTabla = new Form_CrearTabla();
            crearTabla.Show();
        }

        private void verTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CrearColumna crearColumna = new Form_CrearColumna();
            crearColumna.Show();
        }

        private void verTodasLasFilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_VerRegistros verRegistros = new Form_VerRegistros();
            verRegistros.Show();
        }
    }

}
