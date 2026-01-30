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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // Fila lg = new Fila(mtxt_cpf.Text);
          //  lg.Show();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Paciente pac = new Paciente();
            string nomec, nomeu, end, cep, estado, cpf, cartao, tel, email, senha;

            nomec = txt_nomec.Text;
            nomeu = txt_nomeu.Text;
            estado = cmb_estado.Text;
            end = txt_end.Text;
            email = txt_em.Text;
            senha = txt_senha.Text;
            tel = mtxt_tel.Text;
            cpf = mtxt_cpf.Text;
            cartao = m_csus.Text;
            cep = txt_cep.Text;

          try
           {
                pac.Nomecomp_pac = nomec;
                pac.Nomeusu_pac = nomeu;
                pac.Estado_pac = estado;
                pac.Endereco_pac = end;
                pac.Email_pac = email;
                pac.Senha_pac = senha;
                pac.Telefone_pac = tel;
                pac.Cpf_pac = cpf;
                pac.Csus_pac = cartao;
                pac.Cep_pac = cep;
                pac.Cidade_pac = cep;
                pac.Inserir();

       
             MessageBox.Show("Dados inseridos com sucesso!!!");
                this.Hide();
                FRM_home3 fh3 = new FRM_home3();
                fh3.Show();
          }
           catch (Exception)
           {
              MessageBox.Show("Erro ao gravar no banco de dados");

          }
       }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cads cad = new Cads();
            cad.Show();
        }

        private void m_csus_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void mtxt_tel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_em_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nomeu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nomec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
