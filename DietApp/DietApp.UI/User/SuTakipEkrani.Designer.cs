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
            txtSu.Location = new Point(276, 97);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(150, 31);
            txtSu.TabIndex = 0;
            // 
            // pbSuTakip
            // 
            pbSuTakip.Location = new Point(106, 294);
            pbSuTakip.Name = "pbSuTakip";
            pbSuTakip.Size = new Size(320, 34);
            pbSuTakip.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(106, 168);
            button1.Name = "button1";
            button1.Size = new Size(112, 60);
            button1.TabIndex = 2;
            button1.Text = "SU EKLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 166);
            button2.Name = "button2";
            button2.Size = new Size(112, 64);
            button2.TabIndex = 3;
            button2.Text = "SU ÇIKAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 100);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 4;
            label1.Text = "Su Miktarı Girin (mL):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 361);
            label2.Name = "label2";
            label2.Size = new Size(339, 25);
            label2.TabIndex = 5;
            label2.Text = "Su Hedefine Ulaşmak için Gereken Miktar:";
            // 
            // lblKalanSu
            // 
            lblKalanSu.AutoSize = true;
            lblKalanSu.Location = new Point(466, 361);
            lblKalanSu.Name = "lblKalanSu";
            lblKalanSu.Size = new Size(0, 25);
            lblKalanSu.TabIndex = 6;
            // 
            // SuTakipEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 543);
            Controls.Add(lblKalanSu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbSuTakip);
            Controls.Add(txtSu);
            Name = "SuTakipEkrani";
            Text = "SuTakipEkrani";
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