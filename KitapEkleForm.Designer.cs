namespace KutuphaneProje
{
    partial class KitapEkleForm
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
            txtISBN = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtYazar = new TextBox();
            btnIptal = new Button();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(98, 46);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.BackColor = SystemColors.ActiveCaption;
            txtISBN.Font = new Font("Segoe UI", 15F);
            txtISBN.Location = new Point(382, 53);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(315, 41);
            txtISBN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 113);
            label2.Name = "label2";
            label2.Size = new Size(163, 46);
            label2.TabIndex = 0;
            label2.Text = "Kitap Adı:";
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.ActiveCaption;
            txtAd.Font = new Font("Segoe UI", 15F);
            txtAd.Location = new Point(382, 118);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(315, 41);
            txtAd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 186);
            label3.Name = "label3";
            label3.Size = new Size(104, 46);
            label3.TabIndex = 0;
            label3.Text = "Yazar:";
            // 
            // txtYazar
            // 
            txtYazar.BackColor = SystemColors.ActiveCaption;
            txtYazar.Font = new Font("Segoe UI", 15F);
            txtYazar.Location = new Point(382, 191);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(315, 41);
            txtYazar.TabIndex = 1;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.DarkRed;
            btnIptal.Font = new Font("Segoe UI", 20F);
            btnIptal.Location = new Point(31, 298);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(163, 70);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click_1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DarkGreen;
            btnKaydet.Font = new Font("Segoe UI", 20F);
            btnKaydet.Location = new Point(534, 298);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(163, 70);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // KitapEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            Controls.Add(txtYazar);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Name = "KitapEkleForm";
            Text = "KitapEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtISBN;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtYazar;
        private Button btnIptal;
        private Button btnKaydet;
    }
}