using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Work_Interface_homem_maquina
{
    public partial class Contas_a_pagar : Form
    {
        Thread nt;


        public Contas_a_pagar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisa concluida!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apresentação dos Relatorio");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nt = new Thread(Cadastro_conta_pagar);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Cadastro_conta_pagar()
        {
            Application.Run(new Cadastro_de_contas_a_pagar());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo em Aberto!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contas Pagas!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apresentação de todos!");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
