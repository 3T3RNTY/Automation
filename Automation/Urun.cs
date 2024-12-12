using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Automation
{
    
    class Urun
    {
        string connectionString = @"Data Source= ..\..\Database\database.db; version=3;";

        private int id;
        private string marka;
        private string ad;
        private string tur;
        private decimal fiyat;
        private int birimAdet;
        private decimal birimFiyat;
        private int indirimOrani;
        private int indirimliFiyat;
        private int stok;

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public decimal Fiyat { get; set; }
        public int BirimAdet { get; set; }
        public decimal BirimFiyat { get; set; }
        public int IndirimOrani { get; set; }
        public int IndirimliFiyat { get; set; }
        public int Stok { get; set; }


        
        public string Add()
        {
            try
            {

                string insertCmdString = $"INSERT INTO Urunler (Marka,Ad,Tur,Fiyat,BirimFiyat,IndirimOrani,IndirimliFiyat,StokMiktari) VALUES  ('{Marka}','{Ad}','{Tur}','{Fiyat}','{BirimFiyat}','{IndirimOrani}','{IndirimliFiyat}','{Stok}');";




                var connection = new SQLiteConnection(connectionString);
                connection.Open();

                var insertCmd = new SQLiteCommand(insertCmdString, connection);
                insertCmd.ExecuteNonQuery();

                connection.Close();

                return "Başarılı!";
            }
            catch (SQLiteException ex)
            {
                return ex.ToString();
            }
           
        }
    }
}
