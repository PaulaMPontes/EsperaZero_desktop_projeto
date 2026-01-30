using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTela
{
    class IMC
    {
      
        private string res_s;
        private double txt_peso;
        private double txt_alt;
        private double txt_imc;
        private string s2;


        public string Res_s
        {
            get
            {
                return res_s;
            }

            set
            {
                res_s = value;
            }
        }

        public double Txt_peso
        {
            get
            {
                return txt_peso;
            }

            set
            {
                txt_peso = value;
            }
        }

        public double Txt_alt
        {
            get
            {
                return txt_alt;
            }

            set
            {
                txt_alt = value;
            }
        }

        public double Txt_imc
        {
            get
            {
                return txt_imc;
            }

            set
            {
                txt_imc = value;
            }
        }

        public string S2
        {
            get
            {
                return s2;
            }

            set
            {
                s2 = value;
            }
        }

        public void calcularIMC()
        {
            Txt_imc = Txt_peso / Math.Pow(Txt_alt, 2);

        }
        public double mostrarIMC()
        {
            return Txt_imc;

        }

        public string mostrarSitu()
        {
            if (S2 == "feminino" && Txt_imc < 19.1)
            {
                Res_s = "Abaixo do peso";
            }
            else if (S2 == "feminino" && Txt_imc >= 19.1 && Txt_imc < 25.8)
            {
                Res_s = "Peso ideal";
            }
            else if (S2 == "feminino" && Txt_imc > 25.8)
            {
                Res_s = "Obesa";
            }
            if (S2 == "masculino" && Txt_imc < 20.7)
            {
                Res_s = "Abaixo do peso";
            }
            else if (S2 == "masculino" && Txt_imc >= 20.7 && Txt_imc < 26.4)
            {
                Res_s = "Peso ideal";
            }
            else if (S2 == "masculino" && Txt_imc > 26.4)
            {
                Res_s = "Obeso";
            }
            return Res_s;
        }
    }
}

