using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class ClassFilaHome : Conexao
    {

        private string cpf;
        private int posicao;

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

        public int Posicao
        {
            get
            {
                return posicao;
            }

            set
            {
                posicao = value;
            }
        }
        public DataTable ConsultarNome()
        {
            this.abrirConexao();
            string mSQL = "SELECT nome_pac_fila FROM fila where cpf_pac_fila='" + cpf + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ConsultarPosicao()
        {
            abrirConexao();
            string mSQL = "SELECT * FROM fila where cpf_pac_fila='" + cpf +"' ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
