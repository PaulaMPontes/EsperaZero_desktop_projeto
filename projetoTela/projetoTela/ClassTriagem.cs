using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class ClassTriagem : Conexao
    {
        private string nomecomp_paciente;
        private string cpf_paciente;
        private string idade_paciente;
        private string altura_paciente;
        private string peso_paciente;
        private string oxigenio_paciente;
        private string pressao_paciente;
        private string sexo_paciente;
        private string tipos_paciente;
        private string medicamento_paciente;
        private string alergia_paciente;
        private string exerc_paciente;
        private string droga_paciente;
        private string observacao_paciente;
        private double imc_paciente;
        private string situacao_paciente;

        public string Nomecomp_paciente
        {
            get
            {
                return nomecomp_paciente;
            }

            set
            {
                nomecomp_paciente = value;
            }
        }

        public string Cpf_paciente
        {
            get
            {
                return cpf_paciente;
            }

            set
            {
                cpf_paciente = value;
            }
        }

        public string Idade_paciente
        {
            get
            {
                return idade_paciente;
            }

            set
            {
                idade_paciente = value;
            }
        }

        public string Altura_paciente
        {
            get
            {
                return altura_paciente;
            }

            set
            {
                altura_paciente = value;
            }
        }

        public string Peso_paciente
        {
            get
            {
                return peso_paciente;
            }

            set
            {
                peso_paciente = value;
            }
        }

        public string Oxigenio_paciente
        {
            get
            {
                return oxigenio_paciente;
            }

            set
            {
                oxigenio_paciente = value;
            }
        }

        public string Pressao_paciente
        {
            get
            {
                return pressao_paciente;
            }

            set
            {
                pressao_paciente = value;
            }
        }

        public string Sexo_paciente
        {
            get
            {
                return sexo_paciente;
            }

            set
            {
                sexo_paciente = value;
            }
        }

        public string Tipos_paciente
        {
            get
            {
                return tipos_paciente;
            }

            set
            {
                tipos_paciente = value;
            }
        }

        public string Medicamento_paciente
        {
            get
            {
                return medicamento_paciente;
            }

            set
            {
                medicamento_paciente = value;
            }
        }

        public string Alergia_paciente
        {
            get
            {
                return alergia_paciente;
            }

            set
            {
                alergia_paciente = value;
            }
        }

        public string Exerc_paciente
        {
            get
            {
                return exerc_paciente;
            }

            set
            {
                exerc_paciente = value;
            }
        }

        public string Droga_paciente
        {
            get
            {
                return droga_paciente;
            }

            set
            {
                droga_paciente = value;
            }
        }

        public string Observacao_paciente
        {
            get
            {
                return observacao_paciente;
            }

            set
            {
                observacao_paciente = value;
            }
        }

        public double Imc_paciente
        {
            get
            {
                return imc_paciente;
            }

            set
            {
                imc_paciente = value;
            }
        }

        public string Situacao_paciente
        {
            get
            {
                return situacao_paciente;
            }

            set
            {
                situacao_paciente = value;
            }
        }

        public void Inserir()
        {
            string query = "INSERT INTO triagem(nomecomp_paciente,cpf_paciente,idade_paciente,altura_paciente,peso_paciente,oxigenio_paciente,pressao_paciente,sexo_paciente,tipos_paciente,medicamento_paciente,alergia_paciente,exerc_paciente, droga_paciente,observacao_paciente) VALUES  ('" + this.Nomecomp_paciente + "' , '" + this.Cpf_paciente
 + "', '" + this.Idade_paciente + "', '" + this.Altura_paciente + "', '" + this.Peso_paciente + "', '" + this.Oxigenio_paciente + "', '" + this.Pressao_paciente + "', '" + this.Sexo_paciente + "', '" + this.Tipos_paciente + "', '" + this.Medicamento_paciente + "', '" + this.Alergia_paciente + "', '" + this.Exerc_paciente + "', '" + this.Droga_paciente + "', '" + this.Observacao_paciente + "')";
            if (abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                fecharConexao();
            }
        }
        public void Deletar()
        {
            string query = "DELETE FROM fila WHERE cpf_pac_fila='" + Cpf_paciente +"'";
            if (abrirConexao() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        //public string mostraDadosPac()
        //{
        //    return " Nome Completo: " + nomecomp_paciente   + " \n \n CPF: " + cpf_paciente + "\n \n Idade: " + idade_paciente + "\n \n Sexo: " + sexo_paciente + "\n\n Altura( , ): " + altura_paciente + " \n \n IMC: " + imc_paciente + " \n \n Situação: " + situacao_paciente + "\n\n Peso(kg): " + peso_paciente + "\n\n Oxigênio: " + oxigenio_paciente + "\n\n Pressão: " + pressao_paciente + "\n\n Tipo Sanguíneo: " + tipos_paciente + " \n \n Utiliza algum medicamento periodicamente?: " + medicamento_paciente + "\n\n Alérgico(a) a algum medicamento?: " + alergia_paciente + "\n\n Pratica exercício(s)/atividade(s) físicos(as)? Se sim, qual frequência?: " + exerc_paciente + "\n\n Utiliza algum tipo de droga(álcool/entorpecentes)?: " + droga_paciente + "\n\n Observação: " + observacao_paciente;
        //}
    }
}
