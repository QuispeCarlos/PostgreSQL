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
    }
}
