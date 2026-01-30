using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class PageLogin : Conexao 
    {
        private string email_log;
        private string senha_log;
        private string tipo_log;
        private string cpf;

        public string Email_log
        {
            get
            {
                return email_log;
            }

            set
            {
                email_log = value;
            }
        }

        public string Senha_log
        {
            get
            {
                return senha_log;
            }

            set
            {
                senha_log = value;
            }
        }

        public string Tipo_log
        {
            get
            {
                return tipo_log;
            }

            set
            {
                tipo_log = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public int ConsultarPaciente()
        {
            this.abrirConexao();
            string mSQL = "SELECT count(id_paciente) FROM cadastrar_pacientes WHERE email_paciente= '" +  this.Email_log   + "' and senha_paciente= '" + this.Senha_log  + "'" ;
          

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado_query =Convert.ToInt32(cmd.ExecuteScalar());
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
            string mSQL = "SELECT  count(id_usuario)FROM cadastrar_usuarios WHERE email_usuario= '" + this.Email_log + "' and senha_usuario= '" + this.Senha_log + "'";


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
        public DataTable ConsultarCPF()
        {
            this.abrirConexao();
            string mSQL = "SELECT  cpf_paciente FROM cadastrar_pacientes WHERE email_paciente= '" + this.Email_log + "' and senha_paciente= '" + this.Senha_log + "'";


            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            fecharConexao();

        
            this.fecharConexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


    }
}






