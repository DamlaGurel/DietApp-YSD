namespace DietApp.UI
{
    partial class UserBilgileriAlmaEkrani
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
            label2 = new Label();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            label3 = new Label();
            lblKullaniciKisisel = new Label();
            btnKullaniciKisiselHesapla = new Button();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            label5 = new Label();
            txtHedefKilo = new TextBox();
            label4 = new Label();
            lblGunlukKaloriIhtiyaci = new Label();
            grpVucutIndeksBilgi = new GroupBox();
            lblIdealKilo = new Label();
            label6 = new Label();
            btnAnaEkranaGec = new Button();
            dtpBaslangicTarihi = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            dtpBitisTarihi = new DateTimePicker();
            txtIsim = new TextBox();
            label9 = new Label();
            txtSoyisim = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtYas = new TextBox();
            grpVucutIndeksBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 92);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "Boy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 147);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "Kilo:";
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(130, 198);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(81, 29);
            rbKadin.TabIndex = 2;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(313, 198);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(79, 29);
            rbErkek.TabIndex = 3;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 60);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 4;
            label3.Text = "Vücut İndeksiniz:";
            // 
            // lblKullaniciKisisel
            // 
            lblKullaniciKisisel.AutoSize = true;
            lblKullaniciKisisel.Location = new Point(189, 60);
            lblKullaniciKisisel.Name = "lblKullaniciKisisel";
            lblKullaniciKisisel.Size = new Size(17, 25);
            lblKullaniciKisisel.TabIndex = 5;
            lblKullaniciKisisel.Text = " ";
            // 
            // btnKullaniciKisiselHesapla
            // 
            btnKullaniciKisiselHesapla.Location = new Point(94, 221);
            btnKullaniciKisiselHesapla.Name = "btnKullaniciKisiselHesapla";
            btnKullaniciKisiselHesapla.Size = new Size(211, 74);
            btnKullaniciKisiselHesapla.TabIndex = 6;
            btnKullaniciKisiselHesapla.Text = "VÜCUT İNDEKSİ HESAPLA";
            btnKullaniciKisiselHesapla.UseVisualStyleBackColor = true;
            btnKullaniciKisiselHesapla.Click += btnKullaniciKisiselHesapla_Click;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(242, 86);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(150, 31);
            txtBoy.TabIndex = 7;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(242, 141);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(150, 31);
            txtKilo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 198);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 9;
            label5.Text = "Hedef Kilonuz:";
            // 
            // txtHedefKilo
            // 
            txtHedefKilo.Location = new Point(747, 198);
            txtHedefKilo.Name = "txtHedefKilo";
            txtHedefKilo.Size = new Size(150, 31);
            txtHedefKilo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 159);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 11;
            label4.Text = "Günlük Kalori İhtiyacınız:";
            // 
            // lblGunlukKaloriIhtiyaci
            // 
            lblGunlukKaloriIhtiyaci.AutoSize = true;
            lblGunlukKaloriIhtiyaci.Location = new Point(265, 159);
            lblGunlukKaloriIhtiyaci.Name = "lblGunlukKaloriIhtiyaci";
            lblGunlukKaloriIhtiyaci.Size = new Size(0, 25);
            lblGunlukKaloriIhtiyaci.TabIndex = 12;
            // 
            // grpVucutIndeksBilgi
            // 
            grpVucutIndeksBilgi.Controls.Add(lblGunlukKaloriIhtiyaci);
            grpVucutIndeksBilgi.Controls.Add(lblIdealKilo);
            grpVucutIndeksBilgi.Controls.Add(label4);
            grpVucutIndeksBilgi.Controls.Add(label6);
            grpVucutIndeksBilgi.Controls.Add(lblKullaniciKisisel);
            grpVucutIndeksBilgi.Controls.Add(label3);
            grpVucutIndeksBilgi.Controls.Add(btnKullaniciKisiselHesapla);
            grpVucutIndeksBilgi.Location = new Point(53, 265);
            grpVucutIndeksBilgi.Name = "grpVucutIndeksBilgi";
            grpVucutIndeksBilgi.Size = new Size(412, 325);
            grpVucutIndeksBilgi.TabIndex = 14;
            grpVucutIndeksBilgi.TabStop = false;
            grpVucutIndeksBilgi.Text = "Bilgi Paneli";
            // 
            // lblIdealKilo
            // 
            lblIdealKilo.AutoSize = true;
            lblIdealKilo.Location = new Point(211, 108);
            lblIdealKilo.Name = "lblIdealKilo";
            lblIdealKilo.Size = new Size(0, 25);
            lblIdealKilo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 108);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 7;
            label6.Text = "İdeal Kilo Aralığınız:";
            // 
            // btnAnaEkranaGec
            // 
            btnAnaEkranaGec.Location = new Point(766, 523);
            btnAnaEkranaGec.Name = "btnAnaEkranaGec";
            btnAnaEkranaGec.Size = new Size(210, 103);
            btnAnaEkranaGec.TabIndex = 15;
            btnAnaEkranaGec.Text = "Kalorileri Hesaplamaya Hazırsın! BAŞLA";
            btnAnaEkranaGec.UseVisualStyleBackColor = true;
            btnAnaEkranaGec.Click += btnAnaEkranaGec_Click;
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(676, 273);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(300, 31);
            dtpBaslangicTarihi.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(524, 278);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 17;
            label7.Text = "Başlangıç Tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(565, 320);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 19;
            label8.Text = "Bitiş Tarihi:";
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(676, 320);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(300, 31);
            dtpBitisTarihi.TabIndex = 18;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(147, 12);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(150, 31);
            txtIsim.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 18);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 20;
            label9.Text = "İsim:";
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(524, 10);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(150, 31);
            txtSoyisim.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 10);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 22;
            label10.Text = "Soyisim:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(747, 18);
            label11.Name = "label11";
            label11.Size = new Size(41, 25);
            label11.TabIndex = 24;
            label11.Text = "Yaş:";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(817, 18);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(150, 31);
            txtYas.TabIndex = 25;
            // 
            // UserBilgileriAlmaEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 650);
            Controls.Add(txtYas);
            Controls.Add(label11);
            Controls.Add(txtSoyisim);
            Controls.Add(label10);
            Controls.Add(txtIsim);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(label7);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(btnAnaEkranaGec);
            Controls.Add(grpVucutIndeksBilgi);
            Controls.Add(txtHedefKilo);
            Controls.Add(label5);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(rbErkek);
            Controls.Add(rbKadin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserBilgileriAlmaEkrani";
            Text = "UserBilgileriAlmaEkrani";
            grpVucutIndeksBilgi.ResumeLayout(false);
            grpVucutIndeksBilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private Label label3;
        private Label lblKullaniciKisisel;
        private Button btnKullaniciKisiselHesapla;
        private TextBox txtBoy;
        private TextBox txtKilo;
        private Label label5;
        private TextBox txtHedefKilo;
        private Label label4;
        private Label lblGunlukKaloriIhtiyaci;
        private GroupBox grpVucutIndeksBilgi;
        private Button btnAnaEkranaGec;
        private Label lblIdealKilo;
        private Label label6;
        private DateTimePicker dtpBaslangicTarihi;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpBitisTarihi;
        private TextBox txtIsim;
        private Label label9;
        private TextBox txtSoyisim;
        private Label label10;
        private Label label11;
        private TextBox txtYas;
    }
}