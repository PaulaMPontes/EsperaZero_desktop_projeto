using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class UsuariosC : Conexao
    {
        private string nomecomp_usu;
        private string telefone_usu;
        private string email_usu;
        private string senha_usu;
        private string tipo_usu;

        public string Nomecomp_usu
        {
            get
            {
                return nomecomp_usu;
            }

            set
            {
                nomecomp_usu = value;
            }
        }

        public string Telefone_usu
        {
            get
            {
                return telefone_usu;
            }

            set
            {
                telefone_usu = value;
            }
        }

        public string Email_usu
        {
            get
            {
                return email_usu;
            }

            set
            {
                email_usu = value;
            }
        }

        public string Senha_usu
        {
            get
            {
                return senha_usu;
            }

            set
            {
                senha_usu = value;
            }
        }

        public string Tipo_usu
        {
            get
            {
                return tipo_usu;
            }

            set
            {
                tipo_usu = value;
            }
        }

        public void Inserir()
        {
            string query = "INSERT INTO cadastrar_usuarios(nomecomp_usuario,telefone_usuario,email_usuario,senha_usuario,tipo_usuario) VALUES  ('" + this.Nomecomp_usu + "' , '" + this.Telefone_usu + "', '" + this.Email_usu + "', '" + this.Senha_usu + "', '" + this.Tipo_usu + "')";
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
            string mSQL = "SELECT * FROM cadastrar_usuarios";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
