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
    public partial class FRMCadastrarU2 : Form
    {
        public FRMCadastrarU2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosC UsC = new UsuariosC();
            string nomec, tel, email, senha, tipo;

            nomec = txt_nomec.Text;
            email = txt_email.Text;
            senha = txt_senha.Text;
            tel = mtxt_tel.Text;
            tipo = cmbTp.Text;

            try
            {
                UsC.Nomecomp_usu = nomec;
                UsC.Email_usu = email;
                UsC.Senha_usu = senha;
                UsC.Telefone_usu = tel;
                UsC.Tipo_usu = tipo;

                UsC.Inserir();


                MessageBox.Show("Dados inseridos com sucesso!!!");
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
            Cads3 cad3 = new Cads3();
            cad3.Show();
        }
    }
}
