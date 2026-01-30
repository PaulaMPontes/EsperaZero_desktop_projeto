


using MySql.Data.MySqlClient;

namespace projetoTela
{
    class Conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        //Construindo método de conexão

        public Conexao()
        {
            inicializar();
        }

        public void inicializar()
       { 
            servidor = "127.0.0.1";
            database = "espzero";
            usuario = "root";
            senha = "";

            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" +
            database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";

            conectar = new MySqlConnection(conexaostring);

        }
        //método para Abrir Conexão
        public bool abrirConexao()
        {
            //try-catch ,comando para testar parte de um código, se caso der erro não para a execução
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possivel Conectar");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e Senha Inválidos!");
                        break;
                }
                return false;
            }
        }

        //método Fechar Conexão
        public bool fecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}

    

