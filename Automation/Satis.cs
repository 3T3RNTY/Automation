using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Automation
{
    class Satis
    {

        private int id;
        private int urunId;
        private string urunMarka;
        private string urunAd;
        private int miktar;
        private decimal alisFiyat;
        private decimal satisFiyat;
        private string iptal;

        public int Id { get => id; set => id = value; }
        public int UrunId { get => urunId; set => urunId = value; }
        public string UrunMarka { get => urunMarka; set => urunMarka = value; }
        public string UrunAd { get => urunAd; set => urunAd = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public decimal AlisFiyat { get => alisFiyat; set => alisFiyat = value; }
        public decimal SatisFiyat { get => satisFiyat; set => satisFiyat = value; }
        public string Iptal { get => iptal; set => iptal = value; }

        // Satış nesnesini oluşturmak için Yapıcı Metotlar
        public Satis() { }
        public Satis(int id, string tarih, int urunId, string urunMarka, string urunAd, int miktar, decimal alisFiyat, decimal satisFiyat, string iptal)
        {
            Id = id;
            string tarihGiris = tarih.Substring(0,10);
            int.TryParse(tarihGiris.Substring(0, 4), out int yil);         
            int.TryParse(tarihGiris.Substring(5, 2), out int ay);
            int.TryParse(tarihGiris.Substring(8), out int gun);
            DateTime time = new DateTime(yil,ay,gun);           
                
            UrunId = urunId;
            UrunMarka = urunMarka;
            UrunAd = urunAd;
            Miktar = miktar;
            AlisFiyat = alisFiyat;
            SatisFiyat = satisFiyat;
            Iptal = iptal;
        }
    }
}
