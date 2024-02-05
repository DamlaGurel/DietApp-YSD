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
            btnGunSonu.Location = new Point(68, 139);
            btnGunSonu.Name = "btnGunSonu";
            btnGunSonu.Size = new Size(137, 122);
            btnGunSonu.TabIndex = 0;
            btnGunSonu.Text = "GÜN SONU RAPORU";
            btnGunSonu.UseVisualStyleBackColor = true;
            // 
            // btnKiyasRaporlari
            // 
            btnKiyasRaporlari.Location = new Point(331, 139);
            btnKiyasRaporlari.Name = "btnKiyasRaporlari";
            btnKiyasRaporlari.Size = new Size(137, 122);
            btnKiyasRaporlari.TabIndex = 1;
            btnKiyasRaporlari.Text = "KIYASLAMA RAPORLARI";
            btnKiyasRaporlari.UseVisualStyleBackColor = true;
            // 
            // btnYemekKiyaslamaRaporu
            // 
            btnYemekKiyaslamaRaporu.Location = new Point(595, 139);
            btnYemekKiyaslamaRaporu.Name = "btnYemekKiyaslamaRaporu";
            btnYemekKiyaslamaRaporu.Size = new Size(137, 122);
            btnYemekKiyaslamaRaporu.TabIndex = 2;
            btnYemekKiyaslamaRaporu.Text = "YEMEK KIYASLAMA RAPORU";
            btnYemekKiyaslamaRaporu.UseVisualStyleBackColor = true;
            // 
            // AnaRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 351);
            Controls.Add(btnYemekKiyaslamaRaporu);
            Controls.Add(btnKiyasRaporlari);
            Controls.Add(btnGunSonu);
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