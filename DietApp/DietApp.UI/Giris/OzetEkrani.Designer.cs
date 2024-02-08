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
            progressBar1 = new ProgressBar();
            lblHedefKalori = new Label();
            lblGuncelKalori = new Label();
            label2 = new Label();
            cmbOgun = new ComboBox();
            btnRaporlar = new Button();
            btnSuTakip = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_OgundekiYemekler).BeginInit();
            SuspendLayout();
            // 
            // dtpTarih
            // 
<<<<<<< HEAD
            dtpTarih.Location = new Point(458, 196);
            dtpTarih.Margin = new Padding(2);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(211, 23);
=======
            dtpTarih.Location = new Point(1310, 626);
            dtpTarih.Margin = new Padding(5, 5, 5, 5);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(596, 55);
>>>>>>> damla
            dtpTarih.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(361, 197);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
=======
            label1.Location = new Point(1032, 631);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 48);
>>>>>>> damla
            label1.TabIndex = 1;
            label1.Text = "Tarih Seçiniz:";
            // 
            // dgv_OgundekiYemekler
            // 
<<<<<<< HEAD
            dgv_OgundekiYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_OgundekiYemekler.Location = new Point(1, 236);
            dgv_OgundekiYemekler.Margin = new Padding(2);
            dgv_OgundekiYemekler.Name = "dgv_OgundekiYemekler";
            dgv_OgundekiYemekler.RowHeadersWidth = 62;
            dgv_OgundekiYemekler.RowTemplate.Height = 33;
            dgv_OgundekiYemekler.Size = new Size(840, 154);
            dgv_OgundekiYemekler.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(34, 21);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(93, 38);
=======
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 756);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(2400, 494);
            dataGridView1.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(98, 67);
            btnEkle.Margin = new Padding(5, 5, 5, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(265, 120);
>>>>>>> damla
            btnEkle.TabIndex = 5;
            btnEkle.Text = "YEMEK EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
<<<<<<< HEAD
            btnDegistir.Location = new Point(170, 21);
            btnDegistir.Margin = new Padding(2);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(136, 38);
=======
            btnDegistir.Location = new Point(485, 67);
            btnDegistir.Margin = new Padding(5, 5, 5, 5);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(388, 120);
>>>>>>> damla
            btnDegistir.TabIndex = 6;
            btnDegistir.Text = "YEMEĞİ GÜNCELLE";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnKaldir
            // 
<<<<<<< HEAD
            btnKaldir.Location = new Point(374, 21);
            btnKaldir.Margin = new Padding(2);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(92, 38);
=======
            btnKaldir.Location = new Point(1070, 67);
            btnKaldir.Margin = new Padding(5, 5, 5, 5);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(262, 120);
>>>>>>> damla
            btnKaldir.TabIndex = 7;
            btnKaldir.Text = "KALDIR";
            btnKaldir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
<<<<<<< HEAD
            label3.Location = new Point(69, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
=======
            label3.Location = new Point(198, 281);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 48);
>>>>>>> damla
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
<<<<<<< HEAD
            label4.Location = new Point(34, 114);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
=======
            label4.Location = new Point(98, 365);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(355, 48);
>>>>>>> damla
            label4.TabIndex = 9;
            label4.Text = "Güncel Kalori Değeri:";
            // 
            // label5
            // 
            label5.AutoSize = true;
<<<<<<< HEAD
            label5.Location = new Point(488, 114);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 15);
=======
            label5.Location = new Point(1395, 365);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(463, 48);
>>>>>>> damla
            label5.TabIndex = 10;
            label5.Text = "Günlük Hedef Kalori Değeri:";
            // 
            // progressBar1
            // 
<<<<<<< HEAD
            progressBar1.Location = new Point(229, 101);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(236, 38);
