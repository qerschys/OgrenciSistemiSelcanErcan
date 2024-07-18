﻿using System;
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
    public partial class FrmOgretmenDetay : Form
    {
        
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ERGBAB8;Initial Catalog=DbNotKayıt;Integrated Security=True");

            private void FrmOgretmenDetay_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'dbNotKayıtDataSet2.TBLDERS' table. You can move, or remove it, as needed.
                this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

            }

            private void button1_Click(object sender, EventArgs e)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA, OGRAD, OGRSOYAD) values (@P1,@P2,@P3)", baglanti);

                komut.Parameters.AddWithValue("@P1", MskNumara.Text);

                komut.Parameters.AddWithValue("@P2", TxtAd.Text);

                komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Öğrenci Sisteme Eklendi");

                this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

            }





            private void button2_Click_1(object sender, EventArgs e)
            {
                double ortalama, s1, s2, s3;
                string durum;
                s1 = Convert.ToDouble(TxtSınav1.Text);
                s2 = Convert.ToDouble(TxtSınav2.Text);
                s3 = Convert.ToDouble(TxtSınav3.Text);

                ortalama = (s1 + s2 + s3) / 3;

                LblOrtalama.Text = ortalama.ToString();
                if (ortalama >= 50)

                {

                    durum = "True";

                }

                else

                {

                    durum = "False";



                }

                baglanti.Open();

                SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1, OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4, DURUM=@P5 WHERE OGRNUMARA=@P6", baglanti);

                komut.Parameters.AddWithValue("@P1", TxtSınav1.Text);

                komut.Parameters.AddWithValue("@P2", TxtSınav2.Text);

                komut.Parameters.AddWithValue("@P3", TxtSınav3.Text);

                komut.Parameters.AddWithValue("@P4", decimal.Parse(LblOrtalama.Text));

                komut.Parameters.AddWithValue("@P5", durum);

                komut.Parameters.AddWithValue("@P6", MskNumara.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Öğrenci Notları Güncellendi");

                this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);


            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {


                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

                TxtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                TxtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                TxtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();



            }
        
    }
}
