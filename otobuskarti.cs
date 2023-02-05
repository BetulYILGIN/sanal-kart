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
    public partial class otobuskarti : Form
    {
        public otobuskarti()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into otobuskarti(kart_no,ad,soyad,kurum,dogum_tarihi) values(@kart_no,@ad,@soyad,@kurum,@dogum_tarihi)", baglanti);
            komut.Parameters.AddWithValue("@kart_no", mtxtkartno.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@kurum", txtkurum.Text);
            komut.Parameters.AddWithValue("@dogum_tarihi", mtxtdogum.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "resim seç";
            fd.Filter = "(*.jpeg) | *.jpeg | (*.png) | *.png";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete otobuskarti(kart_no,ad,soyad,kurum,dogum_tarihi) values(@kart_no,@ad,@soyad,@kurum,@dogum_tarihi)", baglanti);
            komut.Parameters.AddWithValue("@kart_no", mtxtkartno.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@kurum", txtkurum.Text);
            komut.Parameters.AddWithValue("@dogum_tarihi", mtxtdogum.Text);
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

        private void otobuskarti_Load(object sender, EventArgs e)
        {

        }
    }
}
