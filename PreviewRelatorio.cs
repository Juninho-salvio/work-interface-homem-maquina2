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
    public partial class PreviewRelatorio : Form
    {
        public PreviewRelatorio()
        {
            InitializeComponent();
        }

        private void PreviewRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
