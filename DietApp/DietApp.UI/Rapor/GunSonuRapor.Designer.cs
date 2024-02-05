namespace DietApp.UI
{
    partial class GunSonuRapor
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
            label1 = new Label();
            dtpTarih = new DateTimePicker();
            dgvListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 83);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 3;
            label1.Text = "Tarih Seçiniz:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(291, 80);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(300, 31);
            dtpTarih.TabIndex = 2;
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Location = new Point(1, 224);
            dgvListe.Name = "dgvListe";
            dgvListe.RowHeadersWidth = 62;
            dgvListe.RowTemplate.Height = 33;
            dgvListe.Size = new Size(793, 429);
            dgvListe.TabIndex = 4;
            // 
            // GunSonuRapor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 654);
            Controls.Add(dgvListe);
            Controls.Add(label1);
            Controls.Add(dtpTarih);
            Name = "GunSonuRapor";
            Text = "GunSonuRapor";
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpTarih;
        private DataGridView dgvListe;
    }
}