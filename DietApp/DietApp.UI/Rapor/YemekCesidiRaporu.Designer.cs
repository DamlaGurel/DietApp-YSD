namespace DietApp.UI
{
    partial class YemekCesidiRaporu
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
            dgvYemekCesidiRaporu = new DataGridView();
            label1 = new Label();
            cmbKategori = new ComboBox();
            cmbYemek = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekCesidiRaporu).BeginInit();
            SuspendLayout();
            // 
            // dgvYemekCesidiRaporu
            // 
            dgvYemekCesidiRaporu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekCesidiRaporu.Location = new Point(1, 239);
            dgvYemekCesidiRaporu.Name = "dgvYemekCesidiRaporu";
            dgvYemekCesidiRaporu.RowHeadersWidth = 62;
            dgvYemekCesidiRaporu.RowTemplate.Height = 33;
            dgvYemekCesidiRaporu.Size = new Size(800, 393);
            dgvYemekCesidiRaporu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 148);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Yemek Seçiniz:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(255, 78);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(182, 33);
            cmbKategori.TabIndex = 2;
            // 
            // cmbYemek
            // 
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(255, 140);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(182, 33);
            cmbYemek.TabIndex = 4;
            cmbYemek.SelectedIndexChanged += cmbYemek_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 81);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 3;
            label2.Text = "Kategori Seçiniz:";
            // 
            // YemekCesidiRaporu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(cmbYemek);
            Controls.Add(label2);
            Controls.Add(cmbKategori);
            Controls.Add(label1);
            Controls.Add(dgvYemekCesidiRaporu);
            Name = "YemekCesidiRaporu";
            Text = "YemekCesidiRaporu";
            Load += YemekCesidiRaporu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYemekCesidiRaporu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvYemekCesidiRaporu;
        private Label label1;
        private ComboBox cmbKategori;
        private ComboBox cmbYemek;
        private Label label2;
    }
}