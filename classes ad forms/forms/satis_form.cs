using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaret
{
    public partial class satis_form : Form
    {
        Database database = null;
        SatisDal satisdal = null;
        SatisDetayDal satisdetaydal = null;
        private string txt_fiyat, txt_kdv;
        public satis_form(Database database)
        {
            this.database = database;
            this.satisdal = new SatisDal(database);
            this.satisdetaydal = new SatisDetayDal(database);
            InitializeComponent();
            
        }

        private void satis_form_Load(object sender, EventArgs e)
        {

            dgwUrun.DataSource = satisdal.GetAllUrun();
            dgwMusteri.DataSource = satisdal.GetAllMusteri();
        }



        private void dgwUrun_SelectionChanged(object sender, EventArgs e)
        {
            try {
                
                

                txt_urunkod.Text = dgwUrun.SelectedRows[0].Cells["uru_kod"].Value.ToString();
                txt_fiyat = dgwUrun.SelectedRows[0].Cells["uru_fiyat"].Value.ToString();
                txt_kdv = dgwUrun.SelectedRows[0].Cells["uru_kdvorani"].Value.ToString();
                lbl_oran.Text = dgwUrun.SelectedRows[0].Cells["uru_kdvorani"].Value.ToString();

                hesapla();

            }
            catch(Exception exception)
            { }
        }

        private void dgwMusteri_CursorChanged(object sender, EventArgs e)
        {
            try
            {
                txt_musteri_id.Text = dgwMusteri.SelectedRows[0].Cells["mus_kod"].Value.ToString();
            }
            catch (Exception exception)
            {}

        }
        private void LoadProduct()
        {
            dgwUrun.DataSource = satisdal.GetAllSatis();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            satisdal.Add(new Satis
            {
                sat_musterikodu = txt_urunkod.Text,
                sat_evrakno = txt_evrak.Text,
                sat_evraktarihi = DateTime.Now, 
                sat_aciklama = richTextBox1.Text
            });
           

            
            LoadProduct();

            satisdetaydal.Add(new SatisDetay
            {
                sad_satisevrakno= txt_evrak.Text,
                sad_urunkodu = txt_urunkod.Text,
                sad_miktar =float.Parse(AdetSayac.Value.ToString()),
                sad_fiyat= float.Parse(lblTutar.Text) ,
                sad_tutar = float.Parse(lblTutar.Text),
                sad_kdvorani =float.Parse(lblTutar.Text),
                sad_kdvtutari= float.Parse(lbl_kdv_tutari.Text),
                sad_geneltoplam = float.Parse(lblTutar.Text)

        });
            MessageBox.Show("SATIŞ GERÇEKLEŞTİRİLDİ...");
            LoadProduct();


        }

        private void AdetSayac_ValueChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            database.ConnectionControl();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from urun where uru_kod like '%"+ txtUrunAra.Text + "%'",database.connection);
            SqlDataAdapter ara2 = new SqlDataAdapter("select * from urun where uru_ad like '%" + txtUrunAra.Text + "%'", database.connection);

            ara.Fill(tbl);
            ara2.Fill(tbl);
            database.connection.Close();
            dgwUrun.DataSource = tbl;




        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            database.ConnectionControl();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from musteri where mus_kod like '%" + txtMusteriAra.Text + "%'", database.connection);
            SqlDataAdapter ara2 = new SqlDataAdapter("select * from musteri where mus_ad like '%" + txtMusteriAra.Text + "%'", database.connection);

            ara.Fill(tbl);
            ara2.Fill(tbl);
            database.connection.Close();
            dgwMusteri.DataSource = tbl;

        }

        private void hesapla()
        {
            int adet = Convert.ToInt32(AdetSayac.Value);
            float kdv = ((float.Parse(txt_fiyat)) * (float.Parse(txt_kdv))) / 100;
            float tutar = adet * float.Parse(txt_fiyat);
            lbl_kdv_tutari.Text = (adet * kdv).ToString();
            lblTutar.Text = ((float.Parse(txt_fiyat) + kdv) * adet).ToString();
        }
    } 
}
