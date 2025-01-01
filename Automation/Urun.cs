using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Automation
{
    
    public class Urun
    {
        string connectionString = @"Data Source= ..\..\Database\database.db; version=3;";

        private int id;
        private string marka;
        private string ad;
        private string tur;
        private decimal alisFiyat;
        private decimal satisFiyat;
        private int indirimOrani;
        private decimal indirimliFiyat;
        private int stok;

        public int Id { get { return id; } set { id = value; } }
        public string Marka { get { return marka; } set { marka = value; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Tur { get { return tur; } set { tur = value; } }
        public decimal AlisFiyat { get { return alisFiyat; } set { alisFiyat = value; } }
        public decimal SatisFiyat { get { return satisFiyat; } set { satisFiyat = value; } }
        public int IndirimOrani { get { return indirimOrani; } set { indirimOrani = value; } }
        public decimal IndirimliFiyat { get { return indirimliFiyat; } set { indirimliFiyat = SatisFiyat - (SatisFiyat * IndirimOrani / 100); } }
        public int Stok { get { return stok; } set { stok = value; } }

        public Urun()
        {

        }
        public Urun(int id, string marka, string ad, string tur, decimal alisFiyat, decimal satisFiyat, int indirimOrani, decimal indirimliFiyat, int stok)
        {
            Id = id;
            Marka = marka;
            Ad = ad;
            Tur = tur;
            AlisFiyat = alisFiyat;
            SatisFiyat = satisFiyat;
            IndirimOrani = indirimOrani;
            IndirimliFiyat = indirimliFiyat;
            Stok = stok;
        }
        public Urun(string marka, string ad, string tur, decimal alisFiyat, decimal satisFiyat, int indirimOrani, decimal indirimliFiyat, int stok)
        {        
            Marka = marka;
            Ad = ad;
            Tur = tur;
            AlisFiyat = alisFiyat;
            SatisFiyat = satisFiyat;
            IndirimOrani = indirimOrani;
            IndirimliFiyat = indirimliFiyat;
            Stok = stok;
        }
        public Urun(string marka, string ad, string tur, decimal alisFiyat, decimal satisFiyat, int indirimOrani, decimal indirimliFiyat)
        {
            Marka = marka;
            Ad = ad;
            Tur = tur;
            AlisFiyat = alisFiyat;
            SatisFiyat = satisFiyat;
            IndirimOrani = indirimOrani;
            IndirimliFiyat = indirimliFiyat;
        }


        public string Ekle()
        {
            try
            {

                string insertCmdString = 
                    $" INSERT INTO Urunler (Marka,Ad,Tur,AlisFiyat,SatisFiyat,IndirimOrani,IndirimliFiyat,StokMiktari)" +
                    $" VALUES ('{Marka}','{Ad}','{Tur}','{AlisFiyat}','{SatisFiyat}','{IndirimOrani}','{IndirimliFiyat}','{Stok}');";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var insertCmd = new SQLiteCommand(insertCmdString, connection);
                    insertCmd.ExecuteNonQuery();
                    connection.Close();
                }                

                return "Ürün Başarıyla Eklendi";
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

                string updateCmdString = $"UPDATE Urunler" +
                    $" SET Marka = '{Marka}', Ad = '{Ad}', Tur = '{Tur}', AlisFiyat = '{AlisFiyat}', SatisFiyat = '{SatisFiyat}', IndirimOrani = '{IndirimOrani}', IndirimliFiyat = '{IndirimliFiyat}', StokMiktari = '{Stok}'" +
                    $" WHERE Id = '{Id}';";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var updateCmd = new SQLiteCommand(updateCmdString, connection);
                    updateCmd.ExecuteNonQuery();

                    connection.Close();
                }
                return "Ürün Başarıyla Değiştirildi!";
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

                string deleteCmdString = $"DELETE FROM Urunler WHERE Id = {Id};";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var deleteCmd = new SQLiteCommand(deleteCmdString, connection);
                    deleteCmd.ExecuteNonQuery();

                    connection.Close();
                }
                return "Ürün Başarıyla Silindi!";
            }
            catch (SQLiteException ex)
            {
                return ex.ToString();
            }
        }
    }
}
