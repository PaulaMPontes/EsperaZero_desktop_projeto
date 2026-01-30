using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class ClasseFIla : Conexao
    {
        private int numero_fila;
        private string nome_fila;
        private string categoria_fila;
        private string cpf_fila;

        public int Numero_fila
        {
            get
            {
                return numero_fila;
            }

            set
            {
                numero_fila = value;
            }
        }

        public string Nome_fila
        {
            get
            {
                return nome_fila;
            }

            set
            {
                nome_fila = value;
            }
        }

        public string Categoria_fila
        {
            get
            {
                return categoria_fila;
            }

            set
            {
                categoria_fila = value;
            }
        }

        public string Cpf_fila
        {
            get
            {
                return cpf_fila;
            }

            set
            {
                cpf_fila = value;
            }
        }

        public DataTable Consultar()
        {
            abrirConexao();
            string mSQL = "SELECT * FROM fila";

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
            string mSQL = "SELECT * FROM fila where nome_pac_fila='" + Cpf_fila + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
