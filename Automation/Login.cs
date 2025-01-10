using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Automation
{
    public partial class loginScreen : Form
    {
        // Veritabanı Bağlantısı
        string path = @"Data Source= ..\..\database.db; version=3;";



        public loginScreen()
        {
            InitializeComponent();
        }
        // Giriş Butonuna Basılma Olayı
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string cmd = @"SELECT * FROM Kullanicilar WHERE KullaniciAdi = @username";


            string entryUsername = usertb.Text;
            string entryPassword = sifretb.Text;

            int id = 0;
            string username = "";
            string password = "";
            string ad = "";
            string soyad = "";
            string cinsiyet = "";
            string pozisyon = "";
            string tcno = "";
            string telefon = "";
            string adres = "";
            decimal maas = 0;


            if (usertb.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş olamaz");
            }
            if (sifretb.Text == "")
            {
                MessageBox.Show("Şifre boş olmamaz");
            }
            else
            {
                using (SQLiteConnection connection = new SQLiteConnection(path))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(cmd, connection);

                    command.Parameters.AddWithValue("@username", entryUsername);
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        username = reader.GetString(1);
                        password = reader.GetString(2);
                        ad = reader.GetString(3);
                        soyad = reader.GetString(4);
                        cinsiyet = reader.GetString(5);
                        pozisyon = reader.GetString(6);
                        tcno = reader.GetString(7);
                        telefon = reader.GetString(8);
                        adres = reader.GetString(9);
                        maas = reader.GetDecimal(10);
                    }

                    if (username == entryUsername)
                    {

                        if (password == entryPassword)
                        {
                            

                            Kullanici kullanici = new Kullanici(id,username,password,ad,soyad,cinsiyet,pozisyon,tcno,telefon,adres,maas);

                            Form form = new MainMenu(kullanici);
                            form.Show();
                            Hide();

                        }
                        else
                        {
                            MessageBox.Show("Şifre Yanlış");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı adı bulunmamaktadır.");
                    }

                }
            }




        }
        // 'Şifreyi Göster' Kutusu
        private void loginSifrecheck_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
            if (checkbox.Checked)
            {
                sifretb.UseSystemPasswordChar = false;
            }
            else
            {
                sifretb.UseSystemPasswordChar = true;
            }
        }


        // 'Enter' Tuşuna Basıldığında Giriş Butonuna Basma Eylemini Gerçekleştiren Metot
        private void sifretb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn.PerformClick();
            }
        }
    }
}
