using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Interface_homem_maquina
{
    public partial class Fornecedor : Form
    {

        Thread nt;

        public Fornecedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nt = new Thread(Cadastro_Fornecedor);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cadastro_Fornecedor()
        {
            Application.Run(new Cadastro_Fornecedor_2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisa concluida!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clientes Cadastrados com Sucesso.");
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
