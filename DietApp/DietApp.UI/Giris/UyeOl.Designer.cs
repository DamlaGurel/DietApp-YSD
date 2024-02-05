namespace DietApp.UI
{
    partial class UyeOl
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrari = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblSifreTekrari = new Label();
            grpUyelik = new GroupBox();
            chkAydinlanmaMetni = new CheckBox();
            lblAydinlanmaMetni = new LinkLabel();
            btnUyeOl = new Button();
            grpUyelik.SuspendLayout();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(153, 67);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(150, 31);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(153, 133);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 31);
            txtSifre.TabIndex = 1;
            // 
            // txtSifreTekrari
            // 
            txtSifreTekrari.Location = new Point(153, 201);
            txtSifreTekrari.Name = "txtSifreTekrari";
            txtSifreTekrari.Size = new Size(150, 31);
            txtSifreTekrari.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 64);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 204);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 5;
            label3.Text = "Şifre Tekrarı:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(324, 67);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(0, 25);
            lblKullaniciAdi.TabIndex = 6;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(324, 133);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(0, 25);
            lblSifre.TabIndex = 7;
            // 
            // lblSifreTekrari
            // 
            lblSifreTekrari.AutoSize = true;
            lblSifreTekrari.Location = new Point(324, 201);
            lblSifreTekrari.Name = "lblSifreTekrari";
            lblSifreTekrari.Size = new Size(0, 25);
            lblSifreTekrari.TabIndex = 8;
            // 
            // grpUyelik
            // 
            grpUyelik.Controls.Add(chkAydinlanmaMetni);
            grpUyelik.Controls.Add(lblAydinlanmaMetni);
            grpUyelik.Controls.Add(btnUyeOl);
            grpUyelik.Controls.Add(txtSifre);
            grpUyelik.Controls.Add(lblSifreTekrari);
            grpUyelik.Controls.Add(txtKullaniciAdi);
            grpUyelik.Controls.Add(lblSifre);
            grpUyelik.Controls.Add(txtSifreTekrari);
            grpUyelik.Controls.Add(lblKullaniciAdi);
            grpUyelik.Controls.Add(label1);
            grpUyelik.Controls.Add(label3);
            grpUyelik.Controls.Add(label2);
            grpUyelik.Location = new Point(33, 65);
            grpUyelik.Name = "grpUyelik";
            grpUyelik.Size = new Size(590, 441);
            grpUyelik.TabIndex = 9;
            grpUyelik.TabStop = false;
            grpUyelik.Text = "UyeOlmaPaneli";
            // 
            // chkAydinlanmaMetni
            // 
            chkAydinlanmaMetni.Location = new Point(25, 255);
            chkAydinlanmaMetni.Name = "chkAydinlanmaMetni";
            chkAydinlanmaMetni.Size = new Size(381, 97);
            chkAydinlanmaMetni.TabIndex = 13;
            chkAydinlanmaMetni.Text = "Kişisel verilerimin işlenmesine yönelik aydınlatma metinini okudum, anladım ve onaylıyorum.";
            chkAydinlanmaMetni.UseVisualStyleBackColor = true;
            // 
            // lblAydinlanmaMetni
            // 
            lblAydinlanmaMetni.AutoSize = true;
            lblAydinlanmaMetni.Location = new Point(412, 290);
            lblAydinlanmaMetni.Name = "lblAydinlanmaMetni";
            lblAydinlanmaMetni.Size = new Size(156, 25);
            lblAydinlanmaMetni.TabIndex = 12;
            lblAydinlanmaMetni.TabStop = true;
            lblAydinlanmaMetni.Text = "Aydınlanma Metni";
            // 
            // btnUyeOl
            // 
            btnUyeOl.Location = new Point(25, 381);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(273, 34);
            btnUyeOl.TabIndex = 10;
            btnUyeOl.Text = "UYE OL";
            btnUyeOl.UseVisualStyleBackColor = true;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // UyeOl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 515);
            Controls.Add(grpUyelik);
            Name = "UyeOl";
            Text = "UyeOl";
            grpUyelik.ResumeLayout(false);
            grpUyelik.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrari;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Label lblSifreTekrari;
        private GroupBox grpUyelik;
        private Button btnUyeOl;
        private CheckBox chkAydinlanmaMetni;
        private LinkLabel lblAydinlanmaMetni;
    }
}