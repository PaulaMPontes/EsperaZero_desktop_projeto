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
    public partial class FRM_home2 : Form
    {
        public FRM_home2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Triagem tri = new Triagem();
            tri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Médico2 FM = new FRM_Médico2();
            FM.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Consultas3 fh3 = new FRM_Consultas3();
            fh3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Medicamentos2 frm2 = new FRM_Medicamentos2();
            frm2.Show();
            
        }
    }
}
