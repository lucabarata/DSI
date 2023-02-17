using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2_2DS3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Luca" && int.Parse(textSenha.Text) == 1234)
            {
                FormMenu TelaPrincipal = new FormMenu();
                TelaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos");
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
