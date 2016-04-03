namespace _141142_MihailNacev_VPLab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPole3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPole2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPole1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrisiKosnicka = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstKosnicka = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Kolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти:";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(16, 34);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(225, 277);
            this.lstLista.TabIndex = 1;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Испразни ја листата со продукти?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kolicina);
            this.groupBox1.Controls.Add(this.tbPole3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPole2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPole1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(257, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // tbPole3
            // 
            this.tbPole3.Location = new System.Drawing.Point(7, 125);
            this.tbPole3.Name = "tbPole3";
            this.tbPole3.ReadOnly = true;
            this.tbPole3.Size = new System.Drawing.Size(88, 20);
            this.tbPole3.TabIndex = 5;
            this.tbPole3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена:";
            // 
            // tbPole2
            // 
            this.tbPole2.Location = new System.Drawing.Point(7, 80);
            this.tbPole2.Name = "tbPole2";
            this.tbPole2.ReadOnly = true;
            this.tbPole2.Size = new System.Drawing.Size(187, 20);
            this.tbPole2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категорија";
            // 
            // tbPole1
            // 
            this.tbPole1.Location = new System.Drawing.Point(7, 37);
            this.tbPole1.Name = "tbPole1";
            this.tbPole1.ReadOnly = true;
            this.tbPole1.Size = new System.Drawing.Size(187, 20);
            this.tbPole1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име";
            // 
            // btnDodadiKosnicka
            // 
            this.btnDodadiKosnicka.Location = new System.Drawing.Point(257, 199);
            this.btnDodadiKosnicka.Name = "btnDodadiKosnicka";
            this.btnDodadiKosnicka.Size = new System.Drawing.Size(194, 23);
            this.btnDodadiKosnicka.TabIndex = 4;
            this.btnDodadiKosnicka.Text = "Додади во кошничка >> ";
            this.btnDodadiKosnicka.UseVisualStyleBackColor = true;
            this.btnDodadiKosnicka.Click += new System.EventHandler(this.btnDodadiKosnicka_Click);
            // 
            // btnIzbrisiKosnicka
            // 
            this.btnIzbrisiKosnicka.Location = new System.Drawing.Point(257, 228);
            this.btnIzbrisiKosnicka.Name = "btnIzbrisiKosnicka";
            this.btnIzbrisiKosnicka.Size = new System.Drawing.Size(200, 23);
            this.btnIzbrisiKosnicka.TabIndex = 5;
            this.btnIzbrisiKosnicka.Text = "Избриши од кошничка";
            this.btnIzbrisiKosnicka.UseVisualStyleBackColor = true;
            this.btnIzbrisiKosnicka.Click += new System.EventHandler(this.btnIzbrisiKosnicka_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Додади нов продукт";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(257, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Избриши продукт";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кошничка:";
            // 
            // lstKosnicka
            // 
            this.lstKosnicka.FormattingEnabled = true;
            this.lstKosnicka.Location = new System.Drawing.Point(464, 34);
            this.lstKosnicka.Name = "lstKosnicka";
            this.lstKosnicka.Size = new System.Drawing.Size(225, 251);
            this.lstKosnicka.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вкупно:";
            // 
            // tbVkupno
            // 
            this.tbVkupno.Location = new System.Drawing.Point(515, 291);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.ReadOnly = true;
            this.tbVkupno.Size = new System.Drawing.Size(174, 20);
            this.tbVkupno.TabIndex = 11;
            this.tbVkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbVkupno.TextChanged += new System.EventHandler(this.tbVkupno_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(464, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(225, 30);
            this.button6.TabIndex = 12;
            this.button6.Text = "Испразни ја кошничката?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Kolicina
            // 
            this.Kolicina.Location = new System.Drawing.Point(101, 125);
            this.Kolicina.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Kolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Kolicina.Size = new System.Drawing.Size(93, 20);
            this.Kolicina.TabIndex = 6;
            this.Kolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 400);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbVkupno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstKosnicka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnIzbrisiKosnicka);
            this.Controls.Add(this.btnDodadiKosnicka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPole1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPole3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPole2;
        private System.Windows.Forms.Button btnDodadiKosnicka;
        private System.Windows.Forms.Button btnIzbrisiKosnicka;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstKosnicka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown Kolicina;
    }
}

