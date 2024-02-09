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
            dtpTarih.Location = new Point(654, 327);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(300, 31);
            dtpTarih.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 328);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "Tarih Seçiniz:";
            // 
            // dgv_OgundekiYemekler
            // 
            dgv_OgundekiYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_OgundekiYemekler.Location = new Point(3, 372);
            dgv_OgundekiYemekler.Margin = new Padding(1, 2, 1, 2);
            dgv_OgundekiYemekler.Name = "dgv_OgundekiYemekler";
            dgv_OgundekiYemekler.RowHeadersWidth = 62;
            dgv_OgundekiYemekler.RowTemplate.Height = 33;
            dgv_OgundekiYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_OgundekiYemekler.Size = new Size(1203, 182);
            dgv_OgundekiYemekler.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(49, 35);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(133, 63);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "YEMEK EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(243, 35);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(194, 63);
            btnDegistir.TabIndex = 6;
            btnDegistir.Text = "YEMEĞİ GÜNCELLE";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.Location = new Point(534, 35);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(131, 63);
            btnKaldir.TabIndex = 7;
            btnKaldir.Text = "KALDIR";
            btnKaldir.UseVisualStyleBackColor = true;
            btnKaldir.Click += btnKaldir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 147);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 190);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 9;
            label4.Text = "Güncel Kalori Değeri:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 190);
            label5.Name = "label5";
            label5.Size = new Size(230, 25);
            label5.TabIndex = 10;
            label5.Text = "Günlük Hedef Kalori Değeri:";
            // 
            // lblHedefKalori
            // 
            lblHedefKalori.AutoSize = true;
            lblHedefKalori.Location = new Point(949, 222);
            lblHedefKalori.Name = "lblHedefKalori";
            lblHedefKalori.Size = new Size(0, 25);
            lblHedefKalori.TabIndex = 13;
            // 
            // lblGuncelKalori
            // 
            lblGuncelKalori.AutoSize = true;
            lblGuncelKalori.Location = new Point(243, 190);
            lblGuncelKalori.Name = "lblGuncelKalori";
            lblGuncelKalori.Size = new Size(0, 25);
            lblGuncelKalori.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 332);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 16;
            label2.Text = "Öğün Çeşidini Seçiniz:";
            // 
            // cmbOgun
            // 
            cmbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(230, 328);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(150, 33);
            cmbOgun.TabIndex = 15;
            cmbOgun.SelectedIndexChanged += cmbOgun_SelectedIndexChanged;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(1007, 35);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(113, 63);
            btnRaporlar.TabIndex = 17;
            btnRaporlar.Text = "RAPORLAR";
            btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // btnSuTakip
            // 
            btnSuTakip.Location = new Point(757, 35);
            btnSuTakip.Name = "btnSuTakip";
            btnSuTakip.Size = new Size(113, 63);
            btnSuTakip.TabIndex = 18;
            btnSuTakip.Text = "SU TAKİP";
            btnSuTakip.UseVisualStyleBackColor = true;
            btnSuTakip.Click += btnSuTakip_Click;
            // 
            // pbKaloriTakip
            // 
            pbKaloriTakip.Location = new Point(327, 168);
            pbKaloriTakip.Name = "pbKaloriTakip";
            pbKaloriTakip.Size = new Size(337, 63);
            pbKaloriTakip.TabIndex = 12;
            pbKaloriTakip.Value = 100;
            // 
            // OzetEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 553);
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