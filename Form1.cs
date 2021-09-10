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
    public partial class Menu : Form
    {
        Thread nt;

        public Menu()
        {

            InitializeComponent();
        }

        private void bt_Inicio_Click(object sender, EventArgs e)
        {
            if( textBox1.Text=="SOS" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else 
            {
                MessageBox.Show("Login ou Senha inválido!");
            }
          
        }

        private void novoform()
        {
            Application.Run(new Form2());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
