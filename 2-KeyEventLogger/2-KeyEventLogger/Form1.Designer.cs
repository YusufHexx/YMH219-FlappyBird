namespace _2_KeyEventLogger
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
            btnBaslat = new Button();
            btnDurdur = new Button();
            btnKaydet = new Button();
            lblBaslik = new Label();
            lblDurum = new Label();
            lblSayac = new Label();
            lstKayitlar = new ListBox();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(29, 148);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(235, 33);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnDurdur
            // 
            btnDurdur.Location = new Point(270, 148);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(238, 33);
            btnDurdur.TabIndex = 1;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(29, 187);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(479, 39);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Dosyaya Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(29, 21);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(111, 15);
            lblBaslik.TabIndex = 3;
            lblBaslik.Text = "KEY EVENT LOGGER";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(431, 21);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(77, 15);
            lblDurum.TabIndex = 4;
            lblDurum.Text = "Durum: Hazır";
            // 
            // lblSayac
            // 
            lblSayac.AutoSize = true;
            lblSayac.Location = new Point(29, 244);
            lblSayac.Name = "lblSayac";
            lblSayac.Size = new Size(86, 15);
            lblSayac.TabIndex = 5;
            lblSayac.Text = "Toplam kayıt: 0";
            // 
            // lstKayitlar
            // 
            lstKayitlar.FormattingEnabled = true;
            lstKayitlar.Location = new Point(29, 63);
            lstKayitlar.Name = "lstKayitlar";
            lstKayitlar.Size = new Size(479, 79);
            lstKayitlar.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 320);
            Controls.Add(lstKayitlar);
            Controls.Add(lblSayac);
            Controls.Add(lblDurum);
            Controls.Add(lblBaslik);
            Controls.Add(btnKaydet);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Button btnDurdur;
        private Button btnKaydet;
        private Label lblBaslik;
        private Label lblDurum;
        private Label lblSayac;
        private ListBox lstKayitlar;
    }
}
