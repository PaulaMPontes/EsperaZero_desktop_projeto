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
    public partial class Opcoes : Form
    {
        private PrintDialog printDocument = new PrintDialog();
        private Image imageToPrint;

        public Opcoes()
        {
            InitializeComponent();

           
            // Carregar a imagem
            imageToPrint = Image.FromFile("C:/Users/ds-tec-3/Desktop/C_Sharp_TCC_EsperaZero/icones/logo_tcc3.png");

            // Associar o evento PrintPage ao PrintDocument
            printDocument1.PrintPage += (sender, e) =>
            {
                // Desenha a imagem diretamente, sem redimensionar ou ajustar
              //  e.Graphics.DrawImage(imageToPrint, e.MarginBounds.Left, e.MarginBounds.Top);
                e.Graphics.DrawImage(imageToPrint, 55, 50);
            };

            // Adicionar um botão para iniciar a impressão
            //Button printButton = new Button();
            //printButton.Text = "Imprimir Imagem";
            //printButton.Click += (sender, e) => printDocument1.Print();
            //Controls.Add(printButton);

        }

        ClassProntuario CP = new ClassProntuario();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receita,nome,cpf,csus;
            nome = txt_nomec.Text;
            cpf = mtxt_cpf.Text;
            csus = m_csus.Text;
            receita = txt_receita.Text;

            try
            {
                CP.Nomecomp_pac_med = nome;
                CP.Cpf_pac_med = cpf;
                CP.Cartao_pac_med = csus;
                CP.Receita_pac_med = receita;
                CP.Inserir();

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite sobre o campo.");
                throw;
            }

           

            //string nome, cartao, oxigenio, pressao, receita;






        }

        private void button3_Click(object sender, EventArgs e)
        {

           

            try
            {
                string cpf;

                cpf = mtxt_cpf.Text;
                CP.Cpf_pac_med = cpf.Replace(",", ".");
                CP.Deletar();
                MessageBox.Show("Liberação realizada com sucesso!!");
            }
            catch (Exception)
            {
                MessageBox.Show(" Não foi possível liberar.  ");
                throw;
            }
         
        

         

        }

        private void Opcoes_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string dados;
            CP.Nomemed_pac_med = txtNomemed.Text;
            ////chama o metodo compra
            dados = CP.mostrarReceita();

            //cria um obj fonte
            Font arial13 = new Font("Arial", 13, FontStyle.Bold);
            Font arial132 = new Font("Arial", 13);
            //cria um obj p/ armazenar a cor
            SolidBrush brushBlack = new SolidBrush(Color.Black);

            Font arial19 = new Font("Arial", 19, FontStyle.Bold);
            SolidBrush brushRed = new SolidBrush(Color.Red);

            //e.Graphics.DrawString(" RECEITUÁRIO", arial19, brushBlack, new Point(310, 100));

            //e.Graphics.DrawString(dados, arial13, brushBlack, new Point(50, 220));
            //// Define a área retangular para o texto
            // RectangleF areaTexto = new RectangleF(180, 310, 400, 590);

            //{
            RectangleF areaTexto = new RectangleF(180, 340, 400, 590);
            e.Graphics.DrawString(" RECEITUÁRIO", arial19, brushBlack, new Point(310, 100));
            // e.Graphics.DrawString(dados, arial13, brushBlack, new Point(50, 220));

            e.Graphics.DrawString("Nome Completo:", arial13, brushBlack, new Point(50, 220));
            e.Graphics.DrawString(CP.Nomecomp_pac_med, arial132, brushBlack, new Point(197, 220));

            e.Graphics.DrawString("CPF:", arial13, brushBlack, new Point(50, 260));
            e.Graphics.DrawString(CP.Cpf_pac_med, arial132, brushBlack, new Point(95, 260));

            e.Graphics.DrawString("Cartão do SUS:", arial13, brushBlack, new Point(50, 300));
            e.Graphics.DrawString(CP.Cartao_pac_med, arial132, brushBlack, new Point(185, 300));

            e.Graphics.DrawString("Preescrição:", arial13, brushBlack, new Point(50, 340));
            e.Graphics.DrawString(CP.Receita_pac_med, arial132, brushBlack, areaTexto);

            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, 470,900, 770,900);

            e.Graphics.DrawString(CP.Nomemed_pac_med, arial13, brushBlack, new Point(490, 910));
            //  e.Graphics.DrawString(CP.Receita_pac_med, arial132, brushBlack, new Point(180, 340));
            //  }
            ////acabaqui

            //string texto = "  :  " + txt_receita.Text;
            //int i;
            //int tam = texto.Length;
            //for (i = 0; i < tam; i += 64)
            //{
            //    //Console.WriteLine(teste.Substring(i, Math.Min(40, tam - i))); // só um teste
            //    e.Graphics.DrawString(texto.Substring(i, Math.Min(44, tam - i)), arial13, Brushes.Red, 20, 300 + (i % 44 * 20));
            //}
            ////acabaqui

            //{
            //        string dados;
            //        ////chama o metodo compra
            //        dados = CP.mostrarReceita();
            //        //string texto = "Este é um exemplo de texto longo que será quebrado automaticamente dentro do retângulo especificado.";
            //        Font fonte = new Font("Arial", 12);
            //    Brush pincel = Brushes.Black;

            //    // Define a área retangular para o texto
            //    RectangleF areaTexto = new RectangleF(50, 220, 400, 590); // X, Y, largura, altura

            //    // Desenha o texto na área especificada com quebra automática de linha
            //    e.Graphics.DrawString(dados, fonte, pincel, areaTexto);
            //}

            //acabaqui






        }

        private void mtxt_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_csus_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }

