# 🩺 Skin Cancer Detection System (C# & ML.NET) / Cilt Kanseri Teşhis Sistemi

## 🌍 English Overview
This project is a **C# Windows Forms** application that utilizes **ML.NET** for analyzing skin lesion images to assist in early diagnosis. It was developed as a technical university project. 

### ⚠️ Important Note on Model File
The pre-trained model file (`.mlnet`) is **not included** in this repository due to GitHub's file size limitations (93 MB). However, the complete **training logic** (`MLModel1.training.cs`) and **consumption code** are available. You can retrain the model using the HAM10000 dataset link provided below.

### 🛠 Tech Stack
* **Language:** C# 
* **Framework:** .NET WinForms / ML.NET
* **Database:** SQL Server (for patient records)
* **Dataset:** Designed for the **HAM10000** dataset. [Source: [Kaggle](https://www.kaggle.com/datasets/kmader/skin-cancer-mnist-ham10000)]

---

## 🇹🇷 Türkçe Özet
Bu proje, cilt lezyonu görüntülerinin analiz edilerek erken teşhise yardımcı olunması amacıyla **ML.NET** kullanılarak geliştirilmiş bir **C# Windows Forms** uygulamasıdır. Üniversite dönem projesi olarak hazırlanmıştır.

### ⚠️ Model Dosyası Hakkında Not
Eğitilmiş model dosyası (`.mlnet`), GitHub dosya boyutu sınırları (93 MB) nedeniyle bu depoya **eklenmemiştir.** Ancak, modelin nasıl eğitileceğine dair **eğitim kodları** (`MLModel1.training.cs`) ve kullanım algoritmaları projede mevcuttur. HAM10000 veri seti ile model yeniden oluşturulabilir.

### 🛠 Kullanılan Teknolojiler
* **Dil:** C# 
* **Altyapı:** .NET WinForms / ML.NET
* **Veritabanı:** SQL Server (Hasta takibi için)
* **Veri Seti:** **HAM10000** veri seti temel alınmıştır.

---

## 🚀 How to Run / Nasıl Çalıştırılır
1.  Import `KanserTakipDB_Yedek.sql` into your SQL Server.
2.  Open `KanserTespitProgramı.sln` with Visual Studio.
3.  Ensure ML.NET Model Builder is installed to manage the model training.
