using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class Paciente:Conexao
    {
        private string nomecomp_pac;
        private string nomeusu_pac;
        private string endereco_pac;
        private string cep_pac;
        private string cidade_pac;
        private string estado_pac;
        private string cpf_pac;
        private string m_csus_pac;
        private string telefone_pac;
        private string email_pac;
        private string senha_pac;

        public string Nomecomp_pac
        {
            get
            {
                return nomecomp_pac;
            }

            set
            {
                nomecomp_pac = value;
            }
        }

        public string Nomeusu_pac
        {
            get
            {
                return nomeusu_pac;
            }

            set
            {
                nomeusu_pac = value;
            }
        }

        public string Endereco_pac
        {
            get
            {
                return endereco_pac;
            }

            set
            {
                endereco_pac = value;
            }
        }

        public string Cep_pac
        {
            get
            {
                return cep_pac;
            }

            set
            {
                cep_pac = value;
            }
        }

        public string Cidade_pac
        {
            get
            {
                return cidade_pac;
            }

            set
            {
                cidade_pac = value;
            }
        }

        public string Estado_pac
        {
            get
            {
                return estado_pac;
            }

            set
            {
                estado_pac = value;
            }
        }

        public string Cpf_pac
        {
            get
            {
                return cpf_pac;
            }

            set
            {
                cpf_pac = value;
            }
        }

        public string Csus_pac
        {
            get
            {
                return m_csus_pac;
            }

            set
            {
                m_csus_pac = value;
            }
        }

        public string Telefone_pac
        {
            get
            {
                return telefone_pac;
            }

            set
            {
                telefone_pac = value;
            }
        }

        public string Email_pac
        {
            get
            {
                return email_pac;
            }

            set
            {
                email_pac = value;
            }
        }

        public string Senha_pac
        {
            get
            {
                return senha_pac;
            }

            set
            {
                senha_pac = value;
            }
        }

        public void Inserir()
        {
             string query = "INSERT INTO cadastrar_pacientes(nomecomp_paciente,nomeusu_paciente,cpf_paciente,cartao_paciente,endereco_paciente,cep_paciente,cidade_paciente,estado_paciente,telefone_paciente,email_paciente,senha_paciente) VALUES   ('" +  this.Nomecomp_pac + "' , '" + this.Nomeusu_pac + "' , '" + this.Cpf_pac + "', '" + this.Csus_pac + "', '" + this.Endereco_pac + "' , '" + this.Cep_pac + "', '" + this.Cidade_pac + "', '" + this.Estado_pac + "', '" + this.Telefone_pac + "', '" + this.Email_pac + "', '" + this.Senha_pac + "')";

       //   string query = "INSERT INTO cadastrar_pacientes(nomecomp_paciente)VALUES('Luiz')";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                fecharConexao();
            }
        }

        public DataTable Consultar()
        {
            abrirConexao();
            string mSQL = "SELECT * FROM cadastrar_pacientes";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ConsultarCpf()
        {
            this.abrirConexao();
            string mSQL = "SELECT * FROM cadastrar_pacientes where cpf_paciente ='" + Cpf_pac + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ConsultarNome()
        {
            this.abrirConexao();
            string mSQL = "SELECT * FROM cadastrar_pacientes where nomecomp_paciente='" + Nomecomp_pac + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ConsultarCartao()
        {
            this.abrirConexao();
            string mSQL = "SELECT * FROM cadastrar_pacientes where cartao_paciente ='" + Csus_pac + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
