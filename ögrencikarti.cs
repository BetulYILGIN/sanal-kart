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
    public partial class ögrencikarti : Form
    {
        public ögrencikarti()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ogrencikarti(ad,soyad,ogrencino,fakulte,bolumadi) values(@ad,@soyad,@ogrencino,@fakulte,@bolumadi)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtadi.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@ogrencino", mtxtogrno.Text);
            komut.Parameters.AddWithValue("@fakulte", txtfakulte.Text);
            komut.Parameters.AddWithValue("@bolumadi", txtbolumadi.Text);
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

        private void btnresim_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "resim seç";
            fd.Filter = "(*.jpeg) | *.jpeg | (*.png) | *.png";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete ogrencikarti(ad,soyad,ogrenci_no,fakulte,bolum_adi) values(@ad,@soyad,@ogrenci_no,@fakulte,@bolum_adi)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtadi.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@ogrenci_no", mtxtogrno.Text);
            komut.Parameters.AddWithValue("@fakulte", txtfakulte.Text);
            komut.Parameters.AddWithValue("@bolum_adi", txtbolumadi.Text);
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
    }
}
