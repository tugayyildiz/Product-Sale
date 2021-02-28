using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaret
{
    public partial class girisEkran : Form
    {
        Database database = null;
        public girisEkran(Database database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri_ekle_form ms = new musteri_ekle_form(database);
            ms.Visible = true;
            
        }

        private void girisEkran_Load(object sender, EventArgs e)
        {

        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            urun_ekle_form ue = new urun_ekle_form(database);
            ue.Visible = true;
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            satis_form sf = new satis_form(database);
            sf.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rapor_form r = new rapor_form(database);
            r.Visible = true;
        }
    }
}
