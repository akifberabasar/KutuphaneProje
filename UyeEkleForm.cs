namespace KutuphaneProje
{
    public partial class UyeEkleForm : Form
    {
        public UyeEkleForm()
        {
            InitializeComponent();
        }

        // Kaydet butonuna tıklanınca çalışır
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            // Tüm alanların dolu olup olmadığını kontrol ediyoruz
            if (txtUyeNo.Text == "" || txtAd.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı");
                return;
            }

            // Üye numarasının sayı olup olmadığını kontrol ediyoruz
            if (!int.TryParse(txtUyeNo.Text, out int uyeNo))
            {
                MessageBox.Show("Üye No sadece sayı olmalıdır.", "Uyarı");
                return;
            }

            // Aynı üye numarası zaten kayıtlıysa ekleme yapılmaz
            if (DatabaseHelper.UyeVarMi(uyeNo))
            {
                MessageBox.Show("Bu üye no zaten kayıtlı.", "Uyarı");
                return;
            }

            // Formdan alınan bilgilerle yeni bir Uye nesnesi oluşturuyoruz
            Uye uye = new Uye
            {
                UyeNo = uyeNo,
                Ad = txtAd.Text
            };

            // Üyeyi veritabanına kaydediyoruz
            DatabaseHelper.UyeEkle(uye);
            MessageBox.Show("Üye başarıyla eklendi.", "Bilgi");
            this.Close();
        }

        // İptal butonuna tıklanınca formu kapatır, kayıt yapılmaz
        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}