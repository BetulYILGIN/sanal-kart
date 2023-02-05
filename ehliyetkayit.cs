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
    public partial class ehliyetkayit : Form
    {
        public ehliyetkayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        DataSet daset = new DataSet();

        private void ehliyetkayit_Load(object sender, EventArgs e)
        {
            kayıt_göster();

        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from ehliyet", baglanti);
            adtr.Fill(daset, "ehliyet");
            dataGridView1.DataSource = daset.Tables["ehliyet"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.Text = dataGridView1.CurrentRow.Cells["1"].Value.ToString();
            txt2.Text = dataGridView1.CurrentRow.Cells["2"].Value.ToString();
            txt3.Text = dataGridView1.CurrentRow.Cells["3"].Value.ToString();
            txt4a.Text = dataGridView1.CurrentRow.Cells["4a"].Value.ToString();
            txt4b.Text = dataGridView1.CurrentRow.Cells["4b"].Value.ToString();
            txt4c.Text = dataGridView1.CurrentRow.Cells["4c"].Value.ToString();
            txt4d.Text = dataGridView1.CurrentRow.Cells["4d"].Value.ToString();
            txt5.Text = dataGridView1.CurrentRow.Cells["5"].Value.ToString();
            txt9.Text = dataGridView1.CurrentRow.Cells["9"].Value.ToString();


        }
    }
}
