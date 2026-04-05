namespace KutuphaneProje
{
    public partial class Form1 : Form
    {
        // Kitap ve üye listelerini tüm formlarýn eriþebileceði þekilde tanýmlýyoruz
        internal static List<Kitap> Kitaplar = new List<Kitap>();
        internal static List<Uye> Uyeler = new List<Uye>();

        public Form1()
        {
            // Form bileþenlerini baþlatýyoruz ve pencere baþlýðýný ayarlýyoruz
            InitializeComponent();
            this.Text = "Kütüphane Otomasyonu";
        }

        // "Kitap Ekle" butonuna týklanýnca KitapEkleForm penceresini açar
        private void btnKitapEkle_Click_1(object sender, EventArgs e)
        {
            KitapEkleForm form = new KitapEkleForm();
            form.Show();
        }

        // "Kitaplarý Listele" butonuna týklanýnca KitapListeForm penceresini açar
        private void btnKitapListele_Click_1(object sender, EventArgs e)
        {
            KitapListeForm form = new KitapListeForm();
            form.Show();
        }

        // "Üye Ekle" butonuna týklanýnca UyeEkleForm penceresini açar
        // ShowDialog: form kapanmadan ana menüye dönülemez
        private void btnUyeEkle_Click_1(object sender, EventArgs e)
        {
            UyeEkleForm form = new UyeEkleForm();
            form.ShowDialog();
        }

        // "Ödünç Ver" butonuna týklanýnca OduncForm penceresini açar
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            OduncForm form = new OduncForm();
            form.ShowDialog();
        }

        // "Üyeleri Listele" butonuna týklanýnca UyeListeForm penceresini açar
        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListeForm form = new UyeListeForm();
            form.ShowDialog();
        }

        // "Çýkýþ" butonuna týklanýnca uygulamayý tamamen kapatýr
        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Form ilk açýldýðýnda veritabaný baðlantýsýný test eder
        // Baðlantý baþarýlýysa kaç kitap olduðunu gösterir, hata varsa mesaj verir
        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                var kitaplar = DatabaseHelper.KitaplariGetir();
                MessageBox.Show("Baðlantý baþarýlý! Kitap sayýsý: " + kitaplar.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý: " + ex.Message);
            }
        }
    }
}