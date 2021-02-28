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
    public partial class rapor_form : Form
    {
        Database database = null;
        SatisDal satisdal = null;
        SatisDetayDal detaydal = null;

        public rapor_form(Database database)
        {
            this.database = database;
            this.satisdal = new SatisDal(database);
            this.detaydal = new SatisDetayDal(database);
            InitializeComponent();
        }
    
        private void rapor_forrm_Load(object sender, EventArgs e)
        {
            dgwUrun.DataSource = satisdal.GetAllUrun();
            dgwMusteri.DataSource = satisdal.GetAllMusteri();
            dgwSatis.DataSource = satisdal.GetAllSatis();
            dgwSatisDetay.DataSource = detaydal.GetAll();
        }

        private void dgwUrun_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                txtUrunKodu.Text = dgwUrun.SelectedRows[0].Cells["uru_kod"].Value.ToString();
                txtUrunAdi.Text= dgwUrun.SelectedRows[0].Cells["uru_ad"].Value.ToString();


            }
            catch (Exception exception)
            { }
        }

        private void dgwMusteri_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMKodu.Text = dgwMusteri.SelectedRows[0].Cells["mus_kod"].Value.ToString();
                txtMAdi.Text = dgwMusteri.SelectedRows[0].Cells["mus_ad"].Value.ToString();
            }
            catch (Exception exception)
            { }


        }

        private void dgvSatis_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                txtEvrakNo.Text = dgwSatis.SelectedRows[0].Cells["sat_evrakno"].Value.ToString();
                txtEvrakTarihi.Text = dgwSatis.SelectedRows[0].Cells["sat_evraktarihi"].Value.ToString();
            }
            catch (Exception exception)
            { }

        }

        private void dgwSatisDetay_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtSatisMiktari.Text = dgwSatisDetay.SelectedRows[0].Cells["sad_miktar"].Value.ToString();
                txtSatisFiyati.Text = dgwSatisDetay.SelectedRows[0].Cells["sad_fiyat"].Value.ToString();
                txtSatisTutar.Text = dgwSatisDetay.SelectedRows[0].Cells["sad_tutar"].Value.ToString();
            }
            catch (Exception exception)
            { }
        }

        Font baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana",12);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void pdYaz_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("EVRAK NO:"+ txtEvrakNo.Text, baslik,sb,100,150);
            e.Graphics.DrawString("EVRAK TARİHİ:"+ txtEvrakTarihi.Text, baslik, sb, 100, 200);
            e.Graphics.DrawString("MÜŞTERİ KODU:" + txtMKodu.Text, baslik, sb, 100, 250);
            e.Graphics.DrawString("MÜŞTERİ ADI:" + txtMAdi.Text, baslik, sb, 100, 300);
            e.Graphics.DrawString("SATIŞ TUTAR:"+ txtSatisTutar.Text, baslik, sb, 100, 350);
            e.Graphics.DrawString("ÜRÜN KODU:"+ txtUrunKodu.Text, baslik, sb, 100, 400);
            e.Graphics.DrawString( "ÜRÜN ADI:"+ txtUrunAdi.Text, baslik, sb, 100, 450);
            e.Graphics.DrawString( "SATIŞ MİKTARI:"+ txtSatisMiktari.Text, baslik, sb, 100, 500);
            e.Graphics.DrawString("SATIŞ FİYATI:" + txtSatisFiyati.Text, baslik, sb, 100, 550);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ppdDialog.ShowDialog();

        }
    }
}
