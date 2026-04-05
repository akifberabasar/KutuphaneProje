namespace KutuphaneProje
{
    partial class UyeEkleForm
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
            txtUyeNo = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            btnIptal = new Button();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(138, 46);
            label1.TabIndex = 0;
            label1.Text = "Üye No:";
            // 
            // txtUyeNo
            // 
            txtUyeNo.Font = new Font("Segoe UI", 20F);
            txtUyeNo.Location = new Point(221, 29);
            txtUyeNo.Name = "txtUyeNo";
            txtUyeNo.Size = new Size(293, 52);
            txtUyeNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(43, 122);
            label2.Name = "label2";
            label2.Size = new Size(69, 46);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 20F);
            txtAd.Location = new Point(221, 116);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(293, 52);
            txtAd.TabIndex = 1;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.DarkRed;
            btnIptal.Font = new Font("Segoe UI", 20F);
            btnIptal.Location = new Point(43, 287);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(149, 50);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click_1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DarkGreen;
            btnKaydet.Font = new Font("Segoe UI", 20F);
            btnKaydet.Location = new Point(536, 287);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(149, 50);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlign = ContentAlignment.TopCenter;
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // UyeEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            Controls.Add(txtAd);
            Controls.Add(txtUyeNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UyeEkleForm";
            Text = "UyeEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUyeNo;
        private Label label2;
        private TextBox txtAd;
        private Button btnIptal;
        private Button btnKaydet;
    }
}