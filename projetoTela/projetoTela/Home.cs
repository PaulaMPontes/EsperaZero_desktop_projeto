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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fila f = new Fila(label1.Text);
            f.Show();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cads cd = new Cads();
            cd.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas con = new Consultas();
            con.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fila f = new Fila(label1.Text);
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Filau fu = new Filau();
            fu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Triagem tri = new Triagem();
            tri.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Opcoes op = new Opcoes();
            op.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Medicamento med = new FRM_Medicamento();
            med.Show();
        }
    }
}
