using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace E_KART
{
    public partial class ehliyet : Form
    {
        public ehliyet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        private void ehliyet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ehliyet(1,2,3,4a,4b,4c,4d,5,9) values(@1,@2,@3,@4a,@4b,@4c,@4d,@5,@8)", baglanti);
            komut.Parameters.AddWithValue("@1", txt1.Text);
            komut.Parameters.AddWithValue("@2", txt2.Text);
            komut.Parameters.AddWithValue("@3", txt3.Text);
            komut.Parameters.AddWithValue("@4a", txt4a.Text);
            komut.Parameters.AddWithValue("@4b", txt4b.Text); 
            komut.Parameters.AddWithValue("@4c", txt4c.Text);
            komut.Parameters.AddWithValue("@4d", txt4d.Text);
            komut.Parameters.AddWithValue("@5", txt5.Text);
            komut.Parameters.AddWithValue("@9", txt9.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "resim seç";
            fd.Filter = "(*.jpeg) | *.jpeg | (*.png) | *.png";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "PNG DOSYASI | *.png ";

            if (file.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(file.FileName);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(file.FileName);
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete ehliyet(1,2,3,4a,4b,4c,4d,5,9) values(@1,@2,@3,@4a,@4b,@4c,@4d,@5,@8)", baglanti);
            komut.Parameters.AddWithValue("@1", txt1.Text);
            komut.Parameters.AddWithValue("@2", txt2.Text);
            komut.Parameters.AddWithValue("@3", txt3.Text);
            komut.Parameters.AddWithValue("@4a", txt4a.Text);
            komut.Parameters.AddWithValue("@4b", txt4b.Text);
            komut.Parameters.AddWithValue("@4c", txt4c.Text);
            komut.Parameters.AddWithValue("@4d", txt4d.Text);
            komut.Parameters.AddWithValue("@5", txt5.Text);
            komut.Parameters.AddWithValue("@9", txt9.Text);
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
