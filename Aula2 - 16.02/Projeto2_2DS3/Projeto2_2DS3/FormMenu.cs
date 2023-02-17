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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmpregados formEmpregados = new FormEmpregados();
            formEmpregados.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar nosso sistema", "Saída do sistema");
            Application.Exit();
            FormLogin TelaMenu = new FormLogin();
            TelaMenu.ShowDialog();
        }
    }
}
