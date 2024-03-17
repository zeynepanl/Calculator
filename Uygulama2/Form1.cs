using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1 : Form
    {
        Double sayı1;
        Double sayı2;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (textBox_islem.Text.Trim()== "" || 
                textBox_sayı2.Text.Trim()== "")
            {
                MessageBox.Show("Sayıları boş giremzsiniz...");
                return;
            }
            

            String sayı = textBox_islem.Text;
            this.sayı1 = Convert.ToDouble(sayı);

            sayı = textBox_sayı2.Text;
            this.sayı2 =double.Parse(sayı);

            double sonuc = 0;
            if (checkBox_topla.Checked==true)
            {
                sonuc = sayı1 + sayı2;
                MessageBox.Show("toplam =" + sonuc);
            }
            if (checkBox_cıkar.Checked==true)
            {
                sonuc = sayı1 - sayı2;
                MessageBox.Show("Fark = " + sonuc);
            }
            if ((checkBox_carp.Checked==true))
            {
                sonuc = sayı1 * sayı2;
                MessageBox.Show("Çarpım = " + sonuc);
            }
            if (((checkBox_bol.Checked==true)))
            {
                sonuc = sayı1 / sayı2;
                MessageBox.Show("Bölüm = " + sonuc);
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox_islem.Text;
            textBox_islem.Clear();
            listBox1.Items.Add(s);

        }

        private void button_cıkar_Click(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            if (indeks!=-1)
            {
                listBox1.Items.RemoveAt(indeks);

            }
            
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_sonuc_Click(object sender, EventArgs e)
        {
            String sayı = textBox_sayı1.Text;
            this.sayı1 = Convert.ToDouble(sayı);

            sayı = textBox_sayı2.Text;
            this.sayı2 = double.Parse(sayı);

            string islem = listBox1.SelectedItem.ToString();
            double sonuc = 0;

            switch (islem) {
                case "topla":
                    sonuc = sayı1 + sayı2;
                    break;

                case "çıkar":
                    sonuc = sayı1 -sayı2;
                    break;

                case "böl":
                    sonuc = sayı1 / sayı2;
                    break;

                case "çarp":
                    sonuc = sayı1 * sayı2;
                    break;

                default: 
                    break;

            }

            label_sonuc.Text = "sonuc = " + sonuc;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rbarttır.Checked)
            {
                if(progressBar1.Value+progressBar1.Step<=progressBar1.Maximum)
                {
                    progressBar1.Value += progressBar1.Step;
                }
            }

            else if (rbazalt.Checked)
            {
                if (progressBar1.Value - progressBar1.Step >= progressBar1.Minimum)
                {
                    progressBar1.Value -= progressBar1.Step;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button5.Text = timer1.Enabled ? "DUR" : "BAŞLA";
        }
    }
}
