namespace DietApp.UI
{
    partial class ManelYemekEklemePaneli
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
            txtKaloriDegeri = new TextBox();
            txtKarbonhidrat = new TextBox();
            txtYag = new TextBox();
            txtYemekAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProtein = new TextBox();
            pbGorsel = new PictureBox();
            label6 = new Label();
            btnKaydet = new Button();
            cmbKategori = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtPorsiyon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).BeginInit();
            SuspendLayout();
            // 
            // txtKaloriDegeri
            // 
            txtKaloriDegeri.Location = new Point(249, 201);
            txtKaloriDegeri.Name = "txtKaloriDegeri";
            txtKaloriDegeri.Size = new Size(182, 31);
            txtKaloriDegeri.TabIndex = 0;
            // 
            // txtKarbonhidrat
            // 
            txtKarbonhidrat.Location = new Point(249, 275);
            txtKarbonhidrat.Name = "txtKarbonhidrat";
            txtKarbonhidrat.Size = new Size(182, 31);
            txtKarbonhidrat.TabIndex = 1;
            // 
            // txtYag
            // 
            txtYag.Location = new Point(249, 349);
            txtYag.Name = "txtYag";
            txtYag.Size = new Size(182, 31);
            txtYag.TabIndex = 2;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(249, 127);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(182, 31);
            txtYemekAdi.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 127);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 4;
            label1.Text = "Yemek Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 204);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 5;
            label2.Text = "Kalori Değeri:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 281);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 6;
            label3.Text = "Karbonhidrat Miktarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 357);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 7;
            label4.Text = "Yağ Miktarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 427);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 9;
            label5.Text = "Protein Miktarı:";
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(253, 423);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(182, 31);
            txtProtein.TabIndex = 8;
            // 
            // pbGorsel
            // 
            pbGorsel.Location = new Point(514, 171);
            pbGorsel.Name = "pbGorsel";
            pbGorsel.Size = new Size(191, 242);
            pbGorsel.TabIndex = 10;
            pbGorsel.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 111);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 11;
            label6.Text = "Yemek Görseli:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(514, 470);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(160, 85);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(249, 497);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(182, 33);
            cmbKategori.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 502);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 14;
            label7.Text = "Kategori Seçiniz:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 559);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 16;
            label8.Text = "Porsiyon (gr):";
            // 
            // txtPorsiyon
            // 
            txtPorsiyon.Location = new Point(249, 559);
            txtPorsiyon.Name = "txtPorsiyon";
            txtPorsiyon.Size = new Size(182, 31);
            txtPorsiyon.TabIndex = 17;
            // 
            // ManelYemekEklemePaneli
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 661);
            Controls.Add(txtPorsiyon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbKategori);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(pbGorsel);
            Controls.Add(label5);
            Controls.Add(txtProtein);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYemekAdi);
            Controls.Add(txtYag);
            Controls.Add(txtKarbonhidrat);
            Controls.Add(txtKaloriDegeri);
            Name = "ManelYemekEklemePaneli";
            Text = "ManuelYemekEklemePaneli";
            ((System.ComponentModel.ISupportInitialize)pbGorsel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKaloriDegeri;
        private TextBox txtKarbonhidrat;
        private TextBox txtYag;
        private TextBox txtYemekAdi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProtein;
        private PictureBox pbGorsel;
        private Label label6;
        private Button btnKaydet;
        private ComboBox cmbKategori;
        private Label label7;
        private Label label8;
        private TextBox txtPorsiyon;
    }
}