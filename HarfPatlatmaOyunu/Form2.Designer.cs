namespace HarfPatlatmaOyunu
{
    partial class Form2
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
            nickname_textbox = new TextBox();
            kelimeSec_combo = new ComboBox();
            oyunBaslat_btn = new Button();
            cikis_btn = new Button();
            SuspendLayout();
            // 
            // nickname_textbox
            // 
            nickname_textbox.Location = new Point(40, 26);
            nickname_textbox.Name = "nickname_textbox";
            nickname_textbox.PlaceholderText = "Oyuncu Adı...";
            nickname_textbox.Size = new Size(100, 23);
            nickname_textbox.TabIndex = 0;
            // 
            // kelimeSec_combo
            // 
            kelimeSec_combo.FormattingEnabled = true;
            kelimeSec_combo.Items.AddRange(new object[] { "KALEM", "KİTAP", "BİLGİ", "EKRAN", "YAZILIM" });
            kelimeSec_combo.Location = new Point(40, 66);
            kelimeSec_combo.Name = "kelimeSec_combo";
            kelimeSec_combo.Size = new Size(121, 23);
            kelimeSec_combo.TabIndex = 1;
            // 
            // oyunBaslat_btn
            // 
            oyunBaslat_btn.Location = new Point(40, 105);
            oyunBaslat_btn.Name = "oyunBaslat_btn";
            oyunBaslat_btn.Size = new Size(100, 23);
            oyunBaslat_btn.TabIndex = 2;
            oyunBaslat_btn.Text = "Oyunu Başlat";
            oyunBaslat_btn.UseVisualStyleBackColor = true;
            oyunBaslat_btn.Click += oyunBaslat_btn_Click;
            // 
            // cikis_btn
            // 
            cikis_btn.Location = new Point(40, 134);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(75, 23);
            cikis_btn.TabIndex = 3;
            cikis_btn.Text = "Çıkış";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 444);
            Controls.Add(cikis_btn);
            Controls.Add(oyunBaslat_btn);
            Controls.Add(kelimeSec_combo);
            Controls.Add(nickname_textbox);
            Name = "Form2";
            Text = "Form2";
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nickname_textbox;
        private ComboBox kelimeSec_combo;
        private Button oyunBaslat_btn;
        private Button cikis_btn;
    }
}