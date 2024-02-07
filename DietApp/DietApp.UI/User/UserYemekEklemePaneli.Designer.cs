namespace DietApp.UI
{
    partial class UserYemekEklemePaneli
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
            grpOgunAdi = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            cmbYemekGirisi = new ComboBox();
            txtMiktar = new TextBox();
            cmbKategori = new ComboBox();
            label3 = new Label();
            btnEkle = new Button();
            grpYemekDetay = new GroupBox();
            lblProtein = new Label();
            lblYag = new Label();
            lblKarbonhidrat = new Label();
            lblKalori = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            pbGorsel = new PictureBox();
            grpOgunAdi.SuspendLayout();
            grpYemekDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).BeginInit();
            SuspendLayout();
            // 
            // grpOgunAdi
            // 
            grpOgunAdi.Controls.Add(label4);
            grpOgunAdi.Controls.Add(label2);
            grpOgunAdi.Controls.Add(cmbYemekGirisi);
            grpOgunAdi.Controls.Add(txtMiktar);
            grpOgunAdi.Controls.Add(cmbKategori);
            grpOgunAdi.Controls.Add(label3);
            grpOgunAdi.Location = new Point(62, 2);
            grpOgunAdi.Margin = new Padding(2);
            grpOgunAdi.Name = "grpOgunAdi";
            grpOgunAdi.Padding = new Padding(2);
            grpOgunAdi.Size = new Size(334, 207);
            grpOgunAdi.TabIndex = 30;
            grpOgunAdi.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 44);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 21;
            label4.Text = "Kategori Seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 16;
            label2.Text = "Yemek Girişi Yapınız:";
            // 
            // cmbYemekGirisi
            // 
            cmbYemekGirisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemekGirisi.FormattingEnabled = true;
            cmbYemekGirisi.Location = new Point(187, 99);
            cmbYemekGirisi.Margin = new Padding(2);
            cmbYemekGirisi.Name = "cmbYemekGirisi";
            cmbYemekGirisi.Size = new Size(121, 28);
            cmbYemekGirisi.TabIndex = 17;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(187, 152);
            txtMiktar.Margin = new Padding(2);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(121, 27);
            txtMiktar.TabIndex = 18;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(187, 44);
            cmbKategori.Margin = new Padding(2);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 28);
            cmbKategori.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 19;
            label3.Text = "Yemek Miktarını Giriniz:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(436, 234);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(128, 64);
            btnEkle.TabIndex = 29;
            btnEkle.Text = "ÖĞÜNE YEMEK EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // grpYemekDetay
            // 
            grpYemekDetay.Controls.Add(lblProtein);
            grpYemekDetay.Controls.Add(lblYag);
            grpYemekDetay.Controls.Add(lblKarbonhidrat);
            grpYemekDetay.Controls.Add(lblKalori);
            grpYemekDetay.Controls.Add(label5);
            grpYemekDetay.Controls.Add(label7);
            grpYemekDetay.Controls.Add(label6);
            grpYemekDetay.Controls.Add(label8);
            grpYemekDetay.Location = new Point(62, 245);
            grpYemekDetay.Margin = new Padding(2);
            grpYemekDetay.Name = "grpYemekDetay";
            grpYemekDetay.Padding = new Padding(2);
            grpYemekDetay.Size = new Size(318, 248);
            grpYemekDetay.TabIndex = 28;
            grpYemekDetay.TabStop = false;
            grpYemekDetay.Text = "Kalori Detay Paneli";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(182, 218);
            lblProtein.Margin = new Padding(2, 0, 2, 0);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(0, 20);
            lblProtein.TabIndex = 20;
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Location = new Point(182, 164);
            lblYag.Margin = new Padding(2, 0, 2, 0);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(0, 20);
            lblYag.TabIndex = 19;
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Location = new Point(182, 102);
            lblKarbonhidrat.Margin = new Padding(2, 0, 2, 0);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(0, 20);
            lblKarbonhidrat.TabIndex = 18;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(182, 40);
            lblKalori.Margin = new Padding(2, 0, 2, 0);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(0, 20);
            lblKalori.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 218);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 16;
            label5.Text = "Protein Miktarı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 102);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 14;
            label7.Text = "Karbonhidrat Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 164);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 15;
            label6.Text = "Yağ Miktarı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 40);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 13;
            label8.Text = "Kalori Değeri:";
            // 
            // pbGorsel
            // 
            pbGorsel.Location = new Point(454, 22);
            pbGorsel.Margin = new Padding(2);
            pbGorsel.Name = "pbGorsel";
            pbGorsel.Size = new Size(125, 138);
            pbGorsel.TabIndex = 27;
            pbGorsel.TabStop = false;
            // 
            // UserYemekEklemePaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 515);
            Controls.Add(grpOgunAdi);
            Controls.Add(btnEkle);
            Controls.Add(grpYemekDetay);
            Controls.Add(pbGorsel);
            Margin = new Padding(2);
            Name = "UserYemekEklemePaneli";
            Text = "UserYemekEklemePaneli";
            grpOgunAdi.ResumeLayout(false);
            grpOgunAdi.PerformLayout();
            grpYemekDetay.ResumeLayout(false);
            grpYemekDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgunAdi;
        private Label label4;
        private Label label2;
        private ComboBox cmbYemekGirisi;
        private TextBox txtMiktar;
        private ComboBox cmbKategori;
        private Label label3;
        private Button btnEkle;
        private GroupBox grpYemekDetay;
        private Label lblProtein;
        private Label lblYag;
        private Label lblKarbonhidrat;
        private Label lblKalori;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private PictureBox pbGorsel;
    }
}