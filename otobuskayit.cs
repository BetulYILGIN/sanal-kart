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
    public partial class otobuskayit : Form
    {
        public otobuskayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        DataSet daset = new DataSet();


        private void otobuskayit_Load(object sender, EventArgs e)
        {
            kayıt_göster();

        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from otobuskarti", baglanti);
            adtr.Fill(daset, "otobuskarti");
            dataGridView1.DataSource = daset.Tables["otobuskarti"];
            baglanti.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxtkartno.Text = dataGridView1.CurrentRow.Cells["kartno"].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            txtkurum.Text = dataGridView1.CurrentRow.Cells["kurum"].Value.ToString();
            mtxtdogum.Text = dataGridView1.CurrentRow.Cells["dogumtarihi"].Value.ToString();



        }

        private void otobuskayit_Load_1(object sender, EventArgs e)
        {

        }
    }
}
