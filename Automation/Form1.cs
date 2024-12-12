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
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public string connectionString = @"..\..\Database\satabase.db; version=3;";

        public Form1()
        {
            InitializeComponent();
            UrunlerSource.Fill();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        // Çalışan menüsü butonları
        private void calisanListele_Click(object sender, EventArgs e)
        {

        }
        private void calisanEkle_Click(object sender, EventArgs e)
        {

        }
        private void calisanDuzenle_Click(object sender, EventArgs e)
        {

        }
        private void calisanSil_Click(object sender, EventArgs e)
        {

        }

        // Ürün menüsü butonları
        private void urunListele_Click(object sender, EventArgs e)
        {
            urunListe.Show();
            urunEklePencere.Hide();
            UrunEkleBtn.Hide();
        }
        private void urunEkle_Click(object sender, EventArgs e)
        {
            
            urunListe.Hide();
            urunEklePencere.Show();
            UrunEkleBtn.Show();
        }
        private void urunDuzenle_Click(object sender, EventArgs e)
        {

        }
        private void urunSil_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void UrunEkleBtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();

            urun.Marka = urunEkleMarkatb.Text;
            urun.Ad = urunEkleAdtb.Text;
            urun.Tur = urunEkleTurtb.Text;
            urun.Fiyat = Convert.ToInt32(urunEkleFiyatb.Text);
            urun.BirimAdet = Convert.ToInt32(urunEkleBAdettb.Text);
            urun.IndirimOrani = Convert.ToInt32(urunEkleIndirimOranitb.Text);
            urun.Stok = Convert.ToInt32(urunEkleStoktb.Text);

            MessageBox.Show(urun.Add());
        }
    }
}
