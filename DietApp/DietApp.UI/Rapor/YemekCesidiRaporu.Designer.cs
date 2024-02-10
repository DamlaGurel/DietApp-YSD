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
            dgvYemekCesidiRaporu.Location = new Point(1, 191);
            dgvYemekCesidiRaporu.Margin = new Padding(2, 2, 2, 2);
            dgvYemekCesidiRaporu.Name = "dgvYemekCesidiRaporu";
            dgvYemekCesidiRaporu.RowHeadersWidth = 62;
            dgvYemekCesidiRaporu.RowTemplate.Height = 33;
            dgvYemekCesidiRaporu.Size = new Size(794, 314);
            dgvYemekCesidiRaporu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Yemek Seçiniz:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(204, 62);
            cmbKategori.Margin = new Padding(2, 2, 2, 2);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(146, 28);
            cmbKategori.TabIndex = 2;
            // 
            // cmbYemek
            // 
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(204, 112);
            cmbYemek.Margin = new Padding(2, 2, 2, 2);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(146, 28);
            cmbYemek.TabIndex = 4;
            cmbYemek.SelectedIndexChanged += cmbYemek_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Kategori Seçiniz:";
            // 
            // YemekCesidiRaporu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 508);
            Controls.Add(cmbYemek);
            Controls.Add(label2);
            Controls.Add(cmbKategori);
            Controls.Add(label1);
            Controls.Add(dgvYemekCesidiRaporu);
            Margin = new Padding(2, 2, 2, 2);
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