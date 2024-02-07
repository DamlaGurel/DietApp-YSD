namespace DietApp.UI
{
    partial class SuTakipEkrani
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
            txtSu = new TextBox();
            pbSuTakip = new ProgressBar();
            btnSuEkle = new Button();
            btnSuCikar = new Button();
            label1 = new Label();
            label2 = new Label();
            lblKalanSu = new Label();
            SuspendLayout();
            // 
            // txtSu
            // 
            txtSu.Location = new Point(221, 78);
            txtSu.Margin = new Padding(2);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(121, 27);
            txtSu.TabIndex = 0;
            // 
            // pbSuTakip
            // 
            pbSuTakip.Location = new Point(85, 235);
            pbSuTakip.Margin = new Padding(2);
            pbSuTakip.Name = "pbSuTakip";
            pbSuTakip.Size = new Size(256, 27);
            pbSuTakip.TabIndex = 1;
            // 
            // btnSuEkle
            // 
            btnSuEkle.Location = new Point(85, 134);
            btnSuEkle.Margin = new Padding(2);
            btnSuEkle.Name = "btnSuEkle";
            btnSuEkle.Size = new Size(90, 48);
            btnSuEkle.TabIndex = 2;
            btnSuEkle.Text = "SU EKLE";
            btnSuEkle.UseVisualStyleBackColor = true;
            btnSuEkle.Click += btnSuEkle_Click;
            // 
            // btnSuCikar
            // 
            btnSuCikar.Location = new Point(251, 133);
            btnSuCikar.Margin = new Padding(2);
            btnSuCikar.Name = "btnSuCikar";
            btnSuCikar.Size = new Size(90, 51);
            btnSuCikar.TabIndex = 3;
            btnSuCikar.Text = "SU ÇIKAR";
            btnSuCikar.UseVisualStyleBackColor = true;
            btnSuCikar.Click += btnSuCikar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 4;
            label1.Text = "Su Miktarı Girin (mL):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 289);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(284, 20);
            label2.TabIndex = 5;
            label2.Text = "Su Hedefine Ulaşmak için Gereken Miktar:";
            // 
            // lblKalanSu
            // 
            lblKalanSu.AutoSize = true;
            lblKalanSu.Location = new Point(373, 289);
            lblKalanSu.Margin = new Padding(2, 0, 2, 0);
            lblKalanSu.Name = "lblKalanSu";
            lblKalanSu.Size = new Size(0, 20);
            lblKalanSu.TabIndex = 6;
            // 
            // SuTakipEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 434);
            Controls.Add(lblKalanSu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSuCikar);
            Controls.Add(btnSuEkle);
            Controls.Add(pbSuTakip);
            Controls.Add(txtSu);
            Margin = new Padding(2);
            Name = "SuTakipEkrani";
            Text = "SuTakipEkrani";
            Load += SuTakipEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSu;
        private ProgressBar pbSuTakip;
        private Button btnSuEkle;
        private Button btnSuCikar;
        private Label label1;
        private Label label2;
        private Label lblKalanSu;
    }
}