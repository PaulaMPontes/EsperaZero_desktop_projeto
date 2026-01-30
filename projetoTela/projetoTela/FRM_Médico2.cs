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
    public partial class FRM_Médico2 : Form
    {
        private PrintDialog printDocument = new PrintDialog();
        private Image imageToPrint;
        public FRM_Médico2()
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
        }
        ClassProntuario CP = new ClassProntuario();

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string cpf;

                cpf = mtxt_cpf.Text;
                CP.Cpf_pac_med = cpf.Replace(",",".");
                CP.Deletar();
                MessageBox.Show("Liberação realizada com sucesso!!");
            }
            catch (Exception)
            {
                MessageBox.Show(" Não foi possível liberar.  ");
                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receita, nome, cpf, csus;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_home2 fh2 = new FRM_home2();
            fh2.Show();
        }

        private void FRM_Médico2_Load(object sender, EventArgs e)
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

            RectangleF areaTexto = new RectangleF(180, 340, 400, 590);
            e.Graphics.DrawString(" RECEITUÁRIO", arial19, brushBlack, new Point(310, 100));
      

            e.Graphics.DrawString("Nome Completo:", arial13, brushBlack, new Point(50, 220));
            e.Graphics.DrawString(CP.Nomecomp_pac_med, arial132, brushBlack, new Point(197, 220));
    
            e.Graphics.DrawString("CPF:", arial13, brushBlack, new Point(50, 260));
            e.Graphics.DrawString(CP.Cpf_pac_med, arial132, brushBlack, new Point(95, 260));

            e.Graphics.DrawString("Cartão do SUS:", arial13, brushBlack, new Point(50, 300));
            e.Graphics.DrawString(CP.Cartao_pac_med, arial132, brushBlack, new Point(185, 300));

            e.Graphics.DrawString("Preescrição:", arial13, brushBlack, new Point(50, 340));
            e.Graphics.DrawString(CP.Receita_pac_med, arial132, brushBlack, areaTexto);

            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, 470, 900, 770, 900);

            e.Graphics.DrawString(CP.Nomemed_pac_med, arial13, brushBlack, new Point(490, 910));
        }

        private void mtxt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
