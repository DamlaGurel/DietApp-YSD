namespace DietApp.UI
{
    partial class YemekGuncelle
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
            btnGuncelle = new Button();
            grpYemekDetay = new GroupBox();
            lblProtein = new Label();
            lblYag = new Label();
            lblKarbonhidrat = new Label();
            lblKalori = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            cmbKategori = new ComboBox();
            label4 = new Label();
            pbGorsel = new PictureBox();
            label3 = new Label();
            txtMiktar = new TextBox();
            cmbYemekGirisi = new ComboBox();
            label2 = new Label();
            grpOgunAdi = new GroupBox();
            grpYemekDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).BeginInit();
            grpOgunAdi.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(366, 176);
            btnGuncelle.Margin = new Padding(2, 2, 2, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(112, 48);
            btnGuncelle.TabIndex = 24;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
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
            grpYemekDetay.Location = new Point(29, 163);
            grpYemekDetay.Margin = new Padding(2, 2, 2, 2);
            grpYemekDetay.Name = "grpYemekDetay";
            grpYemekDetay.Padding = new Padding(2, 2, 2, 2);
            grpYemekDetay.Size = new Size(278, 186);
            grpYemekDetay.TabIndex = 23;
            grpYemekDetay.TabStop = false;
            grpYemekDetay.Text = "Kalori Detay Paneli";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(160, 164);
            lblProtein.Margin = new Padding(2, 0, 2, 0);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(0, 15);
            lblProtein.TabIndex = 20;
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Location = new Point(160, 123);
            lblYag.Margin = new Padding(2, 0, 2, 0);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(0, 15);
            lblYag.TabIndex = 19;
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Location = new Point(160, 76);
            lblKarbonhidrat.Margin = new Padding(2, 0, 2, 0);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(0, 15);
            lblKarbonhidrat.TabIndex = 18;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(160, 30);
            lblKalori.Margin = new Padding(2, 0, 2, 0);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(0, 15);
            lblKalori.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 164);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 16;
            label5.Text = "Protein Miktarı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 76);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 14;
            label7.Text = "Karbonhidrat Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 123);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 15;
            label6.Text = "Yağ Miktarı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 30);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 13;
            label8.Text = "Kalori Değeri:";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(164, 33);
            cmbKategori.Margin = new Padding(2, 2, 2, 2);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(106, 23);
            cmbKategori.TabIndex = 22;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 33);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 21;
            label4.Text = "Kategori Seçiniz:";
            // 
            // pbGorsel
            // 
            pbGorsel.Location = new Point(358, 32);
            pbGorsel.Margin = new Padding(2, 2, 2, 2);
            pbGorsel.Name = "pbGorsel";
            pbGorsel.Size = new Size(109, 104);
            pbGorsel.TabIndex = 20;
            pbGorsel.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 19;
            label3.Text = "Yemek Miktarını Giriniz:";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(164, 114);
            txtMiktar.Margin = new Padding(2, 2, 2, 2);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(106, 23);
            txtMiktar.TabIndex = 18;
            // 
            // cmbYemekGirisi
            // 
            cmbYemekGirisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemekGirisi.FormattingEnabled = true;
            cmbYemekGirisi.Location = new Point(164, 74);
            cmbYemekGirisi.Margin = new Padding(2, 2, 2, 2);
            cmbYemekGirisi.Name = "cmbYemekGirisi";
            cmbYemekGirisi.Size = new Size(106, 23);
            cmbYemekGirisi.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 16;
            label2.Text = "Yemek Girişi Yapınız:";
            // 
            // grpOgunAdi
            // 
            grpOgunAdi.Controls.Add(label4);
            grpOgunAdi.Controls.Add(label2);
            grpOgunAdi.Controls.Add(cmbYemekGirisi);
            grpOgunAdi.Controls.Add(txtMiktar);
            grpOgunAdi.Controls.Add(cmbKategori);
            grpOgunAdi.Controls.Add(label3);
            grpOgunAdi.Location = new Point(22, 7);
            grpOgunAdi.Margin = new Padding(2, 2, 2, 2);
            grpOgunAdi.Name = "grpOgunAdi";
            grpOgunAdi.Padding = new Padding(2, 2, 2, 2);
            grpOgunAdi.Size = new Size(293, 140);
            grpOgunAdi.TabIndex = 26;
            grpOgunAdi.TabStop = false;
            // 
            // YemekGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 429);
            Controls.Add(grpOgunAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(grpYemekDetay);
            Controls.Add(pbGorsel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "YemekGuncelle";
            Text = "YemekGuncelle";
            Load += YemekGuncelle_Load;
            grpYemekDetay.ResumeLayout(false);
            grpYemekDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).EndInit();
            grpOgunAdi.ResumeLayout(false);
            grpOgunAdi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuncelle;
        private GroupBox grpYemekDetay;
        private Label lblProtein;
        private Label lblYag;
        private Label lblKarbonhidrat;
        private Label lblKalori;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private ComboBox cmbKategori;
        private Label label4;
        private PictureBox pbGorsel;
        private Label label3;
        private TextBox txtMiktar;
        private ComboBox cmbYemekGirisi;
        private Label label2;
        private GroupBox grpOgunAdi;
    }
}