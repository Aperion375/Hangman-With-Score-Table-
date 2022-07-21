
namespace WinFormsApp5
{
    partial class adamasgiris
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
            this.Hayvanlar = new MetroFramework.Controls.MetroTile();
            this.Teknoloji = new MetroFramework.Controls.MetroTile();
            this.Ulkeler = new MetroFramework.Controls.MetroTile();
            this.Yemekler = new MetroFramework.Controls.MetroTile();
            this.Sporlar = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.İsim = new System.Windows.Forms.ColumnHeader();
            this.Puan = new System.Windows.Forms.ColumnHeader();
            this.Tablo = new MetroFramework.Controls.MetroTile();
            this.Orta = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.Zor = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // Hayvanlar
            // 
            this.Hayvanlar.ActiveControl = null;
            this.Hayvanlar.Location = new System.Drawing.Point(57, 136);
            this.Hayvanlar.Name = "Hayvanlar";
            this.Hayvanlar.Size = new System.Drawing.Size(107, 54);
            this.Hayvanlar.TabIndex = 0;
            this.Hayvanlar.Text = "Hayvanlar";
            this.Hayvanlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hayvanlar.UseSelectable = true;
            this.Hayvanlar.UseStyleColors = true;
            this.Hayvanlar.Click += new System.EventHandler(this.Ulkeler_Click);
            // 
            // Teknoloji
            // 
            this.Teknoloji.ActiveControl = null;
            this.Teknoloji.Location = new System.Drawing.Point(57, 253);
            this.Teknoloji.Name = "Teknoloji";
            this.Teknoloji.Size = new System.Drawing.Size(107, 54);
            this.Teknoloji.TabIndex = 1;
            this.Teknoloji.Text = "Teknoloji";
            this.Teknoloji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Teknoloji.UseSelectable = true;
            this.Teknoloji.UseStyleColors = true;
            this.Teknoloji.Click += new System.EventHandler(this.Teknoloji_Click);
            // 
            // Ulkeler
            // 
            this.Ulkeler.ActiveControl = null;
            this.Ulkeler.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Ulkeler.Location = new System.Drawing.Point(170, 136);
            this.Ulkeler.Name = "Ulkeler";
            this.Ulkeler.Size = new System.Drawing.Size(107, 54);
            this.Ulkeler.TabIndex = 2;
            this.Ulkeler.Text = "Ulkeler";
            this.Ulkeler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ulkeler.UseSelectable = true;
            this.Ulkeler.UseStyleColors = true;
            this.Ulkeler.Click += new System.EventHandler(this.Ulkeler_Click);
            // 
            // Yemekler
            // 
            this.Yemekler.ActiveControl = null;
            this.Yemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Yemekler.ForeColor = System.Drawing.SystemColors.Control;
            this.Yemekler.Location = new System.Drawing.Point(170, 196);
            this.Yemekler.Name = "Yemekler";
            this.Yemekler.Size = new System.Drawing.Size(107, 54);
            this.Yemekler.TabIndex = 4;
            this.Yemekler.Text = "Yemekler";
            this.Yemekler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Yemekler.UseSelectable = true;
            this.Yemekler.UseStyleColors = true;
            this.Yemekler.Click += new System.EventHandler(this.Yemekler_Click);
            // 
            // Sporlar
            // 
            this.Sporlar.ActiveControl = null;
            this.Sporlar.Location = new System.Drawing.Point(57, 193);
            this.Sporlar.Name = "Sporlar";
            this.Sporlar.Size = new System.Drawing.Size(107, 54);
            this.Sporlar.TabIndex = 3;
            this.Sporlar.Text = "Sporlar";
            this.Sporlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sporlar.UseSelectable = true;
            this.Sporlar.UseStyleColors = true;
            this.Sporlar.Click += new System.EventHandler(this.Sporlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsminizi Girin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "İsminizi Giriniz";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İsim,
            this.Puan});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(351, 253);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 162);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // İsim
            // 
            this.İsim.Text = "İsim";
            this.İsim.Width = 125;
            // 
            // Puan
            // 
            this.Puan.Text = "Puan";
            this.Puan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Puan.Width = 125;
            // 
            // Tablo
            // 
            this.Tablo.ActiveControl = null;
            this.Tablo.Location = new System.Drawing.Point(23, 374);
            this.Tablo.Name = "Tablo";
            this.Tablo.Size = new System.Drawing.Size(89, 41);
            this.Tablo.TabIndex = 9;
            this.Tablo.Text = "Tablo Reset";
            this.Tablo.UseSelectable = true;
            this.Tablo.Click += new System.EventHandler(this.Tablo_Click);
            // 
            // Orta
            // 
            this.Orta.AutoSize = true;
            this.Orta.Location = new System.Drawing.Point(425, 193);
            this.Orta.Name = "Orta";
            this.Orta.Size = new System.Drawing.Size(49, 15);
            this.Orta.TabIndex = 10;
            this.Orta.Text = "Orta ";
            this.Orta.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(425, 175);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(52, 15);
            this.metroRadioButton2.TabIndex = 11;
            this.metroRadioButton2.Text = "Kolay";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // Zor
            // 
            this.Zor.AutoSize = true;
            this.Zor.Location = new System.Drawing.Point(425, 214);
            this.Zor.Name = "Zor";
            this.Zor.Size = new System.Drawing.Size(41, 15);
            this.Zor.TabIndex = 12;
            this.Zor.Text = "Zor";
            this.Zor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Zor.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(351, 136);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Zorluğu Seçiniz";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Beyaz",
            "Koyu"});
            this.metroComboBox1.Location = new System.Drawing.Point(464, 9);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(83, 29);
            this.metroComboBox1.TabIndex = 14;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tema Rengi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Diğer Renkler";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Siyah",
            "Beyaz",
            "Turuncu",
            "Mavi",
            "Kırmızı",
            "Yeşil"});
            this.metroComboBox2.Location = new System.Drawing.Point(464, 44);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(83, 29);
            this.metroComboBox2.TabIndex = 17;
            this.metroComboBox2.UseSelectable = true;
            // 
            // adamasgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 426);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Zor);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.Orta);
            this.Controls.Add(this.Tablo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Yemekler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sporlar);
            this.Controls.Add(this.Ulkeler);
            this.Controls.Add(this.Teknoloji);
            this.Controls.Add(this.Hayvanlar);
            this.Name = "adamasgiris";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "adamasgiris";
            this.Load += new System.EventHandler(this.adamasgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Hayvanlar;
        private MetroFramework.Controls.MetroTile Teknoloji;
        private MetroFramework.Controls.MetroTile Ulkeler;
        private MetroFramework.Controls.MetroTile Sporlar;
        private MetroFramework.Controls.MetroTile Yemekler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader İsim;
        private System.Windows.Forms.ColumnHeader Puan;
        private MetroFramework.Controls.MetroTile Tablo;
        private MetroFramework.Controls.MetroRadioButton Orta;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton Zor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
    }
}