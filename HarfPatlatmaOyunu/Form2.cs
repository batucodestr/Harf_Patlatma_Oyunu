using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HarfPatlatmaOyunu
{
    public partial class Form2 : Form
    {
        public string oyuncuAdi;
        public string secilenKelime;
        public Form2()
        {
            InitializeComponent();
        }


        private void cikis_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cikis_btn.PerformClick();
            }
        }

        private void oyunBaslat_btn_Click(object sender, EventArgs e)
        {
            oyuncuAdi = nickname_textbox.Text;
            secilenKelime = kelimeSec_combo.Text;

            if (nickname_textbox.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş olamaz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kelimeSec_combo.Text == "")
            {
                MessageBox.Show("Bir kelime seçmelisiniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;

        }
    }
}
