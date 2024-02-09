namespace DietApp.UI.Rapor
{
    partial class AnaRaporEkrani
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
            btnGunSonu = new Button();
            btnKiyasRaporlari = new Button();
            btnYemekKiyaslamaRaporu = new Button();
            SuspendLayout();
            // 
            // btnGunSonu
            // 
            btnGunSonu.Location = new Point(54, 111);
            btnGunSonu.Margin = new Padding(2, 2, 2, 2);
            btnGunSonu.Name = "btnGunSonu";
            btnGunSonu.Size = new Size(110, 98);
            btnGunSonu.TabIndex = 0;
            btnGunSonu.Text = "GÜN SONU RAPORU";
            btnGunSonu.UseVisualStyleBackColor = true;
            btnGunSonu.Click += btnGunSonu_Click;
            // 
            // btnKiyasRaporlari
            // 
            btnKiyasRaporlari.Location = new Point(265, 111);
            btnKiyasRaporlari.Margin = new Padding(2, 2, 2, 2);
            btnKiyasRaporlari.Name = "btnKiyasRaporlari";
            btnKiyasRaporlari.Size = new Size(110, 98);
            btnKiyasRaporlari.TabIndex = 1;
            btnKiyasRaporlari.Text = "KIYASLAMA RAPORLARI";
            btnKiyasRaporlari.UseVisualStyleBackColor = true;
            btnKiyasRaporlari.Click += btnKiyasRaporlari_Click;
            // 
            // btnYemekKiyaslamaRaporu
            // 
            btnYemekKiyaslamaRaporu.Location = new Point(476, 111);
            btnYemekKiyaslamaRaporu.Margin = new Padding(2, 2, 2, 2);
            btnYemekKiyaslamaRaporu.Name = "btnYemekKiyaslamaRaporu";
            btnYemekKiyaslamaRaporu.Size = new Size(110, 98);
            btnYemekKiyaslamaRaporu.TabIndex = 2;
            btnYemekKiyaslamaRaporu.Text = "YEMEK KIYASLAMA RAPORU";
            btnYemekKiyaslamaRaporu.UseVisualStyleBackColor = true;
            btnYemekKiyaslamaRaporu.Click += btnYemekKiyaslamaRaporu_Click;
            // 
            // AnaRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 281);
            Controls.Add(btnYemekKiyaslamaRaporu);
            Controls.Add(btnKiyasRaporlari);
            Controls.Add(btnGunSonu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AnaRaporEkrani";
            Text = "AnaRaporEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGunSonu;
        private Button btnKiyasRaporlari;
        private Button btnYemekKiyaslamaRaporu;
    }
}