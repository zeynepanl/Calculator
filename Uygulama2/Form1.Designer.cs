namespace Uygulama2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox_sayı1 = new System.Windows.Forms.TextBox();
            this.textBox_sayı2 = new System.Windows.Forms.TextBox();
            this.label_sayı2 = new System.Windows.Forms.Label();
            this.label_sayı1 = new System.Windows.Forms.Label();
            this.checkBox_bol = new System.Windows.Forms.CheckBox();
            this.checkBox_carp = new System.Windows.Forms.CheckBox();
            this.checkBox_cıkar = new System.Windows.Forms.CheckBox();
            this.checkBox_topla = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_sonuc = new System.Windows.Forms.Label();
            this.button_sonuc = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_cıkar = new System.Windows.Forms.Button();
            this.button1_ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_islem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbarttır = new System.Windows.Forms.RadioButton();
            this.rbazalt = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.textBox_sayı1);
            this.panel1.Controls.Add(this.textBox_sayı2);
            this.panel1.Controls.Add(this.label_sayı2);
            this.panel1.Controls.Add(this.label_sayı1);
            this.panel1.Controls.Add(this.checkBox_bol);
            this.panel1.Controls.Add(this.checkBox_carp);
            this.panel1.Controls.Add(this.checkBox_cıkar);
            this.panel1.Controls.Add(this.checkBox_topla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 128);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(410, 90);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(43, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBox_sayı1
            // 
            this.textBox_sayı1.Location = new System.Drawing.Point(72, 90);
            this.textBox_sayı1.Name = "textBox_sayı1";
            this.textBox_sayı1.Size = new System.Drawing.Size(122, 22);
            this.textBox_sayı1.TabIndex = 3;
            // 
            // textBox_sayı2
            // 
            this.textBox_sayı2.Location = new System.Drawing.Point(255, 90);
            this.textBox_sayı2.Name = "textBox_sayı2";
            this.textBox_sayı2.Size = new System.Drawing.Size(122, 22);
            this.textBox_sayı2.TabIndex = 3;
            // 
            // label_sayı2
            // 
            this.label_sayı2.AutoSize = true;
            this.label_sayı2.Location = new System.Drawing.Point(200, 90);
            this.label_sayı2.Name = "label_sayı2";
            this.label_sayı2.Size = new System.Drawing.Size(49, 16);
            this.label_sayı2.TabIndex = 2;
            this.label_sayı2.Text = "sayı 2=";
            // 
            // label_sayı1
            // 
            this.label_sayı1.AutoSize = true;
            this.label_sayı1.Location = new System.Drawing.Point(17, 90);
            this.label_sayı1.Name = "label_sayı1";
            this.label_sayı1.Size = new System.Drawing.Size(49, 16);
            this.label_sayı1.TabIndex = 2;
            this.label_sayı1.Text = "sayı 1=";
            // 
            // checkBox_bol
            // 
            this.checkBox_bol.AutoSize = true;
            this.checkBox_bol.Location = new System.Drawing.Point(320, 34);
            this.checkBox_bol.Name = "checkBox_bol";
            this.checkBox_bol.Size = new System.Drawing.Size(48, 20);
            this.checkBox_bol.TabIndex = 1;
            this.checkBox_bol.Text = "böl";
            this.checkBox_bol.UseVisualStyleBackColor = true;
            // 
            // checkBox_carp
            // 
            this.checkBox_carp.AutoSize = true;
            this.checkBox_carp.Location = new System.Drawing.Point(219, 34);
            this.checkBox_carp.Name = "checkBox_carp";
            this.checkBox_carp.Size = new System.Drawing.Size(56, 20);
            this.checkBox_carp.TabIndex = 1;
            this.checkBox_carp.Text = "çarp";
            this.checkBox_carp.UseVisualStyleBackColor = true;
            this.checkBox_carp.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox_cıkar
            // 
            this.checkBox_cıkar.AutoSize = true;
            this.checkBox_cıkar.Location = new System.Drawing.Point(118, 34);
            this.checkBox_cıkar.Name = "checkBox_cıkar";
            this.checkBox_cıkar.Size = new System.Drawing.Size(58, 20);
            this.checkBox_cıkar.TabIndex = 1;
            this.checkBox_cıkar.Text = "çıkar";
            this.checkBox_cıkar.UseVisualStyleBackColor = true;
            // 
            // checkBox_topla
            // 
            this.checkBox_topla.AutoSize = true;
            this.checkBox_topla.Location = new System.Drawing.Point(17, 34);
            this.checkBox_topla.Name = "checkBox_topla";
            this.checkBox_topla.Size = new System.Drawing.Size(59, 20);
            this.checkBox_topla.TabIndex = 1;
            this.checkBox_topla.Text = "topla";
            this.checkBox_topla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel 1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.rbazalt);
            this.panel2.Controls.Add(this.rbarttır);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 99);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Panel 4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.label_sonuc);
            this.panel3.Controls.Add(this.button_sonuc);
            this.panel3.Controls.Add(this.button_temizle);
            this.panel3.Controls.Add(this.button_cıkar);
            this.panel3.Controls.Add(this.button1_ekle);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_islem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(2, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 258);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label_sonuc
            // 
            this.label_sonuc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_sonuc.Location = new System.Drawing.Point(1, 235);
            this.label_sonuc.Name = "label_sonuc";
            this.label_sonuc.Size = new System.Drawing.Size(229, 23);
            this.label_sonuc.TabIndex = 6;
            this.label_sonuc.Text = "Sonuç :";
            // 
            // button_sonuc
            // 
            this.button_sonuc.Location = new System.Drawing.Point(148, 153);
            this.button_sonuc.Name = "button_sonuc";
            this.button_sonuc.Size = new System.Drawing.Size(75, 23);
            this.button_sonuc.TabIndex = 5;
            this.button_sonuc.Text = "sonuç";
            this.button_sonuc.UseVisualStyleBackColor = true;
            this.button_sonuc.Click += new System.EventHandler(this.button_sonuc_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Location = new System.Drawing.Point(148, 124);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(75, 23);
            this.button_temizle.TabIndex = 5;
            this.button_temizle.Text = "temizle";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button_cıkar
            // 
            this.button_cıkar.Location = new System.Drawing.Point(148, 95);
            this.button_cıkar.Name = "button_cıkar";
            this.button_cıkar.Size = new System.Drawing.Size(75, 23);
            this.button_cıkar.TabIndex = 5;
            this.button_cıkar.Text = "çıkar >";
            this.button_cıkar.UseVisualStyleBackColor = true;
            this.button_cıkar.Click += new System.EventHandler(this.button_cıkar_Click);
            // 
            // button1_ekle
            // 
            this.button1_ekle.Location = new System.Drawing.Point(148, 65);
            this.button1_ekle.Name = "button1_ekle";
            this.button1_ekle.Size = new System.Drawing.Size(75, 23);
            this.button1_ekle.TabIndex = 4;
            this.button1_ekle.Text = "< ekle";
            this.button1_ekle.UseVisualStyleBackColor = true;
            this.button1_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 164);
            this.listBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Panel 2";
            // 
            // textBox_islem
            // 
            this.textBox_islem.Location = new System.Drawing.Point(72, 19);
            this.textBox_islem.Name = "textBox_islem";
            this.textBox_islem.Size = new System.Drawing.Size(156, 22);
            this.textBox_islem.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "işlem =";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(239, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 258);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sonuç :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "topla",
            "çıkar",
            "çarp",
            "böl"});
            this.comboBox1.Location = new System.Drawing.Point(21, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "sonuç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_sonuc_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Panel 3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "< ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "çıkar >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_cıkar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // rbarttır
            // 
            this.rbarttır.AutoSize = true;
            this.rbarttır.Location = new System.Drawing.Point(22, 31);
            this.rbarttır.Name = "rbarttır";
            this.rbarttır.Size = new System.Drawing.Size(53, 20);
            this.rbarttır.TabIndex = 2;
            this.rbarttır.TabStop = true;
            this.rbarttır.Text = "arttır";
            this.rbarttır.UseVisualStyleBackColor = true;
            // 
            // rbazalt
            // 
            this.rbazalt.AutoSize = true;
            this.rbazalt.Location = new System.Drawing.Point(148, 31);
            this.rbazalt.Name = "rbazalt";
            this.rbazalt.Size = new System.Drawing.Size(56, 20);
            this.rbazalt.TabIndex = 2;
            this.rbazalt.TabStop = true;
            this.rbazalt.Text = "azalt";
            this.rbazalt.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(304, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "BAŞLA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_bol;
        private System.Windows.Forms.CheckBox checkBox_carp;
        private System.Windows.Forms.CheckBox checkBox_cıkar;
        private System.Windows.Forms.CheckBox checkBox_topla;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBox_sayı2;
        private System.Windows.Forms.TextBox textBox_islem;
        private System.Windows.Forms.Label label_sayı2;
        private System.Windows.Forms.Label label_sayı1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_sonuc;
        private System.Windows.Forms.Button button_sonuc;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_cıkar;
        private System.Windows.Forms.Button button1_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sayı1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton rbazalt;
        private System.Windows.Forms.RadioButton rbarttır;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

