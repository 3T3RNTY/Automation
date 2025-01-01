using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Automation
{
    public class Kullanici
    {
        string connectionString = @"Data Source= ..\..\Database\database.db; version=3;";

        private int id;
        private string kullaniciAdi;
        private string sifre;
        private string ad;
        private string soyad;
        private string cinsiyet;
        private string pozisyon;
        private string tcno;
        private string telefon;
        private string adres;
        private decimal maas;

        public int Id { get => id; set => id = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string Pozisyon { get => pozisyon; set => pozisyon = value; }
        public string Tcno { get => tcno; set => tcno = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }
        public decimal Maas { get => maas; set => maas = value; }

        public Kullanici() { }
        public Kullanici(string kullaniciAdi, string sifre, string ad, string soyad, string cinsiyet, string pozisyon, string tcno, string telefon, string adres, decimal maas)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
            Pozisyon = pozisyon;
            Tcno = tcno;
            Telefon = telefon;
            Adres = adres;
            Maas = maas;
        }
        public Kullanici(int id, string kullaniciAdi, string sifre, string ad, string soyad, string cinsiyet, string pozisyon, string tcno, string telefon, string adres,decimal maas)
        {
            Id = id;
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
            Pozisyon = pozisyon;
            Tcno = tcno;
            Telefon = telefon;
            Adres = adres;
            Maas = maas;
        }


        public string Ekle()
        {
            try
            {
                string insertCmdString =
                    $" INSERT INTO Kullanicilar (KullaniciAdi,Sifre,Ad,Soyad,Cinsiyet,Pozisyon,TCNO,TelefonNo,EvAdres,Maas)" +
                    $" VALUES ('{KullaniciAdi}','{Sifre}','{Ad}','{Soyad}','{Cinsiyet}','{Pozisyon}','{Tcno}','{Telefon}','{Adres}','{Maas}');";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var insertCmd = new SQLiteCommand(insertCmdString, connection);
                    insertCmd.ExecuteNonQuery();
                    connection.Close();
                }

                return "Kişi Bilgileri Başarıyla Eklendi";
            }
            catch (SQLiteException ex)
            {
                return ex.ToString();
            }   
        }

        public string Degistir()
        {
            try
            {

                string updateCmdString = $"UPDATE Kullanicilar" +
                    $" SET " +
                    $" KullaniciAdi = '{KullaniciAdi}', Sifre = '{Sifre}', Ad = '{Ad}', Soyad = '{Soyad}', Cinsiyet = '{Cinsiyet}'," +
                    $" Pozisyon = '{Pozisyon}', TCNO = '{Tcno}',TelefonNo = '{Telefon}', EvAdres = '{Adres}', Maas = '{Maas}'" +
                    $" WHERE Id = '{Id}';";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var updateCmd = new SQLiteCommand(updateCmdString, connection);
                    updateCmd.ExecuteNonQuery();
                    connection.Close();
                }

                return "Kişi Bilgileri Başarıyla Değiştirildi";
            }
            catch (SQLiteException ex)
            {
                return ex.ToString();
            }
        }

        public string Sil()
        {
            try
            {
                string deleteCmdString = $"DELETE FROM Kullanicilar WHERE Id = {Id};";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var deleteCmd = new SQLiteCommand(deleteCmdString, connection);
                    deleteCmd.ExecuteNonQuery();

                    connection.Close();
                }
                return "Kişi Bilgileri Başarıyla Silindi";
            }
            catch (SQLiteException ex)
            {
                return ex.ToString();
            }
        }       
    }
}
