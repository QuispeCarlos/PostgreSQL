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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        private void Conectar()
        {
            string password = textBox_password.Text;

            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.EstablecerConexion(password);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void CerrarVentana()
        {
            this.Close();
        }
    }
}
