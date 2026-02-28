using System;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel; 
using System.IO;       

namespace KanserTespitProgramı
{
    public partial class HastaListesiForm : Form
    {
        // --- VERİTABANI BAĞLANTISI ---
    
        string baglantiAdresi = "Data Source=KAAN\\SQLEXPRESS;Initial Catalog=KanserTakipDB;Integrated Security=True;TrustServerCertificate=True";

        public HastaListesiForm()
        {
            InitializeComponent(); 
        }

        // --- FORM AÇILINCA YAPILACAKLAR ---
        private void HastaListesiForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();

            txtAra.Text = "İsim Giriniz";
            txtAra.ForeColor = Color.Gray; 
        }

        // --- LİSTEYİ GÜNCELLEME FONKSİYONU ---
        void ListeyiYenile()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open(); 

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HastaAnalizleri ORDER BY Tarih DESC", baglanti);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo); 

                    dgvList.DataSource = tablo;

                    dgvList.ClearSelection();

                    IstatistikleriHesapla();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Listeleme hatası: " + hata.Message);
            }
        }

        // --- İSTATİSTİK HESAPLAMA ---
        void IstatistikleriHesapla()
        {
            int riskliSayisi = 0;
            int temizSayisi = 0;

            foreach (DataGridViewRow satir in dgvList.Rows)
            {
                if (satir.Cells["Sonuc"].Value != null)
                {
                    string sonuc = satir.Cells["Sonuc"].Value.ToString();

                    if (sonuc == "RİSKLİ" || sonuc == "1" || sonuc == "Riskli")
                    {
                        riskliSayisi++;
                    }
                    else
                    {
                        temizSayisi++;
                    }
                }
            }

            int gercekToplam = riskliSayisi + temizSayisi; 
            lblToplam.Text = "Toplam: " + gercekToplam.ToString();
            lblRiskli.Text = "Riskli: " + riskliSayisi.ToString();
            lblTemiz.Text = "Temiz: " + temizSayisi.ToString();
        }

        // --- İSİM ARAMA BUTONU ---
        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvList.ClearSelection(); 
            string arananIsim = txtAra.Text.Trim().ToLower(); 

            if (arananIsim == "" || arananIsim == "isim giriniz")
            {
                MessageBox.Show("Lütfen aranacak bir isim girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool bulunduMu = false;

            foreach (DataGridViewRow satir in dgvList.Rows)
            {
                if (satir.Cells[1].Value != null)
                {
                    string listedekiIsim = satir.Cells[1].Value.ToString().Trim().ToLower();

                    if (listedekiIsim == arananIsim)
                    {
                        satir.Selected = true; 
                        dgvList.FirstDisplayedScrollingRowIndex = satir.Index;
                        bulunduMu = true;
                        break; 
                    }
                }
            }

            if (bulunduMu == false)
            {
                MessageBox.Show("Bu isimde bir kayıt bulunamadı.", "Sonuç Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- ARAMA KUTUSU EFEKTLERİ ---
        private void txtAra_Enter(object sender, EventArgs e)
        {
            if (txtAra.Text == "İsim Giriniz")
            {
                txtAra.Text = "";
                txtAra.ForeColor = Color.Black;
            }
        }

        private void txtAra_Leave(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
            {
                txtAra.Text = "İsim Giriniz";
                txtAra.ForeColor = Color.Gray;
            }
        }

        // --- KAYIT SİLME BUTONU ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek kaydı listeden seçin.");
                return;
            }

            DataGridViewRow secilenSatir = dgvList.SelectedRows[0];

            string silinecekID = secilenSatir.Cells[0].Value.ToString();
            string hastaAdi = secilenSatir.Cells[1].Value.ToString();

            DialogResult onay = MessageBox.Show(hastaAdi + " isimli kaydı silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM HastaAnalizleri WHERE Id = @p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", silinecekID);
                        komut.ExecuteNonQuery(); 

                        MessageBox.Show("Kayıt silindi.");

                        ListeyiYenile();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Silme hatası: " + hata.Message);
                }
            }
        }

        // --- TARİH FİLTRELEME BUTONU ---
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    string sorgu = "SELECT * FROM HastaAnalizleri WHERE Tarih >= @t1 AND Tarih <= @t2";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                    da.SelectCommand.Parameters.AddWithValue("@t1", dtpBaslangic.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@t2", dtpBitis.Value.Date.AddDays(1).AddSeconds(-1));

                    DataTable tablo = new DataTable();
                    da.Fill(tablo);

                    dgvList.DataSource = tablo;

                    IstatistikleriHesapla();

                    dgvList.SelectAll();

                    MessageBox.Show(tablo.Rows.Count + " kayıt bulundu.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Filtre hatası: " + hata.Message);
            }
        }

        // --- EXCEL'E AKTARMA (CLOSEDXML YÖNTEMİ) ---
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count == 0)
            {
                MessageBox.Show("Listede veri yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Excel Dosyası|*.xlsx"; 
            kaydet.Title = "Rapor Kaydet";
            
            kaydet.FileName = "KanserAnalizRaporu_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

            if (kaydet.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    using (var kitap = new XLWorkbook())
                    {
                        var sayfa = kitap.Worksheets.Add("Hasta Listesi");

                       
                        for (int i = 0; i < dgvList.Columns.Count; i++)
                        {
                            sayfa.Cell(1, i + 1).Value = dgvList.Columns[i].HeaderText;
                        }

                        
                        var baslikAraligi = sayfa.Range(1, 1, 1, dgvList.Columns.Count);
                        baslikAraligi.Style.Font.Bold = true;
                        baslikAraligi.Style.Fill.BackgroundColor = XLColor.LightGray;

                
                        for (int i = 0; i < dgvList.Rows.Count; i++)
                        {
                            if (dgvList.Rows[i].IsNewRow) continue;

                            for (int j = 0; j < dgvList.Columns.Count; j++)
                            {
                                if (dgvList.Rows[i].Cells[j].Value != null)
                                {
                                    sayfa.Cell(i + 2, j + 1).Value = dgvList.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }

                        
                        sayfa.Columns().AdjustToContents();

                        kitap.SaveAs(kaydet.FileName);
                    }

                    MessageBox.Show("Excel raporu başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Rapor hatası: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        // - exel interop sürüm hatası falan verdiği için closedxml kullandım. Hem de daha hızlı çalışıyor bağımsız çalışıyor.
        // - yapay zeka modelini MLModel1.mbconfig dosyasında eğittim. Kodda ise MLModel1.Predict() metoduyla çağırıyorum kullanıyorum.
    
    }
}