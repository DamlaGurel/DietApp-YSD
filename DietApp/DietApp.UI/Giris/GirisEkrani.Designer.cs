namespace DietApp.UI
{
    partial class GirisEkrani
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
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            grpGiris = new GroupBox();
            txtKullaniciAdi = new TextBox();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            btnUyeOl = new Button();
            label1 = new Label();
            label2 = new Label();
            grpGiris.SuspendLayout();
            SuspendLayout();
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(474, 124);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(0, 25);
            lblSifre.TabIndex = 10;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(474, 56);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(0, 25);
            lblKullaniciAdi.TabIndex = 8;
            // 
            // grpGiris
            // 
            grpGiris.Controls.Add(txtKullaniciAdi);
            grpGiris.Controls.Add(btnGirisYap);
            grpGiris.Controls.Add(txtSifre);
            grpGiris.Controls.Add(btnUyeOl);
            grpGiris.Controls.Add(label1);
            grpGiris.Controls.Add(label2);
            grpGiris.Location = new Point(34, 25);
            grpGiris.Name = "grpGiris";
            grpGiris.Size = new Size(339, 399);
            grpGiris.TabIndex = 9;
            grpGiris.TabStop = false;
            grpGiris.Text = "Giriş Paneli";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(141, 30);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(150, 31);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(40, 180);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(251, 34);
            btnGirisYap.TabIndex = 5;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(141, 98);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 31);
            txtSifre.TabIndex = 1;
            // 
            // btnUyeOl
            // 
            btnUyeOl.Location = new Point(40, 247);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(251, 34);
            btnUyeOl.TabIndex = 4;
            btnUyeOl.Text = "ÜYE OL";
            btnUyeOl.UseVisualStyleBackColor = true;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(grpGiris);
            Name = "GirisEkrani";
            Text = "GirisEkrani";
            grpGiris.ResumeLayout(false);
            grpGiris.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSifre;
        private Label lblKullaniciAdi;
        private GroupBox grpGiris;
        private TextBox txtKullaniciAdi;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private Button btnUyeOl;
        private Label label1;
        private Label label2;
    }
}