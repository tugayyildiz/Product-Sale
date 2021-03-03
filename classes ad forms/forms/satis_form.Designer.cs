
namespace eticaret
{
    partial class satis_form
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
            this.dgwUrun = new System.Windows.Forms.DataGridView();
            this.dgwMusteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_musteri_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_urunkod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_satis = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AdetSayac = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_kdv_tutari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_evrak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_oran = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdetSayac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrun
            // 
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Location = new System.Drawing.Point(35, 66);
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.Size = new System.Drawing.Size(365, 115);
            this.dgwUrun.TabIndex = 0;
            this.dgwUrun.SelectionChanged += new System.EventHandler(this.dgwUrun_SelectionChanged);
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.Location = new System.Drawing.Point(437, 66);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.Size = new System.Drawing.Size(405, 117);
            this.dgwMusteri.TabIndex = 1;
            this.dgwMusteri.CursorChanged += new System.EventHandler(this.dgwMusteri_CursorChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MÜŞTERİ";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(112, 38);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(215, 20);
            this.txtUrunAra.TabIndex = 4;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(512, 38);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(241, 20);
            this.txtMusteriAra.TabIndex = 5;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "MÜŞTERİ KOD:";
            // 
            // txt_musteri_id
            // 
            this.txt_musteri_id.Location = new System.Drawing.Point(646, 227);
            this.txt_musteri_id.Name = "txt_musteri_id";
            this.txt_musteri_id.Size = new System.Drawing.Size(100, 20);
            this.txt_musteri_id.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "GENEL  TOPLAM:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(484, 575);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(20, 13);
            this.lblTutar.TabIndex = 20;
            this.lblTutar.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ÜRÜN KOD:";
            // 
            // txt_urunkod
            // 
            this.txt_urunkod.Location = new System.Drawing.Point(132, 231);
            this.txt_urunkod.Name = "txt_urunkod";
            this.txt_urunkod.Size = new System.Drawing.Size(121, 20);
            this.txt_urunkod.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "ADET:";
            // 
            // btn_satis
            // 
            this.btn_satis.Location = new System.Drawing.Point(331, 620);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(173, 31);
            this.btn_satis.TabIndex = 27;
            this.btn_satis.Text = "SATIŞI GERÇEKLEŞTİR";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 81);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "AÇIKLAMA:";
            // 
            // AdetSayac
            // 
            this.AdetSayac.Location = new System.Drawing.Point(411, 452);
            this.AdetSayac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AdetSayac.Name = "AdetSayac";
            this.AdetSayac.Size = new System.Drawing.Size(51, 20);
            this.AdetSayac.TabIndex = 36;
            this.AdetSayac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AdetSayac.ValueChanged += new System.EventHandler(this.AdetSayac_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "KDV TUTARI:";
            // 
            // lbl_kdv_tutari
            // 
            this.lbl_kdv_tutari.AutoSize = true;
            this.lbl_kdv_tutari.Location = new System.Drawing.Point(484, 496);
            this.lbl_kdv_tutari.Name = "lbl_kdv_tutari";
            this.lbl_kdv_tutari.Size = new System.Drawing.Size(20, 13);
            this.lbl_kdv_tutari.TabIndex = 38;
            this.lbl_kdv_tutari.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "EVRAK NO:";
            // 
            // txt_evrak
            // 
            this.txt_evrak.Location = new System.Drawing.Point(131, 280);
            this.txt_evrak.Name = "txt_evrak";
            this.txt_evrak.Size = new System.Drawing.Size(122, 20);
            this.txt_evrak.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "KDV ORANI:";
            // 
            // lbl_oran
            // 
            this.lbl_oran.AutoSize = true;
            this.lbl_oran.Location = new System.Drawing.Point(484, 532);
            this.lbl_oran.Name = "lbl_oran";
            this.lbl_oran.Size = new System.Drawing.Size(20, 13);
            this.lbl_oran.TabIndex = 42;
            this.lbl_oran.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "ARA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "ARA:";
            // 
            // satis_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 663);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_oran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_evrak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_kdv_tutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdetSayac);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_satis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_urunkod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_musteri_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwMusteri);
            this.Controls.Add(this.dgwUrun);
            this.Name = "satis_form";
            this.Text = "satis_form";
            this.Load += new System.EventHandler(this.satis_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdetSayac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrun;
        private System.Windows.Forms.DataGridView dgwMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_musteri_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_urunkod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown AdetSayac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_kdv_tutari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_evrak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_oran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}