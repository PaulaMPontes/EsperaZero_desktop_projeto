using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTela
{
    public partial class FRM_FilaM : Form
    {
        public FRM_FilaM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            ClasseFIla cf = new ClasseFIla();
            dt = cf.Consultar();
            string numf = "0";
            string cat = "0";

            //foreach (DataColumn column in dt.Columns){
            for (int i = 0; i < 27; i++)
            {
                numf = dt.Rows[i].ItemArray[1].ToString();
                // string numf = dt.Rows[0].ItemArray[2].ToString();
                cat = dt.Rows[i].ItemArray[4].ToString();


                if ((numf == "1") && (cat == "consulta"))
                {
                    fila1.BackColor = Color.Blue;

                }
                else if ((numf == "1") && (cat == "triagem"))
                {
                    fila1.BackColor = Color.Chartreuse;


                }
                else if ((numf == "1") && (cat == "medicamento"))
                {
                    fila1.BackColor = Color.Red;
                }

                ///////////////////////////////////////////////////////

                if ((numf == "2") && (cat == "consulta"))
                {
                    fila2.BackColor = Color.Blue;

                }
                else if ((numf == "2") && (cat == "triagem"))
                {
                    fila2.BackColor = Color.Chartreuse;


                }
                else if ((numf == "2") && (cat == "medicamento"))
                {
                    fila2.BackColor = Color.Red;
                }

                ///////////////////////////////////////////////////////

                if ((numf == "3") && (cat == "consulta"))
                {
                    fila3.BackColor = Color.Blue;

                }
                else if ((numf == "3") && (cat == "triagem"))
                {
                    fila3.BackColor = Color.Chartreuse;


                }
                else if ((numf == "3") && (cat == "medicamento"))
                {
                    fila3.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////

                if ((numf == "4") && (cat == "consulta"))
                {
                    fila4.BackColor = Color.Blue;

                }
                else if ((numf == "4") && (cat == "triagem"))
                {
                    fila4.BackColor = Color.Chartreuse;


                }
                else if ((numf == "4") && (cat == "medicamento"))
                {
                    fila4.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////


                if ((numf == "5") && (cat == "consulta"))
                {
                    fila5.BackColor = Color.Blue;

                }
                else if ((numf == "5") && (cat == "triagem"))
                {
                    fila5.BackColor = Color.Chartreuse;


                }
                else if ((numf == "5") && (cat == "medicamento"))
                {
                    fila5.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "6") && (cat == "consulta"))
                {
                    fila6.BackColor = Color.Blue;

                }
                else if ((numf == "6") && (cat == "triagem"))
                {
                    fila6.BackColor = Color.Chartreuse;


                }
                else if ((numf == "6") && (cat == "medicamento"))
                {
                    fila6.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "7") && (cat == "consulta"))
                {
                    fila7.BackColor = Color.Blue;

                }
                else if ((numf == "7") && (cat == "triagem"))
                {
                    fila7.BackColor = Color.Chartreuse;


                }
                else if ((numf == "7") && (cat == "medicamento"))
                {
                    fila7.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "8") && (cat == "consulta"))
                {
                    fila8.BackColor = Color.Blue;

                }
                else if ((numf == "8") && (cat == "triagem"))
                {
                    fila8.BackColor = Color.Chartreuse;


                }
                else if ((numf == "8") && (cat == "medicamento"))
                {
                    fila8.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "9") && (cat == "consulta"))
                {
                    fila9.BackColor = Color.Blue;

                }
                else if ((numf == "9") && (cat == "triagem"))
                {
                    fila9.BackColor = Color.Chartreuse;


                }
                else if ((numf == "9") && (cat == "medicamento"))
                {
                    fila9.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "10") && (cat == "consulta"))
                {
                    fila10.BackColor = Color.Blue;

                }
                else if ((numf == "10") && (cat == "triagem"))
                {
                    fila10.BackColor = Color.Chartreuse;


                }
                else if ((numf == "10") && (cat == "medicamento"))
                {
                    fila10.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////

                if ((numf == "11") && (cat == "consulta"))
                {
                    fila11.BackColor = Color.Blue;

                }
                else if ((numf == "11") && (cat == "triagem"))
                {
                    fila11.BackColor = Color.Chartreuse;


                }
                else if ((numf == "11") && (cat == "medicamento"))
                {
                    fila11.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "12") && (cat == "consulta"))
                {
                    fila12.BackColor = Color.Blue;

                }
                else if ((numf == "12") && (cat == "triagem"))
                {
                    fila12.BackColor = Color.Chartreuse;


                }
                else if ((numf == "12") && (cat == "medicamento"))
                {
                    fila12.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "13") && (cat == "consulta"))
                {
                    fila13.BackColor = Color.Blue;

                }
                else if ((numf == "13") && (cat == "triagem"))
                {
                    fila13.BackColor = Color.Chartreuse;


                }
                else if ((numf == "13") && (cat == "medicamento"))
                {
                    fila13.BackColor = Color.Red;
                }
                ////////////////////////////////////////////////////
                if ((numf == "14") && (cat == "consulta"))
                {
                    fila14.BackColor = Color.Blue;

                }
                else if ((numf == "14") && (cat == "triagem"))
                {
                    fila14.BackColor = Color.Chartreuse;


                }
                else if ((numf == "14") && (cat == "medicamento"))
                {
                    fila14.BackColor = Color.Red;
                }
                //////////////////////////////////////////////////////
                if ((numf == "15") && (cat == "consulta"))
                {
                    fila15.BackColor = Color.Blue;

                }
                else if ((numf == "15") && (cat == "triagem"))
                {
                    fila15.BackColor = Color.Chartreuse;


                }
                else if ((numf == "15") && (cat == "medicamento"))
                {
                    fila15.BackColor = Color.Red;
                }
                //////////////////////////////////////////////
                if ((numf == "16") && (cat == "consulta"))
                {
                    fila16.BackColor = Color.Blue;

                }
                else if ((numf == "16") && (cat == "triagem"))
                {
                    fila16.BackColor = Color.Chartreuse;


                }
                else if ((numf == "16") && (cat == "medicamento"))
                {
                    fila16.BackColor = Color.Red;
                }

                //////////////////////////////////////////////////////////////////////
                if ((numf == "17") && (cat == "consulta"))
                {
                    fila17.BackColor = Color.Blue;

                }
                else if ((numf == "17") && (cat == "triagem"))
                {
                    fila17.BackColor = Color.Chartreuse;


                }
                else if ((numf == "17") && (cat == "medicamento"))
                {
                    fila17.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////////////////////
                if ((numf == "18") && (cat == "consulta"))
                {
                    fila18.BackColor = Color.Blue;

                }
                else if ((numf == "18") && (cat == "triagem"))
                {
                    fila18.BackColor = Color.Chartreuse;


                }
                else if ((numf == "18") && (cat == "medicamento"))
                {
                    fila18.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////////////
                if ((numf == "19") && (cat == "consulta"))
                {
                    fila19.BackColor = Color.Blue;

                }
                else if ((numf == "19") && (cat == "triagem"))
                {
                    fila19.BackColor = Color.Chartreuse;


                }
                else if ((numf == "19") && (cat == "medicamento"))
                {
                    fila19.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////////////////
                if ((numf == "20") && (cat == "consulta"))
                {
                    fila20.BackColor = Color.Blue;

                }
                else if ((numf == "20") && (cat == "triagem"))
                {
                    fila20.BackColor = Color.Chartreuse;


                }
                else if ((numf == "20") && (cat == "medicamento"))
                {
                    fila20.BackColor = Color.Red;
                }
                ////////////////////////////////////////////////////////////////////
                if ((numf == "21") && (cat == "consulta"))
                {
                    fila21.BackColor = Color.Blue;

                }
                else if ((numf == "21") && (cat == "triagem"))
                {
                    fila21.BackColor = Color.Chartreuse;


                }
                else if ((numf == "21") && (cat == "medicamento"))
                {
                    fila21.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "22") && (cat == "consulta"))
                {
                    fila22.BackColor = Color.Blue;

                }
                else if ((numf == "22") && (cat == "triagem"))
                {
                    fila22.BackColor = Color.Chartreuse;


                }
                else if ((numf == "22") && (cat == "medicamento"))
                {
                    fila22.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////////
                if ((numf == "23") && (cat == "consulta"))
                {
                    fila23.BackColor = Color.Blue;

                }
                else if ((numf == "23") && (cat == "triagem"))
                {
                    fila23.BackColor = Color.Chartreuse;


                }
                else if ((numf == "23") && (cat == "medicamento"))
                {
                    fila23.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "24") && (cat == "consulta"))
                {
                    fila24.BackColor = Color.Blue;

                }
                else if ((numf == "24") && (cat == "triagem"))
                {
                    fila24.BackColor = Color.Chartreuse;


                }
                else if ((numf == "24") && (cat == "medicamento"))
                {
                    fila24.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////

                if ((numf == "25") && (cat == "consulta"))
                {
                    fila25.BackColor = Color.Blue;

                }
                else if ((numf == "25") && (cat == "triagem"))
                {
                    fila25.BackColor = Color.Chartreuse;


                }
                else if ((numf == "25") && (cat == "medicamento"))
                {
                    fila25.BackColor = Color.Red;
                }
                ///////////////////////////////////////////////////////////////
                if ((numf == "26") && (cat == "consulta"))
                {
                    fila26.BackColor = Color.Blue;

                }
                else if ((numf == "26") && (cat == "triagem"))
                {
                    fila26.BackColor = Color.Chartreuse;


                }
                else if ((numf == "26") && (cat == "medicamento"))
                {
                    fila26.BackColor = Color.Red;
                }
                ////////////////////////////////////////////////////////////////////
                if ((numf == "27") && (cat == "consulta"))
                {
                    fila27.BackColor = Color.Blue;

                }
                else if ((numf == "27") && (cat == "triagem"))
                {
                    fila27.BackColor = Color.Chartreuse;


                }
                else if ((numf == "27") && (cat == "medicamento"))
                {
                    fila27.BackColor = Color.Red;
                }
                /////////////////////////////////////////////////////////////////////
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Consultas3 FC3 = new FRM_Consultas3();
            FC3.Show();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}

