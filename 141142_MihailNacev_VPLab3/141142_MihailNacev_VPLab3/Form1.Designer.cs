namespace _141142_MihailNacev_VPLab3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SrednaPica = new System.Windows.Forms.TextBox();
            this.GolemaPica = new System.Windows.Forms.TextBox();
            this.MalaPica = new System.Windows.Forms.TextBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kecap = new System.Windows.Forms.TextBox();
            this.EkstraSirenje = new System.Windows.Forms.TextBox();
            this.Feferonki = new System.Windows.Forms.TextBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.cbEkstraSirenje = new System.Windows.Forms.CheckBox();
            this.cbFeferonki = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vkPivo = new System.Windows.Forms.TextBox();
            this.vkSokJabolko = new System.Windows.Forms.TextBox();
            this.vkKokaKola = new System.Windows.Forms.TextBox();
            this.CenaPivo = new System.Windows.Forms.TextBox();
            this.CenaSokOdJabolko = new System.Windows.Forms.TextBox();
            this.CenaKokaKola = new System.Windows.Forms.TextBox();
            this.KolicinaPivo = new System.Windows.Forms.TextBox();
            this.KolicinaSokOdJabolko = new System.Windows.Forms.TextBox();
            this.KolicinaKokaKola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CenaDesert = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ZaVrakanje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Naplateno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vkupnoNaplata = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SrednaPica);
            this.groupBox1.Controls.Add(this.GolemaPica);
            this.groupBox1.Controls.Add(this.MalaPica);
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // SrednaPica
            // 
            this.SrednaPica.Location = new System.Drawing.Point(183, 57);
            this.SrednaPica.Name = "SrednaPica";
            this.SrednaPica.Size = new System.Drawing.Size(100, 20);
            this.SrednaPica.TabIndex = 4;
            this.SrednaPica.Text = "300";
            this.SrednaPica.TextChanged += new System.EventHandler(this.SrednaPica_TextChanged);
            // 
            // GolemaPica
            // 
            this.GolemaPica.Location = new System.Drawing.Point(183, 92);
            this.GolemaPica.Name = "GolemaPica";
            this.GolemaPica.Size = new System.Drawing.Size(100, 20);
            this.GolemaPica.TabIndex = 5;
            this.GolemaPica.Text = "500";
            this.GolemaPica.TextChanged += new System.EventHandler(this.GolemaPica_TextChanged);
            // 
            // MalaPica
            // 
            this.MalaPica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.MalaPica.Location = new System.Drawing.Point(183, 20);
            this.MalaPica.Name = "MalaPica";
            this.MalaPica.Size = new System.Drawing.Size(100, 20);
            this.MalaPica.TabIndex = 3;
            this.MalaPica.Text = "200";
            this.MalaPica.TextChanged += new System.EventHandler(this.MalaPica_TextChanged);
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(7, 93);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(63, 17);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.TabStop = true;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rbGolema_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(7, 57);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(62, 17);
            this.rbSredna.TabIndex = 1;
            this.rbSredna.TabStop = true;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rbSredna_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(7, 20);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(52, 17);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kecap);
            this.groupBox2.Controls.Add(this.EkstraSirenje);
            this.groupBox2.Controls.Add(this.Feferonki);
            this.groupBox2.Controls.Add(this.cbKecap);
            this.groupBox2.Controls.Add(this.cbEkstraSirenje);
            this.groupBox2.Controls.Add(this.cbFeferonki);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // Kecap
            // 
            this.Kecap.Location = new System.Drawing.Point(185, 93);
            this.Kecap.Name = "Kecap";
            this.Kecap.Size = new System.Drawing.Size(100, 20);
            this.Kecap.TabIndex = 5;
            this.Kecap.Text = "20";
            this.Kecap.TextChanged += new System.EventHandler(this.Kecap_TextChanged);
            // 
            // EkstraSirenje
            // 
            this.EkstraSirenje.Location = new System.Drawing.Point(185, 54);
            this.EkstraSirenje.Name = "EkstraSirenje";
            this.EkstraSirenje.Size = new System.Drawing.Size(100, 20);
            this.EkstraSirenje.TabIndex = 4;
            this.EkstraSirenje.Text = "30";
            this.EkstraSirenje.TextChanged += new System.EventHandler(this.EkstraSirenje_TextChanged);
            // 
            // Feferonki
            // 
            this.Feferonki.Location = new System.Drawing.Point(185, 20);
            this.Feferonki.Name = "Feferonki";
            this.Feferonki.Size = new System.Drawing.Size(100, 20);
            this.Feferonki.TabIndex = 3;
            this.Feferonki.Text = "40";
            this.Feferonki.TextChanged += new System.EventHandler(this.Feferonki_TextChanged);
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(6, 93);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(56, 17);
            this.cbKecap.TabIndex = 2;
            this.cbKecap.Text = "Кечап";
            this.cbKecap.UseVisualStyleBackColor = true;
            this.cbKecap.CheckedChanged += new System.EventHandler(this.cbKecap_CheckedChanged);
            // 
            // cbEkstraSirenje
            // 
            this.cbEkstraSirenje.AutoSize = true;
            this.cbEkstraSirenje.Location = new System.Drawing.Point(7, 57);
            this.cbEkstraSirenje.Name = "cbEkstraSirenje";
            this.cbEkstraSirenje.Size = new System.Drawing.Size(106, 17);
            this.cbEkstraSirenje.TabIndex = 1;
            this.cbEkstraSirenje.Text = "Екстра Сирење";
            this.cbEkstraSirenje.UseVisualStyleBackColor = true;
            this.cbEkstraSirenje.CheckedChanged += new System.EventHandler(this.cbEkstraSirenje_CheckedChanged);
            // 
            // cbFeferonki
            // 
            this.cbFeferonki.AutoSize = true;
            this.cbFeferonki.Location = new System.Drawing.Point(7, 22);
            this.cbFeferonki.Name = "cbFeferonki";
            this.cbFeferonki.Size = new System.Drawing.Size(87, 17);
            this.cbFeferonki.TabIndex = 0;
            this.cbFeferonki.Text = "Феферонки";
            this.cbFeferonki.UseVisualStyleBackColor = true;
            this.cbFeferonki.CheckedChanged += new System.EventHandler(this.cbFeferonki_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.vkPivo);
            this.groupBox3.Controls.Add(this.vkSokJabolko);
            this.groupBox3.Controls.Add(this.vkKokaKola);
            this.groupBox3.Controls.Add(this.CenaPivo);
            this.groupBox3.Controls.Add(this.CenaSokOdJabolko);
            this.groupBox3.Controls.Add(this.CenaKokaKola);
            this.groupBox3.Controls.Add(this.KolicinaPivo);
            this.groupBox3.Controls.Add(this.KolicinaSokOdJabolko);
            this.groupBox3.Controls.Add(this.KolicinaKokaKola);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(29, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Количина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вкупно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            // 
            // vkPivo
            // 
            this.vkPivo.Location = new System.Drawing.Point(479, 90);
            this.vkPivo.Name = "vkPivo";
            this.vkPivo.ReadOnly = true;
            this.vkPivo.Size = new System.Drawing.Size(100, 20);
            this.vkPivo.TabIndex = 11;
            // 
            // vkSokJabolko
            // 
            this.vkSokJabolko.Location = new System.Drawing.Point(479, 56);
            this.vkSokJabolko.Name = "vkSokJabolko";
            this.vkSokJabolko.ReadOnly = true;
            this.vkSokJabolko.Size = new System.Drawing.Size(100, 20);
            this.vkSokJabolko.TabIndex = 10;
            // 
            // vkKokaKola
            // 
            this.vkKokaKola.Location = new System.Drawing.Point(479, 23);
            this.vkKokaKola.Name = "vkKokaKola";
            this.vkKokaKola.ReadOnly = true;
            this.vkKokaKola.Size = new System.Drawing.Size(100, 20);
            this.vkKokaKola.TabIndex = 9;
            // 
            // CenaPivo
            // 
            this.CenaPivo.Location = new System.Drawing.Point(322, 91);
            this.CenaPivo.Name = "CenaPivo";
            this.CenaPivo.Size = new System.Drawing.Size(100, 20);
            this.CenaPivo.TabIndex = 8;
            this.CenaPivo.Text = "80";
            this.CenaPivo.TextChanged += new System.EventHandler(this.CenaPivo_TextChanged);
            // 
            // CenaSokOdJabolko
            // 
            this.CenaSokOdJabolko.Location = new System.Drawing.Point(322, 57);
            this.CenaSokOdJabolko.Name = "CenaSokOdJabolko";
            this.CenaSokOdJabolko.Size = new System.Drawing.Size(100, 20);
            this.CenaSokOdJabolko.TabIndex = 7;
            this.CenaSokOdJabolko.Text = "70";
            this.CenaSokOdJabolko.TextChanged += new System.EventHandler(this.CenaSokOdJabolko_TextChanged);
            // 
            // CenaKokaKola
            // 
            this.CenaKokaKola.Location = new System.Drawing.Point(322, 22);
            this.CenaKokaKola.Name = "CenaKokaKola";
            this.CenaKokaKola.Size = new System.Drawing.Size(100, 20);
            this.CenaKokaKola.TabIndex = 6;
            this.CenaKokaKola.Text = "60";
            this.CenaKokaKola.TextChanged += new System.EventHandler(this.CenaKokaKola_TextChanged);
            // 
            // KolicinaPivo
            // 
            this.KolicinaPivo.Location = new System.Drawing.Point(191, 90);
            this.KolicinaPivo.Name = "KolicinaPivo";
            this.KolicinaPivo.Size = new System.Drawing.Size(100, 20);
            this.KolicinaPivo.TabIndex = 5;
            this.KolicinaPivo.Text = "0";
            this.KolicinaPivo.TextChanged += new System.EventHandler(this.KolicinaPivo_TextChanged);
            // 
            // KolicinaSokOdJabolko
            // 
            this.KolicinaSokOdJabolko.Location = new System.Drawing.Point(191, 57);
            this.KolicinaSokOdJabolko.Name = "KolicinaSokOdJabolko";
            this.KolicinaSokOdJabolko.Size = new System.Drawing.Size(100, 20);
            this.KolicinaSokOdJabolko.TabIndex = 4;
            this.KolicinaSokOdJabolko.Text = "0";
            this.KolicinaSokOdJabolko.TextChanged += new System.EventHandler(this.KolicinaSokOdJabolko_TextChanged);
            // 
            // KolicinaKokaKola
            // 
            this.KolicinaKokaKola.Location = new System.Drawing.Point(191, 22);
            this.KolicinaKokaKola.Name = "KolicinaKokaKola";
            this.KolicinaKokaKola.Size = new System.Drawing.Size(100, 20);
            this.KolicinaKokaKola.TabIndex = 3;
            this.KolicinaKokaKola.Text = "0";
            this.KolicinaKokaKola.TextChanged += new System.EventHandler(this.KolicinaKokaKola_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CenaDesert);
            this.groupBox4.Controls.Add(this.CancelButton);
            this.groupBox4.Controls.Add(this.AcceptButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(29, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // CenaDesert
            // 
            this.CenaDesert.Location = new System.Drawing.Point(176, 39);
            this.CenaDesert.Name = "CenaDesert";
            this.CenaDesert.Size = new System.Drawing.Size(115, 20);
            this.CenaDesert.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(176, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Откажи";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(176, 68);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(115, 23);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Нарачај";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Цена на десерт:";
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "12";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ZaVrakanje);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.Naplateno);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.vkupnoNaplata);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(351, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 140);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // ZaVrakanje
            // 
            this.ZaVrakanje.Location = new System.Drawing.Point(146, 100);
            this.ZaVrakanje.Name = "ZaVrakanje";
            this.ZaVrakanje.ReadOnly = true;
            this.ZaVrakanje.Size = new System.Drawing.Size(125, 20);
            this.ZaVrakanje.TabIndex = 5;
            this.ZaVrakanje.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "За враќање:";
            // 
            // Naplateno
            // 
            this.Naplateno.Location = new System.Drawing.Point(146, 59);
            this.Naplateno.Name = "Naplateno";
            this.Naplateno.Size = new System.Drawing.Size(126, 20);
            this.Naplateno.TabIndex = 3;
            this.Naplateno.Text = "0";
            this.Naplateno.TextChanged += new System.EventHandler(this.Naplateno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Наплатено:";
            // 
            // vkupnoNaplata
            // 
            this.vkupnoNaplata.Location = new System.Drawing.Point(146, 17);
            this.vkupnoNaplata.Name = "vkupnoNaplata";
            this.vkupnoNaplata.ReadOnly = true;
            this.vkupnoNaplata.Size = new System.Drawing.Size(126, 20);
            this.vkupnoNaplata.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Вкупно за плаќање:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 468);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SrednaPica;
        private System.Windows.Forms.TextBox GolemaPica;
        private System.Windows.Forms.TextBox MalaPica;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Kecap;
        private System.Windows.Forms.TextBox EkstraSirenje;
        private System.Windows.Forms.TextBox Feferonki;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.CheckBox cbEkstraSirenje;
        private System.Windows.Forms.CheckBox cbFeferonki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox KolicinaPivo;
        private System.Windows.Forms.TextBox KolicinaSokOdJabolko;
        private System.Windows.Forms.TextBox KolicinaKokaKola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vkPivo;
        private System.Windows.Forms.TextBox vkSokJabolko;
        private System.Windows.Forms.TextBox vkKokaKola;
        private System.Windows.Forms.TextBox CenaPivo;
        private System.Windows.Forms.TextBox CenaSokOdJabolko;
        private System.Windows.Forms.TextBox CenaKokaKola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CenaDesert;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Naplateno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vkupnoNaplata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ZaVrakanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

