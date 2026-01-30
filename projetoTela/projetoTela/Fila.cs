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
    public partial class Fila : Form
    {
        ClasseFIla CF = new ClasseFIla();
        public Fila(string cpf)
        {
            InitializeComponent();
            lbl_nome.Text = cpf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_home3 h3 = new FRM_home3();
            h3.Show();
        
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fila_Load(object sender, EventArgs e)
        {
            

        }

        private void Fila_Load_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            ClasseFIla CF = new ClasseFIla();
            ClassFilaHome CFH = new ClassFilaHome();
            string nome;
            string numf = "0";
            int numero;


            nome = lbl_nome.Text;
            //numero = int.Parse(lbl_pos.Text);


            //CFH.Posicao = numero;
            CFH.Cpf = nome;

            //CFH.ConsultarPosicao();
            // CFH.ConsultarNome();


            lbl_nome.Text = CFH.Cpf.ToString();
            dt = CFH.ConsultarPosicao();
         numf = dt.Rows[0].ItemArray[1].ToString();

            //lbl_pos.Text = CFH.Cpf.ToString();
            //dt = CFH.ConsultarNome();
            //numf = dt.Rows[0].ItemArray[3].ToString();


            //lbl_pos2.Text = CFH.Cpf.ToString();
            //dt = CFH.ConsultarNome();
            //numf = dt.Rows[0].ItemArray[3].ToString();


            lbl_pos.Text = numf.ToString();
            lbl_pos2.Text = numf.ToString();



        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pos2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
