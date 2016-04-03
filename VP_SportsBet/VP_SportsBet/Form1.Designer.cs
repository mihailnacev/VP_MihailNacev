namespace VP_SportsBet
{
    partial class Form1
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
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodadiTim = new System.Windows.Forms.Button();
            this.btnDodadiBilten = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudKoef3 = new System.Windows.Forms.NumericUpDown();
            this.nudKoef2 = new System.Windows.Forms.NumericUpDown();
            this.nudKoef1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodadiNatprevar = new System.Windows.Forms.Button();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPecati = new System.Windows.Forms.Button();
            this.tbDobivka = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudUplata = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.tbKoeficient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoef3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoef2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoef1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUplata)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(12, 21);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTeams.Size = new System.Drawing.Size(225, 238);
            this.lbTeams.TabIndex = 0;
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.Location = new System.Drawing.Point(243, 21);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(279, 238);
            this.lbGames.TabIndex = 1;
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.Location = new System.Drawing.Point(528, 21);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(232, 238);
            this.lbTickets.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Листа на тимови:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Билтен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тикет";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodadiTim);
            this.groupBox1.Controls.Add(this.btnDodadiBilten);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSifra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudKoef3);
            this.groupBox1.Controls.Add(this.nudKoef2);
            this.groupBox1.Controls.Add(this.nudKoef1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Креирај билтен";
            // 
            // btnDodadiTim
            // 
            this.btnDodadiTim.Location = new System.Drawing.Point(10, 199);
            this.btnDodadiTim.Name = "btnDodadiTim";
            this.btnDodadiTim.Size = new System.Drawing.Size(195, 23);
            this.btnDodadiTim.TabIndex = 11;
            this.btnDodadiTim.Text = "Додади нов тим";
            this.btnDodadiTim.UseVisualStyleBackColor = true;
            this.btnDodadiTim.Click += new System.EventHandler(this.btnDodadiTim_Click);
            // 
            // btnDodadiBilten
            // 
            this.btnDodadiBilten.Location = new System.Drawing.Point(10, 166);
            this.btnDodadiBilten.Name = "btnDodadiBilten";
            this.btnDodadiBilten.Size = new System.Drawing.Size(195, 23);
            this.btnDodadiBilten.TabIndex = 10;
            this.btnDodadiBilten.Text = "Додади во билтен";
            this.btnDodadiBilten.UseVisualStyleBackColor = true;
            this.btnDodadiBilten.Click += new System.EventHandler(this.btnDodadiBilten_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Шифра:";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(58, 139);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(121, 20);
            this.tbSifra.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "1";
            // 
            // nudKoef3
            // 
            this.nudKoef3.DecimalPlaces = 2;
            this.nudKoef3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudKoef3.Location = new System.Drawing.Point(39, 106);
            this.nudKoef3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKoef3.Name = "nudKoef3";
            this.nudKoef3.Size = new System.Drawing.Size(120, 20);
            this.nudKoef3.TabIndex = 4;
            this.nudKoef3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudKoef2
            // 
            this.nudKoef2.DecimalPlaces = 2;
            this.nudKoef2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudKoef2.Location = new System.Drawing.Point(39, 80);
            this.nudKoef2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKoef2.Name = "nudKoef2";
            this.nudKoef2.Size = new System.Drawing.Size(120, 20);
            this.nudKoef2.TabIndex = 3;
            this.nudKoef2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudKoef1
            // 
            this.nudKoef1.DecimalPlaces = 2;
            this.nudKoef1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudKoef1.Location = new System.Drawing.Point(39, 54);
            this.nudKoef1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKoef1.Name = "nudKoef1";
            this.nudKoef1.Size = new System.Drawing.Size(120, 20);
            this.nudKoef1.TabIndex = 2;
            this.nudKoef1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Постави коефициенти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Избери 2 тима од иста држава";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodadiNatprevar);
            this.groupBox2.Controls.Add(this.cbTip);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(244, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додади натпревар во тикет";
            // 
            // btnDodadiNatprevar
            // 
            this.btnDodadiNatprevar.Location = new System.Drawing.Point(6, 199);
            this.btnDodadiNatprevar.Name = "btnDodadiNatprevar";
            this.btnDodadiNatprevar.Size = new System.Drawing.Size(139, 23);
            this.btnDodadiNatprevar.TabIndex = 5;
            this.btnDodadiNatprevar.Text = "Додади натпревар";
            this.btnDodadiNatprevar.UseVisualStyleBackColor = true;
            this.btnDodadiNatprevar.Click += new System.EventHandler(this.btnDodadiNatprevar_Click);
            // 
            // cbTip
            // 
            this.cbTip.AllowDrop = true;
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbTip.Location = new System.Drawing.Point(10, 154);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(112, 21);
            this.cbTip.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Избери тип:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Шифра:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Избери натпревар од билтенот или внеси шифра";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPecati);
            this.groupBox3.Controls.Add(this.tbDobivka);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.nudUplata);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbKoeficient);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(528, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 228);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Уплати тикет";
            // 
            // btnPecati
            // 
            this.btnPecati.Location = new System.Drawing.Point(10, 184);
            this.btnPecati.Name = "btnPecati";
            this.btnPecati.Size = new System.Drawing.Size(216, 23);
            this.btnPecati.TabIndex = 6;
            this.btnPecati.Text = "Печати";
            this.btnPecati.UseVisualStyleBackColor = true;
            // 
            // tbDobivka
            // 
            this.tbDobivka.Location = new System.Drawing.Point(10, 139);
            this.tbDobivka.Name = "tbDobivka";
            this.tbDobivka.ReadOnly = true;
            this.tbDobivka.Size = new System.Drawing.Size(216, 20);
            this.tbDobivka.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Добивка:";
            // 
            // nudUplata
            // 
            this.nudUplata.Location = new System.Drawing.Point(10, 81);
            this.nudUplata.Name = "nudUplata";
            this.nudUplata.Size = new System.Drawing.Size(216, 20);
            this.nudUplata.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Уплата:";
            // 
            // tbKoeficient
            // 
            this.tbKoeficient.Location = new System.Drawing.Point(10, 37);
            this.tbKoeficient.Name = "tbKoeficient";
            this.tbKoeficient.ReadOnly = true;
            this.tbKoeficient.Size = new System.Drawing.Size(216, 20);
            this.tbKoeficient.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Вкупно коефициент:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.lbTeams);
            this.Name = "Form1";
            this.Text = "Спортска обложувалница";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoef3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoef2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoef1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodadiTim;
        private System.Windows.Forms.Button btnDodadiBilten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudKoef3;
        private System.Windows.Forms.NumericUpDown nudKoef2;
        private System.Windows.Forms.NumericUpDown nudKoef1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodadiNatprevar;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPecati;
        private System.Windows.Forms.TextBox tbDobivka;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudUplata;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbKoeficient;
        private System.Windows.Forms.Label label13;
    }
}

