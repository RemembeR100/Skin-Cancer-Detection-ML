# 🩺 Skin Cancer Detection System (C# & ML.NET) / Cilt Kanseri Teşhis Sistemi

## 🌍 English Overview
This project is a **C# Windows Forms** application that utilizes **ML.NET** for analyzing skin lesion images to assist in early diagnosis. It was developed as a technical university project.

### ⚠️ Disclaimer
* **Prototype Only:** This is an academic prototype and **not a real-world medical tool.**
* **Model Accuracy:** The included model is trained on a limited sample for demonstration purposes. It does not provide 100% accurate medical results.

### 🛠 Tech Stack
* **Language:** C#
* **Framework:** .NET WinForms / ML.NET
* **Database:** SQL Server (for patient records)
* **Dataset Info:** Designed for the **HAM10000** dataset. (Raw images are not included due to size).

---

## 🇹🇷 Türkçe Özet
Bu proje, cilt lezyonu görüntülerinin analiz edilerek erken teşhise yardımcı olunması amacıyla **ML.NET** kullanılarak geliştirilmiş bir **C# Windows Forms** uygulamasıdır. Üniversite dönem projesi olarak hazırlanmıştır.

### ⚠️ Önemli Not
* **Prototip:** Bu bir akademik çalışmadır ve **gerçek bir tıbbi cihaz/yazılım değildir.**
* **Doğruluk:** İçindeki yapay zeka modeli, sistemin işleyişini göstermek adına sınırlı veriyle eğitilmiştir; kesin tıbbi sonuçlar vermez.

### 🛠 Kullanılan Teknolojiler
* **Dil:** C#
* **Altyapı:** .NET WinForms / ML.NET
* **Veritabanı:** SQL Server (Hasta takibi için)
* **Veri Seti:** **HAM10000** veri seti temel alınmıştır. (Boyut nedeniyle ham resimler repoya eklenmemiştir).

---

## 🚀 How to Run / Nasıl Çalıştırılır
1.  Import `KanserTakipDB_Yedek.sql` into your SQL Server.
2.  Open `KanserTespitProgramı.sln` with Visual Studio.
3.  The pre-trained model is located in the project folder as `MLModel1.mlnet`.
