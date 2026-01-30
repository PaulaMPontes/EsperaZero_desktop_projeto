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
    public partial class CadastrarPaciente2 : Form
    {
        public CadastrarPaciente2()
        {
            InitializeComponent();
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
            
                FRM_home3 h3 = new FRM_home3();
                h3.Show();
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
            FRM_home3 h3 = new FRM_home3();
            h3.Show();
        }

        private void mtxt_cpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

