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
    public partial class FormEmpregados : Form
    {
        public FormEmpregados()
        {
            InitializeComponent();
        }

        private void lblNomeFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(textNomeFuncionario.Text == "" || textAnoNasc.Text == "" || textCargo.Text == "")
            {
                MessageBox.Show("Erro. Preencha todos os campos obrigatórios.");
            }
            else
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
                string[] funcionarios = new string[3];

                Close();
            }
            
        }

        private void textNomeFuncionario_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
