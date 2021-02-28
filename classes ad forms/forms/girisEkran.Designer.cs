
namespace eticaret
{
    partial class girisEkran
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
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_satis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_musteri
            // 
            this.btn_musteri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_musteri.Location = new System.Drawing.Point(30, 161);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(140, 76);
            this.btn_musteri.TabIndex = 0;
            this.btn_musteri.Text = "MÜŞTERİ TANIMLA";
            this.btn_musteri.UseVisualStyleBackColor = true;
            this.btn_musteri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_urun
            // 
            this.btn_urun.Location = new System.Drawing.Point(213, 161);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(140, 76);
            this.btn_urun.TabIndex = 1;
            this.btn_urun.Text = "ÜRÜN TANIMLA";
            this.btn_urun.UseVisualStyleBackColor = true;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_satis
            // 
            this.btn_satis.Location = new System.Drawing.Point(413, 161);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(140, 76);
            this.btn_satis.TabIndex = 2;
            this.btn_satis.Text = "SATIŞ";
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "RAPOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // girisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_satis);
            this.Controls.Add(this.btn_urun);
            this.Controls.Add(this.btn_musteri);
            this.Name = "girisEkran";
            this.Text = "girisEkran";
            this.Load += new System.EventHandler(this.girisEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.Button button1;
    }
}