=======
            progressBar1.Location = new Point(655, 324);
            progressBar1.Margin = new Padding(5, 5, 5, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(675, 120);
>>>>>>> damla
            progressBar1.TabIndex = 12;
            progressBar1.Value = 100;
            // 
            // lblHedefKalori
            // 
            lblHedefKalori.AutoSize = true;
<<<<<<< HEAD
            lblHedefKalori.Location = new Point(664, 133);
            lblHedefKalori.Margin = new Padding(2, 0, 2, 0);
            lblHedefKalori.Name = "lblHedefKalori";
            lblHedefKalori.Size = new Size(0, 15);
=======
            lblHedefKalori.Location = new Point(1898, 425);
            lblHedefKalori.Margin = new Padding(5, 0, 5, 0);
            lblHedefKalori.Name = "lblHedefKalori";
            lblHedefKalori.Size = new Size(0, 48);
>>>>>>> damla
            lblHedefKalori.TabIndex = 13;
            // 
            // lblGuncelKalori
            // 
            lblGuncelKalori.AutoSize = true;
<<<<<<< HEAD
            lblGuncelKalori.Location = new Point(170, 114);
            lblGuncelKalori.Margin = new Padding(2, 0, 2, 0);
            lblGuncelKalori.Name = "lblGuncelKalori";
            lblGuncelKalori.Size = new Size(0, 15);
=======
            lblGuncelKalori.Location = new Point(485, 365);
            lblGuncelKalori.Margin = new Padding(5, 0, 5, 0);
            lblGuncelKalori.Name = "lblGuncelKalori";
            lblGuncelKalori.Size = new Size(0, 48);
>>>>>>> damla
            lblGuncelKalori.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(16, 200);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
=======
            label2.Location = new Point(45, 638);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(369, 48);
>>>>>>> damla
            label2.TabIndex = 16;
            label2.Text = "Öğün Çeşidini Seçiniz:";
            // 
            // cmbOgun
            // 
            cmbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgun.FormattingEnabled = true;
<<<<<<< HEAD
            cmbOgun.Location = new Point(161, 197);
            cmbOgun.Margin = new Padding(2);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(106, 23);
=======
            cmbOgun.Location = new Point(460, 631);
            cmbOgun.Margin = new Padding(5, 5, 5, 5);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(296, 56);
>>>>>>> damla
            cmbOgun.TabIndex = 15;
            cmbOgun.SelectedIndexChanged += cmbOgun_SelectedIndexChanged;
            // 
            // btnRaporlar
            // 
<<<<<<< HEAD
            btnRaporlar.Location = new Point(705, 21);
            btnRaporlar.Margin = new Padding(2);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(79, 38);
=======
            btnRaporlar.Location = new Point(2015, 67);
            btnRaporlar.Margin = new Padding(5, 5, 5, 5);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(225, 120);
>>>>>>> damla
            btnRaporlar.TabIndex = 17;
            btnRaporlar.Text = "RAPORLAR";
            btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // btnSuTakip
            // 
<<<<<<< HEAD
            btnSuTakip.Location = new Point(530, 21);
            btnSuTakip.Margin = new Padding(2);
            btnSuTakip.Name = "btnSuTakip";
            btnSuTakip.Size = new Size(79, 38);
=======
            btnSuTakip.Location = new Point(1515, 67);
            btnSuTakip.Margin = new Padding(5, 5, 5, 5);
            btnSuTakip.Name = "btnSuTakip";
            btnSuTakip.Size = new Size(225, 120);
>>>>>>> damla
            btnSuTakip.TabIndex = 18;
            btnSuTakip.Text = "SU TAKİP";
            btnSuTakip.UseVisualStyleBackColor = true;
            btnSuTakip.Click += btnSuTakip_Click;
            // 
            // OzetEkrani
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 391);
=======
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2405, 1250);
>>>>>>> damla
            Controls.Add(btnSuTakip);
            Controls.Add(btnRaporlar);
            Controls.Add(label2);
            Controls.Add(cmbOgun);
            Controls.Add(lblGuncelKalori);
            Controls.Add(lblHedefKalori);
            Controls.Add(progressBar1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnKaldir);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(dgv_OgundekiYemekler);
            Controls.Add(label1);
            Controls.Add(dtpTarih);
            Margin = new Padding(5, 5, 5, 5);
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
        private ProgressBar progressBar1;
        private Label lblHedefKalori;
        private Label lblGuncelKalori;
        private Label label2;
        private ComboBox cmbOgun;
        private Button btnRaporlar;
        private Button btnSuTakip;
    }
}