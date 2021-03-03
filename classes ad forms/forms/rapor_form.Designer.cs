
namespace eticaret
{
    partial class rapor_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor_form));
            this.dgwUrun = new System.Windows.Forms.DataGridView();
            this.dgwMusteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.txtEvrakTarihi = new System.Windows.Forms.TextBox();
            this.txtMKodu = new System.Windows.Forms.TextBox();
            this.txtMAdi = new System.Windows.Forms.TextBox();
            this.txtSatisTutar = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtSatisMiktari = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgwSatis = new System.Windows.Forms.DataGridView();
            this.dgwSatisDetay = new System.Windows.Forms.DataGridView();
            this.pdYaz = new System.Drawing.Printing.PrintDocument();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrun
            // 
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Location = new System.Drawing.Point(32, 41);
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.Size = new System.Drawing.Size(240, 150);
            this.dgwUrun.TabIndex = 0;
            this.dgwUrun.SelectionChanged += new System.EventHandler(this.dgwUrun_SelectionChanged);
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.Location = new System.Drawing.Point(309, 41);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.Size = new System.Drawing.Size(240, 150);
            this.dgwMusteri.TabIndex = 1;
            this.dgwMusteri.SelectionChanged += new System.EventHandler(this.dgwMusteri_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EVRAK NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EVRAK TARİHİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ÜRÜN KODU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ÜRÜN ADI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SATIŞ MİKTARI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "MÜŞTERİ KODU:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "MÜŞTERİ ADI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "SATIŞ TUTARI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "SATIŞ FİYATI:";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(366, 210);
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(100, 20);
            this.txtEvrakNo.TabIndex = 11;
            // 
            // txtEvrakTarihi
            // 
            this.txtEvrakTarihi.Location = new System.Drawing.Point(366, 242);
            this.txtEvrakTarihi.Name = "txtEvrakTarihi";
            this.txtEvrakTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtEvrakTarihi.TabIndex = 12;
            // 
            // txtMKodu
            // 
            this.txtMKodu.Location = new System.Drawing.Point(366, 274);
            this.txtMKodu.Name = "txtMKodu";
            this.txtMKodu.Size = new System.Drawing.Size(100, 20);
            this.txtMKodu.TabIndex = 13;
            // 
            // txtMAdi
            // 
            this.txtMAdi.Location = new System.Drawing.Point(366, 305);
            this.txtMAdi.Name = "txtMAdi";
            this.txtMAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMAdi.TabIndex = 14;
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Location = new System.Drawing.Point(366, 336);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.Size = new System.Drawing.Size(100, 20);
            this.txtSatisTutar.TabIndex = 15;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(366, 374);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(100, 20);
            this.txtUrunKodu.TabIndex = 16;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(366, 412);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 17;
            // 
            // txtSatisMiktari
            // 
            this.txtSatisMiktari.Location = new System.Drawing.Point(366, 447);
            this.txtSatisMiktari.Name = "txtSatisMiktari";
            this.txtSatisMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtSatisMiktari.TabIndex = 18;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(366, 473);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyati.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "RAPORLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwSatis
            // 
            this.dgwSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSatis.Location = new System.Drawing.Point(604, 41);
            this.dgwSatis.Name = "dgwSatis";
            this.dgwSatis.Size = new System.Drawing.Size(240, 150);
            this.dgwSatis.TabIndex = 21;
            this.dgwSatis.SelectionChanged += new System.EventHandler(this.dgvSatis_SelectionChanged);
            // 
            // dgwSatisDetay
            // 
            this.dgwSatisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSatisDetay.Location = new System.Drawing.Point(904, 41);
            this.dgwSatisDetay.Name = "dgwSatisDetay";
            this.dgwSatisDetay.Size = new System.Drawing.Size(240, 150);
            this.dgwSatisDetay.TabIndex = 22;
            this.dgwSatisDetay.SelectionChanged += new System.EventHandler(this.dgwSatisDetay_SelectionChanged);
            // 
            // pdYaz
            // 
            this.pdYaz.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYaz_PrintPage);
            // 
            // ppdDialog
            // 
            this.ppdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDialog.Document = this.pdYaz;
            this.ppdDialog.Enabled = true;
            this.ppdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDialog.Icon")));
            this.ppdDialog.Name = "ppdDialog";
            this.ppdDialog.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "ÜRÜN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "MÜŞTERİ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(700, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "SATIŞ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1001, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "SATIŞ DETAY";
            // 
            // rapor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 662);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgwSatisDetay);
            this.Controls.Add(this.dgwSatis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtSatisMiktari);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.txtSatisTutar);
            this.Controls.Add(this.txtMAdi);
            this.Controls.Add(this.txtMKodu);
            this.Controls.Add(this.txtEvrakTarihi);
            this.Controls.Add(this.txtEvrakNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwMusteri);
            this.Controls.Add(this.dgwUrun);
            this.Name = "rapor_form";
            this.Text = "rapor_forrm";
            this.Load += new System.EventHandler(this.rapor_forrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatisDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrun;
        private System.Windows.Forms.DataGridView dgwMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.TextBox txtEvrakTarihi;
        private System.Windows.Forms.TextBox txtMKodu;
        private System.Windows.Forms.TextBox txtMAdi;
        private System.Windows.Forms.TextBox txtSatisTutar;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtSatisMiktari;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgwSatis;
        private System.Windows.Forms.DataGridView dgwSatisDetay;
        private System.Drawing.Printing.PrintDocument pdYaz;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}