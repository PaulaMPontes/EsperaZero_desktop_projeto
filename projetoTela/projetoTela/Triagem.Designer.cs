namespace projetoTela
{
    partial class Triagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triagem));
            this.label12 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nomec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_ox = new System.Windows.Forms.TextBox();
            this.txt_prss = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.res_s = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.ComboBox();
            this.txt_idd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_medic = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_droga = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ptrc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_alerg = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.mtxt_cpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(159, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 39;
            this.label12.Text = "Pressão:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(298, 285);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(96, 20);
            this.txt_peso.TabIndex = 36;
            this.txt_peso.TextChanged += new System.EventHandler(this.txt_end_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Peso(kg):";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_nomec
            // 
            this.txt_nomec.Location = new System.Drawing.Point(298, 102);
            this.txt_nomec.Name = "txt_nomec";
            this.txt_nomec.Size = new System.Drawing.Size(269, 20);
            this.txt_nomec.TabIndex = 33;
            this.txt_nomec.TextChanged += new System.EventHandler(this.txt_nomec_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Oxigênio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Altura( , ):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 29;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome Completo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(262, 635);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(305, 147);
            this.txt_obs.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Observação: ";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_calcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_calcular.Image")));
            this.btn_calcular.Location = new System.Drawing.Point(667, 247);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(144, 40);
            this.btn_calcular.TabIndex = 43;
            this.btn_calcular.Text = "IMC";
            this.btn_calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_ox
            // 
            this.txt_ox.Location = new System.Drawing.Point(298, 323);
            this.txt_ox.Name = "txt_ox";
            this.txt_ox.Size = new System.Drawing.Size(96, 20);
            this.txt_ox.TabIndex = 45;
            // 
            // txt_prss
            // 
            this.txt_prss.Location = new System.Drawing.Point(298, 364);
            this.txt_prss.Name = "txt_prss";
            this.txt_prss.Size = new System.Drawing.Size(96, 20);
            this.txt_prss.TabIndex = 46;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(452, 247);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 19);
            this.lbl.TabIndex = 47;
            this.lbl.Text = "IMC:";
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.Location = new System.Drawing.Point(498, 247);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(18, 19);
            this.lbl_imc.TabIndex = 48;
            this.lbl_imc.Text = "...";
            // 
            // s2
            // 
            this.s2.FormattingEnabled = true;
            this.s2.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.s2.Location = new System.Drawing.Point(298, 211);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(100, 21);
            this.s2.TabIndex = 49;
            this.s2.Text = "Selecione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Sexo:";
            // 
            // res_s
            // 
            this.res_s.AutoSize = true;
            this.res_s.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_s.Location = new System.Drawing.Point(529, 275);
            this.res_s.Name = "res_s";
            this.res_s.Size = new System.Drawing.Size(18, 19);
            this.res_s.TabIndex = 52;
            this.res_s.Text = "...";
            this.res_s.Click += new System.EventHandler(this.res_s_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Situação:";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(298, 249);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(96, 20);
            this.txt_altura.TabIndex = 34;
            this.txt_altura.TextChanged += new System.EventHandler(this.txt_nomeu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 34);
            this.label7.TabIndex = 53;
            this.label7.Text = "Triagem";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Location = new System.Drawing.Point(705, 695);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 112);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(669, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 55;
            this.button1.Text = "Enviar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 32);
            this.button3.TabIndex = 56;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "Tipo sanguíneo:";
            // 
            // txt_tipo
            // 
            this.txt_tipo.FormattingEnabled = true;
            this.txt_tipo.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.txt_tipo.Location = new System.Drawing.Point(298, 402);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(100, 21);
            this.txt_tipo.TabIndex = 57;
            this.txt_tipo.Text = "Selecione";
            // 
            // txt_idd
            // 
            this.txt_idd.Location = new System.Drawing.Point(298, 174);
            this.txt_idd.Name = "txt_idd";
            this.txt_idd.Size = new System.Drawing.Size(96, 20);
            this.txt_idd.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 59;
            this.label11.Text = "Idade:";
            // 
            // txt_medic
            // 
            this.txt_medic.Location = new System.Drawing.Point(477, 447);
            this.txt_medic.Name = "txt_medic";
            this.txt_medic.Size = new System.Drawing.Size(234, 20);
            this.txt_medic.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(158, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(313, 19);
            this.label13.TabIndex = 61;
            this.label13.Text = "Utiliza algum medicamento periodicamente?";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_droga
            // 
            this.txt_droga.Location = new System.Drawing.Point(533, 587);
            this.txt_droga.Name = "txt_droga";
            this.txt_droga.Size = new System.Drawing.Size(178, 20);
            this.txt_droga.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(158, 588);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(365, 19);
            this.label14.TabIndex = 63;
            this.label14.Text = "Utiliza algum tipo de droga(álcool/entorpecentes) ?";
            // 
            // txt_ptrc
            // 
            this.txt_ptrc.Location = new System.Drawing.Point(641, 529);
            this.txt_ptrc.Multiline = true;
            this.txt_ptrc.Name = "txt_ptrc";
            this.txt_ptrc.Size = new System.Drawing.Size(172, 39);
            this.txt_ptrc.TabIndex = 66;
            this.txt_ptrc.TextChanged += new System.EventHandler(this.txt_ptrc_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(158, 528);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(483, 19);
            this.label15.TabIndex = 65;
            this.label15.Text = "Prática exercício(s)/atividade(s) físicos(as)? Se sim, qual frequência?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(158, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(248, 19);
            this.label16.TabIndex = 67;
            this.label16.Text = "Alérgico(a) a algum medicamento?";
            // 
            // txt_alerg
            // 
            this.txt_alerg.Location = new System.Drawing.Point(477, 485);
            this.txt_alerg.Name = "txt_alerg";
            this.txt_alerg.Size = new System.Drawing.Size(234, 20);
            this.txt_alerg.TabIndex = 68;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(158, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 19);
            this.label17.TabIndex = 69;
            this.label17.Text = "CPF:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 743);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 44);
            this.button2.TabIndex = 85;
            this.button2.Text = "Liberar Paciente";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument2;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(298, 137);
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(82, 20);
            this.mtxt_cpf.TabIndex = 86;
            // 
            // Triagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(823, 799);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_alerg);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_ptrc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_droga);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_medic);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_idd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.res_s);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt_prss);
            this.Controls.Add(this.txt_ox);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_nomec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Triagem";
            this.Text = "Triagem";
            this.Load += new System.EventHandler(this.Triagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nomec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_ox;
        private System.Windows.Forms.TextBox txt_prss;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.ComboBox s2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label res_s;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txt_tipo;
        private System.Windows.Forms.TextBox txt_idd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_medic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_droga;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ptrc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_alerg;
        private System.Windows.Forms.Label label17;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.TextBox mtxt_cpf;
    }
}