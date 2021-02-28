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
    public partial class musteri_ekle_form : Form
    {
        MusteriDal musteridal = null;
        public musteri_ekle_form(Database database)
        {
            this.musteridal = new MusteriDal(database);
            InitializeComponent();
        }
        private void LoadProduct()
        {
            dgw_musteri.DataSource = musteridal.GetAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            musteridal.Add(new Musteri
            {
                mus_kod = txtKod.Text,
                mus_ad = txtAd.Text,
                mus_adres1 = txtAdres1.Text,
                mus_adres2 = txtAdres2.Text,
                mus_adres3 = txtAdres3.Text,
                mus_telefon = txtTelefon.Text,
                mus_email =txtMail.Text


            });

            MessageBox.Show("MÜŞTERİ EKLENDİ...");
            LoadProduct();
        }
    }
}
