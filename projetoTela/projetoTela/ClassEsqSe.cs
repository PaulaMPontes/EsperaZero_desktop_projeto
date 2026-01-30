using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class ClassEsqSe : Conexao
    {
        private string esq_email;
        private string esq_senha;
        private string esq_n_senha;

        public string Esq_email
        {
            get
            {
                return esq_email;
            }

            set
            {
                esq_email = value;
            }
        }

        public string Esq_senha
        {
            get
            {
                return esq_senha;
            }

            set
            {
                esq_senha = value;
            }
        }

        public string Esq_n_senha
        {
            get
            {
                return esq_n_senha;
            }

            set
            {
                esq_n_senha = value;
            }
        }
        public int ConsultarPaciente()
        {
            this.abrirConexao();
            string mSQL = "SELECT count(id_paciente) FROM cadastrar_pacientes WHERE email_paciente= '" + this.Esq_email + "' , senha_paciente= '" + this.Esq_senha + "'and senha_paciente= '" + this.Esq_n_senha + "'";


            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            fecharConexao();

            int valor_login;
            valor_login = resultado_query;
            this.fecharConexao();
            return valor_login;

        }
        public int ConsultarUsuario()
        {
            this.abrirConexao();
            string mSQL = "SELECT  count(id_usuario)FROM cadastrar_usuarios WHERE email_usuario= '" + this.Esq_email + "' , senha_paciente= '" + this.Esq_senha + "'and senha_paciente= '" + this.Esq_n_senha + "'";


            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            fecharConexao();

            int valor_login;
            valor_login = resultado_query;
            this.fecharConexao();
            return valor_login;
        }
        public void AlterarPaciente()
        {
            string query = "UPDATE cadastrar_pacientes set senha_paciente = '" + this.Esq_senha + "', senha_paciente = '" + this.Esq_n_senha + "'  where email_paciente= '" + this.esq_email + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public void Alterarusuario()
        {
            string query = "UPDATE cadastrar_usuarios set senha_usuario = '" + this.Esq_senha + "', senha_usuario = '" + this.Esq_n_senha + "'  where email_usuario= '" + this.esq_email + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
    }
}
