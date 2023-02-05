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
    public partial class kimlikkayit : Form
    {
        public kimlikkayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        DataSet daset = new DataSet();


        private void kimlikkayit_Load(object sender, EventArgs e)
        {
            
            kayıt_göster();

        }
        private void kayıt_göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from KİMLİK", baglanti);
            adtr.Fill(daset, "KİMLİK");
            dataGridView1.DataSource = daset.Tables["KİMLİK"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            txtdogum.Text = dataGridView1.CurrentRow.Cells["dogum"].Value.ToString();
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtbabaadi.Text = dataGridView1.CurrentRow.Cells["babaadı"].Value.ToString();
            txtanneadi.Text = dataGridView1.CurrentRow.Cells["anneadi"].Value.ToString();



        }
    }
}
