namespace DietApp.UI
{
    partial class OzetEkrani
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
            dtpTarih = new DateTimePicker();
            label1 = new Label();
            dgv_OgundekiYemekler = new DataGridView();
            btnEkle = new Button();
            btnDegistir = new Button();
            btnKaldir = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblHedefKalori = new Label();
            lblGuncelKalori = new Label();
            label2 = new Label();
            cmbOgun = new ComboBox();
            btnRaporlar = new Button();
            btnSuTakip = new Button();
            pbKaloriTakip = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgv_OgundekiYemekler).BeginInit();
            SuspendLayout();
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(523, 261);
            dtpTarih.Margin = new Padding(2, 3, 2, 3);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(241, 27);
            dtpTarih.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 263);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Tarih Seçiniz:";
            // 
            // dgv_OgundekiYemekler
            // 
            dgv_OgundekiYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_OgundekiYemekler.Location = new Point(2, 297);
            dgv_OgundekiYemekler.Margin = new Padding(1);
            dgv_OgundekiYemekler.Name = "dgv_OgundekiYemekler";
            dgv_OgundekiYemekler.RowHeadersWidth = 62;
            dgv_OgundekiYemekler.RowTemplate.Height = 33;
            dgv_OgundekiYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_OgundekiYemekler.Size = new Size(962, 276);
            dgv_OgundekiYemekler.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(39, 28);
            btnEkle.Margin = new Padding(2, 3, 2, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 51);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "YEMEK EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(194, 28);
            btnDegistir.Margin = new Padding(2, 3, 2, 3);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(155, 51);
            btnDegistir.TabIndex = 6;
            btnDegistir.Text = "YEMEĞİ GÜNCELLE";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.Location = new Point(427, 28);
            btnKaldir.Margin = new Padding(2, 3, 2, 3);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(105, 51);
            btnKaldir.TabIndex = 7;
            btnKaldir.Text = "KALDIR";
            btnKaldir.UseVisualStyleBackColor = true;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 152);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 9;
            label4.Text = "Güncel Kalori Değeri:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(636, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 10;
            label5.Text = "Günlük Hedef Kalori Değeri:";
            // 
            // lblHedefKalori
            // 
            lblHedefKalori.AutoSize = true;
            lblHedefKalori.Location = new Point(834, 152);
            lblHedefKalori.Margin = new Padding(2, 0, 2, 0);
            lblHedefKalori.Name = "lblHedefKalori";
            lblHedefKalori.Size = new Size(0, 20);
            lblHedefKalori.TabIndex = 13;
            // 
            // lblGuncelKalori
            // 
            lblGuncelKalori.AutoSize = true;
            lblGuncelKalori.Location = new Point(194, 152);
            lblGuncelKalori.Margin = new Padding(2, 0, 2, 0);
            lblGuncelKalori.Name = "lblGuncelKalori";
            lblGuncelKalori.Size = new Size(0, 20);
            lblGuncelKalori.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 265);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 16;
            label2.Text = "Öğün Çeşidini Seçiniz:";
            // 
            // cmbOgun
            // 
            cmbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(184, 263);
            cmbOgun.Margin = new Padding(2, 3, 2, 3);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(121, 28);
            cmbOgun.TabIndex = 15;
            cmbOgun.SelectedIndexChanged += cmbOgun_SelectedIndexChanged;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(806, 28);
            btnRaporlar.Margin = new Padding(2, 3, 2, 3);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(90, 51);
            btnRaporlar.TabIndex = 17;
            btnRaporlar.Text = "RAPORLAR";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnSuTakip
            // 
            btnSuTakip.Location = new Point(606, 28);
            btnSuTakip.Margin = new Padding(2, 3, 2, 3);
            btnSuTakip.Name = "btnSuTakip";
            btnSuTakip.Size = new Size(90, 51);
            btnSuTakip.TabIndex = 18;
            btnSuTakip.Text = "SU TAKİP";
            btnSuTakip.UseVisualStyleBackColor = true;
            btnSuTakip.Click += btnSuTakip_Click;
            // 
            // pbKaloriTakip
            // 
            pbKaloriTakip.Location = new Point(334, 137);
            pbKaloriTakip.Margin = new Padding(2, 3, 2, 3);
            pbKaloriTakip.Name = "pbKaloriTakip";
            pbKaloriTakip.Size = new Size(270, 51);
            pbKaloriTakip.TabIndex = 12;
            pbKaloriTakip.Value = 100;
            // 
            // OzetEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 579);
            Controls.Add(btnSuTakip);
            Controls.Add(btnRaporlar);
            Controls.Add(label2);
            Controls.Add(cmbOgun);
            Controls.Add(lblGuncelKalori);
            Controls.Add(lblHedefKalori);
            Controls.Add(pbKaloriTakip);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnKaldir);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(dgv_OgundekiYemekler);
            Controls.Add(label1);
            Controls.Add(dtpTarih);
            Margin = new Padding(2, 3, 2, 3);
            Name = "OzetEkrani";
            Text = "OzetEkrani";
            Load += OzetEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_OgundekiYemekler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTarih;
        private Label label1;
        private DataGridView dgv_OgundekiYemekler;
        private Button btnEkle;
        private Button btnDegistir;
        private Button btnKaldir;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblHedefKalori;
        private Label lblGuncelKalori;
        private Label label2;
        private ComboBox cmbOgun;
        private Button btnRaporlar;
        private Button btnSuTakip;
        private ProgressBar pbKaloriTakip;
    }
}