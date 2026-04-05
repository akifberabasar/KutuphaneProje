using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        // Form açıldığında ComboBox'ları veritabanından gelen verilerle doldurur
        private void OduncForm_Load(object sender, EventArgs e)
        {
            // Tüm üyeleri üye ComboBox'ına yüklüyoruz
            // DisplayMember: ekranda görünecek alan, ValueMember: arka planda kullanılacak alan
            cmbUye.DataSource = DatabaseHelper.UyeleriGetir();
            cmbUye.DisplayMember = "Ad";
            cmbUye.ValueMember = "UyeNo";

            // Sadece rafta olan kitapları (Durum == true) kitap ComboBox'ına yüklüyoruz
            // Ödünçte olan kitaplar listede görünmez
            cmbKitap.DataSource = DatabaseHelper.KitaplariGetir().Where(k => k.Durum == true).ToList();
            cmbKitap.DisplayMember = "Ad";
            cmbKitap.ValueMember = "ISBN";
        }

        // İptal butonuna tıklanınca formu kapatır, işlem yapılmaz
        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ödünç Ver butonuna tıklanınca çalışır
        private void btnOduncVer_Click_1(object sender, EventArgs e)
        {
            // Üye veya kitap seçilmemişse uyarı verir
            if (cmbUye.SelectedItem == null || cmbKitap.SelectedItem == null)
            {
                MessageBox.Show("Lütfen üye ve kitap seçiniz.", "Uyarı");
                return;
            }

            // Seçilen ComboBox elemanlarını Uye ve Kitap nesnelerine dönüştürüyoruz
            Uye secilenUye = (Uye)cmbUye.SelectedItem;
            Kitap secilenKitap = (Kitap)cmbKitap.SelectedItem;

            // Veritabanına ödünç kaydı ekleniyor, kitabın durumu 0 (ödünçte) yapılıyor
            DatabaseHelper.OduncVer(secilenUye.UyeNo, secilenKitap.ISBN);
            MessageBox.Show($"{secilenKitap.Ad} kitabı {secilenUye.Ad} kişisine ödünç verildi.", "Bilgi");
            this.Close();
        }
    }
}