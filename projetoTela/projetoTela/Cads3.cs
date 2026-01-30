using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTela
{
    public partial class Cads3 : Form
    {
        public Cads3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             FRMCadastrarU2 fcu2 = new FRMCadastrarU2();
            fcu2.Show();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
           FRMCadastrarP2 fcp2   = new FRMCadastrarP2();
            fcp2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
