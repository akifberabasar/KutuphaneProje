namespace KutuphaneProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKitapEkle = new Button();
            btnKitapListele = new Button();
            btnUyeEkle = new Button();
            btnUyeListele = new Button();
            btnOduncVer = new Button();
            btnCikis = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Font = new Font("Segoe UI", 20F);
            btnKitapEkle.Location = new Point(25, 119);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(500, 54);
            btnKitapEkle.TabIndex = 0;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click_1;
            // 
            // btnKitapListele
            // 
            btnKitapListele.Font = new Font("Segoe UI", 20F);
            btnKitapListele.Location = new Point(25, 179);
            btnKitapListele.Name = "btnKitapListele";
            btnKitapListele.Size = new Size(500, 54);
            btnKitapListele.TabIndex = 0;
            btnKitapListele.Text = "Kitapları Listele";
            btnKitapListele.TextAlign = ContentAlignment.MiddleLeft;
            btnKitapListele.UseVisualStyleBackColor = true;
            btnKitapListele.Click += btnKitapListele_Click_1;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Segoe UI", 20F);
            btnUyeEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeEkle.Location = new Point(25, 233);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(500, 54);
            btnUyeEkle.TabIndex = 0;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click_1;
            // 
            // btnUyeListele
            // 
            btnUyeListele.Font = new Font("Segoe UI", 20F);
            btnUyeListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeListele.Location = new Point(25, 287);
            btnUyeListele.Name = "btnUyeListele";
            btnUyeListele.Size = new Size(500, 54);
            btnUyeListele.TabIndex = 0;
            btnUyeListele.Text = "Üyeleri Listele";
            btnUyeListele.TextAlign = ContentAlignment.MiddleLeft;
            btnUyeListele.UseVisualStyleBackColor = true;
            btnUyeListele.Click += btnUyeListele_Click;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Font = new Font("Segoe UI", 20F);
            btnOduncVer.Location = new Point(25, 341);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(500, 54);
            btnOduncVer.TabIndex = 0;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.TextAlign = ContentAlignment.MiddleLeft;
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Segoe UI", 20F);
            btnCikis.Location = new Point(25, 391);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(500, 54);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.TextAlign = ContentAlignment.MiddleLeft;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(44, 43);
            label1.Name = "label1";
            label1.Size = new Size(216, 46);
            label1.TabIndex = 1;
            label1.Text = "İşlem Seçiniz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(843, 478);
            Controls.Add(label1);
            Controls.Add(btnCikis);
            Controls.Add(btnOduncVer);
            Controls.Add(btnUyeListele);
            Controls.Add(btnUyeEkle);
            Controls.Add(btnKitapListele);
            Controls.Add(btnKitapEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKitapEkle;
        private Button btnKitapListele;
        private Button btnUyeEkle;
        private Button btnUyeListele;
        private Button btnOduncVer;
        private Button btnCikis;
        private Label label1;
    }
}
