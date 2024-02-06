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
            ((System.ComponentModel.ISupportInitialize)pbGorsel).BeginInit();
            SuspendLayout();
            // 
            // txtKaloriDegeri
            // 
            txtKaloriDegeri.Location = new Point(174, 121);
            txtKaloriDegeri.Margin = new Padding(2, 2, 2, 2);
            txtKaloriDegeri.Name = "txtKaloriDegeri";
            txtKaloriDegeri.Size = new Size(129, 23);
            txtKaloriDegeri.TabIndex = 0;
            // 
            // txtKarbonhidrat
            // 
            txtKarbonhidrat.Location = new Point(174, 165);
            txtKarbonhidrat.Margin = new Padding(2, 2, 2, 2);
            txtKarbonhidrat.Name = "txtKarbonhidrat";
            txtKarbonhidrat.Size = new Size(129, 23);
            txtKarbonhidrat.TabIndex = 1;
            // 
            // txtYag
            // 
            txtYag.Location = new Point(174, 209);
            txtYag.Margin = new Padding(2, 2, 2, 2);
            txtYag.Name = "txtYag";
            txtYag.Size = new Size(129, 23);
            txtYag.TabIndex = 2;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(174, 76);
            txtYemekAdi.Margin = new Padding(2, 2, 2, 2);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(129, 23);
            txtYemekAdi.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Yemek Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Kalori Değeri:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 6;
            label3.Text = "Karbonhidrat Miktarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 214);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Yağ Miktarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 256);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Protein Miktarı:";
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(177, 254);
            txtProtein.Margin = new Padding(2, 2, 2, 2);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(129, 23);
            txtProtein.TabIndex = 8;
            // 
            // pbGorsel
            // 
            pbGorsel.Location = new Point(360, 103);
            pbGorsel.Margin = new Padding(2, 2, 2, 2);
            pbGorsel.Name = "pbGorsel";
            pbGorsel.Size = new Size(134, 145);
            pbGorsel.TabIndex = 10;
            pbGorsel.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 67);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "Yemek Görseli:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(360, 282);
            btnKaydet.Margin = new Padding(2, 2, 2, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 51);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(174, 298);
            cmbKategori.Margin = new Padding(2, 2, 2, 2);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(129, 23);
            cmbKategori.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 301);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 14;
            label7.Text = "Kategori Seçiniz:";
            // 
            // ManelYemekEklemePaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 397);
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
            Margin = new Padding(2, 2, 2, 2);
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
    }
}