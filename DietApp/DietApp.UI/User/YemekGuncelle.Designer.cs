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
            dataGridView1 = new DataGridView();
            grpOgunAdi = new GroupBox();
            grpYemekDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpOgunAdi.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(523, 293);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(160, 80);
            btnGuncelle.TabIndex = 24;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
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
            grpYemekDetay.Location = new Point(41, 271);
            grpYemekDetay.Name = "grpYemekDetay";
            grpYemekDetay.Size = new Size(397, 310);
            grpYemekDetay.TabIndex = 23;
            grpYemekDetay.TabStop = false;
            grpYemekDetay.Text = "Kalori Detay Paneli";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(228, 273);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(0, 25);
            lblProtein.TabIndex = 20;
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Location = new Point(228, 205);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(0, 25);
            lblYag.TabIndex = 19;
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Location = new Point(228, 127);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(0, 25);
            lblKarbonhidrat.TabIndex = 18;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(228, 50);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(0, 25);
            lblKalori.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 273);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 16;
            label5.Text = "Protein Miktarı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 127);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 14;
            label7.Text = "Karbonhidrat Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 205);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 15;
            label6.Text = "Yağ Miktarı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 50);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 13;
            label8.Text = "Kalori Değeri:";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(234, 55);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(150, 33);
            cmbKategori.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 55);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 21;
            label4.Text = "Kategori Seçiniz:";
            // 
            // pbGorsel
            // 
            pbGorsel.Location = new Point(512, 54);
            pbGorsel.Name = "pbGorsel";
            pbGorsel.Size = new Size(156, 173);
            pbGorsel.TabIndex = 20;
            pbGorsel.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 190);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 19;
            label3.Text = "Yemek Miktarını Giriniz:";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(234, 190);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(150, 31);
            txtMiktar.TabIndex = 18;
            // 
            // cmbYemekGirisi
            // 
            cmbYemekGirisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemekGirisi.FormattingEnabled = true;
            cmbYemekGirisi.Location = new Point(234, 124);
            cmbYemekGirisi.Name = "cmbYemekGirisi";
            cmbYemekGirisi.Size = new Size(150, 33);
            cmbYemekGirisi.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 124);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 16;
            label2.Text = "Yemek Girişi Yapınız:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 605);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 110);
            dataGridView1.TabIndex = 25;
            // 
            // grpOgunAdi
            // 
            grpOgunAdi.Controls.Add(label4);
            grpOgunAdi.Controls.Add(label2);
            grpOgunAdi.Controls.Add(cmbYemekGirisi);
            grpOgunAdi.Controls.Add(txtMiktar);
            grpOgunAdi.Controls.Add(cmbKategori);
            grpOgunAdi.Controls.Add(label3);
            grpOgunAdi.Location = new Point(32, 12);
            grpOgunAdi.Name = "grpOgunAdi";
            grpOgunAdi.Size = new Size(418, 234);
            grpOgunAdi.TabIndex = 26;
            grpOgunAdi.TabStop = false;
            // 
            // YemekGuncelle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 715);
            Controls.Add(grpOgunAdi);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuncelle);
            Controls.Add(grpYemekDetay);
            Controls.Add(pbGorsel);
            Name = "YemekGuncelle";
            Text = "YemekGuncelle";
            grpYemekDetay.ResumeLayout(false);
            grpYemekDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGorsel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private GroupBox grpOgunAdi;
    }
}