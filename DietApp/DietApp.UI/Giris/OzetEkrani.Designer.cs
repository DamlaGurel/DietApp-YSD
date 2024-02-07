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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(524, 261);
            dtpTarih.Margin = new Padding(2, 2, 2, 2);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 315);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(960, 206);
            dataGridView1.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(39, 28);
            btnEkle.Margin = new Padding(2, 2, 2, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 50);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "YEMEK EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(194, 28);
            btnDegistir.Margin = new Padding(2, 2, 2, 2);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(155, 50);
            btnDegistir.TabIndex = 6;
            btnDegistir.Text = "YEMEĞİ GÜNCELLE";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.Location = new Point(428, 28);
            btnKaldir.Margin = new Padding(2, 2, 2, 2);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(105, 50);
            btnKaldir.TabIndex = 7;
            btnKaldir.Text = "KALDIR";
            btnKaldir.UseVisualStyleBackColor = true;
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
            label5.Location = new Point(558, 152);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 10;
            label5.Text = "Günlük Hedef Kalori Değeri:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(262, 135);
            progressBar1.Margin = new Padding(2, 2, 2, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(270, 50);
            progressBar1.TabIndex = 12;
            progressBar1.Value = 100;
            // 
            // lblHedefKalori
            // 
            lblHedefKalori.AutoSize = true;
            lblHedefKalori.Location = new Point(759, 177);
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
            label2.Location = new Point(18, 266);
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
            cmbOgun.Margin = new Padding(2, 2, 2, 2);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(121, 28);
            cmbOgun.TabIndex = 15;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(806, 28);
            btnRaporlar.Margin = new Padding(2, 2, 2, 2);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(90, 50);
            btnRaporlar.TabIndex = 17;
            btnRaporlar.Text = "RAPORLAR";
            btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // btnSuTakip
            // 
            btnSuTakip.Location = new Point(606, 28);
            btnSuTakip.Margin = new Padding(2, 2, 2, 2);
            btnSuTakip.Name = "btnSuTakip";
            btnSuTakip.Size = new Size(90, 50);
            btnSuTakip.TabIndex = 18;
            btnSuTakip.Text = "SU TAKİP";
            btnSuTakip.UseVisualStyleBackColor = true;
            btnSuTakip.Click += btnSuTakip_Click;
            // 
            // OzetEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 521);
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
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(dtpTarih);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OzetEkrani";
            Text = "OzetEkrani";
            Load += OzetEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTarih;
        private Label label1;
        private DataGridView dataGridView1;
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