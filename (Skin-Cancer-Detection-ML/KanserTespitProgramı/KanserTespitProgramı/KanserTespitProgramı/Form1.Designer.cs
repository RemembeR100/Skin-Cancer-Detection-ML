
namespace KanserTespitProgramı
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
            pbResim = new PictureBox();
            btnResimSec = new Button();
            btnAnaliz = new Button();
            button3 = new Button();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            lblSonuc = new Label();
            lblOran = new Label();
            btnKaydet = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // pbResim
            // 
            pbResim.BorderStyle = BorderStyle.Fixed3D;
            pbResim.Location = new Point(74, 44);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(255, 211);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResimSec.Location = new Point(74, 312);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(84, 23);
            btnResimSec.TabIndex = 1;
            btnResimSec.Text = "Resim Yükle";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click_1;
            // 
            // btnAnaliz
            // 
            btnAnaliz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnaliz.BackColor = SystemColors.Control;
            btnAnaliz.Enabled = false;
            btnAnaliz.Location = new Point(164, 312);
            btnAnaliz.Name = "btnAnaliz";
            btnAnaliz.Size = new Size(81, 23);
            btnAnaliz.TabIndex = 2;
            btnAnaliz.Text = "Analiz Et";
            btnAnaliz.UseVisualStyleBackColor = true;
            btnAnaliz.Click += btnAnaliz_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(469, 339);
            button3.Name = "button3";
            button3.Size = new Size(151, 23);
            button3.TabIndex = 3;
            button3.Text = "Hasta Listesi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtAdSoyad.Location = new Point(218, 376);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(96, 379);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 5;
            label1.Text = "Hastanın Adı Soyadı:";
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonuc.Location = new Point(469, 122);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(154, 21);
            lblSonuc.TabIndex = 6;
            lblSonuc.Text = "Sonuc Bekleniyor...";
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOran
            // 
            lblOran.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOran.AutoSize = true;
            lblOran.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOran.Location = new Point(572, 165);
            lblOran.Name = "lblOran";
            lblOran.Size = new Size(42, 21);
            lblOran.TabIndex = 7;
            lblOran.Text = "%00";
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnKaydet.Enabled = false;
            btnKaydet.Location = new Point(254, 312);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 170);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 9;
            label2.Text = "Kanser Risk Yüzdesi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnKaydet);
            Controls.Add(lblOran);
            Controls.Add(lblSonuc);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Controls.Add(button3);
            Controls.Add(btnAnaliz);
            Controls.Add(btnResimSec);
            Controls.Add(pbResim);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kanser Tespit Programı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAnaliz_Click_1(object sender, EventArgs e)
        {
            // 1. Resim yoksa çık
            if (string.IsNullOrEmpty(secilenResimYolu)) return;

            try
            {
                lblSonuc.Text = "Hesaplanıyor...";
                Application.DoEvents();

                // --- YAPAY ZEKA MODELİ ---
                // Resimdeki kodunda 'ReadAllBytes' kullandığın ve çalıştığı için aynısını bırakıyorum.
                var input = new MLModel1.ModelInput()
                {
                    ImageSource = System.IO.File.ReadAllBytes(secilenResimYolu)
                };

                // Tahmin Et
                var sonuc = MLModel1.Predict(input);

                // --- SONUCU YAZDIR ---
                lblSonuc.Text = sonuc.PredictedLabel;

                // --- RENK AYARI (TÜRKÇE) ---
                // Komutanım, burayı düzelttik! Artık "Riskli" kelimesini arıyoruz.
                string gelenCevap = sonuc.PredictedLabel;

                if (gelenCevap == "Riskli" || gelenCevap == "1")
                {
                    // Eğer model "Riskli" dediyse KIRMIZI yap
                    lblSonuc.ForeColor = Color.Red;
                    lblSonuc.Text = "RİSKLİ";
                }
                else
                {
                    // Değilse (Temiz ise) YEŞİL yap
                    lblSonuc.ForeColor = Color.Green;
                    lblSonuc.Text = "TEMİZ";
                }

                // Rengi sabitle
                lblSonuc.Refresh();

                // --- ORANI YAZDIR ---
                float enYuksekOran = sonuc.Score.Max();
                lblOran.Text = "%" + (enYuksekOran * 100).ToString("0.00");

                MessageBox.Show("Analiz bitti komutanım! Sonuç: " + gelenCevap);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Analiz Hatası: " + hata.Message);
            }
        }

        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                secilenResimYolu = dosya.FileName;
                pbResim.ImageLocation = secilenResimYolu; // Resmi göster

                // Resim geldi, analiz butonunu aç
                btnAnaliz.Enabled = true;

                // Bilgi ver
                lblSonuc.Text = "Resim yüklendi. Analiz bekleniyor...";
                lblSonuc.ForeColor = Color.Black;
            }
        }

        #endregion

        private PictureBox pbResim;
        private Button btnResimSec;
        private Button btnAnaliz;
        private Button button3;
        private TextBox txtAdSoyad;
        private Label label1;
        private Label lblSonuc;
        private Label lblOran;
        private Button btnKaydet;
        private Label label2;
    }
}
