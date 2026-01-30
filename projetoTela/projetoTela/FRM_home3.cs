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
    public partial class FRM_home3 : Form
    {
        public FRM_home3()
        {
            InitializeComponent();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cads2 c2 = new Cads2();
            c2.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Consultas2 fc2 = new FRM_Consultas2();
            fc2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
