namespace KutuphaneProje
{
    partial class OduncForm
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
            cmbUye = new ComboBox();
            label2 = new Label();
            cmbKitap = new ComboBox();
            btnIptal = new Button();
            btnOduncVer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(145, 46);
            label1.TabIndex = 0;
            label1.Text = "Üye Seç:";
            // 
            // cmbUye
            // 
            cmbUye.Font = new Font("Segoe UI", 15F);
            cmbUye.FormattingEnabled = true;
            cmbUye.Location = new Point(218, 48);
            cmbUye.Name = "cmbUye";
            cmbUye.Size = new Size(238, 43);
            cmbUye.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(43, 140);
            label2.Name = "label2";
            label2.Size = new Size(165, 46);
            label2.TabIndex = 0;
            label2.Text = "Kitap Seç:";
            // 
            // cmbKitap
            // 
            cmbKitap.Font = new Font("Segoe UI", 15F);
            cmbKitap.FormattingEnabled = true;
            cmbKitap.Location = new Point(218, 145);
            cmbKitap.Name = "cmbKitap";
            cmbKitap.Size = new Size(238, 43);
            cmbKitap.TabIndex = 1;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Red;
            btnIptal.Font = new Font("Segoe UI", 20F);
            btnIptal.Location = new Point(43, 302);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(145, 57);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click_1;
            // 
            // btnOduncVer
            // 
            btnOduncVer.BackColor = Color.LawnGreen;
            btnOduncVer.Font = new Font("Segoe UI", 20F);
            btnOduncVer.Location = new Point(574, 302);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(145, 57);
            btnOduncVer.TabIndex = 2;
            btnOduncVer.Text = "Kaydet";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click += btnOduncVer_Click_1;
            // 
            // OduncForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOduncVer);
            Controls.Add(btnIptal);
            Controls.Add(cmbKitap);
            Controls.Add(cmbUye);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OduncForm";
            Text = "OduncForm";
            Load += OduncForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbUye;
        private Label label2;
        private ComboBox cmbKitap;
        private Button btnIptal;
        private Button btnOduncVer;
    }
}