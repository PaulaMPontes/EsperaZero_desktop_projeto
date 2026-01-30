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
    public partial class Cads2 : Form
    {
        public Cads2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_home3 h3 = new FRM_home3();
            h3.Show();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarPaciente2 cd2 = new CadastrarPaciente2();
            cd2.Show();

        }
    }
}
 