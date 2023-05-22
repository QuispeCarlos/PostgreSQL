using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Login.Clases
{
    class CConexion
    {
        public NpgsqlConnection EstablecerConexion(string _password)
        {

            NpgsqlConnection conex = new NpgsqlConnection();
            string servidor = "localhost";
            string baseDatos = "postgres";
            string usuario = "postgres";
            //string password = "sa123";
            string puerto = "5432";

            String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "database=" + baseDatos + ";" +
                "user id=" + usuario + ";" + "password=" + _password + ";";

            //host=localhost port=5432 dbname=postgres user=postgres password=xxxxxxx sslmode=prefer connect_timeout=10


            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");

                Form_Principal formPrincipal = new Form_Principal();
                formPrincipal.ShowDialog();

                conex.Close();

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + e.ToString());
            }
            return conex;
        }
    }
}
