using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_KART
{
    public partial class kimlik : Form
    {
        public kimlik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KİMLİK(ad,soyad,dogum_tarihi,tc,baba_adı,anne_adı,cinsiyet) values(@ad,@soyad,@dogum_tarihi,@tc,@anne_adı,@baba_adı,@cinsiyet1)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@dogum_tarihi", txtdogum.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@baba_adı", txtbabaadi.Text);
            komut.Parameters.AddWithValue("@anne_adı", txtanneadi.Text);
            komut.Parameters.AddWithValue("@cinsiyet1", rdkadin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt Başarılı.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }


            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete KİMLİK(ad,soyad,dogum_tarihi,tc,baba_adı,anne_adı,cinsiyet) values(@ad,@soyad,@dogum_tarihi,@tc,@anne_adı,@baba_adı,@cinsiyet1)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@dogum_tarihi", txtdogum.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@baba_adı", txtbabaadi.Text);
            komut.Parameters.AddWithValue("@anne_adı", txtanneadi.Text);
            komut.Parameters.AddWithValue("@cinsiyet1", rdkadin.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("kayıt Başarılı.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }


            }
        }

        private void kimlik_Load(object sender, EventArgs e)
        {

        }
    }
}
