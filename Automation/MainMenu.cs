using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Automation
{
    public partial class MainMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        // Kullanılacak Sınıflardan Nesnelerin Türetilmesi
        Satis satis = new Satis();
        Kullanici kullanici = new Kullanici();
        Kullanici calisan = new Kullanici();
        Urun urun = new Urun();

        // Veritabanı Bağlantı Adresi
       
        string connectionString = @"Data Source= ..\..\database.db; version=3;";

        int yetki = 0;       

        // Veritabanı Tablolarından Bilgi Alma Query'leri
        string urunSelectCmd = "SELECT * FROM Urunler";
        string kisiSelectCmd = "SELECT * FROM Kullanicilar";
        string satisListeleCmd = "SELECT * FROM Satislar";

        public MainMenu(Kullanici kullanici)
        {
            InitializeComponent();

            this.kullanici = kullanici;
            switch (kullanici.Pozisyon)
            {
                case "Müdür":
                    {
                        yetki = 5;
                        break;
                    }
                case "Müdür Yardımcısı":
                    {
                        yetki = 4;
                        break;
                    }
                case "Depo Sorumlusu":
                    {
                        yetki = 3;
                        break;
                    }
                case "Satış Danışmanı":
                    {
                        yetki = 2;
                        break;
                    }
                case "Kasiyer":
                    {
                        yetki = 1;
                        break;
                    }

            }
            switch (yetki)
            {
                // Müdür Yetkisi
                case 5:
                    {
                        calisanMainGroup.Visible = true;
                        urunlerMainGroup.Visible = true;
                        stokMainGroup.Visible = true;
                        satisMainGroup.Visible = true;
                        break;
                    }
                // Yardımcı Müdür Yetkisi
                case 4:
                    {
                        calisanMainGroup.Visible = true;
                        urunlerMainGroup.Visible = true;
                        stokMainGroup.Visible = true;
                        satisMainGroup.Visible = true;
                        break;
                    }
                // Depo Sorumlusu Yetkisi
                case 3:
                    {
                        calisanMainGroup.Visible = false;
                        urunlerMainGroup.Visible = true;
                        stokMainGroup.Visible = true;
                        satisMainGroup.Visible = false;

                        break;
                    }
                // Satış Danışmanı Yetkisi
                case 2:
                    {
                        calisanMainGroup.Visible = false;

                        urunlerMainGroup.Visible = true;
                        urunEkle.Visible = false;
                        urunDuzenle.Visible = false;
                        urunSil.Visible = false;

                        satisMainGroup.Visible = true;
                        satisEkle.Visible = false;
                        satisSil.Visible = false;
                        


                        break;
                    }
                // Kasiyer yetkisi
                case 1:
                    {

                        urunlerMainGroup.Visible = true;

                        urunEkle.Visible = false;
                        urunDuzenle.Visible = false;
                        urunSil.Visible = false;

                        satisMainGroup.Visible = true;
                        gbSatisHesap.Visible = false;


                        break;
                    }
            }
            // Menü Oluşturulduğunda Tabloların Doldurulması
            KisiGuncelle();
            UrunGuncelle();
            StokGuncelle();
            SatisGuncelle();          
        }

        #region Çalışan Menüsü

        // Yan Panel Çalışan Listeleme Butonu
        private void calisanListele_Click(object sender, EventArgs e)
        {
            gbCalisanSearch.Location = new Point(10, 10);

            gbCalisanKontrol.Show();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            gbCalisanInfo.Hide();
            gbCalisanSearch.Show();
            gbCalisanSelect.Hide();

            calisanList.Show();
        }

        // Yan Panel Çalışan Ekleme Butonu
        private void calisanEkle_Click(object sender, EventArgs e)
        {
            gbCalisanSearch.Location = new Point(10, 340);

            gbCalisanKontrol.Show();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            gbCalisanInfo.Show();
            gbCalisanSearch.Hide();
            gbCalisanSelect.Hide();

            btnCalisanEkle.Show();
            btnCalisanDegistir.Hide();
            btnCalisanSil.Hide();

            calisanList.Hide();
            KisiTemizle();
        }

        // Yan Panel Çalışan Düzenleme Butonu
        private void calisanDuzenle_Click(object sender, EventArgs e)
        {
            gbCalisanSearch.Location = new Point(10, 340);

            gbCalisanKontrol.Show();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            gbCalisanInfo.Show();
            gbCalisanSearch.Show();
            gbCalisanSelect.Show();

            btnCalisanEkle.Hide();
            btnCalisanDegistir.Show();
            btnCalisanSil.Hide();

            calisanList.Show();
            KisiTemizle();

        }

        // Yan Panel Çalışan Silme Butonu
        private void calisanSil_Click(object sender, EventArgs e)
        {
            gbCalisanSearch.Location = new Point(10, 340);

            gbCalisanKontrol.Show();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            gbCalisanInfo.Show();
            gbCalisanSearch.Show();
            gbCalisanSelect.Show();

            btnCalisanEkle.Hide();
            btnCalisanDegistir.Hide();
            btnCalisanSil.Show();

            calisanList.Show();
            KisiTemizle();
        }
        #endregion

        #region Çalışan İşlem Butonları

        // Çalışan Bilgi Ekleme İşlemi
        private void calisanEklebtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = tbCalisanKullaniciAdi.Text;
            string sifre = tbCalisanSifre.Text;
            string ad = tbCalisanAd.Text;
            string soyad = tbCalisanSoyad.Text;
            string cinsiyet = cbCalisanCinsiyet.Text;
            string pozisyon = cbCalisanPozisyon.Text;
            string tcno = tbCalisanTcno.Text;
            string telefon = tbCalisanTelefon.Text;
            string adres = tbCalisanAdres.Text;

            if (decimal.TryParse(tbCalisanMaas.Text, out decimal maas))
            {
                if (maas < 0)
                {
                    MessageBox.Show("Çalışan Maaşı Negatif Olamaz.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Çalışan Maaşı Bir Sayı Olmalıdır.");
                return;
            }

            Kullanici calisan = new Kullanici(kullaniciAdi, sifre, ad, soyad, cinsiyet, pozisyon, tcno, telefon, adres, maas);

            MessageBox.Show(calisan.Ekle());
            KisiGuncelle();
            KisiTemizle();
        }

        // Çalışan Bilgi Değiştirme Işlemi
        private void CalisanDegistirbtn_Click(object sender, EventArgs e)
        {
            calisan.KullaniciAdi = tbCalisanKullaniciAdi.Text;
            calisan.Sifre = tbCalisanSifre.Text;
            calisan.Ad = tbCalisanAd.Text;
            calisan.Soyad = tbCalisanSoyad.Text;
            calisan.Cinsiyet = cbCalisanCinsiyet.Text;
            calisan.Pozisyon = cbCalisanPozisyon.Text;
            calisan.Tcno = tbCalisanTcno.Text;
            calisan.Telefon = tbCalisanTelefon.Text;
            calisan.Adres = tbCalisanAdres.Text;
            if (decimal.TryParse(tbCalisanMaas.Text, out decimal maas))
            {
                if (maas < 0)
                {
                    MessageBox.Show("Maaş  Negatif Olamaz");
                    return;
                }
                calisan.Maas = maas;
            }
            else
            {
                MessageBox.Show("Maaş Bir Sayı Olmalı");
                return;
            }

            MessageBox.Show(calisan.Degistir());
            KisiGuncelle();
            KisiTemizle();
        }

        // Çalışan Bilgi Silme Işlemi
        private void calisanSilbtn_Click(object sender, EventArgs e)
        {
            if (tbCalisanKullaniciAdi.Text == "")
            {
                MessageBox.Show("Önce Silinecek Çalışanı Seçmelisin");
            }
            else
            {
                MessageBox.Show(calisan.Sil());
                KisiGuncelle();
                KisiTemizle();
            }
        }

        // Çalışan Bilgi Seçme Işlemi
        private void calisanSelectbtn_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectCommand = $"SELECT * FROM Kullanicilar WHERE Id = @id";
                var command = new SQLiteCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@id", tbCalisanSecim.Text);

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var input = reader.GetValues();
                    int id = reader.GetInt32(0);
                    string kullaniciAdi = reader.GetString(1);
                    string sifre = reader.GetString(2);
                    string ad = reader.GetString(3);
                    string soyad = reader.GetString(4);
                    string cinsiyet = reader.GetString(5);
                    string pozisyon = reader.GetString(6);
                    string tcno = reader.GetString(7);
                    string telefon = reader.GetString(8);
                    string adres = reader.GetString(9);
                    decimal maas = reader.GetInt32(10);

                    Kullanici calisan = new Kullanici(id, kullaniciAdi, sifre, ad, soyad, cinsiyet, pozisyon, tcno, telefon, adres, maas);
                    this.calisan = calisan;
                }
                connection.Close();

                tbCalisanKullaniciAdi.Text = calisan.KullaniciAdi;
                tbCalisanSifre.Text = calisan.Sifre;
                tbCalisanAd.Text = calisan.Ad;
                tbCalisanSoyad.Text = calisan.Soyad;
                cbCalisanCinsiyet.Text = calisan.Cinsiyet;
                cbCalisanPozisyon.Text = calisan.Pozisyon;
                tbCalisanTcno.Text = calisan.Tcno;
                tbCalisanTelefon.Text = calisan.Telefon;
                tbCalisanAdres.Text = calisan.Adres;
                tbCalisanMaas.Text = calisan.Maas.ToString();

            }
        }

        // Çalışan Arama Işlemi
        private void calisanSearchtb_TextChanged(object sender, EventArgs e)
        {
            string selectWantedCommand = "SELECT * FROM Kullanicilar";

            var adapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();


            if (tbCalisanArama.Text != "")
            {
                switch (cbCalisanArama.SelectedIndex)
                {
                    case 0:
                        {
                            selectWantedCommand += $" WHERE Id like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 1:
                        {
                            selectWantedCommand += $" WHERE KullaniciAdi like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 2:
                        {
                            selectWantedCommand += $" WHERE Sifre like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 3:
                        {
                            selectWantedCommand += $" WHERE Ad like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 4:
                        {
                            selectWantedCommand += $" WHERE Soyad like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 5:
                        {
                            selectWantedCommand += $" WHERE Cinsiyet like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 6:
                        {
                            selectWantedCommand += $" WHERE Pozisyon like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 7:
                        {
                            selectWantedCommand += $" WHERE TCNO like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 8:
                        {
                            selectWantedCommand += $" WHERE TelefonNo like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 9:
                        {
                            selectWantedCommand += $" WHERE EvAdres like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                    case 10:
                        {
                            selectWantedCommand += $" WHERE Maas like '%{tbCalisanArama.Text}%'";
                            break;
                        }
                }
            }
            else
            {
                selectWantedCommand = "SELECT * FROM Kullanicilar";
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(selectWantedCommand, connection))
                {

                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    calisanList.DataSource = dataTable;
                }
            }
        }
        #endregion

        #region Ürün Menüsü
        // Ürün menüsü butonları
        private void urunListele_Click(object sender, EventArgs e)
        {
            urunBulmagb.Location = new Point(10, 10);

            gbCalisanKontrol.Hide();
            gbUrunKontrol.Show();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            urunBilgigb.Hide();
            urunSelectgb.Hide();
            urunBulmagb.Show();

            urunEditList.Show();
            UrunTemizle();

        }
        // Yan panel ürün ekleme butonu
        private void urunEkle_Click(object sender, EventArgs e)
        {
            urunBulmagb.Location = new Point(10, 260);

            gbCalisanKontrol.Hide();
            gbUrunKontrol.Show();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            urunBilgigb.Show();
            urunSelectgb.Hide();
            urunBulmagb.Hide();

            eklebtn.Show();
            silbtn.Hide();
            degistirbtn.Hide();

            urunEditList.Hide();
            UrunTemizle();
        }
        // Yan panel ürün düzenleme butonu
        private void urunDuzenle_Click(object sender, EventArgs e)
        {
            urunBulmagb.Location = new Point(10, 260);

            gbCalisanKontrol.Hide();
            gbUrunKontrol.Show();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            urunBilgigb.Show();
            urunSelectgb.Show();
            urunBulmagb.Show();

            eklebtn.Hide();
            silbtn.Hide();
            degistirbtn.Show();

            urunEditList.Show();
            UrunTemizle();
        }
        // Yan panel ürün silme butonu
        private void urunSil_Click(object sender, EventArgs e)
        {
            urunBulmagb.Location = new Point(10, 260);

            gbCalisanKontrol.Hide();
            gbUrunKontrol.Show();           
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            urunBilgigb.Show();
            urunSelectgb.Show();
            urunBulmagb.Show();

            eklebtn.Hide();
            silbtn.Show();
            degistirbtn.Hide();

            urunEditList.Show();
            UrunTemizle();
        }
        #endregion

        #region Ürün İşlem Butonları

        // 'Ekle' Butonu eventleri
        private void UrunEkleBtn_Click(object sender, EventArgs e)
        {
            string marka = tbUrunMarka.Text;
            string ad = tbUrunAd.Text;
            string tur = tbUrunTur.Text;


            if (decimal.TryParse(tbUrunAlisFiyat.Text, out decimal alisFiyat))
            {
                if (alisFiyat < 0)
                {
                    MessageBox.Show("Alış Fiyatı Negatif Olamaz.");
                    return;

                }               
            }
            else
            {
                MessageBox.Show("Alış Fiyatı Bir Sayı Olmalıdır.");
                return;
            }

            if (decimal.TryParse(tbUrunSatisFiyat.Text, out decimal satisFiyat))
            {
                if (satisFiyat < 0)
                {
                    MessageBox.Show("Satış Fiyatı Negatif Olamaz.");
                    return;
                }               
            }
            else
            {
                MessageBox.Show("Satış Fiyatı Bir Sayı Olmalıdır.");
                return;
            }

            if (int.TryParse(tbUrunIndirim.Text, out int indirim))
            {
                if (indirim < 0)
                {
                    MessageBox.Show("Indirim Oranı Negatif Olamaz.");
                    return;
                }            
            }
            else
            {
                MessageBox.Show("İndirim Oranı Bir Sayı Olmalıdır.");
                return;
            }

            decimal indirimliFiyat = satisFiyat - (satisFiyat * indirim /100);

            Urun urun = new Urun(marka, ad, tur, alisFiyat, satisFiyat, indirim, indirimliFiyat);
            MessageBox.Show(urun.Ekle());

            UrunTemizle();
            UrunGuncelle();
        }

        // 'Değiştir' Butonu eventleri
        private void degistirbtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbUrunAlisFiyat.Text, out decimal alisFiyat))
            {
                if (alisFiyat >= 0)
                {
                    urun.AlisFiyat = alisFiyat;
                }
                else
                {
                    MessageBox.Show("Satış Fiyatı Negatif Olamaz.");
                    return;
                }             
            }
            else
            {
                MessageBox.Show("Alış Fiyatı Bir Sayı Olmalıdır.");
                return;
            }
            if (decimal.TryParse(tbUrunSatisFiyat.Text, out decimal satisFiyat))
            {
                if (satisFiyat >= 0)
                {
                    urun.SatisFiyat = satisFiyat;
                }
                else
                {
                    MessageBox.Show("Satış Fiyatı Negatif Olamaz.");
                    return;
                }
            
            }
            else
            {
                MessageBox.Show("Satış Fiyatı Bir Sayı Olmalıdır.");
                return;
            }
            if (int.TryParse(tbUrunIndirim.Text, out int indirim))
            {
                if( indirim >= 0)
                {
                    urun.IndirimOrani = indirim;
                }
                else
                {
                    MessageBox.Show("Indirim Oranı Negatif Olamaz.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("İndirim Oranı Bir Sayı Olmalıdır.");
                return;
            }

            urun.IndirimliFiyat = satisFiyat;

            MessageBox.Show(urun.Degistir());

            UrunGuncelle();
            UrunTemizle();

        }

        // 'Sil' Butonu eventleri
        private void silbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(urun.Sil());
            UrunGuncelle();
            UrunTemizle();
        }

        // Ürün Seçim Olayı
        private void urunSelectbtn_Click(object sender, EventArgs e)
        {

            if (urunSelecttb.Text == "")
            {
                MessageBox.Show("Id girişi boş olamaz!");
                return;
            }
            if (int.TryParse(urunSelecttb.Text, out int id))
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectCommand = $"SELECT * FROM urunler WHERE Id = @id";
                    var command = new SQLiteCommand(selectCommand, connection);
                    command.Parameters.AddWithValue("@id", id);

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        string marka = reader.GetString(1);
                        string ad = reader.GetString(2);
                        string tur = reader.GetString(3);

                        decimal alisFiyat = reader.GetDecimal(4);
                        decimal satisFiyat = reader.GetDecimal(5);
                        int indirimOrani = reader.GetInt32(6);
                        decimal indirimliFiyat = 0;
                        int stok = reader.GetInt32(8);

                        Urun urun = new Urun(id, marka, ad, tur, alisFiyat, satisFiyat, indirimOrani, indirimliFiyat, stok);

                        tbUrunMarka.Text = urun.Marka;
                        tbUrunAd.Text = urun.Ad;
                        tbUrunTur.Text = urun.Tur;
                        tbUrunAlisFiyat.Text = urun.AlisFiyat.ToString();
                        tbUrunSatisFiyat.Text = urun.SatisFiyat.ToString();
                        tbUrunIndirim.Text = urun.IndirimOrani.ToString();

                        this.urun = urun;

                    }
                }
            }
            else
            {
                MessageBox.Show("Id Bir Sayı Olmalıdır.");
            }



        }

        // Ürün Arama Olayı
        private void urunSearchtb_TextChanged(object sender, EventArgs e)
        {
            string selectWantedCommand = "SELECT * FROM Urunler";

            var adapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();

            if (urunSearchtb.Text != "")
            {
                switch (urunSearchcb.SelectedIndex)
                {
                    case 0:
                        {

                            selectWantedCommand += $" WHERE Id like '%{urunSearchtb.Text}%'";

                            break;
                        }
                    case 1:
                        {
                            selectWantedCommand += $" WHERE Marka like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 2:
                        {
                            selectWantedCommand += $" WHERE Ad like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 3:
                        {
                            selectWantedCommand += $" WHERE Tur like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 4:
                        {
                            selectWantedCommand += $" WHERE AlisFiyat like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 5:
                        {
                            selectWantedCommand += $" WHERE SatisFiyat like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 6:
                        {
                            selectWantedCommand += $" WHERE IndirimOrani like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 7:
                        {
                            selectWantedCommand += $" WHERE IndirimliFiyat like '%{urunSearchtb.Text}%'";
                            break;
                        }
                    case 8:
                        {
                            selectWantedCommand += $" WHERE StokMiktari like '%{urunSearchtb.Text}%'";
                            break;
                        }
                }
            }
            else
            {
                selectWantedCommand = "SELECT * FROM Urunler";
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(selectWantedCommand, connection))
                {

                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    urunEditList.DataSource = dataTable;
                }
            }
        }

       
        #endregion

        #region Stok Kontrol Menüsü

        private void stokEkle_Click(object sender, EventArgs e)
        {
            gbCalisanKontrol.Hide();
            gbUrunKontrol.Hide();
            gbStokKontrol.Show();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            StokTemizle();
            gbStokIslem.Text = "Stok Ekle";
            btnStokIslem.Text = "Stok Ekle";
           
        }
        private void stokSil_Click(object sender, EventArgs e)
        {
            gbCalisanKontrol.Hide();
            gbUrunKontrol.Hide();
            gbStokKontrol.Show();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            StokTemizle();
            gbStokIslem.Text = "Stok Sil";
            btnStokIslem.Text = "Stok Sil";
        }

        private void btnStokSecim_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbStokSecim.Text, out int id))
            {
                string command = "SELECT * FROM Urunler WHERE Id = @id";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var selectCommand = new SQLiteCommand(command, connection);
                    selectCommand.Parameters.AddWithValue("@id", id);
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        string marka = reader.GetString(1);
                        string ad = reader.GetString(2);
                        string tur = reader.GetString(3);

                        decimal alisFiyat = reader.GetDecimal(4);
                        decimal satisFiyat = reader.GetDecimal(5);
                        int indirimOrani = reader.GetInt32(6);
                        decimal indirimliFiyat = 0;
                        int stok = reader.GetInt32(8);

                        Urun urun = new Urun(id, marka, ad, tur, alisFiyat, satisFiyat, indirimOrani, indirimliFiyat, stok);
                        this.urun = urun;
                        MessageBox.Show("Ürün Başarıyla Seçildi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli Bir Id Giriniz.");
                return;
            }       
        }
        private void btnStokIslem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbStokIslem.Text, out int stok))
            {
                if (stok < 0)
                {
                    MessageBox.Show("Stok Miktarı Negatif Olamaz");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Stok Miktarı Negatif Olamaz");
                return;
            }

            if (btnStokIslem.Text == "Stok Ekle")
            {
                urun.Stok += stok;
                urun.Degistir();
                StokGuncelle();
                StokTemizle();
            }
            else
            {
                urun.Stok -= stok;
                urun.Degistir();
                StokGuncelle();
                StokTemizle();
            }
           
        }

        #endregion

        #region Satış Kontrol Menüsü

        private void satısEkle_Click(object sender, EventArgs e)
        {
            gbCalisanKontrol.Hide();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();

            gbSatisKontrol.Show();
            gbSatislar.Hide();
            gbHesapAyari.Hide();

            SatisTemizle();
            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(urunSelectCmd, connection))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    DataTable datatable = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);
                    gcSatisListe.DataSource = datatable;
                }
            }
        }

        private void satisSil_Click(object sender, EventArgs e)
        {
            gbCalisanKontrol.Hide();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();

            gbSatisKontrol.Hide();
            gbSatislar.Show();
            gbHesapAyari.Hide();

            btnSatisListeleme.Hide();
            btnSatisIptal.Show();
            gbSatisListeSecim.Visible = true;
            gbSatisHesap.Hide();
            SatisGuncelle();
            SatisTemizle();
        }

        private void satisListele_Click(object sender, EventArgs e)
        {
            gbCalisanKontrol.Hide();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Show();
            gbHesapAyari.Hide();

            btnSatisListeleme.Show();
            gbSatisHesap.Location = new Point(10,120);
            btnSatisListeleme.Location = new Point(90, 280);
            gbSatisListeSecim.Visible = false;
            gbSatisHesap.Show();
            btnSatisIptal.Hide();
            SatisGuncelle();
            SatisTemizle();
        }


        #endregion

        #region Satış Butonları

        // Satış Ekleme Butonları

        private void btnSatisSecim_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbSatisSecim.Text, out int id))
            {
                string command = "SELECT * FROM Urunler WHERE Id = @id";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var selectCommand = new SQLiteCommand(command, connection);
                    selectCommand.Parameters.AddWithValue("@id", id);
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        string marka = reader.GetString(1);
                        string ad = reader.GetString(2);
                        string tur = reader.GetString(3);

                        decimal alisFiyat = reader.GetDecimal(4);
                        decimal satisFiyat = reader.GetDecimal(5);
                        int indirimOrani = reader.GetInt32(6);
                        decimal indirimliFiyat = 0;
                        int stok = reader.GetInt32(8);

                        Urun urun = new Urun(id, marka, ad, tur, alisFiyat, satisFiyat, indirimOrani, indirimliFiyat, stok);
                        this.urun = urun;
                        MessageBox.Show("Ürün Başarıyla Seçildi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli Bir Id Giriniz.");
                return;
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (int.TryParse(tbSatisMiktar.Text, out int satis))
            {
                if (satis < 0)
                {
                    MessageBox.Show("Satış Miktarı Negatif Olamaz");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Satış Miktarı Sayı Olmalıdır.");
                return;
            }
            if (urun.Stok < satis)
            {
                MessageBox.Show("Yeterince Stok Bulunmamaktadır.");
                return;
            }


            string satisCmd = "INSERT INTO Satislar (Tarih, UrunId, UrunMarka, UrunAd, Miktar, AlisFiyat, SatisFiyat, Iptal) VALUES (@Tarih, @Id, @Marka, @Ad, @Miktar, @AlisFiyat, @SatisFiyat, @Iptal);";
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var satisCommand = new SQLiteCommand(satisCmd, connection);
                    satisCommand.Parameters.AddWithValue("@Tarih", today);
                    satisCommand.Parameters.AddWithValue("@Id", urun.Id);
                    satisCommand.Parameters.AddWithValue("@Marka", urun.Marka);
                    satisCommand.Parameters.AddWithValue("@Ad", urun.Ad);
                    satisCommand.Parameters.AddWithValue("@Miktar", satis);
                    satisCommand.Parameters.AddWithValue("@AlisFiyat", urun.AlisFiyat);
                    satisCommand.Parameters.AddWithValue("@SatisFiyat", urun.IndirimliFiyat);
                    satisCommand.Parameters.AddWithValue("@Iptal", "Hayır");
                    satisCommand.ExecuteNonQuery();

                    MessageBox.Show("Sipariş Başarıyla Oluşturuldu.");
                    urun.Stok -= satis;
                    urun.Degistir();

                    using (var command = new SQLiteCommand(urunSelectCmd, connection))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                        DataTable datatable = new DataTable();
                        adapter.SelectCommand = command;
                        adapter.Fill(datatable);
                        gcSatisListe.DataSource = datatable;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SatisTemizle();
        }

        //   Satış Listesi Butonları

        // Iptal Olmayan Satışları Listele
        private void btnSatisListeSecim_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbSatisListeSecim.Text, out int id))
            {
                string command = "SELECT * FROM Satislar WHERE Id = @id";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var selectCommand = new SQLiteCommand(command, connection);
                    selectCommand.Parameters.AddWithValue("@id", id);
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        string tarih = reader.GetString(1);
                        int urunId = reader.GetInt32(2);
                        string urunMarka = reader.GetString(3);
                        string urunAd = reader.GetString(4);
                        int miktar = reader.GetInt32(5);
                        int alisFiyat = reader.GetInt32(6);
                        int satisFiyat = reader.GetInt32(7);
                        string iptal = reader.GetString(8);

                        Satis satis = new Satis(id, tarih, urunId, urunMarka,urunAd,miktar,alisFiyat,satisFiyat,iptal);
                        this.satis = satis;
                        MessageBox.Show("Satış Başarıyla Seçildi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli Bir Id Giriniz.");
                return;
            }
        }

        // Satış Iptal Etme
        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (satis.Iptal == "Evet")
                return;

            string satisIptalCmd = "UPDATE Satislar SET Iptal = 'Evet' WHERE Id = @Id";
            string urunSecimCmd = "SELECT * FROM Urunler WHERE Id = @Id";
            string urunUpdateCmd = "UPDATE Urunler SET StokMiktari = @Stok WHERE Id = @Id";
            int stok = satis.Miktar;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var iptalCommand = new SQLiteCommand(satisIptalCmd, connection);
                iptalCommand.Parameters.AddWithValue("@Id", satis.Id);
                iptalCommand.ExecuteNonQuery();

                var urunSecim = new SQLiteCommand(urunSecimCmd,connection);
                urunSecim.Parameters.AddWithValue("@Id", satis.UrunId);               
                SQLiteDataReader reader = urunSecim.ExecuteReader();

                while (reader.Read())
                {
                    stok += reader.GetInt32(8);
                }

                var urunUpdate = new SQLiteCommand(urunUpdateCmd,connection);
                urunUpdate.Parameters.AddWithValue("@Stok", stok);
                urunUpdate.Parameters.AddWithValue("@Id", satis.UrunId);
                urunUpdate.ExecuteNonQuery();
                MessageBox.Show("Sipariş Başarıyla Iptal Edildi");
            }
            SatisGuncelle();
            SatisTemizle();

        }

        // Gelir - Gider Hesapla
        private void btnSatisHesapla_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            switch (cbSatisHesap.SelectedIndex)
            {
                case 0:
                    {
                        date = DateTime.Now.AddDays(-1);
                        break;
                    }
                case 1:
                    {
                        date = DateTime.Now.AddDays(-7);
                        break;
                    }
                case 2:
                    {
                        date = DateTime.Now.AddDays(-30);
                        break;
                    }              
                default:
                    {
                        break;
                    }
            }


            int gelir = 0;
            int gider = 0;
            int searchId = 0;
            int id = 0;
            string maxId = "SELECT Id FROM Satislar WHERE Id = (SELECT MAX(Id) FROM Satislar)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(maxId, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    searchId = reader.GetInt32(0);
                }
                while (id <= searchId)
                {
                    string selectCmd = $"Select * FROM Satislar WHERE Id = '{id}' AND Iptal = 'Hayır' ";
                    var selectCommand = new SQLiteCommand(selectCmd, connection);
                    SQLiteDataReader read = selectCommand.ExecuteReader();
                    while (read.Read())
                    {
                        string tarih = read.GetString(1);
                        int miktar = read.GetInt32(5);
                        int alisFiyat = read.GetInt32(6);
                        int satisFiyat = read.GetInt32(7);

                        DateTime time = new DateTime(Convert.ToInt32(tarih.Substring(0, 4)), Convert.ToInt32(tarih.Substring(5, 2)), Convert.ToInt32(tarih.Substring(8, 2)));
                        if (date < time)
                        {
                            gelir += satisFiyat * miktar;
                            gider += alisFiyat * miktar;
                            
                        }

                    }
                    tbSatisGelir.Text = gelir.ToString();
                    tbSatisGider.Text = gider.ToString();
                    tbSatisToplam.Text = (gelir - gider).ToString();
                    id++;
                }                
            }       
        }

        // Tüm Satışları Listele
        bool isPressed = false;
        private void btnSatisListeleme_Click(object sender, EventArgs e)
        {
            string listele = "";
            if (isPressed)
            {
                btnSatisListeleme.BackColor = Color.White;
                listele = "SELECT * FROM Satislar WHERE Iptal = 'Hayır'";
                isPressed = false;
            }
            else
            {
                btnSatisListeleme.BackColor = Color.Silver;
                isPressed = true;
                listele = "SELECT * FROM Satislar";
                

            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(listele, connection);
                var adapter = new SQLiteDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                gcSatislar.DataSource = table;

            }


        }

        // Özel Arama Kısmı
        private void tbSatisListeArama_TextChanged(object sender, EventArgs e)
        {
            string arama = "";
            string girdi = tbSatisListeArama.Text;
            switch (cbSatisListeArama.SelectedIndex)
            {
                case 0:
                    {
                        arama = $"WHERE Id Like '%{girdi}%'";
                        break;
                    }
                case 1:
                    {
                        arama = $"WHERE Tarih Like '%{girdi}%'";
                        break;
                    }
                case 2:
                    {
                        arama = $"WHERE UrunId Like '%{girdi}%'";
                        break;
                    }
                case 3:
                    {
                        arama = $"WHERE UrunMarka Like '%{girdi}%'";
                        break;
                    }
                case 4:
                    {
                        arama = $"WHERE UrunAd Like '%{girdi}%'";
                        break;
                    }
                case 5:
                    {
                        arama = $"WHERE Miktar Like '%{girdi}%'";
                        break;
                    }
                case 6:
                    {
                        arama = $"WHERE AlimFiyat Like '%{girdi}%'";
                        break;
                    }
                case 7:
                    {
                        arama = $"WHERE SatimFiyat Like '%{girdi}%'";
                        break;
                    }
                case 8:
                    {
                        arama = $"WHERE Iptal Like '%{girdi}%'";
                        break;
                    }
            }

            string aramaCmd = "SELECT * FROM Satislar " + arama;
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(aramaCmd, connection);
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                gcSatislar.DataSource = table;
            }


        }


        #endregion

        #region Hesap Ayarı

        private void hesapAyari_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.TextChanged += new EventHandler(textChanged);
            textbox.TextChanged += new EventHandler(SifreChanged);

            gbCalisanKontrol.Hide();
            gbUrunKontrol.Hide();
            gbStokKontrol.Hide();
            gbSatisKontrol.Hide();
            gbSatislar.Hide();
            gbHesapAyari.Show();

            tbHesapAd.Text = kullanici.Ad;
            tbHesapSoyad.Text = kullanici.Soyad;
            tbHesapKullaniciAdi.Text = kullanici.KullaniciAdi;
            tbHesapPozisyon.Text = kullanici.Pozisyon;
            cbHesapCinsiyet.Text = kullanici.Cinsiyet;
            tbHesapTelefon.Text = kullanici.Telefon;
            tbHesapAdres.Text = kullanici.Adres;

            btnHesapKaydet.Enabled = false;

        }

        private void SifreChanged(object sender, EventArgs e)
        {
            btnSifreDegis.Enabled = true;
        }

        private void textChanged(object sender, EventArgs e)
        {
            btnHesapKaydet.Enabled = true;
        }
        private void btnHesapKaydet_Click(object sender, EventArgs e)
        {
            kullanici.Ad = tbHesapAd.Text;
            kullanici.Soyad = tbHesapSoyad.Text;
            kullanici.KullaniciAdi = tbHesapKullaniciAdi.Text;
            kullanici.Cinsiyet = cbHesapCinsiyet.Text;
            kullanici.Telefon = tbHesapTelefon.Text;
            kullanici.Adres = tbHesapAdres.Text;
            MessageBox.Show(kullanici.Degistir());
        }

        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            if (tbYeniSifre.Text != tbYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni Şifre Uyuşmamaktadır.");
                return;
            }
            if (tbYeniSifre.TextLength < 5)
            {
                MessageBox.Show( "Yeni Şifre 5 Karakterden Uzun Olmalıdır.");
                return;
            }
            if (tbMevcutSifre.Text != kullanici.Sifre)
            {
                MessageBox.Show("Mevcut Şifre Yanlış");
                return;
            }
            kullanici.Sifre = tbYeniSifre.Text;
            MessageBox.Show(kullanici.Degistir());
        }

        #endregion



        // Çalışan Listesini Güncelleyen Metot
        public void KisiGuncelle()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(kisiSelectCmd, connection))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    DataTable datatable = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);
                    calisanList.DataSource = datatable;
                }
            }
        }

        // Ürün Listesini Güncelleyen Metot
        public void UrunGuncelle()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(urunSelectCmd, connection))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    DataTable datatable = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);
                    urunEditList.DataSource = datatable;
                }
            }
        }

        // Stok Listesini Güncelleyen Metot
        public void StokGuncelle()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(urunSelectCmd, connection))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    DataTable datatable = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);
                    gcStokList.DataSource = datatable;
                }
            }
        }
        // Satış-Ürün Listesini Güncelleyen Metot
        public void SatisGuncelle()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                using (var command = new SQLiteCommand(satisListeleCmd, connection))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    DataTable datatable = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);
                    gcSatislar.DataSource = datatable;
                }
            }
        }
        


        // Kişi Işleminden Sonra Girdileri Temizleyen Metot
        public void KisiTemizle()
        {
            tbCalisanKullaniciAdi.Text = "";
            tbCalisanSifre.Text = "";
            tbCalisanAd.Text = "";
            tbCalisanSoyad.Text = "";
            cbCalisanCinsiyet.Text = "";
            cbCalisanPozisyon.Text = "";
            tbCalisanTelefon.Text = "";
            tbCalisanAdres.Text = "";
            tbCalisanMaas.Text = "";         
        }

        // Ürün Işleminden Sonra Girdileri Temizleyen Metot
        public void UrunTemizle()
        {
            tbUrunMarka.Text = "";
            tbUrunAd.Text = "";
            tbUrunTur.Text = "";
            tbUrunAlisFiyat.Text = "";
            tbUrunSatisFiyat.Text = "";
            tbUrunIndirim.Text = "";
        }

        // Stok Işleminden Sonra Girdileri Temizleyen Metot
        public void StokTemizle()
        {
            tbStokIslem.Text = "";
            tbStokSecim.Text = "";
        }

        // Satış Işleminden Sonra Girdileri Temizleyen Metot
        public void SatisTemizle()
        {
            tbSatisArama.Text = "";
            tbSatisGelir.Text = "";
            tbSatisGider.Text = "";
            tbSatisListeArama.Text = "";
            tbSatisListeSecim.Text = "";
            tbSatisMiktar.Text = "";
            tbSatisSecim.Text = "";
            tbSatisToplam.Text = "";
        }



        // Form Kapandığında Uygulama Sonlanır
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Yan Menüden Çıkış'a Basıldığında Uygulama Sonlanır
        private void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}