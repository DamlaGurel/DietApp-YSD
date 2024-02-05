namespace DietApp.UI
{
    partial class KiyasRaporlari
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
            label1 = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            label2 = new Label();
            dtpBitisTarihi = new DateTimePicker();
            label6 = new Label();
            cmbOgun = new ComboBox();
            grpOgunKarsilastirma = new GroupBox();
            label4 = new Label();
            lblOgunKullaniciOrtalama = new Label();
            lblOgunOrtalama = new Label();
            label9 = new Label();
            label3 = new Label();
            cmbKategori = new ComboBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            lblKategoriKullaniciOrtalama = new Label();
            lblKategoriOrtalama = new Label();
            label13 = new Label();
            grpOgunKarsilastirma.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 5;
            label1.Text = "Başlangıç Tarihini Seçiniz:";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(237, 51);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(300, 31);
            dtpBaslangicTarihi.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(614, 51);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 7;
            label2.Text = "Bitiş Tarihini Seçiniz:";
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(797, 48);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(300, 31);
            dtpBitisTarihi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 88);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 18;
            label6.Text = "Öğün Çeşidini Seçiniz:";
            // 
            // cmbOgun
            // 
            cmbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(265, 85);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(150, 33);
            cmbOgun.TabIndex = 17;
            // 
            // grpOgunKarsilastirma
            // 
            grpOgunKarsilastirma.Controls.Add(label4);
            grpOgunKarsilastirma.Controls.Add(lblOgunKullaniciOrtalama);
            grpOgunKarsilastirma.Controls.Add(lblOgunOrtalama);
            grpOgunKarsilastirma.Controls.Add(label6);
            grpOgunKarsilastirma.Controls.Add(label9);
            grpOgunKarsilastirma.Controls.Add(cmbOgun);
            grpOgunKarsilastirma.Location = new Point(40, 142);
            grpOgunKarsilastirma.Name = "grpOgunKarsilastirma";
            grpOgunKarsilastirma.Size = new Size(1042, 210);
            grpOgunKarsilastirma.TabIndex = 21;
            grpOgunKarsilastirma.TabStop = false;
            grpOgunKarsilastirma.Text = "Öğün Karşılaştırma Paneli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 130);
            label4.Name = "label4";
            label4.Size = new Size(265, 25);
            label4.TabIndex = 24;
            label4.Text = "Kullanıcı Ortalama Kalori Miktarı:";
            // 
            // lblOgunKullaniciOrtalama
            // 
            lblOgunKullaniciOrtalama.AutoSize = true;
            lblOgunKullaniciOrtalama.Location = new Point(817, 130);
            lblOgunKullaniciOrtalama.Name = "lblOgunKullaniciOrtalama";
            lblOgunKullaniciOrtalama.Size = new Size(0, 25);
            lblOgunKullaniciOrtalama.TabIndex = 23;
            // 
            // lblOgunOrtalama
            // 
            lblOgunOrtalama.AutoSize = true;
            lblOgunOrtalama.Location = new Point(817, 59);
            lblOgunOrtalama.Name = "lblOgunOrtalama";
            lblOgunOrtalama.Size = new Size(0, 25);
            lblOgunOrtalama.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(512, 59);
            label9.Name = "label9";
            label9.Size = new Size(251, 25);
            label9.TabIndex = 21;
            label9.Text = "Ortalama Alınan Kalori Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 93);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 23;
            label3.Text = "Kategori Seçiniz:";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(232, 93);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(150, 33);
            cmbKategori.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblKategoriKullaniciOrtalama);
            groupBox1.Controls.Add(lblKategoriOrtalama);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(40, 388);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1042, 210);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yemek Kategorisi Karşılaştırma Paneli";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 130);
            label7.Name = "label7";
            label7.Size = new Size(265, 25);
            label7.TabIndex = 24;
            label7.Text = "Kullanıcı Ortalama Kalori Miktarı:";
            // 
            // lblKategoriKullaniciOrtalama
            // 
            lblKategoriKullaniciOrtalama.AutoSize = true;
            lblKategoriKullaniciOrtalama.Location = new Point(817, 130);
            lblKategoriKullaniciOrtalama.Name = "lblKategoriKullaniciOrtalama";
            lblKategoriKullaniciOrtalama.Size = new Size(0, 25);
            lblKategoriKullaniciOrtalama.TabIndex = 23;
            // 
            // lblKategoriOrtalama
            // 
            lblKategoriOrtalama.AutoSize = true;
            lblKategoriOrtalama.Location = new Point(817, 59);
            lblKategoriOrtalama.Name = "lblKategoriOrtalama";
            lblKategoriOrtalama.Size = new Size(0, 25);
            lblKategoriOrtalama.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(512, 59);
            label13.Name = "label13";
            label13.Size = new Size(251, 25);
            label13.TabIndex = 21;
            label13.Text = "Ortalama Alınan Kalori Miktarı:";
            // 
            // KiyasRaporlari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 644);
            Controls.Add(groupBox1);
            Controls.Add(grpOgunKarsilastirma);
            Controls.Add(label2);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(label1);
            Controls.Add(dtpBaslangicTarihi);
            Name = "KiyasRaporlari";
            Text = "KiyasRaporlari";
            grpOgunKarsilastirma.ResumeLayout(false);
            grpOgunKarsilastirma.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBaslangicTarihi;
        private Label label2;
        private DateTimePicker dtpBitisTarihi;
        private Label label6;
        private ComboBox cmbOgun;
        private GroupBox grpOgunKarsilastirma;
        private Label label4;
        private Label lblOgunKullaniciOrtalama;
        private Label lblOgunOrtalama;
        private Label label9;
        private Label label3;
        private ComboBox cmbKategori;
        private GroupBox groupBox1;
        private Label label7;
        private Label lblKategoriKullaniciOrtalama;
        private Label lblKategoriOrtalama;
        private Label label13;
    }
}