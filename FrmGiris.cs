using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciSistemiSelcanErcan
{
    public partial class FrmGiris : Form
    {
        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ERGBAB8;Initial Catalog=DbNotKayıt;Integrated Security=True");

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ServerName = "DESKTOP-ERGBAB8";
            string DatabaseName = "DbNotKayıt";

            string connectionString = $"Data Source={ServerName};Initial Catalog={DatabaseName};Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string kullaniciAdi = TxtOgretmenAdı.Text;
                    string sifre = TxtOgretmenSifre.Text;

                    string sqlSorgu = "SELECT OGRTID, OGRTAD, OGRTSIFRE FROM TBLOGRETMEN WHERE OGRTAD = @ad AND OGRTSIFRE = @sifre";

                    using (SqlCommand sorgu = new SqlCommand(sqlSorgu, baglanti))
                    {
                        sorgu.Parameters.AddWithValue("@ad", kullaniciAdi);
                        sorgu.Parameters.AddWithValue("@sifre", sifre);

                        using (SqlDataReader dr = sorgu.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Kullanıcı doğrulandıysa burada istediğiniz işlemleri yapabilirsiniz
                                FrmOgretmenDetay frm = new FrmOgretmenDetay();
                                frm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Yanlış Kullanıcı Adı veya Parola. Lütfen Bilgileri Doğru Girdiğinizden Emin Olun.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanı bağlantı hatası: {ex.Message}");
                }
            }
        }



        private void BtnOgrenciGiris_Click_1(object sender, EventArgs e)
        {
            string ogrenciNumara = maskedTextBox1.Text; // Öğrenci numarasını alıyoruz
            string ogrenciAd = OgrenciAd.Text; // Öğrenci adını alıyoruz

            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDERS WHERE OGRNUMARA=@p1 AND OGRAD=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", ogrenciNumara);
            komut.Parameters.AddWithValue("@p2", ogrenciAd);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();
                frm.numara = ogrenciNumara;
                frm.ogrenciAd = ogrenciAd;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı. Lütfen doğru numara ve ad giriniz.");
            }

            baglanti.Close();

        }





    }
}
