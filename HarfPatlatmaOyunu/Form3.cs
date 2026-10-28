using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HarfPatlatmaOyunu
{
    public partial class Form3 : Form
    {
        public string oyuncuAdi;
        public string secilenKelime;
        public int hata_say = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            oyuncuAdi_lbl.Text = "Oyuncu Adı: " + oyuncuAdi;
            secilenKelime_lbl.Text = "Seçilen Kelime: " + secilenKelime;
            hataSayisi_lbl.Text = "Hata Sayısı: " + hata_say.ToString();

            int puan = 100 - (hata_say * 10);
            puan_lbl.Text = "Puan: " + puan.ToString();

        }
    }
}
