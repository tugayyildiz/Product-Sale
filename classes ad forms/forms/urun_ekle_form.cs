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
    public partial class urun_ekle_form : Form
    {
        Database database = null;
        urunDal urundal = null;

        public urun_ekle_form(Database database)
        {
            this.urundal = new urunDal(database);
            InitializeComponent();
        }

        private void LoadProduct()
        {
            dgwUrun.DataSource = urundal.GetAll();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            urundal.Add(new urun 
            {
                uru_kod = txtKod.Text,
                uru_ad =txtAd.Text,
                uru_birim = txtBirim.Text,
                uru_fiyat = float.Parse(txtFiyat.Text),
                uru_kdvorani = float.Parse(txtKdvOrani.Text)
            });

            MessageBox.Show("ÜRÜN EKLENDİ...");
            LoadProduct();
        }
    }
}
