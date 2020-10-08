using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        ArrayList list = new ArrayList();
       
        private void button1_Click(object sender, EventArgs e)
        {  //Kaydet Butonu
            Kisi kisi = new Kisi();//bir instance'dır. Ram üzerinde oluşturulan kopyadır. 
            kisi.Ad = textBox1.Text;
            kisi.SoyAd = textBox2.Text;
            kisi.Meslek = textBox3.Text;
            kisi.Tarih = dateTimePicker1.Value;
            kisi.EvliMi= checkBox1.Checked;

            list.Add(kisi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Yenile butonu
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Detay butonu
            Kisi deger = (Kisi)listBox1.SelectedItem;
            label5.Text = deger.Ad;
            
        }
    }
}
