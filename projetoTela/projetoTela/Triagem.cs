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
    public partial class Triagem : Form
    {
        ClassTriagem CT = new ClassTriagem();
        private PrintDialog printDocument = new PrintDialog();
        private Image imageToPrint;


        public Triagem()
        {
            InitializeComponent();

            // Carregar a imagem
            imageToPrint = Image.FromFile("C:/Users/ds-tec-3/Desktop/C_Sharp_TCC_EsperaZero/icones/logo_tcc3.png");

            // Associar o evento PrintPage ao PrintDocument
            printDocument2.PrintPage += (sender, e) =>
            {
           
                e.Graphics.DrawImage(imageToPrint, 55, 50);
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void mtxt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomeu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_csus_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void txt_nomec_TextChanged(object sender, EventArgs e)
        {

        }

        private void Triagem_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            ClassTriagem tri = new ClassTriagem();
            try
            {
                IMC imc = new IMC();
                string sexo = "";
                double altura, peso;
                altura = double.Parse(txt_altura.Text);
                peso = double.Parse(txt_peso.Text);

                int indice = s2.SelectedIndex;

                if (indice == 0)
                {
                    sexo = "masculino";
                }
                else if (indice == 1)
                {
                    sexo = "feminino";
                }



                imc.Txt_alt = altura;
                imc.Txt_peso = peso;
                imc.S2 = sexo;
                imc.calcularIMC();

                lbl_imc.Text = imc.Txt_imc.ToString();
                MessageBox.Show("O IMC é: " + imc.mostrarIMC());
                res_s.Text = imc.mostrarSitu();

                CT.Imc_paciente = imc.Txt_imc;
                CT.Situacao_paciente = imc.Res_s;

            }
            catch (Exception)
            {
                MessageBox.Show("Digite o valor correto.");
                throw;
            }         
         

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void res_s_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nome, cpf, idade, altura, peso, oxigenio, pressao, sexo, tipo, medicamento, alergia, exercicio, droga, observacao;

            nome = txt_nomec.Text;
            cpf = mtxt_cpf.Text;
            idade = txt_idd.Text;
            altura = txt_altura.Text;
            peso = txt_peso.Text;
            oxigenio = txt_ox.Text;
            pressao = txt_prss.Text;
            sexo = s2.Text;
            tipo = txt_tipo.Text;
            medicamento = txt_medic.Text;
            alergia = txt_alerg.Text;
            exercicio = txt_ptrc.Text;
            droga = txt_droga.Text;
            observacao = txt_obs.Text;

            try
            {
                CT.Nomecomp_paciente = nome;
                CT.Cpf_paciente = cpf;
                CT.Idade_paciente = idade;
                CT.Altura_paciente = altura;
                CT.Peso_paciente = peso;
                CT.Oxigenio_paciente = oxigenio;
                CT.Pressao_paciente = pressao;
                CT.Sexo_paciente = sexo;
                CT.Tipos_paciente = tipo;
                CT.Medicamento_paciente = medicamento;
                CT.Alergia_paciente = alergia;
                CT.Exerc_paciente = exercicio;
                CT.Droga_paciente = droga;
                CT.Observacao_paciente = observacao;
                CT.Inserir();
              
               // MessageBox.Show(nome + cpf + idade + sexo+ altura + peso + oxigenio + pressao  + tipo + medicamento + alergia + exercicio + droga + observacao);

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira corretamente os valores.");
                throw;
            }
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ClassTriagem CT = new ClassTriagem();
            //string dados;
            ////chama o metodo compra
            //dados = CT.mostraDadosPac();
            //MessageBox.Show(dados);

            ////cria um obj fonte
            //Font arial13 = new Font("Arial", 13, FontStyle.Bold);
            ////cria um obj p/ armazenar a cor
            //SolidBrush brushBlack = new SolidBrush(Color.Black);

            //Font arial19 = new Font("Arial", 19, FontStyle.Bold);
            //SolidBrush brushRed = new SolidBrush(Color.Red);

            //e.Graphics.DrawString("Triagem do Paciente", arial19, brushBlack, new Point(280, 100));

            //e.Graphics.DrawString(dados, arial13, brushBlack, new Point(50, 250));

            //string dados;
            //chama o metodo compra
            //dados = CT.mostraDadosPac();

            ////cria um obj fonte
            //Font times12 = new Font("Times New Roman", 12);

            ////cria um obj p/ armazenar a cor
            //SolidBrush brushBlack = new SolidBrush(Color.Black);

            //Font times16 = new Font("Arial", 16);
            //SolidBrush brushRed = new SolidBrush(Color.Red);

            //e.Graphics.DrawString("MERCADOS LUIZINHO'S", times16, brushRed, new Point(10, 100));

            //e.Graphics.DrawString(dados, times12, brushBlack, new Point(50, 250));


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_ptrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            IMC imc = new IMC();

            double altura, peso;
            altura = double.Parse(txt_altura.Text);
            peso = double.Parse(txt_peso.Text);

            imc.calcularIMC();

            //   MessageBox.Show(imc.mostrarIMC().ToString());
            //   MessageBox.Show(imc.Txt_imc.ToString());
            //string dados;


            //= txt_nomec.Text;
            //CT.Cpf_paciente = mtxt_cpf.Text;
            //CT.Idade_paciente = txt_idd.Text;
            //CT.Sexo_paciente = s2.Text;
            //CT.Altura_paciente = txt_altura.Text;
            //CT.Peso_paciente = txt_peso.Text;

            // CT.Imc_paciente = lbl_imc.Text;
            //lbl_imc.Text = imc.Txt_imc.ToString();

            CT.Imc_paciente = imc.Txt_imc;
            //CT.Situacao_paciente = res_s.Text;
            //CT.Oxigenio_paciente = txt_ox.Text;
            //CT.Pressao_paciente = txt_prss.Text;
            //CT.Tipos_paciente = txt_tipo.Text;
            //CT.Medicamento_paciente = txt_medic.Text;
            //CT.Alergia_paciente = txt_alerg.Text;
            //CT.Exerc_paciente = txt_ptrc.Text;
            //CT.Droga_paciente = txt_droga.Text;
            //CT.Observacao_paciente = txt_obs.Text;
            //chama o metodo compra
            // dados = CT.mos();

            //cria um obj fonte
            Font arial13 = new Font("Arial", 13, FontStyle.Bold);
            Font arial132 = new Font("Arial", 13);
            //cria um obj p/ armazenar a cor
            SolidBrush brushBlack = new SolidBrush(Color.Black);

            Font arial19 = new Font("Arial", 19, FontStyle.Bold);
            SolidBrush brushRed = new SolidBrush(Color.Red);

            RectangleF areaTexto1 = new RectangleF(440, 580, 360, 40);
            RectangleF areaTexto2 = new RectangleF(355, 620, 440, 40);
            RectangleF areaTexto3 = new RectangleF(165, 755, 450, 170);
            RectangleF areaTexto4 = new RectangleF(490, 713, 310, 40);

            e.Graphics.DrawString("Triagem do Paciente", arial19, brushBlack, new Point(280, 100));

            ////e.Graphics.DrawString(dados, arial13, brushBlack, new Point(50, 250));

            e.Graphics.DrawString("Nome Completo:", arial13, brushBlack, new Point(50, 220));
            e.Graphics.DrawString(CT.Nomecomp_paciente, arial132, brushBlack, new Point(197, 220));

            e.Graphics.DrawString("CPF:", arial13, brushBlack, new Point(50, 260));
            e.Graphics.DrawString(CT.Cpf_paciente, arial13, brushBlack, new Point(95, 260));

            e.Graphics.DrawString("Idade:", arial13, brushBlack, new Point(50, 300));
            e.Graphics.DrawString(CT.Idade_paciente, arial13, brushBlack, new Point(105,300 ));

            e.Graphics.DrawString("Sexo:", arial13, brushBlack, new Point(50, 340));
            e.Graphics.DrawString(CT.Sexo_paciente, arial13, brushBlack, new Point(102,340 ));

            e.Graphics.DrawString("Altura:", arial13, brushBlack, new Point(50, 380));
            e.Graphics.DrawString(CT.Altura_paciente, arial13, brushBlack, new Point(110,380 ));

            e.Graphics.DrawString("Peso:", arial13, brushBlack, new Point(50, 420));
            e.Graphics.DrawString(CT.Peso_paciente, arial13, brushBlack, new Point(102,420 ));

            e.Graphics.DrawString("IMC:", arial13, brushBlack, new Point(340, 380));
            e.Graphics.DrawString(lbl_imc.Text, arial13, brushBlack, new Point(382, 380));

            e.Graphics.DrawString("Situação:", arial13, brushBlack, new Point(340, 420));
            e.Graphics.DrawString(CT.Situacao_paciente, arial13, brushBlack, new Point(430, 420));

            e.Graphics.DrawString("Oxigênio:", arial13, brushBlack, new Point(50, 460));
            e.Graphics.DrawString(CT.Oxigenio_paciente, arial13, brushBlack, new Point(134, 460));

            e.Graphics.DrawString("Pressão:", arial13, brushBlack, new Point(50, 500));
            e.Graphics.DrawString(CT.Pressao_paciente, arial13, brushBlack, new Point(130, 500));

            e.Graphics.DrawString("Tipo Sanguíneo:", arial13, brushBlack, new Point(50, 540));
            e.Graphics.DrawString(CT.Tipos_paciente, arial13, brushBlack, new Point(195, 540));

            e.Graphics.DrawString("Utiliza algum medicamento periodicamente?:", arial13, brushBlack, new Point(50, 580));
            e.Graphics.DrawString(CT.Medicamento_paciente, arial13, brushBlack, areaTexto1);

            e.Graphics.DrawString("Alérgico(a) a algum medicamento?:", arial13, brushBlack, new Point(50, 620));
            e.Graphics.DrawString(CT.Alergia_paciente, arial13, brushBlack, areaTexto2);

            e.Graphics.DrawString("Prática exercício(s)/atividade(s) físicos(as)? Se sim, qual frequência?:", arial13, brushBlack, new Point(50, 670));
            e.Graphics.DrawString(CT.Exerc_paciente, arial13, brushBlack, new Point(50, 690));

            e.Graphics.DrawString("Utiliza algum tipo de droga(álcool/entorpecentes)?:", arial13, brushBlack, new Point(50, 710));
            e.Graphics.DrawString(CT.Droga_paciente, arial13, brushBlack, areaTexto4);

            e.Graphics.DrawString("Observação:", arial13, brushBlack, new Point(50, 755));
            e.Graphics.DrawString(CT.Observacao_paciente, arial13, brushBlack, areaTexto3);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf;

                cpf = mtxt_cpf.Text;
                CT.Cpf_paciente = cpf.Replace(",",".");
                CT.Deletar();
                MessageBox.Show("Paciente liberado com sucesso!!");
            }
            catch (Exception)
            {
                MessageBox.Show(" Não foi possível liberar.  ");
                throw;
            }
        }
    }
}
