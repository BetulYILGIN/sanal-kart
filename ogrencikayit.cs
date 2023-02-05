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
    public partial class ogrencikayit : Form
    {
        public ogrencikayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        DataSet set = new DataSet();
        private void ogrencikayit_Load(object sender, EventArgs e)
        {
            kayıt_göster();

        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from ogrencikarti", baglanti);
            adtr.Fill(set, "ogrencikarti");
            dataGridView1.DataSource = set.Tables["ogrencikarti"];
            baglanti.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadi.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtsoyadi.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            mtxtogrno.Text = dataGridView1.CurrentRow.Cells["ogrencino"].Value.ToString();
            txtfakulte.Text = dataGridView1.CurrentRow.Cells["fakulte"].Value.ToString();
            txtbolumadi.Text = dataGridView1.CurrentRow.Cells["bolumadi"].Value.ToString();

        }
    }
}
