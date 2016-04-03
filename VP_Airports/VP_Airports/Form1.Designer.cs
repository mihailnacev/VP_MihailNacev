namespace VP_Airports
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
            this.lbAerodromi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDestinacii = new System.Windows.Forms.ListBox();
            this.btnDodadiAerodrom = new System.Windows.Forms.Button();
            this.btnIzbrisiAerodrom = new System.Windows.Forms.Button();
            this.btnDodadiDestinacija = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProsecna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNajskapa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // lbAerodromi
            // 
            this.lbAerodromi.FormattingEnabled = true;
            this.lbAerodromi.Location = new System.Drawing.Point(13, 30);
            this.lbAerodromi.Name = "lbAerodromi";
            this.lbAerodromi.Size = new System.Drawing.Size(200, 160);
            this.lbAerodromi.TabIndex = 1;
            this.lbAerodromi.SelectedIndexChanged += new System.EventHandler(this.lbAerodromi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дестинации";
            // 
            // lbDestinacii
            // 
            this.lbDestinacii.FormattingEnabled = true;
            this.lbDestinacii.Location = new System.Drawing.Point(219, 30);
            this.lbDestinacii.Name = "lbDestinacii";
            this.lbDestinacii.Size = new System.Drawing.Size(205, 160);
            this.lbDestinacii.TabIndex = 3;
            // 
            // btnDodadiAerodrom
            // 
            this.btnDodadiAerodrom.Location = new System.Drawing.Point(13, 197);
            this.btnDodadiAerodrom.Name = "btnDodadiAerodrom";
            this.btnDodadiAerodrom.Size = new System.Drawing.Size(200, 30);
            this.btnDodadiAerodrom.TabIndex = 4;
            this.btnDodadiAerodrom.Text = "Додади аеродром";
            this.btnDodadiAerodrom.UseVisualStyleBackColor = true;
            this.btnDodadiAerodrom.Click += new System.EventHandler(this.btnDodadiAerodrom_Click);
            // 
            // btnIzbrisiAerodrom
            // 
            this.btnIzbrisiAerodrom.Location = new System.Drawing.Point(13, 246);
            this.btnIzbrisiAerodrom.Name = "btnIzbrisiAerodrom";
            this.btnIzbrisiAerodrom.Size = new System.Drawing.Size(200, 30);
            this.btnIzbrisiAerodrom.TabIndex = 5;
            this.btnIzbrisiAerodrom.Text = "Избриши аеродром";
            this.btnIzbrisiAerodrom.UseVisualStyleBackColor = true;
            this.btnIzbrisiAerodrom.Click += new System.EventHandler(this.btnIzbrisiAerodrom_Click);
            // 
            // btnDodadiDestinacija
            // 
            this.btnDodadiDestinacija.Location = new System.Drawing.Point(12, 295);
            this.btnDodadiDestinacija.Name = "btnDodadiDestinacija";
            this.btnDodadiDestinacija.Size = new System.Drawing.Size(200, 30);
            this.btnDodadiDestinacija.TabIndex = 6;
            this.btnDodadiDestinacija.Text = "Додади дестинација";
            this.btnDodadiDestinacija.UseVisualStyleBackColor = true;
            this.btnDodadiDestinacija.Click += new System.EventHandler(this.btnDodadiDestinacija_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProsecna);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNajskapa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(219, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // tbProsecna
            // 
            this.tbProsecna.Location = new System.Drawing.Point(9, 82);
            this.tbProsecna.Name = "tbProsecna";
            this.tbProsecna.ReadOnly = true;
            this.tbProsecna.Size = new System.Drawing.Size(189, 20);
            this.tbProsecna.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // tbNajskapa
            // 
            this.tbNajskapa.Location = new System.Drawing.Point(10, 36);
            this.tbNajskapa.Name = "tbNajskapa";
            this.tbNajskapa.ReadOnly = true;
            this.tbNajskapa.Size = new System.Drawing.Size(189, 20);
            this.tbNajskapa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Најскапа дестинација";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodadiDestinacija);
            this.Controls.Add(this.btnIzbrisiAerodrom);
            this.Controls.Add(this.btnDodadiAerodrom);
            this.Controls.Add(this.lbDestinacii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAerodromi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAerodromi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDestinacii;
        private System.Windows.Forms.Button btnDodadiAerodrom;
        private System.Windows.Forms.Button btnIzbrisiAerodrom;
        private System.Windows.Forms.Button btnDodadiDestinacija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProsecna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNajskapa;
        private System.Windows.Forms.Label label3;
    }
}

