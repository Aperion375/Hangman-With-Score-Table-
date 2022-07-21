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
    public partial class adamasgiris : MetroFramework.Forms.MetroForm
    {
        adamas_oyun game; //Referans

        public adamasgiris()
        {

            InitializeComponent();

        }



        private void Hayvanlar_Click(object sender, EventArgs e)
        {

        }

        private void Ulkeler_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text.Length < 2)
            {
                MessageBox.Show("Lütfen İsminizi Düzgün Giriniz İsim 2 karakterden küçük olamaz");
            }
            else
            {
                this.Hide();
                string[] x = { "ALMANYA", "AMERİKA", "RUSYA", "UKRAYNA", "TÜRKİYE", "KANADA", "İSVEÇ" };
                game = new adamas_oyun(x, textBox1.Text); //Değişken gönderme 
                game.ShowDialog(); // Formu Cağırma 
                this.Close();
            }


        }

        private void Sporlar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text.Length < 2)
            {
                MessageBox.Show("Lütfen İsminizi Düzgün Giriniz İsim 2 karakterden küçük olamaz");
            }
            else
            {
                this.Hide();
                string[] x = { "FUTBOL", "BASKETBOL", "BADMİNTON", "BOKS", "GÜREŞ", "HALTER", "HOKEY", "GOLF", "YÜZME" };
                game = new adamas_oyun(x, textBox1.Text); //Değişken gönderme 
                game.ShowDialog(); // Formu Cağırma 
                this.Close();
            }


        }

        private void Yemekler_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text.Length < 2)
            {
                MessageBox.Show("Lütfen İsminizi Düzgün Giriniz İsim 2 karakterden küçük olamaz");
            }
            else
            {
                this.Hide();
                string[] x = { "SİMİT", "ELMA", "DÖNER", "CİG KÖFTE", "SA", "AYI", "AT", "TİLKİ" };
                game = new adamas_oyun(x, textBox1.Text); //Değişken gönderme 
                game.ShowDialog(); // Formu Cağırma 
                this.Close();
            }
        }



        private void Teknoloji_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text.Length < 2)
            {
                MessageBox.Show("Lütfen İsminizi Düzgün Giriniz İsim 2 karakterden küçük olamaz");
            }
            else
            {
                this.Hide();
                string[] x = { "APPLE", "SAMSUNG", "XİAOMİ", "NVİDİA", "MİCROSOFT", "AMD" };
                game = new adamas_oyun(x, textBox1.Text); //Değişken gönderme 
                game.ShowDialog(); // Formu Cağırma 
                this.Close();
            }


        }

        private void adamasgiris_Load(object sender, EventArgs e)
        {
            Sonuc.SkorTablosu(listView1);
        }

        private void Tablo_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string dosya = "skortablosu.txt";

            TextWriter tw = new StreamWriter(dosya, false);
            tw.Write(string.Empty);
            tw.Close();
        }

       
    }
}