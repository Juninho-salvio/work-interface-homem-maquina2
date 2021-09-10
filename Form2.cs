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
    public partial class Form2 : Form
    {

        Thread nt;

        public Form2()
        {
            InitializeComponent();
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            nt = new Thread(Cadastro_Fornecedor);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
            nt = new Thread(Contas_a_pagar);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void ribbonPanel3_Click(object sender, EventArgs e)
        {
            nt = new Thread(Relatorio_contas_a_pagar);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Cadastro_Fornecedor()
        {
            Application.Run(new Fornecedor());
        }

        private void Contas_a_pagar()
        {
            Application.Run(new Contas_a_pagar());
        }

        private void Relatorio_contas_a_pagar()
        {
            Application.Run(new Relatorio_de_Contas_a_pagar());
        }

    }
}
