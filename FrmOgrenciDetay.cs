using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSistemiSelcanErcan
{
    public partial class FrmOgrenciDetay : Form
    {
        public string numara;
        public string ogrenciAd; // Eklenen property

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ERGBAB8;Initial Catalog=DbNotKayıt;Integrated Security=True");

        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDERS WHERE OGRNUMARA=@p1 AND OGRAD=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", ogrenciAd); // Adı da sorguluyoruz

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblSinav1.Text = dr[4].ToString();
                LblSinav2.Text = dr[5].ToString();
                LblSinav3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();

                // Ortalama kontrolü ve durumu belirleme
                double ortalama;
                if (double.TryParse(dr[7].ToString(), out ortalama))
                {
                    if (ortalama >= 50)
                    {
                        LblDurum.Text = "Geçti";
                    }
                    else
                    {
                        LblDurum.Text = "Kaldı";
                    }
                }
                else
                {
                    LblDurum.Text = "Ortalama bilgisi geçersiz";
                }
            }

            baglanti.Close();
        }

    }
}
