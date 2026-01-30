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
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }
        ClassEsqSe CES = new ClassEsqSe();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email, senha, senha_n;
            email = txt_em.Text;
            senha = txt_senha.Text;
            senha_n = txt_n_senha.Text;

            try
            {
                CES.Esq_email = email;
                CES.Esq_senha = senha;
                CES.Esq_n_senha = senha_n;
                CES.AlterarPaciente();
                CES.Alterarusuario();
                MessageBox.Show("Mudança de senha realizada!!!");
            }
            catch (Exception)
            {
                MessageBox.Show(" Digite a senha novamente.");
                throw;
            }

        }
    }
}
