using KanserTespitProgramı;
using System;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;

namespace KanserTespitProgramı
{
    public partial class Form1 : Form
    {
        // --- DEĞİŞKEN TANIMLARI ---

        string secilenResimYolu = "";

        
        string baglantiAdresi = "Data Source=KAAN\\SQLEXPRESS;Initial Catalog=KanserTakipDB;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent(); 
        }

        // --- RESİM SEÇME İŞLEMİ ---
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dosya = new OpenFileDialog();

            dosya.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                secilenResimYolu = dosya.FileName;

                pbResim.ImageLocation = secilenResimYolu;

                btnAnaliz.Enabled = true;
                btnKaydet.Enabled = false;

                try
                {
                    lblSonuc.Text = "Resim yüklendi. Analiz bekleniyor...";
                    lblSonuc.ForeColor = Color.Black;
                }
                catch { }
            }
        }

        // --- ALTERNATİF RESİM YÜKLEME BUTONU ---
        private void btnYukle_Click(object sender, EventArgs e)
        {
            btnResimSec_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // --- YAPAY ZEKA ANALİZ İŞLEMİ ---
        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Trim() == "")
            {
                MessageBox.Show("Önce hastanın adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 
            }

            
            if (string.IsNullOrEmpty(secilenResimYolu))
            {
                MessageBox.Show("Önce resim seçin!");
                return; 
            }

            try
            {
                lblSonuc.Text = "Hesaplanıyor...";
                lblSonuc.ForeColor = Color.Black;

                Application.DoEvents();

                // --- MAKİNE ÖĞRENMESİ (ML.NET) KISMI ---

                var input = new MLModel1.ModelInput()
                {
                    ImageSource = System.IO.File.ReadAllBytes(secilenResimYolu)
                };

                var sonuc = MLModel1.Predict(input);

                string gelenCevap = sonuc.PredictedLabel;

                if (gelenCevap == "Riskli" || gelenCevap == "1")
                {
                    lblSonuc.Text = "RİSKLİ";
                    lblSonuc.ForeColor = Color.Red;
                }
                else
                {
                    lblSonuc.Text = "TEMİZ";
                    lblSonuc.ForeColor = Color.Green;
                }

                lblSonuc.Refresh(); 

                // --- GÜVEN ORANI HESAPLAMA ---
                float enYuksekOran = sonuc.Score.Max();

                lblOran.Text = "%" + (enYuksekOran * 100).ToString("0.00");

                btnKaydet.Enabled = true;

                MessageBox.Show("Analiz tamamlandı! Sonuç: " + gelenCevap);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        // --- VERİTABANINA KAYDETME İŞLEMİ ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "Sonuç Bekleniyor..." || lblSonuc.Text == "label1" || lblSonuc.Text == "")
            {
                MessageBox.Show("Henüz analiz yapılmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string baglantiAdresi = "Data Source=KAAN\\SQLEXPRESS;Initial Catalog=KanserTakipDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open(); 

                    string sql = "INSERT INTO HastaAnalizleri (AdSoyad, Sonuc, GuvenOrani, Tarih) VALUES (@p1, @p2, @p3, @p4)";

                    SqlCommand komut = new SqlCommand(sql, baglanti);

                    string hastaAdi = txtAdSoyad.Text;
                    if (string.IsNullOrWhiteSpace(hastaAdi)) hastaAdi = "İsimsiz Hasta";

                    komut.Parameters.AddWithValue("@p1", hastaAdi);        // Hasta Adı
                    komut.Parameters.AddWithValue("@p2", lblSonuc.Text);   // Sonuç (RİSKLİ/TEMİZ)
                    komut.Parameters.AddWithValue("@p3", lblOran.Text);    // Güven Oranı
                    komut.Parameters.AddWithValue("@p4", DateTime.Now);    // Şu anki tarih/saat

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Rapor başarıyla veritabanına işlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veritabanı Bağlantı Hatası: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- HASTA LİSTESİ EKRANINI AÇMA ---
        private void button3_Click(object sender, EventArgs e)
        {
            HastaListesiForm listeEkrani = new HastaListesiForm();

            listeEkrani.ShowDialog();
        }

        // - exel interop sürüm hatası falan verdiği için closedxml kullandım. Hem de daha hızlı çalışıyor bağımsız çalışıyor.
        // - yapay zeka modelini MLModel1.mbconfig dosyasında eğittim. Kodda ise MLModel1.Predict() metoduyla çağırıyorum kullanıyorum.

    }
}