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
            // YemekCesidiRaporu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(dgvYemekCesidiRaporu);
            Name = "YemekCesidiRaporu";
            Text = "YemekCesidiRaporu";
            ((System.ComponentModel.ISupportInitialize)dgvYemekCesidiRaporu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvYemekCesidiRaporu;
    }
}