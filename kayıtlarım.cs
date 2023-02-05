using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_KART
{
    public partial class kayıtlarım : Form
    {
        public kayıtlarım()
        {
            InitializeComponent();
        }

      

        private void kimlikkbtn_Click_1(object sender, EventArgs e)
        {
            kimlikkayit form1sec = new kimlikkayit();
            form1sec.Show();
            this.Hide();
        }

        private void ehliyetbtn_Click(object sender, EventArgs e)
        {
            ehliyetkayit form1sec = new ehliyetkayit();
            form1sec.Show();
            this.Hide();
        }

        private void otobusbtn_Click(object sender, EventArgs e)
        {
            otobuskayit form1sec = new otobuskayit();
            form1sec.Show();
            this.Hide();
        }

        private void ogrencibtn_Click(object sender, EventArgs e)
        {
            ogrencikayit form1sec = new ogrencikayit();
            form1sec.Show();
            this.Hide();
        }
    }
}
