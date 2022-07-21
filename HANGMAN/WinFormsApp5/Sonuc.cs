using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp5
{
    public partial class Sonuc : MetroFramework.Forms.MetroForm
    {
        
        adamasgiris again;
        

        int winorlose;
        int puan;
        string aranann;
        int kalan;
        int kalanipucuu;

        string isim;
        
        
        public Sonuc(int sonuccc ,int puaann,string aranan,int kalantahmin, int kalanipucu,string gelenisim)
        {
            InitializeComponent();
            winorlose = sonuccc;
            puan = puaann;
            aranann = aranan;
            kalan = kalantahmin;
            kalanipucuu = kalanipucu;
            isim = gelenisim;
            


        }


        private void Sonuc_Load(object sender, EventArgs e)
        {
            if (winorlose==1)
            {
                label4.Text = isim;
                Sonucc.Text = "Kazandın";
                metroPanel1.ForeColor = Color.Green;
                Puann.Text += puan.ToString();
                label1.Text += aranann;
                label2.Text += kalan.ToString();
                label3.Text += kalanipucuu.ToString();
                string dosya = "skortablosu.txt";

                    FileStream fs = new FileStream(dosya, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Close();
                    string write = isim + " " + puan.ToString();
                    File.AppendAllText(dosya, Environment.NewLine + write);
                


            }
            if (winorlose==-1)
            {
                label4.Text = isim;
                Sonucc.Text = "Kaybettin";
                metroPanel1.ForeColor = Color.Red;
                Puann.Text += puan.ToString();
                label1.Text += aranann;
                label2.Text += kalan.ToString();
                label3.Text += kalanipucuu.ToString();
                string dosya = "skortablosu.txt";

                    FileStream fs = new FileStream(dosya, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    string write = isim + " " + puan.ToString();
                    File.AppendAllText(dosya, Environment.NewLine + write);
                    fs.Close();
                    fs.Flush();
               


            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            again = new adamasgiris();
            again.ShowDialog();
            this.Close();
            
        }

        public static void SkorTablosu(ListView listView)
        {
            string dosya_yolu = "skortablosu.txt";
            
            
            using (var stream = File.Open(dosya_yolu, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {

               
                StreamReader sr = new StreamReader(stream);
                string metin;
                int sayac;
               
                if ((metin = sr.ReadLine()) != null)
                {
                    int i = 0;
                    sayac = metin.Length;
                    while ((metin = sr.ReadLine()) != null)
                    {
                        string[] isimpuan = metin.Split();
                        ListViewItem item = new ListViewItem(isimpuan[0]);
                        item.SubItems.Add(isimpuan[1]);

                        listView.Items.Add(item);
                        
                        if (i == sayac)
                        {
                            break;
                        }
                        i++;

                    }
                    stream.Close();
                }
                
               
               
            }
            
           
           
        }

       
    }
}
