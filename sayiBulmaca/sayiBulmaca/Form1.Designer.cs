namespace sayiBulmaca
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciTahmini = new System.Windows.Forms.TextBox();
            this.txtBilgisayarTahmini = new System.Windows.Forms.TextBox();
            this.txtKullaniciArti = new System.Windows.Forms.TextBox();
            this.txtBilgisayarArti = new System.Windows.Forms.TextBox();
            this.txtKullaniciEksi = new System.Windows.Forms.TextBox();
            this.txtBilgisayarEksi = new System.Windows.Forms.TextBox();
            this.btnKullaniciTahmin = new System.Windows.Forms.Button();
            this.btnBilgisayaraTahminYaptir = new System.Windows.Forms.Button();
            this.btnOyunuBaslatYenidenBaslat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBilgisayarınTahminEttigiSayiyiSifirla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Tahmini:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilgisayar Tahmini:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // txtKullaniciTahmini
            // 
            this.txtKullaniciTahmini.Location = new System.Drawing.Point(108, 98);
            this.txtKullaniciTahmini.Name = "txtKullaniciTahmini";
            this.txtKullaniciTahmini.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciTahmini.TabIndex = 4;
            this.txtKullaniciTahmini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciTahmini_KeyPress);
            // 
            // txtBilgisayarTahmini
            // 
            this.txtBilgisayarTahmini.Location = new System.Drawing.Point(108, 130);
            this.txtBilgisayarTahmini.Name = "txtBilgisayarTahmini";
            this.txtBilgisayarTahmini.Size = new System.Drawing.Size(100, 20);
            this.txtBilgisayarTahmini.TabIndex = 5;
            // 
            // txtKullaniciArti
            // 
            this.txtKullaniciArti.Enabled = false;
            this.txtKullaniciArti.Location = new System.Drawing.Point(214, 98);
            this.txtKullaniciArti.Name = "txtKullaniciArti";
            this.txtKullaniciArti.Size = new System.Drawing.Size(53, 20);
            this.txtKullaniciArti.TabIndex = 6;
            // 
            // txtBilgisayarArti
            // 
            this.txtBilgisayarArti.Location = new System.Drawing.Point(214, 130);
            this.txtBilgisayarArti.Name = "txtBilgisayarArti";
            this.txtBilgisayarArti.Size = new System.Drawing.Size(53, 20);
            this.txtBilgisayarArti.TabIndex = 7;
            this.txtBilgisayarArti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBilgisayarArti_KeyPress);
            // 
            // txtKullaniciEksi
            // 
            this.txtKullaniciEksi.Enabled = false;
            this.txtKullaniciEksi.Location = new System.Drawing.Point(273, 98);
            this.txtKullaniciEksi.Name = "txtKullaniciEksi";
            this.txtKullaniciEksi.Size = new System.Drawing.Size(53, 20);
            this.txtKullaniciEksi.TabIndex = 8;
            // 
            // txtBilgisayarEksi
            // 
            this.txtBilgisayarEksi.Location = new System.Drawing.Point(273, 130);
            this.txtBilgisayarEksi.Name = "txtBilgisayarEksi";
            this.txtBilgisayarEksi.Size = new System.Drawing.Size(53, 20);
            this.txtBilgisayarEksi.TabIndex = 9;
            this.txtBilgisayarEksi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBilgisayarEksi_KeyPress);
            // 
            // btnKullaniciTahmin
            // 
            this.btnKullaniciTahmin.Location = new System.Drawing.Point(345, 98);
            this.btnKullaniciTahmin.Name = "btnKullaniciTahmin";
            this.btnKullaniciTahmin.Size = new System.Drawing.Size(141, 24);
            this.btnKullaniciTahmin.TabIndex = 10;
            this.btnKullaniciTahmin.Text = "Kullanıcı Tahmin Girişi";
            this.btnKullaniciTahmin.UseVisualStyleBackColor = true;
            this.btnKullaniciTahmin.Click += new System.EventHandler(this.btnKullaniciTahmin_Click);
            // 
            // btnBilgisayaraTahminYaptir
            // 
            this.btnBilgisayaraTahminYaptir.Location = new System.Drawing.Point(345, 128);
            this.btnBilgisayaraTahminYaptir.Name = "btnBilgisayaraTahminYaptir";
            this.btnBilgisayaraTahminYaptir.Size = new System.Drawing.Size(141, 24);
            this.btnBilgisayaraTahminYaptir.TabIndex = 11;
            this.btnBilgisayaraTahminYaptir.Text = "Kullanıcı İpucunu Gir";
            this.btnBilgisayaraTahminYaptir.UseVisualStyleBackColor = true;
            this.btnBilgisayaraTahminYaptir.Click += new System.EventHandler(this.btnBilgisayaraTahminYaptir_Click);
            // 
            // btnOyunuBaslatYenidenBaslat
            // 
            this.btnOyunuBaslatYenidenBaslat.Location = new System.Drawing.Point(12, 56);
            this.btnOyunuBaslatYenidenBaslat.Name = "btnOyunuBaslatYenidenBaslat";
            this.btnOyunuBaslatYenidenBaslat.Size = new System.Drawing.Size(141, 24);
            this.btnOyunuBaslatYenidenBaslat.TabIndex = 12;
            this.btnOyunuBaslatYenidenBaslat.Text = "Oyunu Başlat/Yeniden Başlat";
            this.btnOyunuBaslatYenidenBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslatYenidenBaslat.Click += new System.EventHandler(this.btnOyunuBaslatYenidenBaslat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Oyunun Başlaması için Başlat/YenidenBaşlat tuşuna basınız";
            // 
            // btnBilgisayarınTahminEttigiSayiyiSifirla
            // 
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.Location = new System.Drawing.Point(12, 163);
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.Name = "btnBilgisayarınTahminEttigiSayiyiSifirla";
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.Size = new System.Drawing.Size(314, 49);
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.TabIndex = 22;
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.Text = "Bilgisayarın Tahmin Ettiği Sayıyı Sıfırla";
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.UseVisualStyleBackColor = true;
            this.btnBilgisayarınTahminEttigiSayiyiSifirla.Click += new System.EventHandler(this.btnBilgisayarınTahminEttigiSayiyiSifirla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lütfen Tahmin İçin 4 Basamaklı Bir Sayı, + ve - Değerleri İçin 1 Basamaklı Sayı G" +
    "iriniz!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBilgisayarınTahminEttigiSayiyiSifirla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOyunuBaslatYenidenBaslat);
            this.Controls.Add(this.btnBilgisayaraTahminYaptir);
            this.Controls.Add(this.btnKullaniciTahmin);
            this.Controls.Add(this.txtBilgisayarEksi);
            this.Controls.Add(this.txtKullaniciEksi);
            this.Controls.Add(this.txtBilgisayarArti);
            this.Controls.Add(this.txtKullaniciArti);
            this.Controls.Add(this.txtBilgisayarTahmini);
            this.Controls.Add(this.txtKullaniciTahmini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciTahmini;
        private System.Windows.Forms.TextBox txtBilgisayarTahmini;
        private System.Windows.Forms.TextBox txtKullaniciArti;
        private System.Windows.Forms.TextBox txtBilgisayarArti;
        private System.Windows.Forms.TextBox txtKullaniciEksi;
        private System.Windows.Forms.TextBox txtBilgisayarEksi;
        private System.Windows.Forms.Button btnKullaniciTahmin;
        private System.Windows.Forms.Button btnBilgisayaraTahminYaptir;
        private System.Windows.Forms.Button btnOyunuBaslatYenidenBaslat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBilgisayarınTahminEttigiSayiyiSifirla;
        private System.Windows.Forms.Label label5;
    }
}

