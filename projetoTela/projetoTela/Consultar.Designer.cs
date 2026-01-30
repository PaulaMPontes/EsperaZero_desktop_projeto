namespace projetoTela
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.btn_cons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rCpf = new System.Windows.Forms.RadioButton();
            this.rNome = new System.Windows.Forms.RadioButton();
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_paciente = new System.Windows.Forms.DataGridView();
            this.r_csus = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cons
            // 
            this.btn_cons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cons.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cons.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cons.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cons.Image = ((System.Drawing.Image)(resources.GetObject("btn_cons.Image")));
            this.btn_cons.Location = new System.Drawing.Point(429, 195);
            this.btn_cons.Name = "btn_cons";
            this.btn_cons.Size = new System.Drawing.Size(174, 44);
            this.btn_cons.TabIndex = 24;
            this.btn_cons.Text = "Consultar";
            this.btn_cons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cons.UseVisualStyleBackColor = false;
            this.btn_cons.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Consulta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rCpf
            // 
            this.rCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rCpf.AutoSize = true;
            this.rCpf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCpf.Location = new System.Drawing.Point(565, 78);
            this.rCpf.Name = "rCpf";
            this.rCpf.Size = new System.Drawing.Size(58, 23);
            this.rCpf.TabIndex = 25;
            this.rCpf.TabStop = true;
            this.rCpf.Text = "CPF:";
            this.rCpf.UseVisualStyleBackColor = true;
            this.rCpf.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rNome
            // 
            this.rNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rNome.AutoSize = true;
            this.rNome.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNome.Location = new System.Drawing.Point(380, 78);
            this.rNome.Name = "rNome";
            this.rNome.Size = new System.Drawing.Size(142, 23);
            this.rNome.TabIndex = 26;
            this.rNome.TabStop = true;
            this.rNome.Text = "Nome Completo:";
            this.rNome.UseVisualStyleBackColor = true;
            this.rNome.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_consulta
            // 
            this.txt_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_consulta.Location = new System.Drawing.Point(380, 157);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(267, 20);
            this.txt_consulta.TabIndex = 27;
            this.txt_consulta.TextChanged += new System.EventHandler(this.txt_consulta_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(922, 374);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 112);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 34);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_paciente
            // 
            this.dgv_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paciente.Location = new System.Drawing.Point(197, 245);
            this.dgv_paciente.Name = "dgv_paciente";
            this.dgv_paciente.Size = new System.Drawing.Size(624, 199);
            this.dgv_paciente.TabIndex = 29;
            this.dgv_paciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_paciente_CellContentClick);
            // 
            // r_csus
            // 
            this.r_csus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.r_csus.AutoSize = true;
            this.r_csus.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_csus.Location = new System.Drawing.Point(380, 108);
            this.r_csus.Name = "r_csus";
            this.r_csus.Size = new System.Drawing.Size(129, 23);
            this.r_csus.TabIndex = 33;
            this.r_csus.TabStop = true;
            this.r_csus.Text = "Cartão do SUS:";
            this.r_csus.UseVisualStyleBackColor = true;
            this.r_csus.CheckedChanged += new System.EventHandler(this.r_csus_CheckedChanged);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1047, 477);
            this.Controls.Add(this.r_csus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgv_paciente);
            this.Controls.Add(this.txt_consulta);
            this.Controls.Add(this.rNome);
            this.Controls.Add(this.rCpf);
            this.Controls.Add(this.btn_cons);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Consultar";
            this.Text = "Consultar Paciente";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rCpf;
        private System.Windows.Forms.RadioButton rNome;
        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_paciente;
        private System.Windows.Forms.RadioButton r_csus;
    }
}