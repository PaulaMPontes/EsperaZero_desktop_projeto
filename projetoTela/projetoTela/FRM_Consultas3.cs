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
    public partial class FRM_Consultas3 : Form
    {
        public FRM_Consultas3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_FilaM fM = new FRM_FilaM();
            fM.Show();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_ConsultarM fm= new FRM_ConsultarM();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_home2 fh2 = new FRM_home2();
            fh2.Show();
        }
    }
}
