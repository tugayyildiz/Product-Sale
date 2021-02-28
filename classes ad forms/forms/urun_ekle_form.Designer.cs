
namespace eticaret
{
    partial class urun_ekle_form
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
            this.lblKod = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblAdres1 = new System.Windows.Forms.Label();
            this.lblAdres2 = new System.Windows.Forms.Label();
            this.lblAdres3 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKdvOrani = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrun
            // 
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Location = new System.Drawing.Point(110, 3);
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.Size = new System.Drawing.Size(412, 98);
            this.dgwUrun.TabIndex = 0;
          
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(40, 140);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(73, 13);
            this.lblKod.TabIndex = 1;
            this.lblKod.Text = "ÜRÜN KODU";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(50, 172);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(63, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "ÜRÜN ADI:";
            // 
            // lblAdres1
            // 
            this.lblAdres1.AutoSize = true;
            this.lblAdres1.Location = new System.Drawing.Point(38, 202);
            this.lblAdres1.Name = "lblAdres1";
            this.lblAdres1.Size = new System.Drawing.Size(75, 13);
            this.lblAdres1.TabIndex = 3;
            this.lblAdres1.Text = "ÜRÜN BİRİM:";
            // 
            // lblAdres2
            // 
            this.lblAdres2.AutoSize = true;
            this.lblAdres2.Location = new System.Drawing.Point(35, 234);
            this.lblAdres2.Name = "lblAdres2";
            this.lblAdres2.Size = new System.Drawing.Size(78, 13);
            this.lblAdres2.TabIndex = 4;
            this.lblAdres2.Text = "ÜRÜN FİYATI:";
            // 
            // lblAdres3
            // 
            this.lblAdres3.AutoSize = true;
            this.lblAdres3.Location = new System.Drawing.Point(9, 263);
            this.lblAdres3.Name = "lblAdres3";
            this.lblAdres3.Size = new System.Drawing.Size(104, 13);
            this.lblAdres3.TabIndex = 5;
            this.lblAdres3.Text = "ÜRÜN KDV ORANI:";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(133, 137);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(144, 20);
            this.txtKod.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(133, 165);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(144, 20);
            this.txtAd.TabIndex = 9;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(133, 199);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(144, 20);
            this.txtBirim.TabIndex = 10;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(133, 231);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(144, 20);
            this.txtFiyat.TabIndex = 11;
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(133, 260);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(144, 20);
            this.txtKdvOrani.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(169, 312);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKdvOrani);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblAdres3);
            this.Controls.Add(this.lblAdres2);
            this.Controls.Add(this.lblAdres1);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.dgwUrun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrun;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblAdres1;
        private System.Windows.Forms.Label lblAdres2;
        private System.Windows.Forms.Label lblAdres3;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKdvOrani;
        private System.Windows.Forms.Button btnKaydet;
    }
}

