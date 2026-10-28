namespace HarfPatlatmaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            oyuncuadi_label = new Label();
            secilenKelime_lbl = new Label();
            yeniOyun_btn = new Button();
            cikis_btn = new Button();
            SuspendLayout();
            // 
            // oyuncuadi_label
            // 
            oyuncuadi_label.AutoSize = true;
            oyuncuadi_label.Location = new Point(12, 13);
            oyuncuadi_label.Name = "oyuncuadi_label";
            oyuncuadi_label.Size = new Size(73, 15);
            oyuncuadi_label.TabIndex = 0;
            oyuncuadi_label.Text = "Oyuncu Adı:";
            // 
            // secilenKelime_lbl
            // 
            secilenKelime_lbl.AutoSize = true;
            secilenKelime_lbl.Location = new Point(12, 39);
            secilenKelime_lbl.Name = "secilenKelime_lbl";
            secilenKelime_lbl.Size = new Size(86, 15);
            secilenKelime_lbl.TabIndex = 1;
            secilenKelime_lbl.Text = "Seçilen Kelime:";
            // 
            // yeniOyun_btn
            // 
            yeniOyun_btn.Location = new Point(10, 67);
            yeniOyun_btn.Name = "yeniOyun_btn";
            yeniOyun_btn.Size = new Size(75, 23);
            yeniOyun_btn.TabIndex = 3;
            yeniOyun_btn.Text = "Yeni Oyun";
            yeniOyun_btn.UseVisualStyleBackColor = true;
            yeniOyun_btn.Click += yeniOyun_btn_Click;
            // 
            // cikis_btn
            // 
            cikis_btn.Location = new Point(10, 105);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(75, 23);
            cikis_btn.TabIndex = 4;
            cikis_btn.Text = "Çıkış";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 519);
            Controls.Add(cikis_btn);
            Controls.Add(yeniOyun_btn);
            Controls.Add(secilenKelime_lbl);
            Controls.Add(oyuncuadi_label);
            KeyPreview = true;
            Name = "Form1";
            Text = "Harf Patlatma Oyunu";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label oyuncuadi_label;
        private Label secilenKelime_lbl;
        private Button yeniOyun_btn;
        private Button cikis_btn;
    }
}
