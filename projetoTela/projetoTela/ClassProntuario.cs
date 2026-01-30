using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class ClassProntuario : Conexao
    {
        private string nomecomp_pac_med;
        private string cpf_pac_med;
        private string cartao_pac_med;
        private string altura_pac_medcartao_pac_me;
        private string peso_pac_med;
        private string oxigenio_pac_med;
        private string pressao_pac_med;
        private string receita_pac_med;
        private string nomemed_pac_med;

        public string Nomecomp_pac_med
        {
            get
            {
                return nomecomp_pac_med;
            }

            set
            {
                nomecomp_pac_med = value;
            }
        }

        public string Cpf_pac_med
        {
            get
            {
                return cpf_pac_med;
            }

            set
            {
                cpf_pac_med = value;
            }
        }

        public string Altura_pac_medcartao_pac_me
        {
            get
            {
                return altura_pac_medcartao_pac_me;
            }

            set
            {
                altura_pac_medcartao_pac_me = value;
            }
        }

        public string Peso_pac_med
        {
            get
            {
                return peso_pac_med;
            }

            set
            {
                peso_pac_med = value;
            }
        }

        public string Oxigenio_pac_med
        {
            get
            {
                return oxigenio_pac_med;
            }

            set
            {
                oxigenio_pac_med = value;
            }
        }

        public string Pressao_pac_med
        {
            get
            {
                return pressao_pac_med;
            }

            set
            {
                pressao_pac_med = value;
            }
        }

        public string Receita_pac_med
        {
            get
            {
                return receita_pac_med;
            }

            set
            {
                receita_pac_med = value;
            }
        }

        public string Cartao_pac_med
        {
            get
            {
                return cartao_pac_med;
            }

            set
            {
                cartao_pac_med = value;
            }
        }

        public string Nomemed_pac_med
        {
            get
            {
                return nomemed_pac_med;
            }

            set
            {
                nomemed_pac_med = value;
            }
        }

        public void Inserir()
        {
            string query = "INSERT INTO prontuario(nomecomp_pac_med,cpf_pac_med,cartao_pac_med,receita_pac_med) VALUES  ('" + this.Nomecomp_pac_med + "','"+ this.Cpf_pac_med +"','"+ this.Cartao_pac_med +"','"+ this.Receita_pac_med  + "')";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                fecharConexao();
            }
        }
        public void Deletar()
        {
            string query = "DELETE FROM fila WHERE cpf_pac_fila='" + Cpf_pac_med + "'" ;
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public void Consultar()
        {
            string query = "SELECT FROM fila VALUES  ('" + this.Cpf_pac_med + "')";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                fecharConexao();
            }
        }
        public string mostrarReceita()
        {
            return " Nome Completo: " + nomecomp_pac_med  + " \n \n CPF: " + cpf_pac_med+  " \n \n Cartão do SUS: " + cartao_pac_med+ "\n\n Preescrição: " + receita_pac_med;

        }
    }
}