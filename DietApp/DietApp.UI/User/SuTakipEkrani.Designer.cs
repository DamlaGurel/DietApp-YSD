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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblKalanSu = new Label();
            SuspendLayout();
            // 
            // txtSu
            // 
            txtSu.Location = new Point(193, 58);
            txtSu.Margin = new Padding(2, 2, 2, 2);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(106, 23);
            txtSu.TabIndex = 0;
            // 
            // pbSuTakip
            // 
            pbSuTakip.Location = new Point(74, 176);
            pbSuTakip.Margin = new Padding(2, 2, 2, 2);
            pbSuTakip.Name = "pbSuTakip";
            pbSuTakip.Size = new Size(224, 20);
            pbSuTakip.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(74, 101);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 36);
            button1.TabIndex = 2;
            button1.Text = "SU EKLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(220, 100);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 38);
            button2.TabIndex = 3;
            button2.Text = "SU ÇIKAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "Su Miktarı Girin (mL):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 217);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 15);
            label2.TabIndex = 5;
            label2.Text = "Su Hedefine Ulaşmak için Gereken Miktar:";
            // 
            // lblKalanSu
            // 
            lblKalanSu.AutoSize = true;
            lblKalanSu.Location = new Point(326, 217);
            lblKalanSu.Margin = new Padding(2, 0, 2, 0);
            lblKalanSu.Name = "lblKalanSu";
            lblKalanSu.Size = new Size(0, 15);
            lblKalanSu.TabIndex = 6;
            // 
            // SuTakipEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 326);
            Controls.Add(lblKalanSu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbSuTakip);
            Controls.Add(txtSu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SuTakipEkrani";
            Text = "SuTakipEkrani";
            Load += SuTakipEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSu;
        private ProgressBar pbSuTakip;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lblKalanSu;
    }
}