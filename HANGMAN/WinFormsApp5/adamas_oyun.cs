using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using System.Collections;

namespace WinFormsApp5
{
   
    public partial class adamas_oyun : MetroFramework.Forms.MetroForm
    {

        Sonuc xxxxxx;
        int win = 0;
        
        Random rnd = new Random();
        string aranan;
        
        string gizli;
        Bitmap[] adambody =
        {
            WinFormsApp5.Properties.Resources.hangman1,WinFormsApp5.Properties.Resources.hangman2,WinFormsApp5.Properties.Resources.hangman3,WinFormsApp5.Properties.Resources.hangman4,WinFormsApp5.Properties.Resources.hangman5,
        };
        string[] kelimedizi;
        int yanlistahmin = 0;
        int rastgelexx = 0;
        int puan = 100;
        string isim;

        public adamas_oyun(string [] kelimeler,string gelenisim) // Seçilen değişkenleri alan yapıcı
        {
            InitializeComponent();
            kelimedizi = kelimeler;
            isim = gelenisim;
            
            
        }

        private void Tahmin_Butonu(object sender, EventArgs e)
        {
            
           
            MetroFramework.Controls.MetroTile basılan = sender as MetroFramework.Controls.MetroTile;
            basılan.Enabled = false;
            
            if (aranan.Contains(basılan.Text)) // Basılan Harf arananın içinde varmı diye kontrol eder Uzatmak istersek for ile kontrol sağlayabiliriz
            {
                char[] x = gizli.ToCharArray(); // __ ları diziye aktarma
                //char[] aranıcak = aranan.ToCharArray(); // Aranan kelimenin harflerini diziye aktarma
                //char tahmin = basılan.Text[0]; // tahmin edilen butondaki değeri değişkene atama ElementAt(0)'da kullanılabilir
                for (int i = 0; i < aranan.Length; i++)
                {
                    if (aranan[i]==basılan.Text[0])
                    {
                        
                        x[i] = basılan.Text[0]; // Tahmin doğruysa _ yerine Bilinen Harfi atama
                    }
                   
                }
                gizli = new string(x);
                gizliata();
                
            }
            else
            {
                puan = puan - 10;
                yanlistahmin++;
            }
            
            if (yanlistahmin<5)
            {
                Adam.Image = adambody[yanlistahmin];
            }
            else
            {
                win = -1;
                puan = 0;
                this.Hide();
                xxxxxx = new Sonuc(win, puan, aranan, 5 - yanlistahmin, 2 - rastgelexx,isim);
                xxxxxx.ShowDialog();
                this.Close();
                
                
                metroPanel1.Enabled = false;
                button1.Visible = true;

            }
            if (gizli==aranan)
            {
                win = 1;
                this.Hide();
                xxxxxx = new Sonuc(win, puan, aranan, 5 - yanlistahmin, 2 - rastgelexx,isim);
                xxxxxx.ShowDialog();
                this.Close();
                metroPanel1.Enabled = false;
                button1.Visible = true;
            }



        }
        private void Basla_Kelimeler()
        {
            yanlistahmin = 0;
            Adam.Image = adambody[yanlistahmin];
            int a = rnd.Next(0, kelimedizi.Length);
            aranan = kelimedizi[a]; // Kelimelerden rastgele seçme
            label5.Text = label5.Text + aranan.Length;
            for (int i = 0; i < aranan.Length; i++)
            {
                gizli = gizli + "_"; // Harf başına _ koyma
            }
            gizliata();
            button1.Visible = false;
        }


      

        private void gizliata()
        {
            label2.Text = "";
            for (int i = 0; i < gizli.Length; i++)
            {
                label2.Text += gizli[i].ToString();
                
                label2.Text += " ";

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Basla_Kelimeler();
            
            MessageBox.Show( "Her Hata İçin 10 puan kesilir \n " + "İpucu Kullanımı Başına 5 Puan Kesilir "
                + "\n                          Başarılar");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            int sayac = 0;

            if (rastgelexx<2)
            {


               
                puan = puan - 5;
                char[] x = gizli.ToCharArray();

                //Rastgele Verilecek harf
                char rastgele = aranan[rnd.Next(aranan.Length)];
                char[] a = new char[2];
                

                if (sayac == 0)
                {
                    a[0] = rastgele;
                    sayac++;
                }
                else if (sayac == 1 )
                {
                    a[1] = rastgele;
                    
                    while (true)
                    {
                        if (a[1] == a[0])
                        {
                            a[1] = aranan[rnd.Next(aranan.Length)];
                        }
                        else
                        {
                            rastgele = a[1];
                            break;
                        }
                    }
                }

                if (label4.Text == "")
                    {
                        label4.Text = Convert.ToString(rastgele);
                    }
                    else
                    {
                        label4.Text = label4.Text + Convert.ToString("," + rastgele);
                    }
                    for (int i = 0; i < aranan.Length; i++)
                    {
                        if (aranan[i] == rastgele) //harf kontrol
                        {
                            x[i] = rastgele; // verilen harfi _ yerine atama
                        }
                    }
                    gizli = new string(x); // x dizisindekileri string değere dönüştürüp atama
                    gizliata();
                    rastgelexx++;
                    if (gizli == aranan)
                    {
                        win = 1;
                        this.Hide();
                        xxxxxx = new Sonuc(win, puan, aranan, 5 - yanlistahmin, 2 - rastgelexx, isim);
                        xxxxxx.ShowDialog();
                        this.Close();
                        metroPanel1.Enabled = false;
                        button1.Visible = true;
                    }
                
                







                
                
            }
            



            else
            {
                MessageBox.Show("İpucu hakkınız bitti");
                metroButton1.Visible = false;
                //MetroFramework.MetroMessageBox.Show(this, "OK", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); //Hatalı
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
            
            
        }

       
    }
}
