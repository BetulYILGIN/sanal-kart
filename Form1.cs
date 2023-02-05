using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace E_KART
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O0NNHB3;Initial Catalog=EKART;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kimlikbtn_Click(object sender, EventArgs e)
        {
            kimlik form1sec = new kimlik();
            form1sec.Show();
            this.Hide();
        }

        private void ehliyetbtn_Click(object sender, EventArgs e)
        {
            ehliyet form1sec = new ehliyet();
            form1sec.Show();
            this.Hide();
        }

        private void otobusbtn_Click(object sender, EventArgs e)
        {
            otobuskarti form1sec = new otobuskarti();
            form1sec.Show();
            this.Hide();
        }

        private void ogrencibtn_Click(object sender, EventArgs e)
        {
            ögrencikarti form1sec = new ögrencikarti();
            form1sec.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıtlarım form1sec = new kayıtlarım();
            form1sec.Show();
            this.Hide();

            kayıtlarım listele = new kayıtlarım();
            listele.ShowDialog();
        }
    }
}
