using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Interface_homem_maquina
{
    public partial class Cadastro_de_contas_a_pagar : Form
    {
        public Cadastro_de_contas_a_pagar()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_de_contas_a_pagar_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo Salvo!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo Excluído!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo Baixado no computador");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Baixa no Computador Cancelado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo Copiado!");
        }
    }
}
