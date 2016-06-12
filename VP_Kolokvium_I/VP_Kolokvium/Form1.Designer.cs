namespace VP_Kolokvium
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
            this.btnNovS = new System.Windows.Forms.Button();
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.tbProsek = new System.Windows.Forms.TextBox();
            this.btnIzbrisiS = new System.Windows.Forms.Button();
            this.tbPolozeni = new System.Windows.Forms.TextBox();
            this.lbPredmeti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBrojac = new System.Windows.Forms.NumericUpDown();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на студенти";
            // 
            // btnNovS
            // 
            this.btnNovS.Location = new System.Drawing.Point(415, 368);
            this.btnNovS.Name = "btnNovS";
            this.btnNovS.Size = new System.Drawing.Size(229, 23);
            this.btnNovS.TabIndex = 2;
            this.btnNovS.Text = "Нов студент";
            this.btnNovS.UseVisualStyleBackColor = true;
            this.btnNovS.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStudenti
            // 
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.Location = new System.Drawing.Point(415, 29);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.Size = new System.Drawing.Size(229, 316);
            this.lbStudenti.TabIndex = 0;
            this.lbStudenti.SelectedIndexChanged += new System.EventHandler(this.lbStudenti_SelectedIndexChanged);
            // 
            // tbProsek
            // 
            this.tbProsek.Location = new System.Drawing.Point(141, 373);
            this.tbProsek.Name = "tbProsek";
            this.tbProsek.ReadOnly = true;
            this.tbProsek.Size = new System.Drawing.Size(100, 20);
            this.tbProsek.TabIndex = 3;
            this.tbProsek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIzbrisiS
            // 
            this.btnIzbrisiS.Location = new System.Drawing.Point(415, 419);
            this.btnIzbrisiS.Name = "btnIzbrisiS";
            this.btnIzbrisiS.Size = new System.Drawing.Size(229, 23);
            this.btnIzbrisiS.TabIndex = 4;
            this.btnIzbrisiS.Text = "Избриши студент";
            this.btnIzbrisiS.UseVisualStyleBackColor = true;
            this.btnIzbrisiS.Click += new System.EventHandler(this.btnIzbrisiS_Click);
            // 
            // tbPolozeni
            // 
            this.tbPolozeni.Location = new System.Drawing.Point(141, 426);
            this.tbPolozeni.Name = "tbPolozeni";
            this.tbPolozeni.ReadOnly = true;
            this.tbPolozeni.Size = new System.Drawing.Size(100, 20);
            this.tbPolozeni.TabIndex = 5;
            this.tbPolozeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPredmeti
            // 
            this.lbPredmeti.FormattingEnabled = true;
            this.lbPredmeti.Location = new System.Drawing.Point(12, 29);
            this.lbPredmeti.Name = "lbPredmeti";
            this.lbPredmeti.Size = new System.Drawing.Size(229, 316);
            this.lbPredmeti.TabIndex = 6;
            this.lbPredmeti.SelectedIndexChanged += new System.EventHandler(this.lbPredmeti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Досие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Просек:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Положени испити:";
            // 
            // nudBrojac
            // 
            this.nudBrojac.Location = new System.Drawing.Point(248, 29);
            this.nudBrojac.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudBrojac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojac.Name = "nudBrojac";
            this.nudBrojac.Size = new System.Drawing.Size(161, 20);
            this.nudBrojac.TabIndex = 10;
            this.nudBrojac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(248, 56);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(161, 23);
            this.btnGeneriraj.TabIndex = 11;
            this.btnGeneriraj.Text = "Генерирај досие";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 592);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.nudBrojac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPredmeti);
            this.Controls.Add(this.tbPolozeni);
            this.Controls.Add(this.btnIzbrisiS);
            this.Controls.Add(this.tbProsek);
            this.Controls.Add(this.lbStudenti);
            this.Controls.Add(this.btnNovS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Досие студент";
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovS;
        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.TextBox tbProsek;
        private System.Windows.Forms.Button btnIzbrisiS;
        private System.Windows.Forms.TextBox tbPolozeni;
        private System.Windows.Forms.ListBox lbPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBrojac;
        private System.Windows.Forms.Button btnGeneriraj;
    }
}

