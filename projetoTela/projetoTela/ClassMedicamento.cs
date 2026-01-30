using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class ClassMedicamento : Conexao
    {
        private string cpf_medicamento;
        private string nome_medicamento;
        private string idmedicamento;
        private string codigo_medicamento;
        private string descricao_medicamento;
        private string concentrao_medicamento;
        private string apresentacao_medicamento;
        private string codigofam_medicamento;
        private string codigogp_medicamento;
        private string ativo_medicamento;

        public string Codigo_medicamento
        {
            get
            {
                return codigo_medicamento;
            }

            set
            {
                codigo_medicamento = value;
            }
        }

        public string Descricao_medicamento
        {
            get
            {
                return descricao_medicamento;
            }

            set
            {
                descricao_medicamento = value;
            }
        }

        public string Concentrao_medicamento
        {
            get
            {
                return concentrao_medicamento;
            }

            set
            {
                concentrao_medicamento = value;
            }
        }

        public string Apresentacao_medicamento
        {
            get
            {
                return apresentacao_medicamento;
            }

            set
            {
                apresentacao_medicamento = value;
            }
        }

        public string Codigofam_medicamento
        {
            get
            {
                return codigofam_medicamento;
            }

            set
            {
                codigofam_medicamento = value;
            }
        }

        public string Codigogp_medicamento
        {
            get
            {
                return codigogp_medicamento;
            }

            set
            {
                codigogp_medicamento = value;
            }
        }

        public string Ativo_medicamento
        {
            get
            {
                return ativo_medicamento;
            }

            set
            {
                ativo_medicamento = value;
            }
        }

        public string Idmedicamento
        {
            get
            {
                return idmedicamento;
            }

            set
            {
                idmedicamento = value;
            }
        }

        public string Cpf_medicamento
        {
            get
            {
                return cpf_medicamento;
            }

            set
            {
                cpf_medicamento = value;
            }
        }

        public string Nome_medicamento
        {
            get
            {
                return nome_medicamento;
            }

            set
            {
                nome_medicamento = value;
            }
        }

        public void inserir()
        {
            string query = "INSERT INTO medicamentos(codprod_medicamento,desc_medicamento,conc_medicamento,apr_medicamento,codfam_medicamento,codgp_medicamento,ativo_medicamento) VALUES  ('" + this.Codigo_medicamento + "' , '" + this.Descricao_medicamento + "', '" + this.Concentrao_medicamento + "', '" + this.Apresentacao_medicamento + "' , '" + this.Codigofam_medicamento + "', '" + this.Codigogp_medicamento + "', '" + this.Ativo_medicamento + "')";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                fecharConexao();

            }
        }
        public DataTable consultar()
        {
            abrirConexao();
            string mSQL = "SELECT * FROM medicamentos";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void alterar()
        {
            string query = "UPDATE medicamentos SET codprod_medicamento= '" + Codigo_medicamento + "', desc_medicamento=  '" + Descricao_medicamento + "', conc_medicamento= '" + Concentrao_medicamento + "', apr_medicamento= '" + Apresentacao_medicamento + "', codfam_medicamento= '" + Codigofam_medicamento + "', codgp_medicamento= '" + Codigogp_medicamento + "', ativo_medicamento= '" + Ativo_medicamento + "'  where id_medicamento = '" + Idmedicamento + "'";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public void excluir()
        {
            string query = "DELETE from medicamentos where id_medicamento= '" + Idmedicamento + "'";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public void delete()
        {

            string query = "DELETE FROM fila WHERE cpf_pac_fila='" + Cpf_medicamento + "'";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }

        }
    }
}

    

