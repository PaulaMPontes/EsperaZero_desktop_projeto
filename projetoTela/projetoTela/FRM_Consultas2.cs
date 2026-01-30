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
    public partial class FRM_Consultas2 : Form
    {
        public FRM_Consultas2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_home3 fh3 = new FRM_home3();
            this.Hide();
            fh3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_FilaP fp = new FRM_FilaP();
            
            fp.Show();

        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
          
        }

        private void FRM_Consultas2_Load(object sender, EventArgs e)
        {

        }
    }
}
