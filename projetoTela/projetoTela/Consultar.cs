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
    public partial class Consultar : Form
    {
        Paciente pac = new Paciente();

        public Consultar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (r_csus.Checked)
            {
                pac.Csus_pac = txt_consulta.Text;
                dgv_paciente.DataSource = pac.ConsultarCartao();
                dgv_paciente.Columns["id_paciente"].HeaderText = "ID";
                dgv_paciente.Columns["nomecomp_paciente"].HeaderText = "Nome Completo";
                dgv_paciente.Columns["nomeusu_paciente"].HeaderText = "Nome de Usuário";
                dgv_paciente.Columns["cpf_paciente"].HeaderText = "CPF";
                dgv_paciente.Columns["cartao_paciente"].HeaderText = "Cartão SUS";
                dgv_paciente.Columns["endereco_paciente"].HeaderText = "Endereço";
                dgv_paciente.Columns["cep_paciente"].HeaderText = "CEP";
                dgv_paciente.Columns["cidade_paciente"].HeaderText = "Cidade";
                dgv_paciente.Columns["estado_paciente"].HeaderText = "Estado";
                dgv_paciente.Columns["telefone_paciente"].HeaderText = "Telefone";
                dgv_paciente.Columns["email_paciente"].HeaderText = "E-mail";
                dgv_paciente.Columns["senha_paciente"].HeaderText = "Senha";

            }
            else if (rCpf.Checked) {
                pac.Cpf_pac = txt_consulta.Text;
                dgv_paciente.DataSource = pac.ConsultarCpf();
                dgv_paciente.Columns["id_paciente"].HeaderText = "ID";
                dgv_paciente.Columns["nomecomp_paciente"].HeaderText = "Nome Completo";
                dgv_paciente.Columns["nomeusu_paciente"].HeaderText = "Nome de Usuário";
                dgv_paciente.Columns["cpf_paciente"].HeaderText = "CPF";
                dgv_paciente.Columns["cartao_paciente"].HeaderText = "Cartão SUS";
                dgv_paciente.Columns["endereco_paciente"].HeaderText = "Endereço";
                dgv_paciente.Columns["cep_paciente"].HeaderText = "CEP";
                dgv_paciente.Columns["cidade_paciente"].HeaderText = "Cidade";
                dgv_paciente.Columns["estado_paciente"].HeaderText = "Estado";
                dgv_paciente.Columns["telefone_paciente"].HeaderText = "Telefone";
                dgv_paciente.Columns["email_paciente"].HeaderText = "E-mail";
                dgv_paciente.Columns["senha_paciente"].HeaderText = "Senha";
            }
            else if (rNome.Checked)
            {
                pac.Nomecomp_pac = txt_consulta.Text;
                dgv_paciente.DataSource = pac.ConsultarNome();
                dgv_paciente.Columns["id_paciente"].HeaderText = "ID";
                dgv_paciente.Columns["nomecomp_paciente"].HeaderText = "Nome Completo";
                dgv_paciente.Columns["nomeusu_paciente"].HeaderText = "Nome de Usuário";
                dgv_paciente.Columns["cpf_paciente"].HeaderText = "CPF";
                dgv_paciente.Columns["cartao_paciente"].HeaderText = "Cartão SUS";
                dgv_paciente.Columns["endereco_paciente"].HeaderText = "Endereço";
                dgv_paciente.Columns["cep_paciente"].HeaderText = "CEP";
                dgv_paciente.Columns["cidade_paciente"].HeaderText = "Cidade";
                dgv_paciente.Columns["estado_paciente"].HeaderText = "Estado";
                dgv_paciente.Columns["telefone_paciente"].HeaderText = "Telefone";
                dgv_paciente.Columns["email_paciente"].HeaderText = "E-mail";
                dgv_paciente.Columns["senha_paciente"].HeaderText = "Senha";
            }

          
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas cons = new Consultas();
           cons.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_consulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void r_csus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_paciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
