namespace _141142_MihailNacev_VPLab5
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbOperand1 = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbOperand2 = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnIgraci = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(87, 23);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(86, 20);
            this.tbIme.TabIndex = 1;
            // 
            // tbOperand1
            // 
            this.tbOperand1.Location = new System.Drawing.Point(25, 57);
            this.tbOperand1.Name = "tbOperand1";
            this.tbOperand1.ReadOnly = true;
            this.tbOperand1.Size = new System.Drawing.Size(85, 20);
            this.tbOperand1.TabIndex = 2;
            // 
            // tbOperator
            // 
            this.tbOperator.Location = new System.Drawing.Point(116, 57);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.ReadOnly = true;
            this.tbOperator.Size = new System.Drawing.Size(59, 20);
            this.tbOperator.TabIndex = 3;
            // 
            // tbOperand2
            // 
            this.tbOperand2.Location = new System.Drawing.Point(181, 57);
            this.tbOperand2.Name = "tbOperand2";
            this.tbOperand2.ReadOnly = true;
            this.tbOperand2.Size = new System.Drawing.Size(82, 20);
            this.tbOperand2.TabIndex = 4;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(308, 57);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(70, 20);
            this.tbRezultat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // btnPogodi
            // 
            this.btnPogodi.Location = new System.Drawing.Point(402, 54);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(75, 23);
            this.btnPogodi.TabIndex = 7;
            this.btnPogodi.Text = "Погоди";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(95, 104);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(35, 13);
            this.lblPoeni.TabIndex = 9;
            this.lblPoeni.Text = "label4";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 148);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(478, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Преостанато време:\r\n";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(149, 197);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(35, 13);
            this.lblVreme.TabIndex = 12;
            this.lblVreme.Text = "label6";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(25, 243);
            this.progressBar2.Maximum = 60;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(478, 23);
            this.progressBar2.TabIndex = 13;
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(25, 312);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(108, 23);
            this.btnNovaIgra.TabIndex = 14;
            this.btnNovaIgra.Text = "Нова игра";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnIgraci
            // 
            this.btnIgraci.Location = new System.Drawing.Point(198, 312);
            this.btnIgraci.Name = "btnIgraci";
            this.btnIgraci.Size = new System.Drawing.Size(143, 23);
            this.btnIgraci.TabIndex = 15;
            this.btnIgraci.Text = "Најдобри играчи";
            this.btnIgraci.UseVisualStyleBackColor = true;
            this.btnIgraci.Click += new System.EventHandler(this.btnIgraci_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Исклучи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 369);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIgraci);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbOperand2);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbOperand1);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbOperand1;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbOperand2;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnIgraci;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}

