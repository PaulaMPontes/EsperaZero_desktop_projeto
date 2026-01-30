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
    public partial class FRM_Medicamentos2 : Form
    {
        public FRM_Medicamentos2()
        {
            InitializeComponent();
        }
        ClassMedicamento CM = new ClassMedicamento();

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_home2 h = new FRM_home2();
            h.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CM.Idmedicamento = txtID.Text;
                CM.Codigo_medicamento = txtCodP.Text;
                CM.Descricao_medicamento = txtDesc.Text;
                CM.Concentrao_medicamento = txtConc.Text;
                CM.Apresentacao_medicamento = txtAp.Text;
                CM.Codigofam_medicamento = txtCodFam.Text;
                CM.Codigogp_medicamento = txtCodG.Text;
                CM.Ativo_medicamento = txtAtv.Text;
                CM.inserir();
                dgvRemedio.DataSource = CM.consultar();

            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso!!");

            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lblID.Visible = true;
            txtID.Visible = true;
            try
            {
                dgvRemedio.DataSource = CM.consultar();
                dgvRemedio.Columns["id_medicamento"].HeaderText = "ID";
                dgvRemedio.Columns["codprod_medicamento"].HeaderText = "Código";
                dgvRemedio.Columns["desc_medicamento"].HeaderText = "Descrição Produto";
                dgvRemedio.Columns["conc_medicamento"].HeaderText = "Concentração";
                dgvRemedio.Columns["apr_medicamento"].HeaderText = "Apresentação";
                dgvRemedio.Columns["codfam_medicamento"].HeaderText = "Código Família";
                dgvRemedio.Columns["codgp_medicamento"].HeaderText = "Código Grupo";
                dgvRemedio.Columns["ativo_medicamento"].HeaderText = "Ativo";
                dgvRemedio.Columns["cpf_medicamento"].HeaderText = "";
                dgvRemedio.Columns["nome_medicamento"].HeaderText = "";
            }
            finally
            {


            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                CM.Idmedicamento = txtID.Text;
                CM.Codigo_medicamento = txtCodP.Text;
                CM.Descricao_medicamento = txtDesc.Text;
                CM.Concentrao_medicamento = txtConc.Text;
                CM.Apresentacao_medicamento = txtAp.Text;
                CM.Codigofam_medicamento = txtCodFam.Text;
                CM.Codigogp_medicamento = txtCodG.Text;
                CM.Ativo_medicamento = txtAtv.Text;
                CM.alterar();
                dgvRemedio.DataSource = CM.consultar();
            }
            finally
            {
                MessageBox.Show("Dados alterados com sucesso!!");

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                CM.Idmedicamento = txtID.Text;
                CM.excluir();
                dgvRemedio.DataSource = CM.consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso!!");
            }
        }

        private void dgvRemedio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvRemedio.CurrentRow.Cells["ID_medicamento"].Value.ToString();
            txtCodP.Text = dgvRemedio.CurrentRow.Cells["codprod_medicamento"].Value.ToString();
            txtDesc.Text = dgvRemedio.CurrentRow.Cells["desc_medicamento"].Value.ToString();
            txtConc.Text = dgvRemedio.CurrentRow.Cells["conc_medicamento"].Value.ToString();
            txtAp.Text = dgvRemedio.CurrentRow.Cells["apr_medicamento"].Value.ToString();
            txtCodFam.Text = dgvRemedio.CurrentRow.Cells["codfam_medicamento"].Value.ToString();
            txtCodG.Text = dgvRemedio.CurrentRow.Cells["codgp_medicamento"].Value.ToString();
            txtAtv.Text = dgvRemedio.CurrentRow.Cells["ativo_medicamento"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtCodP.Clear();
            txtDesc.Clear();
            txtConc.Clear();
            txtAp.Clear();
            txtCodFam.Clear();
            txtCodG.Clear();
            txtAtv.Clear();
            dgvRemedio.DataSource = "";
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf;

                cpf = textBox2.Text;
                CM.Cpf_medicamento = cpf;
                CM.delete();
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
