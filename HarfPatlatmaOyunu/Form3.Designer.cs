namespace HarfPatlatmaOyunu
{
    partial class Form3
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
            oyuncuAdi_lbl = new Label();
            secilenKelime_lbl = new Label();
            hataSayisi_lbl = new Label();
            puan_lbl = new Label();
            SuspendLayout();
            // 
            // oyuncuAdi_lbl
            // 
            oyuncuAdi_lbl.AutoSize = true;
            oyuncuAdi_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            oyuncuAdi_lbl.Location = new Point(12, 25);
            oyuncuAdi_lbl.Name = "oyuncuAdi_lbl";
            oyuncuAdi_lbl.Size = new Size(94, 20);
            oyuncuAdi_lbl.TabIndex = 0;
            oyuncuAdi_lbl.Text = "Oyuncu Adı:";
            // 
            // secilenKelime_lbl
            // 
            secilenKelime_lbl.AutoSize = true;
            secilenKelime_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            secilenKelime_lbl.Location = new Point(12, 61);
            secilenKelime_lbl.Name = "secilenKelime_lbl";
            secilenKelime_lbl.Size = new Size(113, 20);
            secilenKelime_lbl.TabIndex = 1;
            secilenKelime_lbl.Text = "Seçilen Kelime:";
            // 
            // hataSayisi_lbl
            // 
            hataSayisi_lbl.AutoSize = true;
            hataSayisi_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            hataSayisi_lbl.Location = new Point(12, 94);
            hataSayisi_lbl.Name = "hataSayisi_lbl";
            hataSayisi_lbl.Size = new Size(93, 20);
            hataSayisi_lbl.TabIndex = 2;
            hataSayisi_lbl.Text = "Hata Sayısı: ";
            // 
            // puan_lbl
            // 
            puan_lbl.AutoSize = true;
            puan_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            puan_lbl.Location = new Point(12, 126);
            puan_lbl.Name = "puan_lbl";
            puan_lbl.Size = new Size(52, 20);
            puan_lbl.TabIndex = 3;
            puan_lbl.Text = "Puan: ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 393);
            Controls.Add(puan_lbl);
            Controls.Add(hataSayisi_lbl);
            Controls.Add(secilenKelime_lbl);
            Controls.Add(oyuncuAdi_lbl);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label oyuncuAdi_lbl;
        private Label secilenKelime_lbl;
        private Label hataSayisi_lbl;
        private Label puan_lbl;
    }
}