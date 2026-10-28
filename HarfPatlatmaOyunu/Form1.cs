namespace HarfPatlatmaOyunu
{
    public partial class Form1 : Form
    {
        public string oyuncuAdi;
        public string secilenKelime;
        public int hata_say = 0;
        int tik_say = 0;
        Random rnd = new Random();
        List<Button> harfButonlari = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cikis_btn.PerformClick();
            }
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void yeniOyun_btn_Click(object sender, EventArgs e)
        {
            Form2 ayarlar = new Form2();


            if (ayarlar.ShowDialog() == DialogResult.OK)
            {
                oyuncuAdi = ayarlar.oyuncuAdi;
                secilenKelime = ayarlar.secilenKelime;

                oyuncuadi_label.Text = "Oyuncu Adı: " + oyuncuAdi;
                secilenKelime_lbl.Text = "Seçilen Kelime: " + secilenKelime;

                OyunuBaslat();
            }
        }

        private void OyunuBaslat()
        {
            foreach (Button b in harfButonlari)
            {
                this.Controls.Remove(b);
            }
            harfButonlari.Clear();
            tik_say = 0;

            Font f = new Font("Rubik", 15);

            foreach (char harf in secilenKelime)
            {
                Button btn = new Button();
                btn.Size = new Size(50, 50);
                btn.Font = f;
                btn.Text = harf.ToString();
                btn.Location = new Point(rnd.Next(700), rnd.Next(480));
                btn.BackColor = Color.White;
                btn.Click += harf_click;

                this.Controls.Add(btn);
                harfButonlari.Add(btn);
            }
        }

        private void harf_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == secilenKelime[tik_say].ToString())
            {
                btn.Visible = false;
                tik_say++;
            }
            else
            {
                hata_say++;
            }

            if (tik_say == secilenKelime.Length)
            {
                Form3 bitis = new Form3();
                bitis.oyuncuAdi = oyuncuAdi;
                bitis.secilenKelime = secilenKelime;
                bitis.hata_say = hata_say;
                bitis.ShowDialog();
            }
        }
    }
}