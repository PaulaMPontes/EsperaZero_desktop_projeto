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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            PageLogin PgL = new PageLogin();
            ClasseFIla CF = new ClasseFIla();
            string email, senha,tipo, cpf;
            email = txt_em.Text;
            senha = txt_senha.Text;
            tipo = cmbTp.Text;
            cpf = mtxt_cpf.Text;

        

            if (tipo == "Paciente")
            {
                

                PgL.Email_log = email;
                PgL.Senha_log = senha;
                PgL.Tipo_log = tipo;
             
                
                int r = PgL.ConsultarPaciente();

                
                
                if (r == 1)
                {

                    this.Hide();
                    Fila f1 = new Fila(mtxt_cpf.Text);
                    
                    DataSet ds = new DataSet();
                    DataTable dt;
                  //  string numf;


                //    dt = PgL.ConsultarCPF();
                //    numf = dt.Rows[0].ItemArray[0].ToString();


                 //   CF.Cpf_fila = numf;


                   // f1.ValorRecebido = mtxt_cpf.Text; // Passando valor
                 //   f1.Show(mtxt_cpf);
                    //  MessageBox.Show(CF.Cpf_fila);



                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou/e Senha incorreto.");
                }
            }

            else if (tipo == "Administrador")
            {


                PgL.Email_log = email;
                PgL.Senha_log = senha;
                PgL.Tipo_log = tipo;
                int r = PgL.ConsultarUsuario();

                if (r == 1)
                {

                    this.Hide();
                    Home h = new Home();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou/e Senha incorreto.");
                }
            }

            else if (tipo == "Médico")
            {


                PgL.Email_log = email;
                PgL.Senha_log = senha;
                PgL.Tipo_log = tipo;
                int r = PgL.ConsultarUsuario();

                if (r == 1)
                {

                    this.Hide();
                    FRM_home2 h2 = new FRM_home2();
                    h2.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou/e Senha incorreto.");
                }
            }



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cads3 cad3 = new Cads3();
            cad3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EsqueceuSenha esq = new EsqueceuSenha();
            esq.Show();
        }

        private void mtxt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
